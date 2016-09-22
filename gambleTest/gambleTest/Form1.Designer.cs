namespace gambleTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblYourMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGamble = new System.Windows.Forms.Label();
            this.btnGamblePlus = new System.Windows.Forms.Button();
            this.btnGambleMinus = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCpuNumTwo = new System.Windows.Forms.TextBox();
            this.txtBoxCpuNumOne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMoneyWon = new System.Windows.Forms.TextBox();
            this.txtBoxMoneyLost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxPrevGuessTwo = new System.Windows.Forms.TextBox();
            this.txtBoxPrevGuessOne = new System.Windows.Forms.TextBox();
            this.txtBoxBet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLoose = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Money :";
            // 
            // lblYourMoney
            // 
            this.lblYourMoney.AutoSize = true;
            this.lblYourMoney.Location = new System.Drawing.Point(83, 13);
            this.lblYourMoney.Name = "lblYourMoney";
            this.lblYourMoney.Size = new System.Drawing.Size(37, 13);
            this.lblYourMoney.TabIndex = 1;
            this.lblYourMoney.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pick two numbers";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(19, 77);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(24, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(49, 77);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(24, 23);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(79, 77);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(24, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(79, 106);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(24, 23);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(49, 106);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(24, 23);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(19, 106);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(24, 23);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(79, 135);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(24, 23);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(49, 135);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(24, 23);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(19, 135);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(24, 23);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxNum1.Location = new System.Drawing.Point(19, 53);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.ReadOnly = true;
            this.txtBoxNum1.Size = new System.Drawing.Size(24, 20);
            this.txtBoxNum1.TabIndex = 12;
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxNum2.Location = new System.Drawing.Point(79, 52);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.ReadOnly = true;
            this.txtBoxNum2.Size = new System.Drawing.Size(24, 20);
            this.txtBoxNum2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gamble :";
            // 
            // lblGamble
            // 
            this.lblGamble.AutoSize = true;
            this.lblGamble.Location = new System.Drawing.Point(69, 179);
            this.lblGamble.Name = "lblGamble";
            this.lblGamble.Size = new System.Drawing.Size(25, 13);
            this.lblGamble.TabIndex = 15;
            this.lblGamble.Text = "500";
            // 
            // btnGamblePlus
            // 
            this.btnGamblePlus.Location = new System.Drawing.Point(19, 200);
            this.btnGamblePlus.Name = "btnGamblePlus";
            this.btnGamblePlus.Size = new System.Drawing.Size(24, 23);
            this.btnGamblePlus.TabIndex = 16;
            this.btnGamblePlus.Text = "+";
            this.btnGamblePlus.UseVisualStyleBackColor = true;
            this.btnGamblePlus.Click += new System.EventHandler(this.btnGamblePlus_Click);
            // 
            // btnGambleMinus
            // 
            this.btnGambleMinus.Location = new System.Drawing.Point(79, 200);
            this.btnGambleMinus.Name = "btnGambleMinus";
            this.btnGambleMinus.Size = new System.Drawing.Size(24, 23);
            this.btnGambleMinus.TabIndex = 17;
            this.btnGambleMinus.Text = "-";
            this.btnGambleMinus.UseVisualStyleBackColor = true;
            this.btnGambleMinus.Visible = false;
            this.btnGambleMinus.Click += new System.EventHandler(this.btnGambleMinus_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(120, 91);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 52);
            this.btnGuess.TabIndex = 18;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Generated Number";
            // 
            // txtBoxCpuNumTwo
            // 
            this.txtBoxCpuNumTwo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxCpuNumTwo.Location = new System.Drawing.Point(284, 29);
            this.txtBoxCpuNumTwo.Name = "txtBoxCpuNumTwo";
            this.txtBoxCpuNumTwo.ReadOnly = true;
            this.txtBoxCpuNumTwo.Size = new System.Drawing.Size(24, 20);
            this.txtBoxCpuNumTwo.TabIndex = 21;
            this.txtBoxCpuNumTwo.Visible = false;
            // 
            // txtBoxCpuNumOne
            // 
            this.txtBoxCpuNumOne.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxCpuNumOne.Location = new System.Drawing.Point(251, 29);
            this.txtBoxCpuNumOne.Name = "txtBoxCpuNumOne";
            this.txtBoxCpuNumOne.ReadOnly = true;
            this.txtBoxCpuNumOne.Size = new System.Drawing.Size(24, 20);
            this.txtBoxCpuNumOne.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "You won :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "You lost :";
            // 
            // txtBoxMoneyWon
            // 
            this.txtBoxMoneyWon.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMoneyWon.Location = new System.Drawing.Point(215, 145);
            this.txtBoxMoneyWon.Name = "txtBoxMoneyWon";
            this.txtBoxMoneyWon.ReadOnly = true;
            this.txtBoxMoneyWon.Size = new System.Drawing.Size(92, 20);
            this.txtBoxMoneyWon.TabIndex = 24;
            // 
            // txtBoxMoneyLost
            // 
            this.txtBoxMoneyLost.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMoneyLost.Location = new System.Drawing.Point(215, 188);
            this.txtBoxMoneyLost.Name = "txtBoxMoneyLost";
            this.txtBoxMoneyLost.ReadOnly = true;
            this.txtBoxMoneyLost.Size = new System.Drawing.Size(92, 20);
            this.txtBoxMoneyLost.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Your Numbers";
            // 
            // txtBoxPrevGuessTwo
            // 
            this.txtBoxPrevGuessTwo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxPrevGuessTwo.Location = new System.Drawing.Point(159, 29);
            this.txtBoxPrevGuessTwo.Name = "txtBoxPrevGuessTwo";
            this.txtBoxPrevGuessTwo.ReadOnly = true;
            this.txtBoxPrevGuessTwo.Size = new System.Drawing.Size(24, 20);
            this.txtBoxPrevGuessTwo.TabIndex = 28;
            this.txtBoxPrevGuessTwo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxPrevGuessOne
            // 
            this.txtBoxPrevGuessOne.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxPrevGuessOne.Location = new System.Drawing.Point(129, 29);
            this.txtBoxPrevGuessOne.Name = "txtBoxPrevGuessOne";
            this.txtBoxPrevGuessOne.ReadOnly = true;
            this.txtBoxPrevGuessOne.Size = new System.Drawing.Size(24, 20);
            this.txtBoxPrevGuessOne.TabIndex = 27;
            // 
            // txtBoxBet
            // 
            this.txtBoxBet.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxBet.Location = new System.Drawing.Point(215, 90);
            this.txtBoxBet.Name = "txtBoxBet";
            this.txtBoxBet.ReadOnly = true;
            this.txtBoxBet.Size = new System.Drawing.Size(92, 20);
            this.txtBoxBet.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "You bet :";
            // 
            // lblLoose
            // 
            this.lblLoose.AutoSize = true;
            this.lblLoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoose.Location = new System.Drawing.Point(34, 22);
            this.lblLoose.Name = "lblLoose";
            this.lblLoose.Size = new System.Drawing.Size(264, 55);
            this.lblLoose.TabIndex = 31;
            this.lblLoose.Text = "You Loose";
            this.lblLoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoose.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(44, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 59);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(201, 106);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(97, 59);
            this.btnRestart.TabIndex = 33;
            this.btnRestart.Text = "R E S T A R T";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 237);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblLoose);
            this.Controls.Add(this.txtBoxBet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxPrevGuessTwo);
            this.Controls.Add(this.txtBoxPrevGuessOne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxMoneyLost);
            this.Controls.Add(this.txtBoxMoneyWon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxCpuNumTwo);
            this.Controls.Add(this.txtBoxCpuNumOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnGambleMinus);
            this.Controls.Add(this.btnGamblePlus);
            this.Controls.Add(this.lblGamble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblYourMoney);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "gambleTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYourMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtBoxNum1;
        private System.Windows.Forms.TextBox txtBoxNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGamble;
        private System.Windows.Forms.Button btnGamblePlus;
        private System.Windows.Forms.Button btnGambleMinus;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCpuNumTwo;
        private System.Windows.Forms.TextBox txtBoxCpuNumOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxMoneyWon;
        private System.Windows.Forms.TextBox txtBoxMoneyLost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxPrevGuessTwo;
        private System.Windows.Forms.TextBox txtBoxPrevGuessOne;
        private System.Windows.Forms.TextBox txtBoxBet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLoose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
    }
}

