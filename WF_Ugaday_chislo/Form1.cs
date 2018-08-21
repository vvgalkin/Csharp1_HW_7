using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Ugaday_chislo
{
    public partial class Form1 : Form
    {
        UgadayChislo ugchislo = new UgadayChislo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            UpdateFormOutputUgaday_Chislo(tbUserVar.Text);
        }

        private void UpdateFormOutputUgaday_Chislo(string inputText)
        {
            int result = -1;
            if (int.TryParse(inputText, out result))
            {
                if (result <= 0 || result > 100)
                {
                    lblTip.Text = "Число от 1 до 100";
                    return;
                }

                if (ugchislo.IsCorrect(result))
                {
                    lblTip.Text = "Победа!";
                    MessageBox.Show($"Попыток: {ugchislo.Count}", "Число угадано", MessageBoxButtons.OK);
                    GameOverGuessNumber();
                }
                else if (ugchislo.IsHigher(result))
                {
                    lblTip.Text = "Меньше!";
                }
                else
                {
                    lblTip.Text = "Больше!";
                }
            }
            else
            {
                lblTip.Text = "Ошибка! Введите число!";
            }
        }

        private void GameOverGuessNumber()
        {
            btbCheck.Enabled = false;
        }
        private void GameRenewGuessNumber()
        {
            ugchislo = new UgadayChislo();
            btbCheck.Enabled = true;
            tbUserVar.Text = null;
        }

        private void btbNewGame_Click(object sender, EventArgs e)
        {
            GameRenewGuessNumber();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
