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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Voice_Recognition_and_Command
{
    public partial class Video : Form
    {

        //If Computer is called
        SpeechSynthesizer s = new SpeechSynthesizer();
        Choices keypress = new Choices();
        SpeechRecognitionEngine enable = new SpeechRecognitionEngine();

        //Main Switch
        Choices main = new Choices();
        SpeechRecognitionEngine mainrec = new SpeechRecognitionEngine();

        //VOLUME
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
           IntPtr wParam, IntPtr lParam);

        public Video()
        {
            InitializeComponent();
            this.TopMost = true;
            main.Add(new String[] {
                                     //Available Commands
                                      "Computer", "Hey Computer", "Okay Computer", "Okay Root"
                                      });

            //If Computer is Called
            Grammar gr1 = new Grammar(new GrammarBuilder(main));

            try
            {
                mainrec.RequestRecognizerUpdate();
                mainrec.LoadGrammar(gr1);
                mainrec.SpeechRecognized += mainrec_SpeechRecognized;
                mainrec.SetInputToDefaultAudioDevice();

            }
            catch { return; }



            keypress.Add(new String[] {
                                     //Available Commands
                                     "Pause Please", "Resume Please", "Maximize the Volume Please", "Mute the Volume Please",
                                     "Maximize the Brightness Please", "Minimize the Brightness Please"
                                      });
            //If Computer is Called
            Grammar gr2 = new Grammar(new GrammarBuilder(keypress));

            try
            {
                enable.RequestRecognizerUpdate();
                enable.LoadGrammar(gr2);
                enable.SpeechRecognized += enable_SpeechRecognized;
                enable.SetInputToDefaultAudioDevice();
            }
            catch { return; }

            s.SelectVoiceByHints(VoiceGender.Female);
            mainrec.RecognizeAsync(RecognizeMode.Multiple);


        }


        public void say(String h)
        {
            s.Speak(h);

        }

        //Mainrec
        private void mainrec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String r = e.Result.Text;
            if (r == "Okay Computer" || r == "Okay Root")
            {
                mainrec.RecognizeAsyncStop();
                enable.RecognizeAsync(RecognizeMode.Multiple);
                this.Show();
                progressBar1.Value = 100;
                timer1.Start();

            }

            else if (r == "Hey Computer")
            {
                mainrec.RecognizeAsyncStop();
                enable.RecognizeAsync(RecognizeMode.Multiple);
                this.Show();
                progressBar1.Value = 100;
                timer1.Start();

            }

            else if (r == "Computer")
            {
                mainrec.RecognizeAsyncStop();
                enable.RecognizeAsync(RecognizeMode.Multiple);
                this.Show();
                progressBar1.Value = 100;
                timer1.Start();

            }
        }

        //If Computer is called
        private void enable_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String t = e.Result.Text;
            int x;

            if (t == "Pause Please")
            {
                this.Hide();
                System.Threading.Thread.Sleep(300);
                enable.RecognizeAsyncStop();
                SendKeys.Send(" ");
                timer1.Stop();
                lblTimer.Text = "3";
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;
            }

            else if (t == "Resume Please")
            {
                this.Hide();
                System.Threading.Thread.Sleep(300);
                enable.RecognizeAsyncStop();
                SendKeys.Send(" ");
                timer1.Stop();
                lblTimer.Text = "3";
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;

            }

            else if (t == "Maximize the Volume Please")
            {
                enable.RecognizeAsyncStop();
                for (x = 1;x<=50;x++)
                {
                    SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_UP);
                }
                timer1.Stop();
                this.Hide();
                System.Threading.Thread.Sleep(300);
                lblTimer.Text = "3";
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;

            }
            else if (t == "Mute the Volume Please")
            {
                enable.RecognizeAsyncStop();
                for (x = 1; x <= 50; x++)
                {
                    SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_DOWN);
                }
                timer1.Stop();
                this.Hide();
                System.Threading.Thread.Sleep(300);
                lblTimer.Text = "3";
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;

            }

        }

        private void Video_Presentation_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(-33);
            lblTimer.Text = (Double.Parse(lblTimer.Text) - (1)).ToString();
            lblTimerInv.Text = (Double.Parse(lblTimerInv.Text) - (1)).ToString();
            if (progressBar1.Value == 0)
            {
                timer1.Stop();
                progressBar1.Value = 100;
                lblTimer.Text = "3";

            }
            if ((Double.Parse(lblTimer.Text) == 0))
            {
                enable.RecognizeAsyncStop();
            }
            if ((Double.Parse(lblTimerInv.Text) == 0))
            {
                enable.RecognizeAsyncStop();
                lblTimerInv.Text = "4";
                this.Hide();
                System.Threading.Thread.Sleep(1000);
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
