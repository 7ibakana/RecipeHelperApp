using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeHelperApp
{
    public partial class Form1 : Form
    {       
        decimal fahrenheight = 0; //Declaring the decimal class variable type for fahrenheight and initializing it to 0
        double cups = 0; //Declaring the double class variable type for and cups and initializing it to 0

        public Form1()
        {
            InitializeComponent();
        }

        private void CelText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CtoFbtn_Click(object sender, EventArgs e)
        {
            bool celsiusValid = decimal.TryParse(txtCel.Text, out decimal cel); //inline variable creation
            if (celsiusValid) //check if variable is valid
            {
                decimal celsius = decimal.Parse(txtCel.Text); //converts the txtCel input into a decimal
                fahrenheight = (celsius * 9) / 5 + 32; //fahrenheight is equal to the celsius amount multiplied by 9 and then divded by 5 added to 32
                string fahrenheightString = fahrenheight.ToString(); //fahrenheight converted to a string
                txtFah.Text = fahrenheight.ToString("f2"); //txt.fah input is equal to the fahrenheight string
                txtFah.Focus(); //focus is set to txtFah where output is presented
            }
            else //otherwise present below BessageBox with the error message
            {
                MessageBox.Show("Please enter a valid number", "Error");
            }
        }

        private void mtocupsbtn_Click(object sender, EventArgs e)
        {
            bool milliletersValid = double.TryParse(txtMil.Text, out double mil); //inline variable creation
            if (milliletersValid) //check if variable is valid
            {
                double millileters = double.Parse(txtMil.Text); //converts the txtMil into a double
                cups = millileters * .004227; //cups is equal to millileters * .004227
                string cupsString = cups.ToString(); //cups converted to a string and output formated to 2 decimal points
                txtCup.Text = cups.ToString("f2"); //txtCup input is equal to cups string with the format set to 2 decimal points
                txtCup.Focus(); //focus is set to txtCup where output is presented
            }
            else //otherwise present the below MessageBox with the error message
            {
                MessageBox.Show("Please enter a valid number", "Error");
            }

        }
    }
}
