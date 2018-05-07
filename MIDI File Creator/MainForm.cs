using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    UInt16 timeDivisionValue = 480;

                    if (TimeDivisionOptions.SelectedIndex == 0)
                        timeDivisionValue = 15360;
                    if (TimeDivisionOptions.SelectedIndex == 1)
                        timeDivisionValue = 7680;
                    if (TimeDivisionOptions.SelectedIndex == 2)
                        timeDivisionValue = 3840;
                    if (TimeDivisionOptions.SelectedIndex == 3)
                        timeDivisionValue = 3072;
                    if (TimeDivisionOptions.SelectedIndex == 4)
                        timeDivisionValue = 1920;
                    if (TimeDivisionOptions.SelectedIndex == 5)
                        timeDivisionValue = 1024;
                    if (TimeDivisionOptions.SelectedIndex == 6)
                        timeDivisionValue = 960;
                    if (TimeDivisionOptions.SelectedIndex == 7)
                        timeDivisionValue = 768;
                    if (TimeDivisionOptions.SelectedIndex == 8)
                        timeDivisionValue = 500;
                    if (TimeDivisionOptions.SelectedIndex == 9)
                        timeDivisionValue = 480;
                    if (TimeDivisionOptions.SelectedIndex == 10)
                        timeDivisionValue = 384;
                    if (TimeDivisionOptions.SelectedIndex == 11)
                        timeDivisionValue = 256;
                    if (TimeDivisionOptions.SelectedIndex == 12)
                        timeDivisionValue = 240;
                    if (TimeDivisionOptions.SelectedIndex == 13)
                        timeDivisionValue = 192;
                    if (TimeDivisionOptions.SelectedIndex == 14)
                        timeDivisionValue = 120;
                    if (TimeDivisionOptions.SelectedIndex == 15)
                        timeDivisionValue = 96;
                    if (TimeDivisionOptions.SelectedIndex == 16)
                        timeDivisionValue = 48;
                    if (TimeDivisionOptions.SelectedIndex == 17)
                        timeDivisionValue = 24;

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
