using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;


namespace Voice_Recognition_and_Command
{
    public partial class Form1 : Form
    {
        //If Computer is called
        SpeechSynthesizer s = new SpeechSynthesizer();
        Choices keypress = new Choices();
        SpeechRecognitionEngine enable = new SpeechRecognitionEngine();

        //Main Switch
        Choices main = new Choices();
        SpeechRecognitionEngine mainrec = new SpeechRecognitionEngine();
        

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            notifyIcon.Visible = true;
            s.SelectVoiceByHints(VoiceGender.Female);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void say(String h)
        {
            s.Speak(h);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            s.Speak("This Application was developed by Imperium, exclusively for Teachers' and Students' Presentations, in Bin nyan City Senior High School - San Antonio Campus") ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?",
                "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                s.Speak("Thank you for using this application. Hope it helps");
                this.Close();
            }
            else if (dialog == DialogResult.No)
            {
                
            }
        }

        private void buttonPresentation_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you presenting with a projector?",
               "Projection Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Presentation presents = new Presentation();
                presents.Hide();
                buttonVideo.Enabled = false;
                buttonPresentation.Enabled = false;
                s.Speak("Please turn your computer's projection to Extended, for better use of the program.");
            }
            else if (dialog == DialogResult.No)
            {
                this.Hide();
                Presentations present = new Presentations();
                present.Hide();
                buttonVideo.Enabled = false;
                buttonPresentation.Enabled = false;
                this.ShowInTaskbar = true; 

            }

        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            Video vid = new Video();
            vid.Hide();
            buttonPresentation.Enabled = true;
            this.Hide();
            buttonVideo.Enabled = false;
            buttonPresentation.Enabled = false;
            this.ShowInTaskbar = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                s.Speak("Thank you for using this application. Hope it helps");
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

        }

            private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Do you really want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PowerPoint present = new PowerPoint();
            present.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Video vid = new Video();
            vid.Close();
        }

        private void buttonHowTo_Click(object sender, EventArgs e)
        {
            Tutorial tut = new Tutorial();
            tut.Show();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Determines whether the cursor is in the task bar
            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && cursorNotInBar)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.Visible = true;
        }
    }
    }

