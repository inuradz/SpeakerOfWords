using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;

namespace Text_Speaker
{
    /// <summary>
    /// This is a windows form designed to provide a simple gui layer to .net speech sysnthesis
    /// </summary>
    /// <remarks>
    /// This is the first C# program I have ever written
    /// This is also not meant to give a complete wrapper to the module
    /// </remarks>
    public partial class Speak : Form
    {
        /// <summary>
        /// This holds the speech synthesiser
        /// </summary>
        private SpeechSynthesizer synth;
        private string text;
        private Boolean speaking;
        private VoiceGender gender;
        private VoiceAge age;
        private List<System.Windows.Forms.ToolStripMenuItem> voices;
        /// <summary>
        /// This intilises the class
        /// </summary>
        public Speak()
        {
            InitializeComponent();
            synth = new SpeechSynthesizer();
            voices = new List<System.Windows.Forms.ToolStripMenuItem>();
            voiceMenu();
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(synth_SpeakProgress);
            synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
            speaking = false;
            gender = VoiceGender.NotSet;
            age = VoiceAge.NotSet;
        }

        /// <summary>
        /// This puts all the installed voices into the Voices Menu in the Options Drop Down
        /// </summary>
        /// <remarks>
        /// Not all installed voices on the system will be usable by speech synthesiser
        /// </remarks>
        private void voiceMenu()
        {
            foreach ( InstalledVoice i in synth.GetInstalledVoices())
            {
                var t = new System.Windows.Forms.ToolStripMenuItem();
                this.voices.Add(t);
                t.Name = "Voice:" + i.VoiceInfo.Name;
                t.Size = new System.Drawing.Size(122, 22);
                t.Text = i.VoiceInfo.Name;
                t.Click += this.changeVoice_Click;
            }
            this.installedVoicesToolStripMenuItem.DropDownItems.AddRange(this.voices.ToArray());
        }

        /// <summary>
        /// This is the event handler 
        /// </summary>
        /// <param name="sender">This is information about what sent the event</param>
        /// <param name="e">This is addtional information</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (speaking)
            {
                synth.SpeakAsyncCancelAll();
                speaking = false;
            } else
            {
                text = richTextBox1.Text;
                Regex blank = new Regex(@"\s+");
                Regex newLine = new Regex(@"\n+");
                text = blank.Replace(text, " ");
                text = newLine.Replace(text, "\n");
                button1.Text = "Stop";
                synth.SpeakAsync(text);
                speaking = true;
            }
        }
        /// <summary>
        /// This is used to tell how far the speech has gone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void synth_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            if (text.Length != 0)
            {
                progressBar1.Value = (int) (e.CharacterPosition * 100.0 / text.Length);
                //Console.Write("I saw soemthing");
            }
        }
        /// <summary>
        /// This occcurs when the speech is finally completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            button1.Text = "Speak";
            progressBar1.Value = 100;
        }

        /// <summary>
        /// This gives a simple pop up to give information about the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "This is a basic program that speaks what ever is typed into the text box \n It is written by Inura De Zoysa";
            const string caption = "Info";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }
        /// <summary>
        /// This selects the gender for the select voice by hints
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectGender_Click(object sender, EventArgs e)
        {
            var s = sender as ToolStripMenuItem;
            if(s != null)
            {
                switch (s.Text)
                {
                    case "Male":
                        this.gender = VoiceGender.Male;
                        break;
                    case "Female":
                        this.gender = VoiceGender.Female;
                        break;
                    case "Neutral":
                        this.gender = VoiceGender.Neutral;
                        break;
                    case "Not Set":
                        this.gender = VoiceGender.NotSet;
                        break;
                }
                this.synth.SelectVoiceByHints(gender, age);
            }
        }
        /// <summary>
        /// This sets the age for the select voice by hints
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAge_Click(object sender, EventArgs e)
        {
            var s = sender as ToolStripMenuItem;
            if (s != null)
            {
                switch (s.Text)
                {
                    case "Child":
                        this.age = VoiceAge.Child;
                        break;
                    case "Teenager":
                        this.age = VoiceAge.Teen;
                        break;
                    case "Adult":
                        this.age = VoiceAge.Adult;
                        break;
                    case "Senior":
                        this.age = VoiceAge.Senior;
                        break;
                }
                this.synth.SelectVoiceByHints(gender, age);
            }
        }
        /// <summary>
        /// This changes the voice of synthesiser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeVoice_Click(object sender, EventArgs e)
        {
            var s = sender as ToolStripMenuItem;
            if (s != null)
            {
                this.synth.SelectVoice(s.Text);
            }
        }

        /// <summary>
        /// This opens up a webpage to help page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("www.bing.com");
        }
    }
}
