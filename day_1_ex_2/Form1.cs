using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_1_ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var inputElements = tbInput.Text.ToCharArray();
            int result = 0;
            int floor = 0;
            foreach (var item in inputElements)
            {
                result++;
                if (item == '(')
                    floor++;
                else if (item == ')')
                    floor--;
                if(floor == -1)
                {
                    break;
                }
            }
            tbResult.Text = result.ToString();
        }
    }
}
