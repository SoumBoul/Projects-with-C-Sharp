using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Encrypting_Descrepting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


       
        void Encryption(string Text, int key )
        {

            for (int i = 0; i <Text.Length; i++)
            {
                char c = Text[i] ;

                c = (char)(c +i + key);


                txtEncrypting.Text += c;

                


            }


        }


        void Decryption(string Text, int key)
        {

            for (int i = 0; i < Text.Length; i++)
            {
                char c = Text[i];

                c = (char)(c -i   - key);


                txtDecrypting.Text += c;




            }


        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

           

           



        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

           
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Decryption(txtEncrypting.Text, 2);
            txtEncrypting1.Clear();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            txtDecrypting.Clear();
            txtDecrypting1.Clear();
            txtEncrypting.Clear();


            Encryption(txtEncrypting1.Text, 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEncrypting1.Focus();

        }
    }
}
