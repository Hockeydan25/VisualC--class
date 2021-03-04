using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int pennies = 0;   //varibles are setup here for zero value for scope use.
        int nickles = 0;   //varibles are setup here for zero value for scope use.
        int dimes = 0;    //varibles are setup here for zero value for scope use.
        int quarters = 0; //varibles are setup here for zero value for scope use.

        private void btnCalculate_Click(object sender, EventArgs e) //button click/enter starts calculations.
        {
            int rchange = Convert.ToInt16(txtboxAC.Text); //converting string number to decimal 

            quarters = rchange / 25; //division = into quarters, remainder moves on to nxt calculation 
                rchange = rchange % 25; //remainder divisible 25 not moves on   
            dimes = rchange / 10;       //division equation = into dimes,calculation 
                rchange = rchange % 10; //remainder divisible 10 not moves on  
            nickles = rchange / 5;      //division equation = into nickles,calculation 
                rchange = rchange % 5;  //remainder divisible 5 not moves on  
            pennies = rchange / 1; //division equation = into pennies,calculation should at 0 nxt.
                rchange = rchange % 1;  //remainder divisible 0 equations completed 

            txtboxQ.Text = quarters.ToString(""); //converting intger to string "n" for number.
            txtboxD.Text = dimes.ToString("");   //converting intger to string "n" for number.
            txtboxN.Text = nickles.ToString(""); //converting intger to string "n" for number.
            txtboxP.Text = pennies.ToString(""); //converting intger to string "n" for number.
           
        }
        private void btnExit_Click(object sender, EventArgs e) //button for exit or ESC exits program
        {
            this.Close();                                       //close statement close focus ends.
        }
    }
}
