using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MontecasteloCloudCliente
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        const string ConnectionString = "Initial Catalog=montecastelocloud;Data Source=CARLOS-PC;Integrated Security=SSPI;";

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection Conn = new SqlConnection(ConnectionString))
                {
                    string NombreUsuario = Login.UserName;
                    string Password = textBoxPassword.Text;
                    var Algo = HashAlgorithm.Create("md5");
                    var Hash = Algo.ComputeHash(Encoding.UTF8.GetBytes(Password));
                    var HashPassword = BitConverter.ToString(Hash);
                    var Query = "UPDATE Usuarios SET '@HashPassword' WHERE NombreUsuario = '@Username'";
                    var Delete = Conn.Execute(Query, new { HashPassword, Username = NombreUsuario });
                    if (Delete != 0)
                    {
                        MessageBox.Show("Contraseña cambiada correctamente.", "Cambiar contraseña");
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Se ha producido un error cambiando la contraseña.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection Conn = new SqlConnection(ConnectionString))
                {
                    string NombreUsuario = Login.UserName;
                    var Query = "DELETE FROM Usuarios WHERE NombreUsuario = '@Username'";
                    var Delete = Conn.Execute(Query, new { NombreUsuario });
                    if (Delete != 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Eliminar usuario");
                        Login L1 = new Login();
                        L1.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Se ha producido un error borrando el usuario.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            string NombreUsuario = Login.UserName;
            labelUser.Text = NombreUsuario;
        }
    }
}
