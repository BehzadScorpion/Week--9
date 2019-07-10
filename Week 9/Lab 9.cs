using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_9
{
    public partial class CalculatorButtonTableLab9 : Form
    {
        public CalculatorButtonTableLab9()
        {
            InitializeComponent();
        }

      
        private void CalculatorButtonClickEvent(object sender, EventArgs e)
        {
            var TheButton = sender as Button;

            int ButtonValue;
            bool Result = int.TryParse(TheButton.Text, out ButtonValue);

            if (Result)
            {
                resultLable.Text = TheButton.Text;
            }
            else
            {
                resultLable.Text = "Not a Number (NAN)";
            }
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
