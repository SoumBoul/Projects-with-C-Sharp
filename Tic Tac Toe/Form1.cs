using System;
using System.Windows.Forms;
using TIC_TAC.TOE_2eme_solution.Properties;

using Guna.UI2.WinForms;
using System.Drawing;


namespace TIC_TAC.TOE_2eme_solution
{
    public partial class Form1 : Form
    {

        public enum enPlayer { Player1, Player2 };
        enPlayer player;

        public enum enWinner { Player1, Player2, Draw, InProgress }
        

        int count = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }


        bool WinnerResult(Guna2Button btn1, Guna2Button btn2, Guna2Button btn3)
        {

           
            if (btn1.Tag.ToString() != "?" && btn1.Tag == btn2.Tag && btn1.Tag == btn3.Tag)
            {

               
                btn1.FillColor = Color.GreenYellow;
                btn2.FillColor = Color.GreenYellow;
                btn3.FillColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                   
                    txtWinner.Text = "Player1";
                    return true;
                }



              
                 if (btn1.Tag.ToString() == "O")
                 { 
                   

                    txtWinner.Text = "Player2";
                    return true;

                 }


              
               


            }

            return false;

        }


        void ResultatFinal()
        {
            if (WinnerResult(btn1, btn2, btn3))
                return;

            if (WinnerResult(btn4, btn5, btn6))
                return;

            if (WinnerResult(btn7, btn8, btn9))
                return;

            if (WinnerResult(btn1, btn4, btn7))
                return;

            if (WinnerResult(btn2, btn5, btn8))
                return;

            if (WinnerResult(btn3, btn6, btn9))
                return;
            if (WinnerResult(btn1, btn5, btn9))
                return;
            if (WinnerResult(btn3,btn2, btn1))
                return;
            if (WinnerResult(btn7, btn5, btn3))
                return;






        }

        void ChangeImage(Guna2Button btn)
        {

            if(btn.Tag.ToString()== "?")
            {
               switch(player)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        player = enPlayer.Player2;
                        txtTurn.Text = "Player2";
                        btn.Tag = "X";
                        count++;

                        ResultatFinal();
                        break;

                    case enPlayer.Player2:

                        btn.Image = Resources.O;
                        player = enPlayer.Player1;
                        txtTurn.Text = "Player1";
                        btn.Tag = "O";
                        count++;

                        ResultatFinal();

                        break;




                }



            }


            if(count== 9)
            {
                MessageBox.Show("Game Over");

            }



        }


        private void btn_clik(object sender, EventArgs e)
        {

            ChangeImage((Guna2Button)sender);
        }

        private void btRestartGame_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is Guna2Button button )
                {

                    button.Image = Resources.question_mark_96;
                    btRestartGame.Image = null;
                    button.FillColor = Color.Black;
                    button.Tag = "?";

                }

            }

            enPlayer player = enPlayer.Player1;
            txtTurn.Text = "Player1";
            

        }
    }
}
