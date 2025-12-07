using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string login = "1234";
        string password = "1";

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pas = textBox2.Text;
    
            if (log == login && pas == password)
            {
                Form2 newForm = new Form2();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не правильно введен логин или пароль!", "Внимание!");
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
