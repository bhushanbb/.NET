using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleWinApp.Models;
namespace SampleWinApp
{
    public partial class frmCalcForm : Form
    {
        public frmCalcForm()
        {
            InitializeComponent();
        }
        //When U double-click a control, it generates an event handling code for the default event of that control...
        private void button1_Click(object sender, EventArgs e)
        {
            //get the value for 1st and the second along with the operator...
            double firstValue = double.Parse(txtFirstValue.Text);
            double secondValue = double.Parse(txtSecondValue.Text);
            string @operator = cmbOperator.Text;
            //compute the result using c# operators
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = MathComponent.AddFunc(firstValue, secondValue);
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "X":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    if(secondValue == 0)
                    {
                        MessageBox.Show("Denominator cannot be 0");
                        return;
                    }
                    result = firstValue - secondValue;
                    break;
                    
            }
            //Set the result to the label that we have created....
            lblDisplay.Text = result.ToString();
        }

        private void frmCalcForm_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstValue_Validating(object sender, CancelEventArgs e)
        {
            double res;
            if(!double.TryParse(txtFirstValue.Text, out res))
            {
                MessageBox.Show("Invalid");
                txtFirstValue.Text = string.Empty;
                e.Cancel = true;
            }
        }

        private void txtFirstValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
