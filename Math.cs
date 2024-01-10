using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionPracticeV2
{
    public partial class Math : Form
    {

        private readonly Random single1 = new Random(DateTime.Now.Millisecond);
        private readonly Random single2 = new Random(DateTime.Now.Second);


        private readonly Random doub1e1 = new Random(DateTime.Now.Millisecond);
        private readonly Random double2 = new Random(DateTime.Now.Second);

        private readonly Random triple1 = new Random(DateTime.Now.Millisecond);
        private readonly Random triple2 = new Random(DateTime.Now.Second);

        int answer;
        int input;
        
        int correctAnswers = 0;
        public bool isCorrect = false;
        public bool single = false;
        public bool dbl = false;
        public bool trpl = false;

        private void singleProblem()
        {          
            correctAnswersLbl.Visible = true;
            correctAnswersTB.Visible = true;
            switchBtn1.Visible = false;
            single = true;
            int first = single1.Next(0, 10);
            int second = single2.Next(0, 10);
            answer = first + second;
            problemTB.Text = "what is " + first + " + " + second + " ?";

            RemainConstant();
        }
        private void doubleProblem()
        {
            correctAnswersLbl.Visible = true;
            correctAnswersTB.Visible = true;
            switchBtn2.Visible = false;
            dbl = true;
            int first = doub1e1.Next(10, 100);
            int second = double2.Next(10, 100);
            answer = first + second;

            problemTB.Text = "what is " + first + " + " + second + " ?";

            RemainConstant();
        }

        private void tripleProblem()
        {
            correctAnswersLbl.Visible = true;
            correctAnswersTB.Visible = true;
            switchBtn3.Visible = false;
            trpl = true;
            int first = triple1.Next(100, 1000);
            int second = triple2.Next(100, 1000);
            answer = first + second;

            problemTB.Text = "what is " + first + " + " + second + " ?";

            RemainConstant();
        }

        public Math(Form1 form1)
        {
            InitializeComponent();
           
            {
                if (form1.isSingle == true)
                {
                    
                    typeOfAdditionTB.Text = "single digit addition";
                    singleProblem();


                }
                else if (form1.isDouble == true)
                {
                    
                    typeOfAdditionTB.Text = "double digit addition";
                    doubleProblem();

                }
                else if (form1.isTriple == true)
                {
                    
                    typeOfAdditionTB.Text = "triple digit addition";
                    tripleProblem();
                }
            }
        }

        private void RemainConstant()
        {
            if (single == true)
            {
                dbl = false;
                trpl = false;
            }
            else if (dbl == true)
            {
                single = false;
                trpl = false;
            }
            else if (trpl  == true)
            {
                dbl = false;
                single = false;
            }
        }
        private void CheckAnswer()
        {
            if (int.TryParse(inputTB.Text, out input))

            {
                submitBtn.Visible = false;
                nextBtn.Visible = true;
                if (input == answer)
                {
                    isCorrect = true;
                    resultTB.Text = "correct";

                    correctAnswers += 1;

                    correctAnswersLbl.Text = "correct answers:";
                    correctAnswersTB.Text = correctAnswers.ToString();
                }
                else
                {
                    isCorrect = false;
                    resultTB.Text = "incorrect, it is " + answer;
                    correctAnswersTB.Text = correctAnswers.ToString();
                }
            }

            else
            {
                MessageBox.Show("enter an integer");
                return;
            }
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            correctAnswersLbl.Visible = true;
            correctAnswersTB.Visible = true;
            CheckAnswer();
        }    


        private void switchBtn1_Click(object sender, EventArgs e)
        {
            single = true;
            dbl = false;
            trpl = false;
            typeOfAdditionTB.Text = "single digit addition";
            singleProblem();
            correctAnswersLbl.Visible = true;
            correctAnswersTB.Visible = true;
            switchBtn2.Visible = true;
            switchBtn3.Visible = true;
            submitBtn.Visible = true;
            nextBtn.Visible = false;
            inputTB.Text = "";

        }

        private void switchBtn2_Click(object sender, EventArgs e)
        {
            dbl = true;
            single = false;
            trpl = false;
            RemainConstant();
            typeOfAdditionTB.Text = "double digit addition";
            doubleProblem();
            correctAnswersLbl.Visible = true;
            correctAnswersTB.Visible = true;
            switchBtn1.Visible = true;
            switchBtn3.Visible = true;
            submitBtn.Visible = true;
            nextBtn.Visible = false;
            inputTB.Text = "";
            resultTB.Text = "";
        }

        private void switchBtn3_Click(object sender, EventArgs e)
        {
            trpl = true;
            single = false;
            dbl = false;
            RemainConstant();
            typeOfAdditionTB.Text = "triple digit addition";
            tripleProblem();
            correctAnswersLbl.Visible = true;
            correctAnswersTB.Visible = true;
            switchBtn1.Visible = true;
            switchBtn2.Visible = true;
            submitBtn.Visible = true;
            nextBtn.Visible = false;
            inputTB.Text = "";
            resultTB.Text = "";
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            RemainConstant();

            submitBtn.Visible = true;
            nextBtn.Visible = false;
            inputTB.Text = "";

            if (single == true)
            {
                singleProblem();
                switchBtn2.Visible = true;
                switchBtn3.Visible = true;
            }
            else if (dbl == true)
            {
                doubleProblem();
                switchBtn1.Visible = true;
                switchBtn3.Visible = true;
            }
            else if (trpl == true)
            {
                tripleProblem();
                switchBtn1.Visible = true;
                switchBtn2.Visible = true;
            }

            resultTB.Text = "";

        }


        private void inputTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                correctAnswersLbl.Visible = true;

                submitBtn.Visible = false;
                nextBtn.Visible = true;

                CheckAnswer();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Close();

        }
    }
}
