using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_2_ex_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<Present> presents = new List<Present>();
            int papersize = 0;
            string line;
            StreamReader sr = new StreamReader(@"..\..\input.txt");
            while ((line = sr.ReadLine()) != null)
            {
                var obj = line.Split(new char[] { 'x' });
                Present pst = new Present();
                pst.width = int.Parse(obj[0].ToString());
                pst.depth = int.Parse(obj[1].ToString());
                pst.height = int.Parse(obj[2].ToString());
                pst.smallestSideSize = pst.width * pst.depth;
                if (pst.width * pst.height < pst.smallestSideSize)
                    pst.smallestSideSize = pst.width * pst.height;
                if (pst.depth * pst.height < pst.smallestSideSize)
                    pst.smallestSideSize = pst.depth * pst.height;
                presents.Add(pst);
            }

            foreach (var item in presents)
            {
                papersize = papersize + (2 * item.width * item.depth) + (2 * item.width * item.height) + (2 * item.depth * item.height) + item.smallestSideSize;
            }
            tbResult.Text = papersize.ToString();
        }
    }
}
