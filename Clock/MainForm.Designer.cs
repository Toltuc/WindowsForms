namespace Clock
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.cbShowWeekday = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmishowWeekday = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForegroundCollor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAlams = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAutostart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(17, 16);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(324, 63);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Current time";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.Location = new System.Drawing.Point(29, 220);
            this.cbShowDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(164, 35);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Show date";
            this.cbShowDate.UseVisualStyleBackColor = true;
            // 
            // cbShowWeekday
            // 
            this.cbShowWeekday.AutoSize = true;
            this.cbShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowWeekday.Location = new System.Drawing.Point(29, 265);
            this.cbShowWeekday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbShowWeekday.Name = "cbShowWeekday";
            this.cbShowWeekday.Size = new System.Drawing.Size(219, 35);
            this.cbShowWeekday.TabIndex = 2;
            this.cbShowWeekday.Text = "Show weekday";
            this.cbShowWeekday.UseVisualStyleBackColor = true;
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(29, 309);
            this.btnHideControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(320, 66);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topmostToolStripMenuItem,
            this.showControlsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showDateToolStripMenuItem,
            this.tsmishowWeekday,
            this.toolStripSeparator2,
            this.tsmiFont,
            this.tsmiColor,
            this.toolStripSeparator3,
            this.tsmiAlams,
            this.toolStripSeparator4,
            this.tsmiAutostart,
            this.tsmiClose});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(177, 244);
            // 
            // topmostToolStripMenuItem
            // 
            this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
            this.topmostToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.topmostToolStripMenuItem.Text = "Topmost";
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.showControlsToolStripMenuItem.Text = "Show controls";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.showDateToolStripMenuItem.Text = "Show date";
            // 
            // tsmishowWeekday
            // 
            this.tsmishowWeekday.Name = "tsmishowWeekday";
            this.tsmishowWeekday.Size = new System.Drawing.Size(176, 24);
            this.tsmishowWeekday.Text = "Show weekday";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(176, 24);
            this.tsmiFont.Text = "Font";
            // 
            // tsmiColor
            // 
            this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundCollor,
            this.tsmiBackgroundColor});
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(176, 24);
            this.tsmiColor.Text = "Color";
            // 
            // tsmiForegroundCollor
            // 
            this.tsmiForegroundCollor.Name = "tsmiForegroundCollor";
            this.tsmiForegroundCollor.Size = new System.Drawing.Size(224, 26);
            this.tsmiForegroundCollor.Text = "Foreground collor";
            // 
            // tsmiBackgroundColor
            // 
            this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
            this.tsmiBackgroundColor.Size = new System.Drawing.Size(224, 26);
            this.tsmiBackgroundColor.Text = "Background color";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmiAlams
            // 
            this.tsmiAlams.Name = "tsmiAlams";
            this.tsmiAlams.Size = new System.Drawing.Size(176, 24);
            this.tsmiAlams.Text = "Alams";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmiAutostart
            // 
            this.tsmiAutostart.Name = "tsmiAutostart";
            this.tsmiAutostart.Size = new System.Drawing.Size(176, 24);
            this.tsmiAutostart.Text = "Autostart";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(176, 24);
            this.tsmiClose.Text = "Close";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 414);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeekday);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clock P_421";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox cbShowDate;
		private System.Windows.Forms.CheckBox cbShowWeekday;
		private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmishowWeekday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiForegroundCollor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlams;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutostart;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
    }
}

