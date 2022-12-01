using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
//using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GEN
{
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
        public Login()
        {
            InitializeComponent();

            var pos = this.PointToScreen(panel1.Location);
            pos = pictureBox1.PointToClient(pos);
            panel1.Parent = pictureBox1;
            panel1.Location = pos;
            panel1.BackColor = Color.Transparent;
        }

        public static string username;
        public static string recby
        {
            get { return username; }
            set { username = value; }
        }

        public static string role;
        public static string roleby
        {
            get { return role; }
            set { role = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void user_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User_Info' table. You can move, or remove it, as needed.
            //this.user_InfoTableAdapter.Fill(this.dataSet1.User_Info);            
            roleComboBox.Enabled = false;
            usernameTextBox.Focus();
        }

        private void user_InfoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.user_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(cs);
            string chkquery = "SELECT TOP 1 EndDate FROM EXPDate ORDER BY ID DESC";
            SQLiteCommand sqlcmd = new SQLiteCommand(chkquery, sqlcon);
            SQLiteDataAdapter sqlsda = new SQLiteDataAdapter(sqlcmd);
            DataTable sqldt = new DataTable();
            sqlsda.Fill(sqldt);

            DateTime date1 = DateTime.UtcNow;
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            DateTime date2 = TimeZoneInfo.ConvertTime(date1, tz);
            DateTime expdate = Convert.ToDateTime(sqldt.Rows[0]["EndDate"].ToString());

            if (date2 >= expdate)
            {
                string title = "alert!!";
                MessageBox.Show("alert (\"Your application has expired, kindly contact your system administrator.\");", title);
            }
            else
            {
                this.user_InfoTableAdapter.FillByid(this.dataSet1.User_Info, usernameTextBox.Text, passwordTextBox.Text);

                int noofrec = 0;
                noofrec = dataSet1.User_Info.Rows.Count;

                if (noofrec > 0)
                {
                    recby = usernameTextBox.Text;
                    roleby = roleComboBox.Text;
                    if (roleComboBox.Text == "Admin")
                    {
                        string title = "Login Successfull";
                        MessageBox.Show("Logging in as Admin.", title);
                        AdminPanel AP = new AdminPanel();
                        AP.Show();
                        this.Hide();
                    }
                    else if (roleComboBox.Text == "User")
                    {
                        string title = "Login Successfull";
                        MessageBox.Show("Logging in as User.", title);
                        UserPanel UP = new UserPanel();
                        UP.Show();
                        this.Hide();
                    }
                }
                else
                {
                    string title = "Invalid Login";
                    MessageBox.Show("Invalid Username or Password", title);
                }
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{ENTER}");

                Button button = sender as Button;

                SQLiteConnection sqlcon = new SQLiteConnection(cs);
                string chkquery = "SELECT TOP 1 EndDate FROM EXPDate ORDER BY ID DESC";
                SQLiteCommand sqlcmd = new SQLiteCommand(chkquery, sqlcon);
                SQLiteDataAdapter sqlsda = new SQLiteDataAdapter(sqlcmd);
                DataTable sqldt = new DataTable();
                sqlsda.Fill(sqldt);

                DateTime date1 = DateTime.UtcNow;
                TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                DateTime date2 = TimeZoneInfo.ConvertTime(date1, tz);
                DateTime expdate = Convert.ToDateTime(sqldt.Rows[0]["EndDate"].ToString());

                if (date2 >= expdate)
                {

                    string title = "alert!!";
                    MessageBox.Show("alert (\"Your application has expired, kindly contact your system administrator.\");", title);

                }
                else
                {
                    this.user_InfoTableAdapter.FillByid(this.dataSet1.User_Info, usernameTextBox.Text, passwordTextBox.Text);

                    int noofrec = 0;
                    noofrec = dataSet1.User_Info.Rows.Count;

                    if (noofrec > 0)
                    {
                        recby = usernameTextBox.Text;
                        roleby = roleComboBox.Text;
                        if (roleComboBox.Text == "Admin")
                        {
                            string title = "Login Successfull";
                            MessageBox.Show("Logging in as Admin.", title);
                            AdminPanel AP = new AdminPanel();
                            AP.Show();
                            this.Hide();
                        }
                        else if (roleComboBox.Text == "User")
                        {
                            string title = "Login Successfull";
                            MessageBox.Show("Logging in as User.", title);
                            UserPanel UP = new UserPanel();
                            UP.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        string title = "Invalid Login";
                        MessageBox.Show("Invalid Username or Password", title);

                    }
                }

            }
        }
    }
}
 