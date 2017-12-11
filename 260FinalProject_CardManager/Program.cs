using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _260FinalProject_CardManager
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool runAuth = true;
            bool userGotIn = false;
            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Landon\source\repos\260FinalProject_CardManager\260FinalProject_CardManager\CreditCardInfo.mdf;Integrated Security = True; Connect Timeout = 30");
            addNewUser form2 = new addNewUser();
            Authentication form3 = new Authentication();
            DialogResult dr;

            //Before we run the program, we need to run an authentication window.
            //check for username in database.
            //if the table value is null

            while (userGotIn == false)
            {
                runAuth = false;
                sql.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Table2]", sql);

                int userCount = (int)command.ExecuteScalar();
                sql.Close();
                if (userCount == 0)
                {
                    //if the table is null, this calls for adding a user
                    dr = form2.ShowDialog();
                    runAuth = true;
                }
                else
                {
                    runAuth = true;
                }

                //authenticate the user
                while (runAuth == true)
                {
                    dr = form3.ShowDialog();
                    if (form3.userDeletedData == true)
                    {
                        runAuth = false;
                    }
                    if (form3.authenticated == true)
                    {
                        runAuth = false;
                        userGotIn = true;
                    }
                }
            }

            Application.Run(new Form1());

        }
    }
}
