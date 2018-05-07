namespace MIDI_File_Creator
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
            this.OutputPathLabel = new System.Windows.Forms.Label();
            this.OutputPathBox = new System.Windows.Forms.TextBox();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.TrackCountSpinner = new System.Windows.Forms.NumericUpDown();
            this.TrackCountLabel = new System.Windows.Forms.Label();
            this.TimeDivisionOptions = new System.Windows.Forms.ComboBox();
            this.TimeDivisionLabel = new System.Windows.Forms.Label();
            this.CreateBTN = new System.Windows.Forms.Button();
            this.SaveMIDIDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainFormTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TrackCountSpinner)).BeginInit();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputPathLabel
            // 
            this.OutputPathLabel.AutoSize = true;
            this.OutputPathLabel.Location = new System.Drawing.Point(12, 32);
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Size = new System.Drawing.Size(67, 13);
            this.OutputPathLabel.TabIndex = 0;
            this.OutputPathLabel.Text = "Output Path:";
            // 
            // OutputPathBox
            // 
            this.OutputPathBox.Location = new System.Drawing.Point(85, 29);
            this.OutputPathBox.Name = "OutputPathBox";
            this.OutputPathBox.ReadOnly = true;
            this.OutputPathBox.Size = new System.Drawing.Size(181, 20);
            this.OutputPathBox.TabIndex = 1;
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.Location = new System.Drawing.Point(272, 27);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(75, 23);
            this.BrowseBTN.TabIndex = 2;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = true;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // TrackCountSpinner
            // 
            this.TrackCountSpinner.Location = new System.Drawing.Point(86, 57);
            this.TrackCountSpinner.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TrackCountSpinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TrackCountSpinner.Name = "TrackCountSpinner";
            this.TrackCountSpinner.Size = new System.Drawing.Size(51, 20);
            this.TrackCountSpinner.TabIndex = 3;
            this.MainFormTooltip.SetToolTip(this.TrackCountSpinner, "How many tracks the output MIDI file will contain.\r\n(Ranges from 1 to 65535)");
            this.TrackCountSpinner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TrackCountLabel
            // 
            this.TrackCountLabel.AutoSize = true;
            this.TrackCountLabel.Location = new System.Drawing.Point(11, 59);
            this.TrackCountLabel.Name = "TrackCountLabel";
            this.TrackCountLabel.Size = new System.Drawing.Size(69, 13);
            this.TrackCountLabel.TabIndex = 4;
            this.TrackCountLabel.Text = "Track Count:";
            // 
            // TimeDivisionOptions
            // 
            this.TimeDivisionOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeDivisionOptions.FormattingEnabled = true;
            this.TimeDivisionOptions.Items.AddRange(new object[] {
            "61440 ticks",
            "30720 ticks",
            "15360 ticks",
            "12288 ticks",
            "7680 ticks",
            "4096 ticks",
            "3840 ticks",
            "3072 ticks",
            "2000 ticks",
            "1920 ticks",
            "1536 ticks",
            "1024 ticks",
            "960 ticks",
            "768 ticks",
            "480 ticks",
            "384 ticks",
            "192 ticks",
            "96 ticks"});
            this.TimeDivisionOptions.Location = new System.Drawing.Point(222, 56);
            this.TimeDivisionOptions.Name = "TimeDivisionOptions";
            this.TimeDivisionOptions.Size = new System.Drawing.Size(125, 21);
            this.TimeDivisionOptions.TabIndex = 5;
            this.MainFormTooltip.SetToolTip(this.TimeDivisionOptions, resources.GetString("TimeDivisionOptions.ToolTip"));
            // 
            // TimeDivisionLabel
            // 
            this.TimeDivisionLabel.AutoSize = true;
            this.TimeDivisionLabel.Location = new System.Drawing.Point(143, 59);
            this.TimeDivisionLabel.Name = "TimeDivisionLabel";
            this.TimeDivisionLabel.Size = new System.Drawing.Size(73, 13);
            this.TimeDivisionLabel.TabIndex = 6;
            this.TimeDivisionLabel.Text = "Time Division:";
            // 
            // CreateBTN
            // 
            this.CreateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBTN.Location = new System.Drawing.Point(12, 83);
            this.CreateBTN.Name = "CreateBTN";
            this.CreateBTN.Size = new System.Drawing.Size(335, 33);
            this.CreateBTN.TabIndex = 7;
            this.CreateBTN.Text = "Create MIDI File";
            this.CreateBTN.UseVisualStyleBackColor = true;
            this.CreateBTN.Click += new System.EventHandler(this.CreateBTN_Click);
            // 
            // SaveMIDIDialog
            // 
            this.SaveMIDIDialog.Filter = "MIDI Files|*.mid";
            // 
            // MainFormTooltip
            // 
            this.MainFormTooltip.AutoPopDelay = 32767;
            this.MainFormTooltip.InitialDelay = 500;
            this.MainFormTooltip.ReshowDelay = 100;
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(359, 24);
            this.MainFormMenuStrip.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 125);
            this.Controls.Add(this.CreateBTN);
            this.Controls.Add(this.TimeDivisionLabel);
            this.Controls.Add(this.TimeDivisionOptions);
            this.Controls.Add(this.TrackCountLabel);
            this.Controls.Add(this.TrackCountSpinner);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.OutputPathBox);
            this.Controls.Add(this.OutputPathLabel);
            this.Controls.Add(this.MainFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIDI File Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TrackCountSpinner)).EndInit();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputPathLabel;
        private System.Windows.Forms.TextBox OutputPathBox;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.NumericUpDown TrackCountSpinner;
        private System.Windows.Forms.Label TrackCountLabel;
        private System.Windows.Forms.ComboBox TimeDivisionOptions;
        private System.Windows.Forms.Label TimeDivisionLabel;
        private System.Windows.Forms.Button CreateBTN;
        private System.Windows.Forms.SaveFileDialog SaveMIDIDialog;
        private System.Windows.Forms.ToolTip MainFormTooltip;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

