namespace Activity02
{
    public partial class Form1 : Form
    {
        public static int[,] array2d = new int[3,3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            array2d[0, 0] = Convert.ToInt32(textBox1.Text);
            array2d[0, 1] = Convert.ToInt32(textBox2.Text);
            array2d[0, 2] = Convert.ToInt32(textBox3.Text);
            array2d[1, 0] = Convert.ToInt32(textBox4.Text);
            array2d[1, 1] = Convert.ToInt32(textBox5.Text);
            array2d[1, 2] = Convert.ToInt32(textBox6.Text);
            array2d[2, 0] = Convert.ToInt32(textBox7.Text);
            array2d[2, 1] = Convert.ToInt32(textBox8.Text);
            array2d[2, 2] = Convert.ToInt32(textBox9.Text);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj=new Form2();
            obj.ShowDialog();
            
        }
    }
}