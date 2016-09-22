using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gambleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Money = 10000;       //Variables
        double GuessOne;
        double GuessTwo;
        double CpuNumOne;
        double CpuNumTwo;
        double Gamble = 500;
        double MoneyWon;
        double MoneyLost;

        private void btnGuess_Click(object sender, EventArgs e)
        {

            Random cpuOne = new Random();
            CpuNumOne = cpuOne.Next(1, 10);
                                                                        //Draws the two Cpu numbers
            Random cpuTwo = new Random();
            CpuNumTwo = cpuTwo.Next(1, 10);

            txtBoxCpuNumOne.Text = "" + CpuNumOne;
            txtBoxCpuNumTwo.Text = "" + CpuNumTwo;

            txtBoxBet.Text = "" + Gamble;

            GuessOne = Convert.ToInt32(txtBoxNum1.Text);                //Draws the two Guess numbers
            GuessTwo = Convert.ToInt32(txtBoxNum2.Text);

            if (GuessOne == CpuNumOne && GuessTwo == CpuNumTwo)         //If 100% correct
            {
                MoneyWon = Gamble;

                txtBoxMoneyWon.Text = "" + MoneyWon;
                txtBoxMoneyLost.Text = "0";

                Money = Money + MoneyWon;
                lblYourMoney.Text = "" + Money;
            }
            else if (GuessOne == CpuNumTwo && GuessTwo == CpuNumOne)    //If correct but not in exact order
            {
                MoneyWon = Gamble * 0.75;

                txtBoxMoneyWon.Text = "" + MoneyWon;
                txtBoxMoneyLost.Text = "0";

                Money = Money + MoneyWon;
                lblYourMoney.Text = "" + Money;
            }
            else if (GuessOne == CpuNumOne && GuessTwo != CpuNumTwo || GuessOne != CpuNumOne && GuessTwo == CpuNumTwo)    //If one guess is correct
            {
                MoneyWon = Gamble * 0.25;

                txtBoxMoneyWon.Text = "" + MoneyWon;
                txtBoxMoneyLost.Text = "0";

                Money = Money + MoneyWon;
                lblYourMoney.Text = "" + Money;
            }
            else if (GuessOne == CpuNumTwo && GuessTwo != CpuNumOne || GuessOne != CpuNumTwo && GuessTwo == CpuNumTwo)  //If one guess is correct in incorrect order
            {
                txtBoxMoneyWon.Text = "0";
                txtBoxMoneyLost.Text = "0";

                lblYourMoney.Text = "" + Money;
            }
            else if (GuessOne != CpuNumTwo && GuessTwo != CpuNumOne || GuessOne != CpuNumTwo && GuessTwo != CpuNumTwo)  //If neither guesses are correct
            {
                MoneyLost = Gamble;
                txtBoxMoneyWon.Text = "0";
                txtBoxMoneyLost.Text = "" + MoneyLost;

                Money = Money - MoneyLost;
                lblYourMoney.Text = "" + Money;
            }

            txtBoxNum1.Text = "";                       //Reset the table
            txtBoxNum2.Text = "";

            txtBoxPrevGuessOne.Text = "" + GuessOne;
            txtBoxPrevGuessTwo.Text = "" + GuessTwo;

            GuessOne = 0;
            GuessTwo = 0;

            Gamble = 500;
            lblGamble.Text = "" + Gamble;
            btnGambleMinus.Visible = false;
            if (Money <= 500)
            {
                btnGamblePlus.Visible = false;
                Gamble = Money;
                lblGamble.Text = "" + Gamble;
            }
            else { }
            if (Money <= 0)     //LOOSER!!
            {
                lblGamble.Visible = false;
                lblYourMoney.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = false;
                btn5.Visible = false;
                btn6.Visible = false;
                btn7.Visible = false;
                btn8.Visible = false;
                btn9.Visible = false;
                btnGambleMinus.Visible = false;
                btnGamblePlus.Visible = false;
                btnGuess.Visible = false;
                txtBoxBet.Visible = false;
                txtBoxCpuNumOne.Visible = false;
                txtBoxCpuNumTwo.Visible = false;
                txtBoxMoneyLost.Visible = false;
                txtBoxMoneyWon.Visible = false;
                txtBoxNum1.Visible = false;
                txtBoxNum2.Visible = false;
                txtBoxPrevGuessOne.Visible = false;
                txtBoxPrevGuessTwo.Visible = false;

                lblLoose.Visible = true;
                btnRestart.Visible = true;
                btnExit.Visible = true;
            }
            else { }

        }

        private void btn1_Click(object sender, EventArgs e)         //Button Checkes
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "1";
                GuessOne = 1;
            }
            else
            {
                txtBoxNum1.Text = "1";
                GuessOne = 1;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "2";
                GuessOne = 2;
            }
            else
            {
                txtBoxNum1.Text = "2";
                GuessOne = 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "3";
                GuessOne = 3;
            }
            else
            {
                txtBoxNum1.Text = "3";
                GuessOne = 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "4";
                GuessOne = 4;
            }
            else
            {
                txtBoxNum1.Text = "4";
                GuessOne = 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "5";
                GuessOne = 5;
            }
            else
            {
                txtBoxNum1.Text = "5";
                GuessOne = 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "6";
                GuessOne = 6;
            }
            else
            {
                txtBoxNum1.Text = "6";
                GuessOne = 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "7";
                GuessOne = 7;
            }
            else
            {
                txtBoxNum1.Text = "7";
                GuessOne = 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "8";
                GuessOne = 8;
            }
            else
            {
                txtBoxNum1.Text = "8";
                GuessOne = 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (GuessOne == 1 || GuessOne == 2 || GuessOne == 3 || GuessOne == 4 || GuessOne == 5 || GuessOne == 6 || GuessOne == 7 || GuessOne == 8 || GuessOne == 9)
            {
                txtBoxNum2.Text = "9";
                GuessOne = 9;
            }
            else
            {
                txtBoxNum1.Text = "9";
                GuessOne = 9;
            }
        }

        private void btnGamblePlus_Click(object sender, EventArgs e)        //Check plus button
        {
            if (Gamble + 1000 > Money)
            {
                Gamble = Gamble + 500;
                lblGamble.Text = "" + Gamble;

                btnGambleMinus.Visible = true;
                btnGamblePlus.Visible = false;
            }
            else if (Gamble + 500 <= Money)
            {
                Gamble = Gamble + 500;
                lblGamble.Text = "" + Gamble;

                btnGambleMinus.Visible = true;
            }
            else
            { }
        }

        private void btnGambleMinus_Click(object sender, EventArgs e)   //Check minus button
        {
            if (Gamble <= 1000)
            {
                Gamble = Gamble - 500;
                lblGamble.Text = "" + Gamble;

                btnGambleMinus.Visible = false;
            }
            if (Gamble > 500)
            {
                Gamble = Gamble - 500;
                lblGamble.Text = "" + Gamble;
                btnGamblePlus.Visible = true;
            }
            else { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)      //Exit
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)       //Reset
        {
            lblGamble.Visible = true;
            lblYourMoney.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;
            btnGambleMinus.Visible = true;
            btnGamblePlus.Visible = true;
            btnGuess.Visible = true;
            txtBoxBet.Visible = true;
            txtBoxCpuNumOne.Visible = true;
            txtBoxCpuNumTwo.Visible = true;
            txtBoxMoneyLost.Visible = true;
            txtBoxMoneyWon.Visible = true;
            txtBoxNum1.Visible = true;
            txtBoxNum2.Visible = true;
            txtBoxPrevGuessOne.Visible = true;
            txtBoxPrevGuessTwo.Visible = true;

            lblLoose.Visible = false;
            btnRestart.Visible = false;
            btnExit.Visible = false;

            Money = 10000;
            Gamble = 500;

            lblGamble.Text = "" + Gamble;
            lblYourMoney.Text = "" + Money;

            txtBoxBet.Text = "";
            txtBoxCpuNumOne.Text = "";
            txtBoxCpuNumTwo.Text = "";
            txtBoxMoneyLost.Text = "";
            txtBoxMoneyWon.Text = "";
            txtBoxNum1.Text = "";
            txtBoxNum2.Text = "";
            txtBoxPrevGuessOne.Text = "";
            txtBoxPrevGuessTwo.Text = "";
        }
    }
}
