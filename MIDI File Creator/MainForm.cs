using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MIDI_File_Creator.Properties;

namespace MIDI_File_Creator
{
    public partial class MainForm : Form
    {
        /*
         * General MIDI Reset
         * 0xF0, 0x05, 0x7E, 0x7F, 0x09, 0x01, 0xF7
         * 
         * Roland GS Reset
         * 0xF0, 0x0A, 0x41, 0x10, 0x42, 0x12, 0x40, 0x00, 0x7F, 0x00, 0x41, 0xF7
         * 
         * Yamaha XG Reset
         * 0xF0, 0x08, 0x43, 0x10, 0x4C, 0x00, 0x00, 0x7E, 0x00, 0xF7
         */

        byte[] trackData = { 0x00, 0xB0, 0x07, 0x64, 0x00, 0xB0, 0x0A, 0x40, 0x00, 0xFF, 0x2F, 0x00 };
        byte[] trackDataGM = { 0x00, 0xF0, 0x05, 0x7E, 0x7F, 0x09, 0x01, 0xF7, 0x00, 0xB0, 0x07, 0x64, 0x00, 0xB0, 0x0A, 0x40, 0x00, 0xFF, 0x2F, 0x00 };
        byte[] trackDataRoland = { 0x00, 0xF0, 0x0A, 0x41, 0x10, 0x42, 0x12, 0x40, 0x00, 0x7F, 0x00, 0x41, 0xF7, 0x00, 0xB0, 0x07, 0x64, 0x00, 0xB0, 0x0A, 0x40, 0x00, 0xFF, 0x2F, 0x00 };
        byte[] trackDataYamaha = { 0x00, 0xF0, 0x08, 0x43, 0x10, 0x4C, 0x00, 0x00, 0x7E, 0x00, 0xF7, 0x00, 0xB0, 0x07, 0x64, 0x00, 0xB0, 0x0A, 0x40, 0x00, 0xFF, 0x2F, 0x00 };

        readonly UInt16[] timeDivisionValuesTable = { 15360, 7680, 3840, 3072, 1920, 1024, 960, 768, 500, 480, 384, 256, 240, 192, 120, 96, 48, 24 };

        public MainForm()
        {
            InitializeComponent();
            TrackCountSpinner.Value = Settings.Default.TrackCount;
            TimeDivisionOptions.SelectedIndex = Settings.Default.TimeDivision;
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            if (SaveMIDIDialog.ShowDialog() == DialogResult.OK)
                OutputPathBox.Text = SaveMIDIDialog.FileName;
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(OutputPathBox.Text) || !Directory.Exists(Path.GetDirectoryName(OutputPathBox.Text)))
                {
                    MessageBox.Show(this, "Output path does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Set the default time division value to 1920 ticks per bar if no item is selected.
                    if (TimeDivisionOptions.SelectedIndex < 0)
                    {
                        TimeDivisionOptions.SelectedIndex = 9;
                    }

                    UInt16 timeDivisionValue = timeDivisionValuesTable[TimeDivisionOptions.SelectedIndex];

                    using (FileStream fs = new FileStream(OutputPathBox.Text, FileMode.Append, FileAccess.Write))
                    {
                        using (BinaryWriter midiWriter = new BinaryWriter(fs))
                        {
                            byte[] headerType = Encoding.ASCII.GetBytes("MThd");
                            byte[] headerLength = BitConverter.GetBytes((uint)6);
                            if (BitConverter.IsLittleEndian)
                                Array.Reverse(headerLength);

                            byte[] headerFormat = BitConverter.GetBytes((UInt16)1);
                            if (BitConverter.IsLittleEndian)
                                Array.Reverse(headerFormat);

                            byte[] headerTracks = BitConverter.GetBytes((UInt16)TrackCountSpinner.Value);
                            if (BitConverter.IsLittleEndian)
                                Array.Reverse(headerTracks);

                            byte[] headerDivision = BitConverter.GetBytes(timeDivisionValue);
                            if (BitConverter.IsLittleEndian)
                                Array.Reverse(headerDivision);

                            midiWriter.Write(headerType);
                            midiWriter.Write(headerLength);
                            midiWriter.Write(headerFormat);
                            midiWriter.Write(headerTracks);
                            midiWriter.Write(headerDivision);

                            byte[] trackName = Encoding.ASCII.GetBytes("MTrk");

                            if (Settings.Default.SysExNone)
                            {
                                byte[] trackDataLength = BitConverter.GetBytes(trackData.Length);
                                if (BitConverter.IsLittleEndian)
                                    Array.Reverse(trackDataLength);

                                for (UInt16 i = 0; i < (UInt16)TrackCountSpinner.Value; i++)
                                {
                                    midiWriter.Write(trackName);
                                    midiWriter.Write(trackDataLength);
                                    midiWriter.Write(trackData);
                                }
                            }

                            if (Settings.Default.SysExGM)
                            {
                                byte[] trackDataGMLength = BitConverter.GetBytes(trackDataGM.Length);
                                if (BitConverter.IsLittleEndian)
                                    Array.Reverse(trackDataGMLength);

                                for (UInt16 i = 0; i < (UInt16)TrackCountSpinner.Value; i++)
                                {
                                    midiWriter.Write(trackName);
                                    midiWriter.Write(trackDataGMLength);
                                    midiWriter.Write(trackDataGM);
                                }
                            }

                            if (Settings.Default.SysExRoland)
                            {
                                byte[] trackDataRolandLength = BitConverter.GetBytes(trackDataRoland.Length);
                                if (BitConverter.IsLittleEndian)
                                    Array.Reverse(trackDataRolandLength);

                                for (UInt16 i = 0; i < (UInt16)TrackCountSpinner.Value; i++)
                                {
                                    midiWriter.Write(trackName);
                                    midiWriter.Write(trackDataRolandLength);
                                    midiWriter.Write(trackDataRoland);
                                }
                            }

                            if (Settings.Default.SysExYamaha)
                            {
                                byte[] trackDataYamahaLength = BitConverter.GetBytes(trackDataYamaha.Length);
                                if (BitConverter.IsLittleEndian)
                                    Array.Reverse(trackDataYamahaLength);

                                for (UInt16 i = 0; i < (UInt16)TrackCountSpinner.Value; i++)
                                {
                                    midiWriter.Write(trackName);
                                    midiWriter.Write(trackDataYamahaLength);
                                    midiWriter.Write(trackDataYamaha);
                                }
                            }
                        }                        
                    }

                    MessageBox.Show(this, "Successfully created blank MIDI file.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.TrackCount = TrackCountSpinner.Value;
            Settings.Default.TimeDivision = TimeDivisionOptions.SelectedIndex;
            Settings.Default.Save();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Developed by VirtuosicAI \n\n(https://github.com/VirtuosicAI)", "About");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsFrm = new OptionsForm();
            optionsFrm.ShowDialog();
        }
    }
}
