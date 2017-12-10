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
    public partial class AddCardForm : Form
    {
       // private SqlConnection conn = new SqlConnection();
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Landon\source\repos\260FinalProject_CardManager\260FinalProject_CardManager\CreditCardInfo.mdf;Integrated Security = True; Connect Timeout = 30");
        

        public AddCardForm()
        {
            InitializeComponent();
        }


        TheDatabaseSetYourLookingFor addCardFormDatabase = new TheDatabaseSetYourLookingFor();
        TheDatabaseSetYourLookingForTableAdapters.TableTableAdapter addCardFormTableAdapter = new TheDatabaseSetYourLookingForTableAdapters.TableTableAdapter();


        public struct CreditCardVars
        {
            public string cardNumber;
            public string cardCompany;
            public string cardSec;
            public string expDate;
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

        private void AddCardForm_Load_1(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //enter button on the add card userinput form.
            CreditCardVars newCard = new CreditCardVars
            {
                cardCompany = maskedTextBox1.Text,
                cardNumber = maskedTextBox2.Text,
                expDate = maskedTextBox3.Text,
                cardSec = maskedTextBox4.Text
            };
            DateTime dt = Convert.ToDateTime(newCard.expDate);
            addCardFormTableAdapter.Insert(newCard.cardNumber, dt, newCard.cardCompany, newCard.cardSec, "");

            sql.Open();

            string query = "INSERT INTO [dbo].[Table] (\"Card Number\", \"Card Exp\", \"Card Company\", \"Card Security Number\", \"Card Type\" )";
            query += " VALUES (@Val1, @Val2, @Val3, @Val4, '')";

            SqlCommand command = new SqlCommand(query, sql);

            command.Parameters.AddWithValue("@Val1", newCard.cardNumber);
            command.Parameters.AddWithValue("@Val2", dt);
            command.Parameters.AddWithValue("@Val3", newCard.cardCompany);
            command.Parameters.AddWithValue("@Val4", newCard.cardSec);

            

            command.ExecuteNonQuery();

            sql.Close();

            // this.Validate();
            //addCardFormTableAdapter.Update(this.addCardFormDatabase.Table);
            ActiveForm.Close();
            return;
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

            //mask for card company
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //mask for card number

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //mask for card date
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //mask for CVV
        }
    }
}
