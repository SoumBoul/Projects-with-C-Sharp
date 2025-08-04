using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Test_Memory_game_2
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
          
            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {


            ProgressBar.Value = 0;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;

            ProgressBar.Text += ProgressBar.Value.ToString();

            for(int i=0; i<10; i++)
          {  
                if (ProgressBar.Value < ProgressBar.Maximum)
                {
                    Thread.Sleep(500);
                    ProgressBar.Value += 10;
                    ProgressBar.Text =(((float)ProgressBar.Value / ProgressBar.Maximum) * 100)+ "%";
                    ProgressBar.Refresh();
                    ProgressBar.Refresh();


                }

                else
                {
                    
                }
            }

            Form1 frm = new Form1();

            frm.Show();


        }
    }
}
