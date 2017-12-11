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
    public partial class Form1 : Form
    {
        
        public int numCards = 1;
        SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Landon\source\repos\260FinalProject_CardManager\260FinalProject_CardManager\CreditCardInfo.mdf;Integrated Security = True; Connect Timeout = 30");



        public Form1()
        {
            InitializeComponent();
        }

        private void CardFlowPanel(object sender, PaintEventArgs e)
        {

        }


        private void AddCard(object sender, EventArgs e)
        {

            //Application.Run(new AddCardForm());
            AddCardForm form2 = new AddCardForm();
            DialogResult dr = form2.ShowDialog(this);
            form2.Close();

            //add card
            //needs to create a card inside of the cardflowpanel when clicked.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void loadDataGrid()
        {
            // TODO: This line of code loads data into the 'theDatabaseSetYourLookingFor.Table' table. You can move, or remove it, as needed.

            this.tableTableAdapter1.Fill(this.theDatabaseSetYourLookingFor.Table);
            int i = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                ++i;
                r.Cells["rowNumber"].Value = i;
                Bitmap logo;

                //choosing the card icon
                if (r.Cells["cardNumber"].Value == null)
                {
                    break;
                }

                if (r.Cells["cardNumber"].Value.ToString().StartsWith("4"))
                {
                    logo = Properties.Resources.visa;
                }
                else if (r.Cells["cardNumber"].Value.ToString().StartsWith("5"))
                {
                    logo = Properties.Resources.master;
                }
                else if (r.Cells["cardNumber"].Value.ToString().StartsWith("3"))
                {
                    logo = Properties.Resources.american;
                }
                else if (r.Cells["cardNumber"].Value.ToString().StartsWith("6"))
                {
                    logo = Properties.Resources.discover;
                }
                else
                {
                    logo = Properties.Resources.unknown;
                }

                //loading card icon images
                Bitmap b = new Bitmap(20, 20);
                using (Graphics g = Graphics.FromImage((Image)b))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(logo, 0, 0, 20, 20);
                }

                r.Cells["logo"].Value = b;
            }


            dataGridView1.Refresh();

            // loop through grid and set image type as needed
            return;
            //cardTypeDataGridViewImageColumn.Image = Image.FromFile(theDatabaseSetYourLookingFor.Table.Card_TypeColumn);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update the datagridview
            dataGridView1_CellContentClick_1();

        }

        private void dataGridView1_CellContentClick_1()
        {
            tableBindingSource4.EndEdit();
            theDatabaseSetYourLookingFor.GetChanges();
            tableTableAdapter1.Update(theDatabaseSetYourLookingFor.Table);
            theDatabaseSetYourLookingFor.AcceptChanges();
            loadDataGrid();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dataGridView1.SelectedRows)
            {
                string cardSelected = (string)r.Cells["cardNumber"].Value.ToString();
                tableTableAdapter1.Delete(cardSelected);                                                
                theDatabaseSetYourLookingFor.AcceptChanges();
                tableTableAdapter1.Update(theDatabaseSetYourLookingFor.Table);


                sql.Open();
                SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Table] WHERE \"Card Number\"=@val1", sql);

                command.Parameters.AddWithValue("@val1", cardSelected);
                command.ExecuteNonQuery();
                sql.Close();


            }
            dataGridView1_CellContentClick_1();            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //number of monthly payments
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //total payment ammount
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //interest rate
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //monthly payment
        }

        public void button2_Click(object sender, EventArgs e)
        {
            //make payment calculations button
            string holder;
            float interest = 0;
            float monthly = 0;
            float totPay = 0;

            if (maskedTextBox3.Text.ToString() == "  .")
            {
                maskedTextBox3.Text = "0";
            }
            if (maskedTextBox2.Text.ToString() == "     .")
            {
                maskedTextBox2.Text = "0";
            }
            if (maskedTextBox1.Text.ToString() == "     .")
            {
                maskedTextBox1.Text = "0";
            }

            interest = float.Parse(maskedTextBox2.Text.ToString()) /100;
            monthly = float.Parse(maskedTextBox3.Text.ToString()) /100;
            totPay = float.Parse(maskedTextBox1.Text.ToString()) /100;

            float totPay100 = totPay * 100;
            float interest100 = interest * 100;
            float monthly100 = monthly * 100;
            int months;


            ReccuringPayments myRPayments = new ReccuringPayments();
            months = myRPayments.SetRecPayments(totPay100, interest100, monthly100);

            //months = _260FinalProject_CardManager.SetRecPayments(float totPay100, float interest100, float monthly100);

            if (months == -1)
            {
                textBox5.Text = "Raise Ammount Per Month";
            }
            else
            {
                textBox5.Text = months.ToString();
            }
        }
    }

}
