using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity01
{
    public partial class frmMatrix3 : Form
    {
        public frmMatrix3()
        {
            InitializeComponent();
        }

        private void frmMatrix3_Load(object sender, EventArgs e)
        {
            label1.Text = frmMatrix2.result[0].ToString();
            label2.Text = frmMatrix2.result[1].ToString();
            label3.Text = frmMatrix2.result[2].ToString();
            label4.Text = frmMatrix2.result[3].ToString();
            label5.Text = frmMatrix2.result[4].ToString();
            label6.Text = frmMatrix2.result[5].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
