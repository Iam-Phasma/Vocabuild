using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SimpleGuessingGame
{
    public partial class Form1 : Form
    {

        Random rdm = new Random();
        

        public Form1()
        {
            InitializeComponent();
            

            rightans.Add("Very good!");
            rightans.Add("Nice one!");
            rightans.Add("Correct answer!");
            rightans.Add("That's it!");
            rightans.Add("Sure.");

            wrongans.Add("Sorry, wrong answer.");
            wrongans.Add("Try again next time.");
            wrongans.Add("Unfortunate.");
            wrongans.Add("Opps, wrong click?.");
            wrongans.Add("It's incorrect.");

            /*
            foreach(var i in rightans)
            {
                Console.WriteLine(i);
            }
            */

            

            
            

        }

        int scored = 0;
        ArrayList rightans = new ArrayList();
        ArrayList wrongans = new ArrayList();
        StringBuilder wordsbuilder = new StringBuilder();


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void img_start_Click(object sender, EventArgs e)
        {
            score.Visible = true;
            scoreborad1.Visible = true;
            help.Visible = true;
            next1.Visible = true;
            score.Text = Convert.ToString(scored);

            question1.Visible = true;
            hintclikme1.Visible = true;
            ridge.Visible = true;
            uncover.Visible = true;
            withdraw.Visible = true;
            

            img_logotxt.Visible = false;
            img_start.Enabled = false;
            img_start.Visible = false;
        }

        private void scoreborad1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            next1.Visible = false;
            next2.Visible = true;
            
            question1.Visible = false;
            question2.Visible = true;

            hint1.Visible = false;
            hintclikme1.Visible = false;
            hintclick2.Visible = true;

            ridge.Visible = false;
            ridgeGreen.Visible = false;
            uncover.Visible = false;
            uncoverRed.Visible = false;
            withdraw.Visible = false;
            withdrawRed.Visible = false;

            defend.Visible = true;
            Insist.Visible = true;
            Obviate.Visible = true;

            scoreboard2.Visible = true;
            scoreborad1.Visible = false;

            rightcomment.Visible = false;
            wrongcomment.Visible = false;

        }

        private void score_Click(object sender, EventArgs e)
        {
            
        }

        private void hintclikme1_Click(object sender, EventArgs e)
        {
            hintclikme1.Visible = false;
            hint1.Visible = true;

        }

        private void ridge_Click(object sender, EventArgs e)
        {
            ridgeGreen.Visible = true;
            ridge.Visible = false;
            scored = +1;
            score.Text = Convert.ToString(scored);
            next1.Enabled = true;
            uncover.Enabled = false;
            withdraw.Enabled = false;

            int num = rdm.Next(0, 4);
            rightcomment.Visible = true;
            rightcomment.Text = Convert.ToString("System: " + rightans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Your answers: Ridge, "));

        }

        private void uncover_Click(object sender, EventArgs e)
        {
            uncoverRed.Visible = true;
            uncover.Visible = false;
            ridge.Visible = false;
            ridgeGreen.Visible = true;
            withdraw.Enabled = false;
            next1.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Your answers: Uncover, "));
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            withdrawRed.Visible = true;
            withdraw.Visible = false;
            ridge.Visible = false;
            ridgeGreen.Visible = true;
            uncover.Enabled = false;
            next1.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Your answers: Withdraw, "));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            hintclick2.Visible = false;
            hint2.Visible = true;
            
            
            
        }

        private void uncoverRed_Click(object sender, EventArgs e)
        {

        }

        private void next2_Click(object sender, EventArgs e)
        {
            scoreboard3.Visible = true;
            scoreboard2.Visible = false;

            question2.Visible = false;
            hint2.Visible = false;
            hintclick3.Visible = true;
            hint1.Visible = false;
            hintclick2.Visible = false;
            
            
            defendRed.Visible = false;
            insistGreen.Visible = false;
            obviateRed.Visible = false;
            defend.Visible = false;

            question3.Visible = true;
            disclaim.Visible = true;
            refuse.Visible = true;
            concede.Visible = true;
            Obviate.Visible = false;
            Insist.Visible = false;
            insistGreen.Visible = false;

            next3.Visible = true;
            next2.Visible = false;

            rightcomment.Visible = false;
            wrongcomment.Visible = false;
        }

        private void hint2_Click(object sender, EventArgs e)
        {

        }

        private void Insist_Click(object sender, EventArgs e)
        {
            scored++;
            score.Text = Convert.ToString(scored);
            scoreborad1.Visible = false;

            next2.Enabled = true;

            insistGreen.Visible = true;
            Insist.Visible = false;

            defend.Enabled = false;
            Obviate.Enabled = false;

            int num = rdm.Next(0, 4);
            rightcomment.Visible = true;
            rightcomment.Text = Convert.ToString("System: " + rightans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Insist, "));

        }

        private void defend_Click(object sender, EventArgs e)
        {
            Obviate.Enabled = false;
            Insist.Enabled = false;
            Insist.Visible = false;
            insistGreen.Visible = true;

            defendRed.Visible = true;
            defend.Visible = false;

            next2.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Defend, "));
        }

        private void Obviate_Click(object sender, EventArgs e)
        {
            insistGreen.Visible = true;
            Insist.Visible = false;
            defend.Enabled = false;

            obviateRed.Visible = true;
            Obviate.Visible = false;
            next2.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Obviate, "));
        }

        private void obviateRed_Click(object sender, EventArgs e)
        {

        }

        private void hintclick3_Click(object sender, EventArgs e)
        {
            hintclick3.Visible = false;
            hint3.Visible = true;
        }

        private void disclaim_Click(object sender, EventArgs e)
        {
            refuse.Enabled = false;
            disclaimRed.Visible = true;
            disclaim.Visible = false;
            concedeRed.Visible = true;
            refuse.Visible = false;
            refuseGreen.Visible = true;

            next2.Visible = false;
            next3.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Disclaim, "));
        }

        private void refuse_Click(object sender, EventArgs e)
        {

            refuseGreen.Visible = true;
            refuse.Visible = false;
            scored++;
            score.Text = Convert.ToString(scored);

            disclaim.Enabled = false;

            next2.Visible = false;
            next3.Enabled = true;

            concede.Enabled = false;

            int num = rdm.Next(0, 4);
            rightcomment.Visible = true;
            rightcomment.Text = Convert.ToString("System: " + rightans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Refuse, "));
        }

        private void concede_Click(object sender, EventArgs e)
        {
            concedeRed.Visible = true;
            concede.Visible = false;
            disclaim.Enabled = false;
            refuse.Visible = false;
            refuseGreen.Visible = true;

            next2.Visible = false;
            next3.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Concede, "));
        }

        private void next3_Click(object sender, EventArgs e)
        {
            next4.Visible = true;
            next3.Visible = false;

            scoreboard3.Visible = false;
            scoreboard4.Visible = true;

            disclaim.Visible = false;
            disclaimRed.Visible = false;
            refuse.Visible = false;
            refuseGreen.Visible = false;
            concede.Visible = false;
            concedeRed.Visible = false;

            spectrum.Visible = true;
            upgrade.Visible = true;
            periapsis.Visible = true;

            question4.Visible = true;
            question3.Visible = false;
            hintclick4.Visible = true;

            hint2.Visible = false;
            hintclick2.Visible = false;
            hint3.Visible = false;
            hintclick3.Visible = false;

            rightcomment.Visible = false;
            wrongcomment.Visible = false;

        }

        private void concedeGreen_Click(object sender, EventArgs e)
        {

        }

        private void disclaimRed_Click(object sender, EventArgs e)
        {

        }

        private void refuseGreen_Click(object sender, EventArgs e)
        {

        }

        private void hintclick4_Click(object sender, EventArgs e)
        {
            hintclick4.Visible = false;
            hint4.Visible = true;

        }

        private void spectrum_Click(object sender, EventArgs e)
        {
            spectrum.Visible = false;
            spectrumGreen.Visible = true;

            scored++;
            score.Text = Convert.ToString(scored);

            upgrade.Enabled = false;
            periapsis.Enabled = false;

            next4.Enabled = true;

            int num = rdm.Next(0, 4);
            rightcomment.Visible = true;
            rightcomment.Text = Convert.ToString("System: " + rightans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Spectrum, "));
        }

        private void upgrade_Click(object sender, EventArgs e)
        {
            upgrade.Visible = false;
            upgradeRed.Visible = true;
            spectrum.Visible = false;
            spectrumGreen.Visible = true;
            periapsis.Enabled = false;

            next4.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Upgrade, "));
        }

        private void periapsis_Click(object sender, EventArgs e)
        {
            periapsis.Visible = false;
            periapsisRed.Visible = true;
            spectrum.Visible = false;
            spectrumGreen.Visible = true;
            upgrade.Enabled = false;

            next4.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Periapsis, "));
        }

        private void hintclick5_Click(object sender, EventArgs e)
        {
            hintclick5.Visible = false;
            hint5.Visible = true;

        }

        private void next4_Click(object sender, EventArgs e)
        {
            hintclick5.Visible = true;
            hint4.Visible = false;
            hintclick4.Visible = false;
            hint3.Visible = false;
            hintclick3.Visible = false;
            question4.Visible = false;
            question5.Visible = true;

            scoreboard4.Visible = false;
            scoreboard5.Visible = true;

            spectrum.Visible = false;
            spectrumGreen.Visible = false;
            upgrade.Visible = false;
            upgradeRed.Visible = false;
            periapsis.Visible = false;
            periapsisRed.Visible = false;


            farewell.Visible = true;
            ostrasize.Visible = true;
            change.Visible = true;

            next4.Visible = false;
            exit.Visible = true;

            rightcomment.Visible = false;
            wrongcomment.Visible = false;
        }

        private void farewell_Click(object sender, EventArgs e)
        {
            farewell.Visible = false;
            farewellRed.Visible = true;
            ostrasize.Visible = false;
            ostrasizeGreen.Visible = true;
            change.Enabled = true;
            exit.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Farewell."));
        }

        private void ostrasize_Click(object sender, EventArgs e)
        {
            scored++;
            score.Text = Convert.ToString(scored);

            farewell.Enabled = false;
            change.Enabled = false;
            ostrasize.Visible = false;
            ostrasizeGreen.Visible = true;
            exit.Enabled = true;

            int num = rdm.Next(0, 4);
            rightcomment.Visible = true;
            rightcomment.Text = Convert.ToString("System: " + rightans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Ostracize."));
        }

        private void change_Click(object sender, EventArgs e)
        {
            change.Visible = false;
            changeRed.Visible = true;
            ostrasize.Visible=false;
            ostrasizeGreen.Visible = true;
            farewell.Enabled = false;
            exit.Enabled = true;

            int num = rdm.Next(0, 4);
            wrongcomment.Visible = true;
            wrongcomment.Text = Convert.ToString("System: " + wrongans[num]);

            scredits.Text = Convert.ToString(wordsbuilder.Append("Change."));
        }

        private void changeRed_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            scredits.Visible = true;
            

            scoreEnd.Visible = true;
            scoreEnd.Text = Convert.ToString(scored);
            scoreboard5.Visible = false;
            score.Visible = false;
            question5.Visible = false;
            hint5.Visible = false;
            hint4.Visible = false;
            hint3.Visible = false;
            hint3.Visible = false;
            hint2.Visible = false;
            hint1.Visible = false;
            farewell.Visible = false;
            farewellRed.Visible = false;
            ostrasize.Visible = false;
            ostrasizeGreen.Visible = false;
            change.Visible = false;
            changeRed.Visible = false;
            exit.Visible = false;
            hintclick5.Visible = false;
            hintclick4.Visible = false;
            hintclick3.Visible = false;
            hintclick2.Visible = false;
            hintclikme1.Visible = false;
            help.Visible = false;
            
            outro.Visible = true;

            rightcomment.Visible = false;
            wrongcomment.Visible = false;

            
            
        }
    }
}
