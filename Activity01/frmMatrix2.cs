using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity01
{
    
    public partial class frmMatrix2 : Form
    {
        public static int[] result = new int[6];
        public frmMatrix2()
        {
            InitializeComponent();
        }

        private void frmMatrix2_Load(object sender, EventArgs e)
        {
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] form2Data = new int[6];
            form2Data[0] = Convert.ToInt32(textBox1.Text);
            form2Data[1] = Convert.ToInt32(textBox2.Text);
            form2Data[2] = Convert.ToInt32(textBox3.Text);
            form2Data[3] = Convert.ToInt32(textBox4.Text);
            form2Data[4] = Convert.ToInt32(textBox5.Text);
            form2Data[5] = Convert.ToInt32(textBox6.Text);


            for (int i = 0; i < form2Data.Length; i++)
            {
                result[i] = frmMatrix1.form1Data[i] + form2Data[i];

            }

            frmMatrix2 obj = new frmMatrix2();
            obj.Hide();

            frmMatrix3 obj3=new frmMatrix3();
            obj3.ShowDialog();

        }
    }
}
