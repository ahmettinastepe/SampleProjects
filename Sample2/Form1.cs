using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sample2
{
    public partial class Form1 : Form
    {
        #region Variables

        int due = 4;
        Random random;
        List<int> randomList;

        #endregion

        public Form1()
        {
            InitializeComponent();
            InitialGame();
        }

        void InitialGame()
        {
            NewGame();
            ChangeControls();
        }

        void ChangeControls()
        {
            BtnOne.Text = "0";
            BtnTwo.Text = "0";
            BtnThree.Text = "0";
            BtnFour.Text = "0";
            LblOne.Visible = false;
            LblTwo.Visible = false;
            BtnNewGame.Enabled = true;
            LblDue.Text = due.ToString();
            due = 4;
        }

        void NewGame()
        {
            randomList = new List<int>();
            random = new Random();
        }

        void ShowImpacts(int first,int two)
        {
            LblOne.Visible = true;
            LblTwo.Visible = true;
            LblOne.Text = $"({first.ToString()})";
            LblTwo.Text = $"({two.ToString()})";
        }

        void CreateNumbers()
        {
            for (int i = 0; i < 4; i++)
            {
                int result = random.Next(2, 10);
                randomList.Add(result);
            }
        }

        void InitialButtons()
        {
            BtnOne.Text = randomList[0].ToString();
            BtnTwo.Text = randomList[1].ToString();
            BtnThree.Text = randomList[2].ToString();
            BtnFour.Text = randomList[3].ToString();
        }

        bool Control()
        {
            if (due == 1)
            {
                MessageBox.Show("Kaybettiniz");
                BtnPlay.Enabled = false;
                return false;
            }

            int firstImpact = Convert.ToInt32(BtnOne.Text) * Convert.ToInt32(BtnTwo.Text);
            int secondImpact = Convert.ToInt32(BtnThree.Text) * Convert.ToInt32(BtnFour.Text);
            ShowImpacts(firstImpact, secondImpact);

            if (firstImpact < secondImpact)
            {
                MessageBox.Show("Kazandınız");
                BtnPlay.Enabled = false;
                InitialGame();
                return false;
            }
            else
            {
                due--;
                LblDue.Text = due.ToString();
                NewGame();
                return true;
            }
        }

        void Play()
        {
            CreateNumbers();
            InitialButtons();

            if (!Control())
                InitialGame();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            InitialGame();
            BtnPlay.Enabled = true;
            BtnNewGame.Enabled = false;
        }
    }
}