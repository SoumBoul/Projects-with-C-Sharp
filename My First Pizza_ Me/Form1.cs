using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_PIZZA_Project
{
    public partial class frmForm1 : Form
    {
        public frmForm1()
        {
            InitializeComponent();
        }


        private void rdSmall_MouseDown(object sender, MouseEventArgs e)
        {
            int prise = 20;
            txtSize.Text = rdSmall.Text;
            txtPrise.Text = prise.ToString();
        }

        private void rdMedium_MouseDown(object sender, MouseEventArgs e)
        {
            int prise = 30;
            txtSize.Text = rdMedium.Text;
            txtPrise.Text =prise.ToString();
        }

        private void rdLarge_MouseDown(object sender, MouseEventArgs e)
        {
            int prise = 40;
            txtSize.Text = rdLarge.Text;
            txtPrise.Text = prise.ToString();
        }

        private void rdThinCrust_MouseDown(object sender, MouseEventArgs e)
        {
            int prise = 50;
            txtCrustType.Text = rdThinCrust.Text;
            txtPrise.Text = prise.ToString();

           
        }

        private void rdThickCrust_MouseDown(object sender, MouseEventArgs e)
        {
            int prise = 60;
            txtCrustType.Text = rdThickCrust.Text;
            txtPrise.Text = prise.ToString();
        }

        private void rdEatIn_MouseDown(object sender, MouseEventArgs e)
        {
            txtWhereToEat.Text = rdEatIn.Text;

        }

        private void rdTakeOut_MouseDown(object sender, MouseEventArgs e)
        {
            txtWhereToEat.Text = rdTakeOut.Text;

        }

       
        private void checkPrise()
        {

            
            if (rdSmall.Checked)
            {
                int prise = 20;
                if (chkExtraChees.Checked )
                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();
                }  
      
                 if(chkMushrooms.Checked )
                { 
                    prise += 5;
                    txtPrise.Text = prise.ToString();
                 
                }


                 if(chkTomatoes.Checked)
                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();
                }

                 if(chkOlives.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }
                      if(chkOnion.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }    
                    if(chkGreenPeppers.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }


                else
                {
                    prise -= 5;
                }

            }

            if (rdMedium.Checked)
            {
                int prise = 30;
                if (chkExtraChees.Checked)
                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();
                }


                if (chkMushrooms.Checked)
                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }


                if (chkTomatoes.Checked || rdSmall.Checked== false)
                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();
                }

                if (chkOlives.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }
                if (chkOnion.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }
                if (chkGreenPeppers.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }


                else
                {
                    prise -= 5;
                }

            }

            if (rdLarge.Checked )
            {
                int prise = 40;
                if (chkExtraChees.Checked)
                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();
                }


                if (chkMushrooms.Checked)
                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }


                if (chkTomatoes.Checked)
                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();
                }

                if (chkOlives.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }
                if (chkOnion.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }
                if (chkGreenPeppers.Checked)

                {
                    prise += 5;
                    txtPrise.Text = prise.ToString();

                }


                else
                {
                    prise -= 5;
                }

            }







        }

        private void GroupBox()
        {
            txtToppings.Text = " ";

            if(grToppings.Created)
           {
                
            if (chkExtraChees.Checked)
            {
                txtToppings.Text += chkExtraChees.Text + ", ";
                    checkPrise();
            }

           if (chkMushrooms.Checked)
            {
                txtToppings.Text += chkMushrooms.Text+" ,";
                    checkPrise();
            }

            if(chkTomatoes.Checked)
            {
                txtToppings.Text += chkTomatoes.Text +",";

                    checkPrise();
            }

            if (chkOnion.Checked)
            {
                txtToppings.Text += chkOnion.Text + ",";
                    checkPrise();
            }

            if (chkOlives.Checked)
            {
                
                txtToppings.Text += chkOlives.Text + "," ;
                    checkPrise();
            }

            if (chkGreenPeppers.Checked)
               
            {
                    txtToppings.Text += chkGreenPeppers.Text;
                    checkPrise();
            }


            }

            else
            {

                txtToppings.Text = txtToppings.Text;
            }
        }


        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox();
        }

       

        private void btResetForm_Click(object sender, EventArgs e)
        {
            grSize.Enabled = true;
            grType.Enabled = true;
            grPlaceToEat.Enabled = true;

            chkExtraChees.Enabled = true;
            chkMushrooms.Enabled = true;
            chkGreenPeppers.Enabled = true;
            chkOlives.Enabled = true;
            chkOnion.Enabled = true;
            chkTomatoes.Enabled = true;
        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("Confirm Order", " Cofirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK )
            {

                MessageBox.Show("Order Placed Successfully", " Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);


                grSize.Enabled = false;
                grType.Enabled = false;
                grPlaceToEat.Enabled = false;
                btOrderPizza.Enabled = false;

                chkExtraChees.Enabled = false;
                chkMushrooms.Enabled = false;
                chkGreenPeppers.Enabled = false;
                chkOlives.Enabled = false;
                chkOnion.Enabled = false;
                chkTomatoes.Enabled = false;


            }

            else 
            {

            }
        }
    }
}