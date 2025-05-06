using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voice_Recognition_and_Command
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }


        //BACK
        private void btnFirst_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = true;
            Second.Visible = false;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = false;
            Fifth.Visible = false;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = true;
            btnThirdPic.Visible = false;
            BtnFourthPic.Visible = false;
            BtnFifthPic.Visible = false;
            BtnSixthPic.Visible = false;


            //BACK BUTTONS
            btnFirst.Enabled = false;
            btnSecond.Visible = false;
            BtnThird.Visible = false;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = true;
            lblPage2.Visible = false;
            lblPage3.Visible = false;
            lblPage4.Visible = false;
            lblPage5.Visible = false;
            lblPage6.Visible = false;
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = true;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = false;
            Fifth.Visible = false;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = true;
            BtnFourthPic.Visible = false;
            BtnFifthPic.Visible = false;
            BtnSixthPic.Visible = false;


            //BACK BUTTONS
            btnFirst.Visible = true;
            btnSecond.Visible = false;
            BtnThird.Visible = false;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = true;
            lblPage3.Visible = false;
            lblPage4.Visible = false;
            lblPage5.Visible = false;
            lblPage6.Visible = false;
        }

        private void BtnThird_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = false;
            Third.Visible = true;
            txtThird.Visible = true;
            Fourth.Visible = false;
            Fifth.Visible = false;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = false;
            BtnFourthPic.Visible = true;
            BtnFifthPic.Visible = false;
            BtnSixthPic.Visible = false;


            //BACK BUTTONS
            btnFirst.Visible = false;
            btnSecond.Visible = true;
            BtnThird.Visible = false;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = false;
            lblPage3.Visible = true;
            lblPage4.Visible = false;
            lblPage5.Visible = false;
            lblPage6.Visible = false;
        }

        private void btnFourth_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = false;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = true;
            Fifth.Visible = false;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = false;
            BtnFourthPic.Visible = false;
            BtnFifthPic.Visible = true;
            BtnSixthPic.Visible = false;


            //BACK BUTTONS
            btnFirst.Visible = false;
            btnSecond.Visible = false;
            BtnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = false;
            lblPage3.Visible = false;
            lblPage4.Visible = true;
            lblPage5.Visible = false;
            lblPage6.Visible = false;
        }

        private void btnFifth_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = false;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = false;
            Fifth.Visible = true;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = false;
            BtnFourthPic.Visible = false;
            BtnFifthPic.Visible = false;
            BtnSixthPic.Visible = false;
            BtnSixthPic.Visible = true;
            BtnSixthPic.Enabled = true;

            //BACK BUTTONS
            btnFirst.Visible = false;
            btnSecond.Visible = false;
            BtnThird.Visible = false;
            btnFourth.Visible = true;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = false;
            lblPage3.Visible = false;
            lblPage4.Visible = false;
            lblPage5.Visible = true;
            lblPage6.Visible = false;
        }

        private void BtnSixth_Click(object sender, EventArgs e)
        {
           
        }

        //NEXT
        private void btnSecondPic_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = true;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = false;
            Fifth.Visible = false;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = true;
            BtnFourthPic.Visible = false;
            BtnFifthPic.Visible = false;
            BtnSixthPic.Visible = false;

            //BACK BUTTONS
            btnFirst.Enabled = true;
            btnFirst.Visible = true;
            btnSecond.Visible = false;
            BtnThird.Visible = false;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = true;
            lblPage3.Visible = false;
            lblPage4.Visible = false;
            lblPage5.Visible = false;
            lblPage6.Visible = false;

        }

        private void btnThirdPic_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = false;
            Third.Visible = true;
            txtThird.Visible = true;
            Fourth.Visible = false;
            Fifth.Visible = false;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = false;
            BtnFourthPic.Visible = true;
            BtnFifthPic.Visible = false;
            BtnSixthPic.Visible = false;

            //BACK BUTTONS
            btnFirst.Visible = false;
            btnSecond.Visible = true;
            BtnThird.Visible = false;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = false;
            lblPage3.Visible = true;
            lblPage4.Visible = false;
            lblPage5.Visible = false;
            lblPage6.Visible = false;
        }

        private void BtnFourthPic_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = false;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = true;
            Fifth.Visible = false;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = false;
            BtnFourthPic.Visible = false;
            BtnFifthPic.Visible = true;
            BtnSixthPic.Visible = false;

            //BACK BUTTONS
            btnFirst.Visible = false;
            btnSecond.Visible = false;
            BtnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = false;
            lblPage3.Visible = false;
            lblPage4.Visible = true;
            lblPage5.Visible = false;
            lblPage6.Visible = false;
        }

        private void BtnFifthPic_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = false;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = false;
            Fifth.Visible = true;
            Sixth.Visible = false;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = false;
            BtnFourthPic.Visible = false;
            BtnFifthPic.Visible = false;
            BtnSixthPic.Visible = true;

            //BACK BUTTONS
            btnFirst.Visible = false;
            btnSecond.Visible = false;
            BtnThird.Visible = false;
            btnFourth.Visible = true;
            btnFifth.Visible = false;
            BtnSixth.Visible = false;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = false;
            lblPage3.Visible = false;
            lblPage4.Visible = false;
            lblPage5.Visible = true;
            lblPage6.Visible = false;
        }

        private void BtnSixthPic_Click(object sender, EventArgs e)
        {
            //Images
            First.Visible = false;
            Second.Visible = false;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = false;
            Fifth.Visible = false;
            Sixth.Visible = true;

            //Next Buttons
            btnSecondPic.Visible = false;
            btnThirdPic.Visible = false;
            BtnFourthPic.Visible = false;
            BtnFifthPic.Visible = false;
            BtnSixthPic.Enabled = false;

            //BACK BUTTONS
            btnFirst.Visible = false;
            btnSecond.Visible = false;
            BtnThird.Visible = false;
            btnFourth.Visible = false;
            btnFifth.Visible = true;

            //LABEL
            lblPage1.Visible = false;
            lblPage2.Visible = false;
            lblPage3.Visible = false;
            lblPage4.Visible = false;
            lblPage5.Visible = false;
            lblPage6.Visible = true;
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            //IMAGES
            First.Visible = true;
            Second.Visible = false;
            Third.Visible = false;
            txtThird.Visible = false;
            Fourth.Visible = false;
            Fifth.Visible = false;
            Sixth.Visible = false;

            //LABEL
            lblPage1.Visible = true;
            lblPage2.Visible = false;
            lblPage3.Visible = false;
            lblPage4.Visible = false;
            lblPage5.Visible = false;
            lblPage6.Visible = false;
        }
    }
}
