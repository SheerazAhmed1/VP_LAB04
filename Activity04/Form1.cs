using System.Reflection;

namespace Activity04
{
    public partial class Form1 : Form
    {
        string pathFile = @"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\1.jpg";
        int counter = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button17.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\1.jpg");
            label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = 3)";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\3.jpg");
           

            if(
            button1.Image.ToString()==(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = "+counter+")";
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\6.png");
            if (
           button2.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\1.jpg");
            if (
           button3.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\8.jpg");
            if (
           button4.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\7.jpg");
            if (
           button5.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\2.jpg");
            if (
           button6.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\5.png");
            if (
           button7.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\1.jpg");
            if (
           button8.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\4.jpg");

            if (
           button9.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\6.png");

            if (
           button10.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\7.jpg");

            if (
           button11.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\8.jpg");

            if (
           button12.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\2.jpg");

            if (
           button13.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\5.png");

            if (
           button14.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\1.jpg");

            if (
           button15.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Image = Image.FromFile(@"E:\Computer Science\Extra Semster\VP\Lab\Lab04\Vp_pics\\8.jpg");

            if (
           button16.Image.Equals(pathFile))
            {
                MessageBox.Show("Great");
            }
            else
            {
                counter--;
                label1.Text = "Guess The Picture Three Times From Puzzle\n (Attempts Allowed = " + counter + ")";
            }
        }

        public void checker()
        {
            if(counter == 0)
            {
                MessageBox.Show("You Lost");
            }
        }
    }
}