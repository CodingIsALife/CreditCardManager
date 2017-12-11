using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _260FinalProject_CardManager
{
    public partial class addNewUser : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Landon\source\repos\260FinalProject_CardManager\260FinalProject_CardManager\CreditCardInfo.mdf;Integrated Security = True; Connect Timeout = 30");

        public addNewUser()
        {
            InitializeComponent();
        }

        private void deleteARowForm_Load(object sender, EventArgs e)
        {
            //Form
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Accept button
            string username = textBox4.Text.ToString();
            string password = textBox5.Text.ToString();

            sql.Open();

            string query = "INSERT INTO [dbo].[Table2] (\"Username\", \"Password\")";
            query += " VALUES (@Val1, @Val2)";

            SqlCommand command = new SqlCommand(query, sql);

            command.Parameters.AddWithValue("@Val1", username);
            command.Parameters.AddWithValue("@Val2", password);

            command.ExecuteNonQuery();

            sql.Close();
            ActiveForm.Close();
            return;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //new username box

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //new password box

        }
    }
}
