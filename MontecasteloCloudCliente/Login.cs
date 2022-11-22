using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MontecasteloCloudCliente
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        const string ConnectionString = "Initial Catalog=montecastelocloud;Data Source=CARLOS-PC;Integrated Security=SSPI;";
        public static int ID;
        public static string UserName = String.Empty;

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            var Algo = HashAlgorithm.Create("md5");
            var Hash = Algo.ComputeHash(Encoding.UTF8.GetBytes(Password));
            var HashPassword = BitConverter.ToString(Hash);
            try
            {
                using (IDbConnection Conn = new SqlConnection(ConnectionString))
                {
                    var Query1 = "SELECT * FROM Usuarios WHERE NombreUsuario = '" + Username + "' AND Pass = '" + HashPassword + "'";
                    var Select = Conn.QuerySingle<Usuarios>(Query1);
                    int Id = Select.IDUsuario;
                    string Usuario = $"{Select.NombreUsuario}";
                    string Pass = $"{Select.Pass}";
                    string IfAdmin = $"{Select.IfAdmin}";
                    if (Usuario != null && Pass == HashPassword && Int32.Parse(IfAdmin) == 0)
                    {
                        ID = Id;
                        UserName = Usuario;
                        Archivos A1 = new Archivos();
                        this.Hide();
                        A1.Show();
                    }
                    else if (Usuario != null && Pass == HashPassword && Int32.Parse(IfAdmin) == 1)
                    {
                        UserName = Usuario;
                        Admin admin = new Admin();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Se ha producido un error. El nombre de usuario o la contraseña son incorrectas.");
                    }
                    Conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void ButtonSignin_Click(object sender, EventArgs e)
        {
            Register R1 = new Register();
            this.Hide();
            R1.Show();
        }
    }
}
