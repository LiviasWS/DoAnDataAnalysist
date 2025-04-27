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

namespace Cafeteria
{
    public partial class FLogin : Form
    {
        private DBConnection db;
        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public TextBox TxtPass { get => txtPass; set => txtPass = value; }
        public FLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (ValidateUserSales(username, password))
            {

                db = new DBConnection();

                MessageBox.Show("Login successful!");

                this.Hide();
                FSale sale = new FSale();
                sale.StartPosition = FormStartPosition.CenterScreen;
                sale.Show();
            }
            else if (ValidateUserWarehouse(username, password))
            {

                db = new DBConnection();

                MessageBox.Show("Login successful!");

                this.Hide();
                FKho sale = new FKho();
                sale.StartPosition = FormStartPosition.CenterScreen;
                sale.Show();
            }
            else if (ValidateUserManager(username, password))
            {

                db = new DBConnection();

                MessageBox.Show("Login successful!");

                this.Hide();
                FSaleDashboard sale = new FSaleDashboard();
                sale.StartPosition = FormStartPosition.CenterScreen;
                sale.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private bool ValidateUserSales(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                try
                {
                    con.Open();
                    string sqlStr = "SELECT COUNT(*) FROM NhanVien WHERE Username = @username AND Password = @password AND Role = 'thungan'";
                    SqlCommand cmd = new SqlCommand(sqlStr, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private bool ValidateUserWarehouse(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                try
                {
                    con.Open();
                    string sqlStr = "SELECT COUNT(*) FROM NhanVien WHERE Username = @username AND Password = @password AND Role = 'kho'";
                    SqlCommand cmd = new SqlCommand(sqlStr, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private bool ValidateUserManager(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                try
                {
                    con.Open();
                    string sqlStr = "SELECT COUNT(*) FROM NhanVien WHERE Username = @username AND Password = @password AND Role = 'quanly'";
                    SqlCommand cmd = new SqlCommand(sqlStr, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}