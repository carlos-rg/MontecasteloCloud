using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MontecasteloCloudCliente
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        const string ConnectionString = "Initial Catalog=montecastelocloud;Data Source=CARLOS-PC;Integrated Security=SSPI;";

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            var Algo = HashAlgorithm.Create("md5");
            var Hash = Algo.ComputeHash(Encoding.UTF8.GetBytes(Password));
            var HashPassword = BitConverter.ToString(Hash);
            int IfAdmin;
            if (Username != String.Empty && Password != String.Empty && checkBoxRegister.Checked)
            {
                try
                {
                    using (IDbConnection Conn = new SqlConnection(ConnectionString))
                    {
                        if (checkBoxAdmin.Checked)
                        {
                            IfAdmin = 1;
                        }
                        else
                        {
                            IfAdmin = 0;
                        }
                        var QueryUser = "SELECT * FROM Usuarios WHERE NombreUsuario = '" + Username + "'";
                        var QueryVal = Conn.QuerySingle<Usuarios>(QueryUser);
                        if (QueryVal == null) {
                            var Query = $@"INSERT INTO Usuarios (NombreUsuario, Pass, IfAdmin) VALUES (@Username, @Password, @IfAdmin)";
                            var Insert = Conn.Execute(Query, new { Username, Password = HashPassword, IfAdmin });
                            if (Insert != 0)
                            {
                                WebRequest Request = WebRequest.Create("ftp://127.0.0.1:21/" + Username);
                                Request.Method = WebRequestMethods.Ftp.MakeDirectory;
                                Request.Credentials = new NetworkCredential("test", "test");
                                Request.GetResponse();
                                MessageBox.Show("Se ha creado un nuevo usuario", "Felicidades!");
                                Login L1 = new Login();
                                this.Hide();
                                L1.Show();
                            }
                            else
                            {
                                MessageBox.Show("Se ha producido un error", "Error");
                            }
                            Conn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
