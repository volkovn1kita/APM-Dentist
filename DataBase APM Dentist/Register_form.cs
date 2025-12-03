using System;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_APM_Dentist
{
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();

            // Додайте цей рядок коду, щоб підписатися на подію KeyDown для текстового поля пароля
            textBox2.KeyDown += new KeyEventHandler(textBox2_KeyDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionFile = getConnectionFile();
            string connectionString = getConnectionString(connectionFile);

            string login = "User ID=" + textBox1.Text + ";";
            string pass = "Password=" + textBox2.Text;

            connectionString += login + pass;

            try
            { 
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                MessageBox.Show("Авторизація пройшла успішно", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (textBox1.Text == "administrator")
                {
                    // Відкрити форму адміністратора
                    Main_form mainScreen = new Main_form();
                    mainScreen.Show();
                    Visible = false;
                }
                else if (textBox1.Text == "employee")
                {
                    // Відкрити форму працівника
                    EmployeeForm employeeForm = new EmployeeForm();
                    employeeForm.Show();
                    Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /* string username = textBox1.Text;
             string password = textBox2.Text;

             string role = GetRole(username, password);

             if (role == "administrator")
             {
                 // Відкрити форму адміністратора
                 Main_form mainScreen = new Main_form();
                 mainScreen.Show();
                 Visible = false;
             }
             else if (role == "employee")
             {
                 // Відкрити форму працівника
                 EmployeeForm employeeForm = new EmployeeForm();
                 employeeForm.Show();
                 Visible = false;
             }
             else
             {
                 // Показати повідомлення про помилку
                 MessageBox.Show("Неправильне ім'я користувача або пароль");
             }*/
        }

        public static string getConnectionFile()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) +"\\DBConnectionString";
        }
        public static string getConnectionString(string connectionFile)
        {
            StreamReader rdr = new StreamReader(connectionFile);
            string constring = (rdr.ReadToEnd());
            rdr.Close();
            return constring;
        }


        /*private string GetRole(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DentistDB;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Role FROM AppUsers WHERE Username = @Username AND Password = @Password", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    return result as string;
                }
            }
        }*/

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '●';
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_form_Load(object sender, EventArgs e)
        {

        }
    }
}
