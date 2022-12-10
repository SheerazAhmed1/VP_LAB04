namespace Activity01
{
    public partial class frmMatrix1 : Form
    {
        public static int[] form1Data = new int[6];
        frmMatrix2 obj2 = new frmMatrix2();
        public frmMatrix1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1Data[0] = Convert.ToInt32(textBox1.Text);
            form1Data[1] = Convert.ToInt32(textBox2.Text);
            form1Data[2] = Convert.ToInt32(textBox3.Text);
            form1Data[3] = Convert.ToInt32(textBox4.Text);
            form1Data[4] = Convert.ToInt32(textBox5.Text);
            form1Data[5] = Convert.ToInt32(textBox6.Text);







            frmMatrix1 obj=new frmMatrix1();
            obj.Hide();
            
            obj2.ShowDialog();


        }
    }

   

}