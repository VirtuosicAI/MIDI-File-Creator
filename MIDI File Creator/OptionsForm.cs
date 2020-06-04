using System.Windows.Forms;
using MIDI_File_Creator.Properties;

namespace MIDI_File_Creator
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            SysexNoneRadio.Checked = Settings.Default.SysExNone;
            SysexGMRadio.Checked = Settings.Default.SysExGM;
            SysexRolandRadio.Checked = Settings.Default.SysExRoland;
            SysexYamahaRadio.Checked = Settings.Default.SysExYamaha;
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.SysExNone = SysexNoneRadio.Checked;
            Settings.Default.SysExGM = SysexGMRadio.Checked;
            Settings.Default.SysExRoland = SysexRolandRadio.Checked;
            Settings.Default.SysExYamaha = SysexYamahaRadio.Checked;
            Settings.Default.Save();
        }
    }
}
