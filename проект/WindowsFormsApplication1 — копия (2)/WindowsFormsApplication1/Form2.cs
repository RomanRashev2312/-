using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form3 newForm = new Form3();
                newForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO, Phone, Discount, ID;
            ID = textBox1.Text;
            FIO = textBox2.Text;
            Phone = textBox3.Text;
            Discount = textBox4.Text;
            
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\BASA.accdb";
    
            OleDbConnection dbConnection = new OleDbConnection(connectionString);


            dbConnection.Open();
            string query = "INSERT INTO Clients VALUES ( '" + ID +"', '" + FIO + "','" + Phone + "', '" + Discount + "')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса", "Внимание!");
            else
                MessageBox.Show("Данные добавлены", "Внимание!");
            dbConnection.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }

    }
    

