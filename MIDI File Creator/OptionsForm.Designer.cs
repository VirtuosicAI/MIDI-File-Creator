namespace MIDI_File_Creator
{
    partial class OptionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SysexYamahaRadio = new System.Windows.Forms.RadioButton();
            this.SysexRolandRadio = new System.Windows.Forms.RadioButton();
            this.SysexGMRadio = new System.Windows.Forms.RadioButton();
            this.SysexNoneRadio = new System.Windows.Forms.RadioButton();
            this.OptionsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SysexYamahaRadio);
            this.groupBox1.Controls.Add(this.SysexRolandRadio);
            this.groupBox1.Controls.Add(this.SysexGMRadio);
            this.groupBox1.Controls.Add(this.SysexNoneRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SysEx Reset Messages";
            // 
            // SysexYamahaRadio
            // 
            this.SysexYamahaRadio.AutoSize = true;
            this.SysexYamahaRadio.Location = new System.Drawing.Point(6, 88);
            this.SysexYamahaRadio.Name = "SysexYamahaRadio";
            this.SysexYamahaRadio.Size = new System.Drawing.Size(82, 17);
            this.SysexYamahaRadio.TabIndex = 3;
            this.SysexYamahaRadio.Text = "Yamaha XG";
            this.OptionsToolTip.SetToolTip(this.SysexYamahaRadio, "Add a SysEx Yamaha XG reset message at the beginning of each track.");
            this.SysexYamahaRadio.UseVisualStyleBackColor = true;
            // 
            // SysexRolandRadio
            // 
            this.SysexRolandRadio.AutoSize = true;
            this.SysexRolandRadio.Location = new System.Drawing.Point(6, 65);
            this.SysexRolandRadio.Name = "SysexRolandRadio";
            this.SysexRolandRadio.Size = new System.Drawing.Size(77, 17);
            this.SysexRolandRadio.TabIndex = 2;
            this.SysexRolandRadio.Text = "Roland GS";
            this.OptionsToolTip.SetToolTip(this.SysexRolandRadio, "Add a SysEx Roland GS reset message at the beginning of each track.");
            this.SysexRolandRadio.UseVisualStyleBackColor = true;
            // 
            // SysexGMRadio
            // 
            this.SysexGMRadio.AutoSize = true;
            this.SysexGMRadio.Location = new System.Drawing.Point(6, 42);
            this.SysexGMRadio.Name = "SysexGMRadio";
            this.SysexGMRadio.Size = new System.Drawing.Size(88, 17);
            this.SysexGMRadio.TabIndex = 1;
            this.SysexGMRadio.Text = "General MIDI";
            this.OptionsToolTip.SetToolTip(this.SysexGMRadio, "Add a SysEx General MIDI reset message at the beginning of each track.");
            this.SysexGMRadio.UseVisualStyleBackColor = true;
            // 
            // SysexNoneRadio
            // 
            this.SysexNoneRadio.AutoSize = true;
            this.SysexNoneRadio.Checked = true;
            this.SysexNoneRadio.Location = new System.Drawing.Point(6, 19);
            this.SysexNoneRadio.Name = "SysexNoneRadio";
            this.SysexNoneRadio.Size = new System.Drawing.Size(51, 17);
            this.SysexNoneRadio.TabIndex = 0;
            this.SysexNoneRadio.TabStop = true;
            this.SysexNoneRadio.Text = "None";
            this.OptionsToolTip.SetToolTip(this.SysexNoneRadio, "Don\'t add any SysEx messages to the MIDI file.");
            this.SysexNoneRadio.UseVisualStyleBackColor = true;
            // 
            // OptionsToolTip
            // 
            this.OptionsToolTip.AutoPopDelay = 32767;
            this.OptionsToolTip.InitialDelay = 500;
            this.OptionsToolTip.ReshowDelay = 100;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 138);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SysexYamahaRadio;
        private System.Windows.Forms.RadioButton SysexRolandRadio;
        private System.Windows.Forms.RadioButton SysexGMRadio;
        private System.Windows.Forms.RadioButton SysexNoneRadio;
        private System.Windows.Forms.ToolTip OptionsToolTip;
    }
}