using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_1_ex_1
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
            foreach (var item in inputElements)
            {
                if (item == '(')
                    result++;
                else if (item == ')')
                    result--;
            }
            tbResult.Text = result.ToString();
        }
    }
}
