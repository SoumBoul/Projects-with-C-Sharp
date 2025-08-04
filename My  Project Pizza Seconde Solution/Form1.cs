using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Pizza_num2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrise();


            txtSize.Text = rbSmall.Text;
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrise();
            txtSize.Text = rbMedium.Text;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrise();
            txtSize.Text = rbLarge.Text;
        }

        float GetPriseSize()
        {
            float size = 0;
            if (rbSmall.Checked)
            {
                size = Convert.ToSingle(rbSmall.Tag);
                 
            }

            else if (rbMedium.Checked)
            {
                 return size =   Convert.ToSingle(rbMedium.Tag);
            }

           else 

             { 
                return size = Convert.ToSingle(rbLarge.Tag); 
            }


            return size;


        }


        float  GetPriszToppings()
        {
           

            float size = 0;
            if (chkExtraSheese.Checked)
            {
              size+=Convert.ToSingle(chkExtraSheese.Tag); 

            }
            if (chkMushrooms.Checked)
            {
                 size += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkTomatoes.Checked)
            {
                 size += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkOnion.Checked)
            {
                size += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkOlives.Checked)
            {
                 size += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                 size += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return size;

        }


        float getPriseCrustType()
        {
            
           
            if (rbThinCrust.Checked)
            {
             return Convert.ToSingle(rbThinCrust.Tag);
            }

            else

              { 
               return  Convert.ToSingle(rbThinkCrust.Tag); 
            }

            
        }

        float CalculateAllPrise()
        {
          return    GetPriseSize() + GetPriszToppings() + getPriseCrustType();
        }

        void GetToppings()
        {


            UpdatePrise();
            if (chkExtraSheese.Checked)
            {
                lbToppings.Text = chkExtraSheese.Text;

            }
            if(chkMushrooms.Checked)
            {
                lbToppings.Text +="," +chkMushrooms.Text;
            }
            if (chkTomatoes.Checked)
            {
                lbToppings.Text +="," + chkTomatoes.Text;
            }

            if (chkOnion.Checked)
            {
                lbToppings.Text += ","+ chkOnion.Text;
            }

            if (chkOlives.Checked)
            {
                lbToppings.Text += "," +chkOlives.Text;
            }

            if (chkGreenPeppers.Checked)
            {
                lbToppings.Text +="," + chkGreenPeppers.Text;
            }


        }

        void UpdatePrise()
        {
            txtPrise.Text = "$" + CalculateAllPrise().ToString();
        }

        private void chkExtraSheese_CheckedChanged(object sender, EventArgs e)
        {
            GetToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            GetToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            GetToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            GetToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            GetToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            GetToppings();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = rbThinCrust.Text;
            UpdatePrise();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = rbThinkCrust.Text;
            UpdatePrise();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereToEat.Text = rbEatIn.Text;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereToEat.Text = rbTakeOut.Text;
        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure do you want to conFirm", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
            {
                MessageBox.Show(" your Message Updated Successffuly","confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            grSize.Enabled = false;
            grToppings.Enabled = false;
            grCrustType.Enabled = false;
            grWhereToEat.Enabled = false;

           

        }

        private void btResetForm_Click(object sender, EventArgs e)
        {
            grSize.Enabled = true;
            grToppings.Enabled = true;
            grCrustType.Enabled = true;
            grWhereToEat.Enabled = true;

        }
    }
}
