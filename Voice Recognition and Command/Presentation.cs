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
    public partial class Presentation : Form
    {
        //If Computer is called
        SpeechSynthesizer s = new SpeechSynthesizer();
        Choices keypress = new Choices();
        SpeechRecognitionEngine enable = new SpeechRecognitionEngine();

        //Main Switch
        Choices main = new Choices();
        SpeechRecognitionEngine mainrec = new SpeechRecognitionEngine();

        public Presentation()
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
                                      "Next please", "Next Slide Please", "Move Forward", "Back Please", "Turn Previous",
                "Enter Full Screen Presentation", "Exit Full Screen Presentation"
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

            if (r == "Hey Computer")
            {
                mainrec.RecognizeAsyncStop();
                enable.RecognizeAsync(RecognizeMode.Multiple);
                this.Show();
                progressBar1.Value = 100;
                timer1.Start();

            }

            if (r == "Computer")
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

            if (t == "Next please" || t == "Next Slide Please" || t== "Move Forward")
            {
                this.Hide();
                System.Threading.Thread.Sleep(300);
                enable.RecognizeAsyncStop();
                SendKeys.Send("{RIGHT}");
                timer1.Stop();
                lblTimer.Text = "3";
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;
            }

            else if (t == "Back Please" || t== "Turn Previous")
            {
                this.Hide();
                System.Threading.Thread.Sleep(300);
                enable.RecognizeAsyncStop();
                SendKeys.Send("{LEFT}");
                SendKeys.Send("{LEFT}");
                timer1.Stop();
                lblTimer.Text = "3";
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;
            }

            else if (t == "Enter Full Screen Presentation")
            {
                this.Hide();
                System.Threading.Thread.Sleep(300);
                enable.RecognizeAsyncStop();
                SendKeys.Send("{F5}");
                timer1.Stop();
                lblTimer.Text = "3";
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;
            }

            else if (t == "Exit Full Screen Presentation")
            {
                this.Hide();
                System.Threading.Thread.Sleep(300);
                enable.RecognizeAsyncStop();
                SendKeys.Send("{ESC}");
                timer1.Stop();
                lblTimer.Text = "3";
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;
            }
        }

        private void Presentation_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
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
                this.Hide();
                lblTimerInv.Text = "4";
                mainrec.RecognizeAsync(RecognizeMode.Multiple);
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;
            }

        }
    }
}
