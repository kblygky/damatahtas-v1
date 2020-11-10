using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace damatahtası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0;
            int left = 0;
            Button[,] buttons = new Button[8,8];
            for (int i = 0; i <buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(0); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height =50;
                    buttons[i, j].Left = left;
                    left += 50;
                    buttons[i, j].Top = top;
                    this.Controls.Add(buttons[i, j]);
                    if ((i + j) % 2 == 0) {
                        buttons[i, j].BackColor = Color.Black;
                        buttons[i, j].ForeColor = Color.White;
                    }
                    else buttons[i, j].BackColor = Color.Orange;
                    buttons[i, j].Text = i + "" + j;


                    buttons[i, j].Click += button_Click;

                }
                left = 0;
                top += 50;
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Text+" tıkladın");
            ((Button)sender).BackColor = Color.Red;
        }
    }
    
}
