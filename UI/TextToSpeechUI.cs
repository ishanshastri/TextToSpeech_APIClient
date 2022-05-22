using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS_Project
    {
    public partial class TextToSpeechUI : Form
        {
        private static TextToSpeech TTS = new TextToSpeech();
        public TextToSpeechUI()
            {
            InitializeComponent();
            PopulateComboBox();
            }

        private void speakButton_Click(object sender, EventArgs e)
            {

            }

        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void PopulateComboBox()
            {
            TextBox tb = new TextBox();
            IEnumerable<Voice> voices = TTS.GetAllVoices();
            foreach(Voice v in voices)
                {
                tb.Text = v.Name + " - (" + v.CountryShort + ")";
                this.VoicesComboBox.Controls.Add(tb);
                }
            }
        }
    }
