namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         void button1_Click(object sender, EventArgs e)
        {
            string ka = textBox1.Text;
            string pw = textBox2.Text;

            if (ka == "admin1")
            {
                if(pw == "admin1password")
                {
                    Form2 form2= new Form2();
                    form2.ShowDialog();

                }

                else {
                   Form3 form3= new Form3();   
                   form3.ShowDialog();
                
                }

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}