using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _260FinalProject_CardManager
{

    public partial class Authentication : Form
    {
        /*
        Operation: 
            When this form is called, it first checks if there is a user, 
            and then if there is, continues to let the user to log in 
            to the application. If there is not, the addition of a user is
            called and the user can add name and password.
             
        */

        public bool userDeletedData = false;
        public bool authenticated = false;
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Landon\source\repos\260FinalProject_CardManager\260FinalProject_CardManager\CreditCardInfo.mdf;Integrated Security = True; Connect Timeout = 30");

        public Authentication()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //username box
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete user database

            string usernameVal = "NULL";

            sql.Open();
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Table2] WHERE \"Username\"!=@val1", sql);

            command.Parameters.AddWithValue("@val1", usernameVal);
            command.ExecuteNonQuery();
            userDeletedData = true;
            sql.Close();

            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //authenticate


            while ( authenticated == false)
            { 
                string username = textBox3.Text.ToString();
                string password = textBox4.Text.ToString();

                sql.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Table2] WHERE Username like @val1 AND Password like @val2", sql);

                command.Parameters.AddWithValue("@val1", username);
                command.Parameters.AddWithValue("@val2", password);
                int userCount = (int)command.ExecuteScalar();
                sql.Close();
                if (userCount > 0)
                {
                    authenticated = true;
                    ActiveForm.Close();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //password box
        }
    }
}
