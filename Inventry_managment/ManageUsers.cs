using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Inventry_managment
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=inventrydb; User Id=root; Password=;";


        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO userTbl (Name, FName, Password, PhoneNumber) VALUES (@Name, @FName, @Password, @PhoneNumber)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", nameTxt.Text);
                    cmd.Parameters.AddWithValue("@FName", fnameTxt.Text);
                    cmd.Parameters.AddWithValue("@Password", pwTxt.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", tpTxt.Text);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
