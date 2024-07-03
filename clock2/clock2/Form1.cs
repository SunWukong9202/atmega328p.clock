using System.Windows.Forms;
using System.IO.Ports;  // import the SerialPort 
using System.Reflection.Emit;

namespace clock2
{
    public partial class Form1 : Form
    {
        private string path_to_images = @"../../../images/";
        private bool sw_pause = true;
        private bool timer_pause = true;
        SerialPort serial;
        private Thread thread;
        private int timer_selected_hour;
        private int timer_selected_minute;
        private int timer_selected_second;
        private CancellationTokenSource app_running = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            initComboBoxesFormat();
            serial = new SerialPort("COM5", 9600);
            clock.Maximum = 59;
            clock.Minimum = 0;
            clock.InnerColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            clock.OuterColor = System.Drawing.ColorTranslator.FromHtml("#b4c0d7");
            clock.ProgressColor = System.Drawing.ColorTranslator.FromHtml("#222126");
            sw_clock.Maximum = 59;
            sw_clock.Minimum = 0;
            sw_clock.InnerColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            sw_clock.OuterColor = System.Drawing.ColorTranslator.FromHtml("#b4c0d7");
            sw_clock.ProgressColor = System.Drawing.ColorTranslator.FromHtml("#222126");
            sc_clock.Maximum = 59;
            sc_clock.Minimum = 0;
            sc_clock.InnerColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            sc_clock.OuterColor = System.Drawing.ColorTranslator.FromHtml("#b4c0d7");
            sc_clock.ProgressColor = System.Drawing.ColorTranslator.FromHtml("#222126");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#fefefe");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#fefefe");
            serial.Open();
            // Get the current timestamp
            DateTime currentTime = DateTime.Now;

            // Extract hours, minutes, seconds, and milliseconds
            int hours = currentTime.Hour;
            int minutes = currentTime.Minute;
            int seconds = currentTime.Second;
            int milliseconds = currentTime.Millisecond / 100;
            byte[] init_date = { (byte)milliseconds, (byte)seconds, (byte)minutes, (byte)hours };
            //send signal
            serial.Write(init_date, 0, init_date.Length);
            serial.Close();

            thread = new Thread(serialCOM);
            thread.Start();
        }

        private void serialCOM()
        {
            serial.Open();
            while (!app_running.Token.IsCancellationRequested)
            {
                if (serial.IsOpen) // check if the serial port is open
                {
                    try
                    {
                        byte tx_singal = (byte)serial.ReadByte();
                        if (tx_singal == 0xff)
                        {
                            byte[] buffer = new byte[11];
                            int bytesRead = 0;

                            while (bytesRead < buffer.Length)
                            {
                                if (serial.BytesToRead > 0)
                                {
                                    buffer[bytesRead] = (byte)serial.ReadByte();
                                    bytesRead++;
                                }
                            }
                            int milisec = Convert.ToInt32(buffer[0]);
                            int seconds = Convert.ToInt32(buffer[1]);
                            int minutes = Convert.ToInt32(buffer[2]);
                            int hours = Convert.ToInt32(buffer[3]);
                            //stop watch timestamp
                            int sw_milisec = Convert.ToInt32(buffer[4]);
                            int sw_seconds = Convert.ToInt32(buffer[5]);
                            int sw_minutes = Convert.ToInt32(buffer[6]);
                            //timer/sc timestamp
                            int timer_milisec = Convert.ToInt32(buffer[7]);
                            int timer_seconds = Convert.ToInt32(buffer[8]);
                            int timer_minutes = Convert.ToInt32(buffer[9]);
                            int timer_hours = Convert.ToInt32(buffer[10]);

                            string timestamp = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
                            string sw_timestamp = $"{sw_minutes:D2}:{sw_seconds:D2}:{sw_milisec:D1}0";
                            string timer_timestamp = $"{timer_hours:D2}:{timer_minutes:D2}:{timer_seconds:D2}";
                            // update the UI with the received time string
                            Invoke(new Action(() =>
                            {
                                clock.Text = timestamp;
                                clock.Value = seconds;
                                sw_clock.Text = sw_timestamp;
                                sw_clock.Value = sw_seconds;
                                sc_clock.Text = timer_timestamp;
                                sc_clock.Value = timer_seconds;
                            }));
                        }

                    }
                    catch (Exception ex)
                    {
                        // handle any exceptions that may occur when reading from the serial port
                        Console.WriteLine(ex.Message);
                    }
                }

                if (app_running.Token.IsCancellationRequested) break;
            }

            serial.Close();
        }

        private void initComboBoxesFormat()
        {
            List<string> hours = new List<string>();
            List<string> minutes = new List<string>();
            List<string> seconds = new List<string>();
            for(int i=0; i < 24; i++) hours.Add(i.ToString().PadLeft(2, '0'));
            for(int i=0; i < 60; i++) minutes.Add(i.ToString().PadLeft(2, '0'));
            for(int i=0; i < 60; i++) seconds.Add(i.ToString().PadLeft(2, '0'));
            hours_list.Items.AddRange(hours.ToArray());
            minutes_list.Items.AddRange(minutes.ToArray());
            seconds_list.Items.AddRange(seconds.ToArray());
            hours_list.SelectedItem = "00";
            minutes_list.SelectedItem = "02";
            seconds_list.SelectedItem = "00";
            timer_selected_hour = 0;
            timer_selected_minute = 2;
            timer_selected_second = 0;
        }

        private void handleMouseEnter()
        {
            this.Cursor = Cursors.Hand;
        }

        private void handleMouseLeave()
        {
            this.Cursor = Cursors.Default;  
        }

        private void clock_button_MouseEnter(object sender, EventArgs e)
        {
            handleMouseEnter();
        }

        private void stopwatch_button_MouseEnter(object sender, EventArgs e)
        {
            handleMouseEnter();
        }

        private void sandclock_button_MouseEnter(object sender, EventArgs e)
        {
            handleMouseEnter();
        }

        private void clock_button_MouseLeave(object sender, EventArgs e)
        {
            handleMouseLeave();
        }

        private void stopwatch_button_MouseLeave(object sender, EventArgs e)
        {
            handleMouseLeave();
        }

        private void sandclock_button_MouseLeave(object sender, EventArgs e)
        {
            handleMouseLeave();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            app_running.Cancel();
        }

        private void hours_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_value = hours_list.SelectedItem.ToString();
            timer_selected_hour = int.Parse(selected_value);
        }

        private void minutes_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_value = minutes_list.SelectedItem.ToString();
            timer_selected_minute = int.Parse(selected_value);
        }

        private void seconds_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_value = seconds_list.SelectedItem.ToString();
            timer_selected_second = int.Parse(selected_value);
        }
        private void timer_edit_button_Click(object sender, EventArgs e)
        {
            //timer_edti = 0_0001
            byte timer_edit_signal = 0x01;
            byte[] data = { timer_edit_signal, (byte)timer_selected_hour, (byte)timer_selected_minute, (byte)timer_selected_second};
            //send signal
            serial.Write(data, 0, data.Length);
        }

        private void timer_reset_button_Click(object sender, EventArgs e)
        {
            //timer_reset = 0_0010
            byte[] timer_reset_signal = { 0x02 };
            //send signal
            serial.Write(timer_reset_signal, 0, timer_reset_signal.Length);
        }

        private void timer_play_button_Click(object sender, EventArgs e)
        {
            //timer play = 0_0100
            Console.WriteLine(timer_pause);
            if (timer_pause)
            {
                this.timer_play_button.BackgroundImage = Image.FromFile(path_to_images + "pause.png");
                byte[] play_signal = { 0x04};
                //send signal
                serial.Write(play_signal, 0, play_signal.Length);

            }//pause = 0_1000
            else
            {
                this.timer_play_button.BackgroundImage = Image.FromFile(path_to_images + "play_button.png");
                byte[] stop_signal = { 0x08 };
                //send signal
                serial.Write(stop_signal, 0, stop_signal.Length);

            }
            timer_pause = !timer_pause;
        }

        private void sw_reset_button_Click(object sender, EventArgs e)
        {
            //sw_reset = 1_0000
            byte[] sw_reset_signal = { 0x10 };
            //send signal
            serial.Write(sw_reset_signal, 0, sw_reset_signal.Length);
        }

        private void sw_play_button_Click(object sender, EventArgs e)
        {
            //sw_play = 10_0000
            //
            Console.WriteLine(timer_pause);
            if (sw_pause)
            {
                this.sw_play_button.BackgroundImage = Image.FromFile(path_to_images + "pause.png");
                byte[] play_signal = { 0x20 };
                //send signal
                serial.Write(play_signal, 0, play_signal.Length);
            }
            else//pause = 100_0000
            {
                this.sw_play_button.BackgroundImage = Image.FromFile(path_to_images + "play_button.png");
                byte[] stop_signal = { 0x40 };
                //send signal
                serial.Write(stop_signal, 0, stop_signal.Length);
            }
            sw_pause = !sw_pause;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}