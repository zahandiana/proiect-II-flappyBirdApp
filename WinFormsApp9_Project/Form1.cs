using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WinFormsApp9_Project
{

    public partial class Form1 : Form
    {
        public static string text;
        public Form1()
        {
            InitializeComponent();

        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VS6LDVR\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txt_username.Text;
            password = txt_password.Text;
            text = txt_username.Text;
            try
            {
                String querry = "SELECT * FROM LoginGame WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    password = txt_password.Text;
                    //fereastra cu jocul 
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_username.Clear();
            txt_username.Focus();
            //txt_password.Text = this.getText();      
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}