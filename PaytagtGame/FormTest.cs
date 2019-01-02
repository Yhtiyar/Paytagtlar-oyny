using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaytagtGame
{
    public partial class FormTest : Form
    {
        string [] questions = new string[10];
        bool[] isused = new bool[10];
        Dictionary<string, string[]> answers=new Dictionary<string, string[]>();
        int level = -1;
        Dictionary<string, int> trueanswer=new Dictionary<string, int>();
        string quest;
        string answer;
        public FormTest()
        {
            InitializeComponent(); FillQuestions(); nextLevel();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
           
        }
        void FillQuestions()
        {
            string[] ans = new string[4];
            questions[0] = "Ýurdumyzyň gury ýer serhediniň umumy uzynlygy näçä deň?";
            ans[0] = "a) 4500 km gowrak.";
            ans[1] = "b) 4700 km gowrak.";
            ans[2] = "c) 4800 km gowrak.";
            ans[3] = "d) 4800 km gowrak.";
            answers[questions[0]] = ans;
            trueanswer[questions[0]] = 0;
            ans = new string[4];
            questions[1] = "Garaşsyzlyk ýyllary içinde jemi näçe sany täze etrap peýda boldy?";
            ans[0] = "a) 9 sany";
            ans[1] = "b) 7 sany ";
            ans[2] = "ç) 5 sany";
            ans[3] = "d) 6 sany";
            answers[questions[1]] = ans;
            trueanswer[questions[1]] = 1;


        }
        void nextLevel()
        {

            level++;
            setQuestion(level);
            
        }
        void setQuestion(int index)
        {
            isused[index] = true;
            quest=questions[index];
            labelSorag.Text = quest;
            answer = answers[quest][trueanswer[quest]];
            btA.Text = answers[quest][0];
            btB.Text = answers[quest][1];
            btC.Text = answers[quest][2];
            btD.Text = answers[quest][3];
        }
        bool isAnswerTrue(string temp)
        {
            return (temp == answer);
        }

        private void btA_Click(object sender, EventArgs e)
        {
            if (isAnswerTrue(btA.Text))
                nextLevel();
                
        }

        private void btB_Click(object sender, EventArgs e)
        {
            if (isAnswerTrue(btB.Text))
                nextLevel();
        }

        private void btC_Click(object sender, EventArgs e)
        {
            if (isAnswerTrue(btC.Text))
                nextLevel();
        }

        private void btD_Click(object sender, EventArgs e)
        {
            if (isAnswerTrue(btD.Text))
                nextLevel();
        }
    }
}
