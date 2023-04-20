using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server = JOSEPC\\SQLEXPRESS ; database = LoginInformation ; INTEGRATED SECURITY = true");
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT username, password from usersInformation WHERE username = @vusername AND password = @vpassword", conexion);
            comando.Parameters.AddWithValue("@vusername", txtUsername.Text);
            comando.Parameters.AddWithValue("@vpassword", txtPassword.Text);
            

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                conexion.Close();
                if(rdoAdmin.Checked == true)
                {
                    Menu pantalla = new Menu();
                    pantalla.Show();
                }else if(rdoUser.Checked == true)
                {
                    Form2 pantalla = new Form2();
                    pantalla.Show();
                }
                this.Hide();
                
            }
            else
            {
                lblNotFound.Text = "This user is not registered, please use an existing account";
                conexion.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblWho_Click(object sender, EventArgs e)
        {

        }
    }
}