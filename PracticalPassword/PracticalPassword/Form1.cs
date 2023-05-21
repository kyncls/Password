using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalPassword
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT password FROM thePassword WHERE username = @username";
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\admin\\Documents\\College\\2nd Year\\2nd Sem\\AppsDev\\Activities\\PracticalPass\\Password.mdb";
            using (OleDbConnection connect = new OleDbConnection(con))
            {
                connect.Open();

                using(OleDbCommand cmd = new OleDbCommand(query,connect))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);

                    string passwordFromDatabase = (string)cmd.ExecuteScalar();

                    if(textBox2.Text == passwordFromDatabase)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ïncorrect Username or Password!");
                    }
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
