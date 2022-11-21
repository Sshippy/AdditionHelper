using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExtraDiscussionCode
{
    public partial class txtSecond : Form
    {
        public txtSecond()
        {
            InitializeComponent();
        }

        private void txtSecond_Load(object sender, EventArgs e)
        {

        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSecond_Click(object sender, EventArgs e)
        {

        }

        private void txt2nd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirst.Text);
            b = Convert.ToInt32(txt2nd.Text);
            c = a + b;
            txtResult.Text = c.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
