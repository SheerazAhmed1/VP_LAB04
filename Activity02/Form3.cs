using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity02
{
   
    public partial class Form3 : Form
    {
       public static int[,] arrayform2d = new int[3, 3];
        public static int[,] arrayresult2d = new int[3, 3];
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            arrayform2d[0, 0] = Convert.ToInt32(textBox1.Text);
            arrayform2d[0, 1] = Convert.ToInt32(textBox2.Text);
            arrayform2d[0, 2] = Convert.ToInt32(textBox3.Text);
            arrayform2d[1, 0] = Convert.ToInt32(textBox4.Text);
            arrayform2d[1, 1] = Convert.ToInt32(textBox5.Text);
            arrayform2d[1, 2] = Convert.ToInt32(textBox6.Text);
            arrayform2d[2, 0] = Convert.ToInt32(textBox7.Text);
            arrayform2d[2, 1] = Convert.ToInt32(textBox8.Text);
            arrayform2d[2, 2] = Convert.ToInt32(textBox9.Text);


            for(int i = 0; i < arrayform2d.GetLength(0); i++)
            {
                for(int j = 0; j < arrayform2d.GetLength(1); j++)
                {
                   for(int k = 0; k < arrayresult2d.GetLength(0); k++)
                    {
                        arrayresult2d[i, j] += Form1.array2d[i, k] * arrayform2d[k, j];
                    }
                }
            }

        }
    }
}
