using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Test_Memory_game_2
{
    public partial class Form1 : Form
    {

        List<Color> colors;
        Button FirstButtton;
        Button SecondButton;
        int win = 0;
        int timeElapsed = 0;
        int counter = 00;

        System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
       

        public Form1()
        {
            InitializeComponent();
            IntitialisationColors();
            ChangeColors();
        }



       
       void IntitialisationColors()
        {

            colors = new List<Color>()
            {
          Color.Red, Color.Red,Color.Black,Color.Black,
          Color.Fuchsia, Color.Fuchsia,Color.Green,Color.Green,
          Color.Blue, Color.Blue,Color.Yellow,Color.Yellow,
          Color.Cyan, Color.Cyan,Color.YellowGreen,Color.YellowGreen,

            };


           
        }

        void ChangeColors()
        {
            Random random = new Random();

            foreach(Button btn in Controls.OfType<Button>())
            {
                int index= random.Next(colors.Count);
                btn.BackColor = colors[index];
                btn.Tag = colors[index];
                btn.BackColor = Color.White;
                colors.RemoveAt(index);
            }


        }

        
        
        private void btn_Click(object sender, EventArgs e)
        {
            Button SelectButton = (Button)sender;

            timer1.Start();




            if (FirstButtton == null)
                {
                    FirstButtton = SelectButton;
                    FirstButtton.BackColor = (Color)(FirstButtton.Tag);


                }
                else if (SecondButton == null && SelectButton != FirstButtton)
                {
                
                SecondButton = SelectButton;
                SecondButton.BackColor = (Color)(SecondButton.Tag);
               

                if ((Color)FirstButtton.Tag == (Color)SecondButton.Tag)
                    {
                        win++;
                          FirstButtton.Visible = true;
                          SecondButton.Visible = true;

                          txtWin.Text = win.ToString(); 
                     
                          resetButton();
                         
                    }

                    else
                    {
                        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                        timer.Interval = 400;
                        timer.Tick += (s, ev) =>

                        {
                            FirstButtton.BackColor = Color.White;
                            SecondButton.BackColor = Color.White;
                           
                            resetButton();
                            timer.Stop();
                            timer.Dispose();

                        };

                        timer.Start();
                    }

                
              
            }

          void resetButton()
        {
            FirstButtton = null;
            SecondButton = null;
        }



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Close();
           
           
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            

            txtTimer.Text = $"{counter}:{timeElapsed}";
            if (timeElapsed == 100)
            {
                
                txtTimer.Text = $"{counter++}:{timeElapsed}";
                timeElapsed = 0;

                if(counter == 3)
                {
                    timer1.Stop();
                    txtTimer.Text= $"{counter}:00";

                    MessageBox.Show("Sorry you failed :(");
                   
                }

                
                   
                }
            }



        private void txtWin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
