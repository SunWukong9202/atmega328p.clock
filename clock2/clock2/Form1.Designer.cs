namespace clock2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clock = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sw_clock = new CircularProgressBar.CircularProgressBar();
            this.sw_reset_button = new System.Windows.Forms.Button();
            this.sw_play_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer_edit_button = new System.Windows.Forms.Button();
            this.seconds_list = new System.Windows.Forms.ComboBox();
            this.minutes_list = new System.Windows.Forms.ComboBox();
            this.hours_list = new System.Windows.Forms.ComboBox();
            this.sc_clock = new CircularProgressBar.CircularProgressBar();
            this.timer_reset_button = new System.Windows.Forms.Button();
            this.timer_play_button = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clock_button = new System.Windows.Forms.ToolStripButton();
            this.stopwatch_button = new System.Windows.Forms.ToolStripButton();
            this.sandclock_button = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.clock);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 344);
            this.panel1.TabIndex = 1;
            // 
            // clock
            // 
            this.clock.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.clock.AnimationSpeed = 500;
            this.clock.BackColor = System.Drawing.Color.Transparent;
            this.clock.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clock.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clock.InnerMargin = 2;
            this.clock.InnerWidth = -1;
            this.clock.Location = new System.Drawing.Point(30, 14);
            this.clock.MarqueeAnimationSpeed = 2000;
            this.clock.Name = "clock";
            this.clock.OuterColor = System.Drawing.Color.Gray;
            this.clock.OuterMargin = -25;
            this.clock.OuterWidth = 25;
            this.clock.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clock.ProgressWidth = 15;
            this.clock.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clock.Size = new System.Drawing.Size(211, 211);
            this.clock.StartAngle = 270;
            this.clock.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.clock.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.clock.SubscriptText = "";
            this.clock.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.clock.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.clock.SuperscriptText = " ";
            this.clock.TabIndex = 0;
            this.clock.Text = "clock";
            this.clock.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.clock.Value = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.sw_clock);
            this.panel2.Controls.Add(this.sw_reset_button);
            this.panel2.Controls.Add(this.sw_play_button);
            this.panel2.Location = new System.Drawing.Point(286, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 344);
            this.panel2.TabIndex = 5;
            // 
            // sw_clock
            // 
            this.sw_clock.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.sw_clock.AnimationSpeed = 500;
            this.sw_clock.BackColor = System.Drawing.Color.Transparent;
            this.sw_clock.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sw_clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sw_clock.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sw_clock.InnerMargin = 2;
            this.sw_clock.InnerWidth = -1;
            this.sw_clock.Location = new System.Drawing.Point(30, 14);
            this.sw_clock.MarqueeAnimationSpeed = 2000;
            this.sw_clock.Name = "sw_clock";
            this.sw_clock.OuterColor = System.Drawing.Color.Gray;
            this.sw_clock.OuterMargin = -25;
            this.sw_clock.OuterWidth = 25;
            this.sw_clock.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sw_clock.ProgressWidth = 15;
            this.sw_clock.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sw_clock.Size = new System.Drawing.Size(211, 211);
            this.sw_clock.StartAngle = 270;
            this.sw_clock.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.sw_clock.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.sw_clock.SubscriptText = "";
            this.sw_clock.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.sw_clock.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.sw_clock.SuperscriptText = " ";
            this.sw_clock.TabIndex = 0;
            this.sw_clock.Text = "stop watch";
            this.sw_clock.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.sw_clock.Value = 68;
            // 
            // sw_reset_button
            // 
            this.sw_reset_button.BackColor = System.Drawing.Color.Transparent;
            this.sw_reset_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sw_reset_button.BackgroundImage")));
            this.sw_reset_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sw_reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_reset_button.FlatAppearance.BorderSize = 0;
            this.sw_reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sw_reset_button.Location = new System.Drawing.Point(30, 273);
            this.sw_reset_button.Name = "sw_reset_button";
            this.sw_reset_button.Size = new System.Drawing.Size(88, 37);
            this.sw_reset_button.TabIndex = 3;
            this.sw_reset_button.UseVisualStyleBackColor = false;
            this.sw_reset_button.Click += new System.EventHandler(this.sw_reset_button_Click);
            // 
            // sw_play_button
            // 
            this.sw_play_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sw_play_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sw_play_button.BackgroundImage")));
            this.sw_play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sw_play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_play_button.FlatAppearance.BorderSize = 0;
            this.sw_play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sw_play_button.Location = new System.Drawing.Point(163, 273);
            this.sw_play_button.Name = "sw_play_button";
            this.sw_play_button.Size = new System.Drawing.Size(88, 37);
            this.sw_play_button.TabIndex = 4;
            this.sw_play_button.UseVisualStyleBackColor = false;
            this.sw_play_button.Click += new System.EventHandler(this.sw_play_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.timer_edit_button);
            this.panel3.Controls.Add(this.seconds_list);
            this.panel3.Controls.Add(this.minutes_list);
            this.panel3.Controls.Add(this.hours_list);
            this.panel3.Controls.Add(this.sc_clock);
            this.panel3.Controls.Add(this.timer_reset_button);
            this.panel3.Controls.Add(this.timer_play_button);
            this.panel3.Location = new System.Drawing.Point(572, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 344);
            this.panel3.TabIndex = 6;
            // 
            // timer_edit_button
            // 
            this.timer_edit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timer_edit_button.BackgroundImage")));
            this.timer_edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.timer_edit_button.FlatAppearance.BorderSize = 0;
            this.timer_edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer_edit_button.Location = new System.Drawing.Point(216, 230);
            this.timer_edit_button.Name = "timer_edit_button";
            this.timer_edit_button.Size = new System.Drawing.Size(52, 23);
            this.timer_edit_button.TabIndex = 9;
            this.timer_edit_button.UseVisualStyleBackColor = true;
            this.timer_edit_button.Click += new System.EventHandler(this.timer_edit_button_Click);
            // 
            // seconds_list
            // 
            this.seconds_list.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.seconds_list.FormattingEnabled = true;
            this.seconds_list.Location = new System.Drawing.Point(163, 231);
            this.seconds_list.Name = "seconds_list";
            this.seconds_list.Size = new System.Drawing.Size(47, 23);
            this.seconds_list.TabIndex = 8;
            this.seconds_list.SelectedIndexChanged += new System.EventHandler(this.seconds_list_SelectedIndexChanged);
            // 
            // minutes_list
            // 
            this.minutes_list.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.minutes_list.FormattingEnabled = true;
            this.minutes_list.Location = new System.Drawing.Point(100, 231);
            this.minutes_list.Name = "minutes_list";
            this.minutes_list.Size = new System.Drawing.Size(47, 23);
            this.minutes_list.TabIndex = 7;
            this.minutes_list.SelectedIndexChanged += new System.EventHandler(this.minutes_list_SelectedIndexChanged);
            // 
            // hours_list
            // 
            this.hours_list.DropDownHeight = 130;
            this.hours_list.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.hours_list.FormattingEnabled = true;
            this.hours_list.IntegralHeight = false;
            this.hours_list.Location = new System.Drawing.Point(36, 231);
            this.hours_list.Name = "hours_list";
            this.hours_list.Size = new System.Drawing.Size(47, 23);
            this.hours_list.TabIndex = 6;
            this.hours_list.SelectedIndexChanged += new System.EventHandler(this.hours_list_SelectedIndexChanged);
            // 
            // sc_clock
            // 
            this.sc_clock.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.sc_clock.AnimationSpeed = 500;
            this.sc_clock.BackColor = System.Drawing.Color.Transparent;
            this.sc_clock.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sc_clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sc_clock.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sc_clock.InnerMargin = 2;
            this.sc_clock.InnerWidth = -1;
            this.sc_clock.Location = new System.Drawing.Point(30, 14);
            this.sc_clock.MarqueeAnimationSpeed = 2000;
            this.sc_clock.Name = "sc_clock";
            this.sc_clock.OuterColor = System.Drawing.Color.Gray;
            this.sc_clock.OuterMargin = -25;
            this.sc_clock.OuterWidth = 25;
            this.sc_clock.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sc_clock.ProgressWidth = 15;
            this.sc_clock.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sc_clock.Size = new System.Drawing.Size(211, 211);
            this.sc_clock.StartAngle = 270;
            this.sc_clock.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.sc_clock.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.sc_clock.SubscriptText = "";
            this.sc_clock.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.sc_clock.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.sc_clock.SuperscriptText = " ";
            this.sc_clock.TabIndex = 0;
            this.sc_clock.Text = "timer";
            this.sc_clock.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.sc_clock.Value = 68;
            // 
            // timer_reset_button
            // 
            this.timer_reset_button.BackColor = System.Drawing.Color.Transparent;
            this.timer_reset_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timer_reset_button.BackgroundImage")));
            this.timer_reset_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.timer_reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timer_reset_button.FlatAppearance.BorderSize = 0;
            this.timer_reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer_reset_button.Location = new System.Drawing.Point(30, 273);
            this.timer_reset_button.Name = "timer_reset_button";
            this.timer_reset_button.Size = new System.Drawing.Size(88, 37);
            this.timer_reset_button.TabIndex = 3;
            this.timer_reset_button.UseVisualStyleBackColor = false;
            this.timer_reset_button.Click += new System.EventHandler(this.timer_reset_button_Click);
            // 
            // timer_play_button
            // 
            this.timer_play_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timer_play_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timer_play_button.BackgroundImage")));
            this.timer_play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.timer_play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timer_play_button.FlatAppearance.BorderSize = 0;
            this.timer_play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer_play_button.Location = new System.Drawing.Point(163, 273);
            this.timer_play_button.Name = "timer_play_button";
            this.timer_play_button.Size = new System.Drawing.Size(88, 37);
            this.timer_play_button.TabIndex = 4;
            this.timer_play_button.UseVisualStyleBackColor = false;
            this.timer_play_button.Click += new System.EventHandler(this.timer_play_button_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clock_button,
            this.stopwatch_button,
            this.sandclock_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 55);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clock_button
            // 
            this.clock_button.AutoSize = false;
            this.clock_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clock_button.Image = ((System.Drawing.Image)(resources.GetObject("clock_button.Image")));
            this.clock_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clock_button.Name = "clock_button";
            this.clock_button.Size = new System.Drawing.Size(60, 52);
            this.clock_button.Text = "toolStripButton1";
            this.clock_button.MouseEnter += new System.EventHandler(this.clock_button_MouseEnter);
            this.clock_button.MouseLeave += new System.EventHandler(this.clock_button_MouseLeave);
            // 
            // stopwatch_button
            // 
            this.stopwatch_button.AutoSize = false;
            this.stopwatch_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopwatch_button.Image = ((System.Drawing.Image)(resources.GetObject("stopwatch_button.Image")));
            this.stopwatch_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopwatch_button.Name = "stopwatch_button";
            this.stopwatch_button.Size = new System.Drawing.Size(60, 52);
            this.stopwatch_button.Text = "toolStripButton2";
            this.stopwatch_button.MouseEnter += new System.EventHandler(this.stopwatch_button_MouseEnter);
            this.stopwatch_button.MouseLeave += new System.EventHandler(this.stopwatch_button_MouseLeave);
            // 
            // sandclock_button
            // 
            this.sandclock_button.AutoSize = false;
            this.sandclock_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sandclock_button.Image = ((System.Drawing.Image)(resources.GetObject("sandclock_button.Image")));
            this.sandclock_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sandclock_button.Name = "sandclock_button";
            this.sandclock_button.Size = new System.Drawing.Size(60, 52);
            this.sandclock_button.Text = "toolStripButton3";
            this.sandclock_button.MouseEnter += new System.EventHandler(this.sandclock_button_MouseEnter);
            this.sandclock_button.MouseLeave += new System.EventHandler(this.sandclock_button_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 399);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private CircularProgressBar.CircularProgressBar clock;
        private Panel panel2;
        private CircularProgressBar.CircularProgressBar sw_clock;
        private Button sw_reset_button;
        private Button sw_play_button;
        private Panel panel3;
        private CircularProgressBar.CircularProgressBar sc_clock;
        private Button timer_reset_button;
        private Button timer_play_button;
        private ComboBox hours_list;
        private ComboBox seconds_list;
        private ComboBox minutes_list;
        private ToolStrip toolStrip1;
        private ToolStripButton clock_button;
        private ToolStripButton stopwatch_button;
        private ToolStripButton sandclock_button;
        private Button timer_edit_button;
    }
}