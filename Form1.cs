using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ITE_Project
{
    public partial class Form1 : Form
    {
        
     
        GAMEMANAGE G = new GAMEMANAGE();
        static int Level=0;
        static string text;
        static string CorrectAnswer;
        static string[] WrongAnswer = new string[6];
        QUESTION Q = new QUESTION(Level, text, CorrectAnswer, WrongAnswer);
    
        bool BtnA = false;
        bool BtnB = false;
        bool BtnC = false;
        bool BtnD = false;
        bool Btn5050 = false;
        bool BtnSwitch = false;
        bool BtnWithDraw = false;
        bool BtnStartGame = false;
        string[] Answers = new string[4];
        int[] Money = { 0,100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000, 32000, 64000, 125000, 250000, 500000, 1000000 };


        //Fill in and reset the next question
        void BuildQ()
        {
          
            string Line;
            Line = G.GetRandomQuestion(Level);
            string[] Li = Line.Split(';');
            Q.Text = Li[0];
            Q.CorrectAnswer = Li[1];
            for(int i=0;i<6;i++)
            {
                Q.WrongAnswers[i] = Li[i+2];
            }
            
            Answers = G.GetShuffledAnswers(Q);
            //Fill in the binary matrix
            G.questionsAndAnswers[Q.Level, 0] = Q.Text;
            for(int j=1;j<5;j++)
            {
                G.questionsAndAnswers[Q.Level, j] = Answers[j-1];
            }
            

            //print questions and answers
            BAnswerA.Text = Answers[0];
            BAnswerB.Text = Answers[1];
            BAnswerC.Text = Answers[2];
            BAnswerD.Text = Answers[3];
            LaQuestionView.Text = Q.Text;
            //Make it visible if you have clicked on delete two answers
            BAnswerA.Visible = true;
            BAnswerB.Visible = true;
            BAnswerC.Visible = true;
            BAnswerD.Visible = true;
            //Color reset for money list
            ReLabelTableLighting();


        }
        //Return everything as it is,in case of failure or withdraw
        void ReBuildAndReStart()
        {
            BtnA = false;
            BtnB = false;
            BtnC = false;
            BtnD = false;
            Btn5050 = false;
            BtnSwitch = false;
            BtnWithDraw = false;
            BtnStartGame = false;
            string[] Answers = new string[4];
            BStartGame.Visible = true;
            Level = 0;
            BAnswerA.Text = "A";
            BAnswerB.Text = "B";
            BAnswerC.Text = "C";
            BAnswerD.Text = "D";
            LaQuestionView.Text = "Question  will appear  here";
            BStartGame.Visible = true;
            if(BSwitchQuestion.Visible==false)
            {
                BSwitchQuestion.Visible = true;
            }
            BAnswerA.Visible = true;
            BAnswerB.Visible = true;
            BAnswerC.Visible = true;
            BAnswerD.Visible = true;
            B5050.Visible = true;
            laLevel.Text = "Level:0";
            LaMoney.Text = "Money:$0";
            laCurrent.Text = "Current:$0";
            ReLabelTableLighting();


        }
        //Help buttons
        void SwitchQuestion()
        {
            string PastText = Q.Text;
            
            BuildQ();
            while(Q.Text==PastText)
            {
                BuildQ();
            }
           
        }
        void B50_50()
        {
            Random RandNum = new Random();
            int Rand1 = RandNum.Next(0, 3);
            int RandCorrectAnswer = 0;
            for (int j = 0; j < 4; j++)
            {
                if (Q.IsCorrect(Answers[j]))
                {
                    RandCorrectAnswer = j;
                    break;
                }
            }
            int i = 0;
            for (;i < 2;)
            {

                int Rand2 = 0;



                if (Rand1 != RandCorrectAnswer)
                {


                    i++;
                    switch (Rand1)
                    {
                        case 0:
                            {
                                BAnswerA.Visible = false;
                                break;
                            }
                        case 1:
                            {
                                BAnswerB.Visible = false;
                                break;
                            }
                        case 2:
                            {
                                BAnswerC.Visible = false;
                                break;
                            }
                        case 3:
                            {
                                BAnswerD.Visible = false;
                                break;
                            }
                    }


                    Rand2 = Rand1;
                    Rand1 = RandNum.Next(0, 3);
                    while((Rand1  == Rand2)||(Rand1==RandCorrectAnswer))
                    {
                        Rand1 = RandNum.Next(0, 3);


                    }

                }
            }
        }
        //Light the list of funds
        void LabelTableLighting(int Level)
        {
            switch (Level)
            {
                case 1:
                    L100.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 2:
                    L200.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 3:
                    L300.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 4:
                    L500.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 5:
                    L1000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 6:
                    L2000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 7:
                    L4000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 8:
                    L8000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 9:
                    L16000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 10:
                    L32000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 11:
                    L64000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 12:
                    L125000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 13:
                    L250000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 14:
                    L500000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
                case 15:
                    L1000000.BackColor = System.Drawing.Color.AliceBlue;
                    break;
            }

        }
        //Reset the funds list
        void ReLabelTableLighting()
        {
            L100.BackColor = System.Drawing.Color.LightSlateGray;
            L200.BackColor = System.Drawing.Color.LightSlateGray;
            L300.BackColor = System.Drawing.Color.LightSlateGray;
            L500.BackColor = System.Drawing.Color.LightSlateGray;
            L1000.BackColor = System.Drawing.Color.LightSlateGray;
            L2000.BackColor = System.Drawing.Color.LightSlateGray;
            L4000.BackColor = System.Drawing.Color.LightSlateGray;
            L8000.BackColor = System.Drawing.Color.LightSlateGray;
            L16000.BackColor = System.Drawing.Color.LightSlateGray;
            L32000.BackColor = System.Drawing.Color.LightSlateGray;
            L64000.BackColor = System.Drawing.Color.LightSlateGray;
            L125000.BackColor = System.Drawing.Color.LightSlateGray;
            L250000.BackColor = System.Drawing.Color.LightSlateGray;
            L500000.BackColor = System.Drawing.Color.LightSlateGray;
            L1000000.BackColor = System.Drawing.Color.LightSlateGray;
        }



        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void GamePlay()
        {
            if (Level >=15)
            {
                MessageBox.Show("Congratulation on winning , you won a million", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReBuildAndReStart();
            
            }
            else
            {


                if (BtnWithDraw == true)
                {
                    MessageBox.Show("I got this money " + Money[Level].ToString(), "Withdraw", MessageBoxButtons.OK);
                    ReBuildAndReStart();
                }
                else if (BtnSwitch == true)
                {
                    SwitchQuestion();
                    MessageBox.Show("the question has been changed", "Switch question", MessageBoxButtons.OK);
                    BtnSwitch = false;
                }
                else if (Btn5050 == true)
                {
                    B50_50();
                    MessageBox.Show("Tow answers have been deleted", " 50:50", MessageBoxButtons.OK);
                    Btn5050 = false;
                    

                }
                else if (BtnA == true)
                {
                    if (Q.IsCorrect(Answers[0]))
                    {
                        MessageBox.Show("Congratulation,you took a step", "Congratulation", MessageBoxButtons.OK);
                        Level++;
                        BuildQ();
                        laLevel.Text = "Level:" + Level.ToString();
                        LaMoney.Text = "Money:$" + Money[Level].ToString();
                        laCurrent.Text = "Current:$" + Money[Level-1].ToString();
                        LabelTableLighting(Level);
                        BtnA = false;
                    }
                    else
                    {
                        MessageBox.Show("Unfortunately,you lost you will lose all your money");
                        ReBuildAndReStart();
                    }
                }
                else if (BtnB == true)
                {
                    if (Q.IsCorrect(Answers[1]))
                    {
                        MessageBox.Show("Congratulation,you took a step", "Congratulation", MessageBoxButtons.OK);
                        Level++;
                        BuildQ();
                        laLevel.Text ="Level:" +Level.ToString();
                        LaMoney.Text ="Money:$"+ Money[Level].ToString();
                        laCurrent.Text = "Current:$" + Money[Level-1].ToString();
                        LabelTableLighting(Level);
                        BtnB = false;
                    }
                    else
                    {
                        MessageBox.Show("Unfortunately,you lost you will lose all your money");
                        ReBuildAndReStart();
                    }
                }
                else if (BtnC == true)
                {
                    if (Q.IsCorrect(Answers[2]))
                    {
                        MessageBox.Show("Congratulation,you took a step", "Congratulation", MessageBoxButtons.OK);
                        Level++;
                        BuildQ();
                        laLevel.Text = "Level:" + Level.ToString();
                        LaMoney.Text = "Money:$" + Money[Level].ToString();
                        laCurrent.Text = "Current:$" + Money[Level-1].ToString();
                        LabelTableLighting(Level);
                        BtnC = false;
                    }
                    else
                    {
                        MessageBox.Show("Unfortunately,you lost you will lose all your money");
                        ReBuildAndReStart();
                    }
                }
                else if (BtnD == true)
                {
                    if (Q.IsCorrect(Answers[3]))
                    {
                        MessageBox.Show("Congratulation,you took a step", "Congratulation", MessageBoxButtons.OK);
                        Level++;
                        BuildQ();
                        laLevel.Text = "Level:" + Level.ToString();
                        LaMoney.Text = "Money:$" + Money[Level].ToString();
                        laCurrent.Text = "Current:$" + Money[Level-1].ToString();
                        LabelTableLighting(Level);
                        BtnD = false;
                    }
                    else
                    {
                        MessageBox.Show("Unfortunately,you lost you will lose all your money");
                        ReBuildAndReStart();
                        
                    }
                }
            }
        }
        

        private void BStartGame_Click(object sender, EventArgs e)
        {
           

            if(MessageBox.Show("Do you want to start playing ","start playing", MessageBoxButtons.YesNo)== DialogResult.Yes)//DialogResult is enum
            {
                BtnStartGame = true;
                BStartGame.Visible= false;
                Level++;
                BuildQ();
                laLevel.Text = "Level:" + Level.ToString();
                LaMoney.Text = "Money:$" + Money[Level].ToString();
                laCurrent.Text = "Current:$" + Money[Level-1].ToString();
                LabelTableLighting(Level);
                GamePlay();
            }
            
           
        }
        private void BAnswerA_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to install the option", "install the option", MessageBoxButtons.YesNo) == DialogResult.Yes) && (BtnStartGame == true))
            {


                BtnA = true;

                GamePlay();
            }
            else if (BtnStartGame == false)
            {
                MessageBox.Show("Watch out,press start playing first", "Watch out");
            }
            

        }
        private void BAnswerB_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to install the option", "install the option", MessageBoxButtons.YesNo) == DialogResult.Yes) && (BtnStartGame == true))
            {
                BtnB = true;
                GamePlay();
            }
            else if (BtnStartGame == false)
            {
                MessageBox.Show("Watch out,press start playing first", "Watch out");
            }
           
        }
        private void BAnswerC_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to install the option", "install the option", MessageBoxButtons.YesNo) == DialogResult.Yes) && (BtnStartGame == true))
            {

                BtnC = true;

                GamePlay();
            }
            else if (BtnStartGame == false)
            {
                MessageBox.Show("Watch out,press start playing first", "Watch out");
            }
        }
        private void BAnswerD_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to install the option", "install the option", MessageBoxButtons.YesNo) == DialogResult.Yes) && (BtnStartGame == true))
            {


                BtnD = true;

                GamePlay();
            }
            else if (BtnStartGame == false)
            {
                MessageBox.Show("Watch out,press start playing first", "Watch out");
            }
        }
        private void BSwitch_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to change the question", "switch question", MessageBoxButtons.YesNo) == DialogResult.Yes) && (BtnStartGame == true))
            {
                BtnSwitch = true;
                BSwitchQuestion.Visible = false;
                GamePlay();

            }
            else if (BtnStartGame == false)
            {
                MessageBox.Show("Watch out,press start playing first", "Watch out");
            }



        }
        private void B5050_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to delete two answers", "50:50", MessageBoxButtons.YesNo) == DialogResult.Yes) && (BtnStartGame == true))
            {
                Btn5050 = true;
                B5050.Visible = false;
                GamePlay();
        
            }
            else if (BtnStartGame == false)
            {
                MessageBox.Show("Watch out,press start playing first", "Watch out");
            }
        }
        private void BWithdraw_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to finish knowing that you will keep the amount", "Withdraw", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && (BtnStartGame==true))
            {

                BtnWithDraw = true;
                GamePlay();
            }
            else if (BtnStartGame == false)
            {
                MessageBox.Show("Watch out,press start playing first", "Watch out");
            }


        }
    }
}
