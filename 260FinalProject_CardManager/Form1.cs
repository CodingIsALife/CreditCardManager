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

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
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

            tableTableAdapter1.Update(theDatabaseSetYourLookingFor.Table);
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
    }
}
