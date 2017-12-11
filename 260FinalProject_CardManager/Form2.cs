using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _260FinalProject_CardManager
{

    public partial class deleteARowForm : Form
    {
        public int ReturnValue { get; set; }
        public deleteARowForm(int numRows)
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
            string string1 = listBox1.Text;
            if (listBox1.Text != null)
            {
                ReturnValue = int.Parse(listBox1.Text);
            }
            ActiveForm.Close();
            return;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
