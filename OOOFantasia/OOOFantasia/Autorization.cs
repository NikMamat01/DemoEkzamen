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

namespace OOOFantasia
{
    public partial class Autorization : Form
    {
        
        public Autorization()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Вход в аккаунт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vxod_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cs = new SqlConnection(@"Data Source = DESKTOP-U3T0DTQ\MSSQLSERVER01; Initial Catalog = Trade_2; Integrated Security = True");
                string sql = "SELECT * FROM [User] WHERE UserLogin = '" + login.Text + "' and UserPassword = '" + password.Text + "' ";
                SqlDataAdapter sql1 = new SqlDataAdapter(sql, cs);
                DataTable dt = new DataTable();
                sql1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Gost gost = new Gost();
                    gost.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }
        /// <summary>
        /// Вход незарегистрированного пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guest_Click(object sender, EventArgs e)
        {
            Gost g = new Gost();
            g.Show();
            this.Hide();
        }
        /// <summary>
        /// Выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Вы точно хотите выйти?",
        "Выход из программы",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
