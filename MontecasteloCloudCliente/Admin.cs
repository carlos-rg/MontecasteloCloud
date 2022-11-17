using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MontecasteloCloudCliente
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        const string ConnectionString = "Initial Catalog=montecastelocloud;Data Source=CARLOS-PC;Integrated Security=SSPI;";

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            string Username = listBoxUsuarios.SelectedItem.ToString();
            using (IDbConnection Conn = new SqlConnection(ConnectionString))
            {
                var Query = "DELETE FROM Usuarios WHERE NombreUsuario = '@Username'";
                var Delete = Conn.Execute(Query, new { Username });
                if (Delete != 0)
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "Eliminar usuario");
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            using (IDbConnection Conn = new SqlConnection(ConnectionString))
            {
                var Query = "SELECT * FROM Usuarios";
                var Select = Conn.Query<Usuarios>(Query).ToList();
                for (int i = 0; i < Select.Count; i++)
                {
                    listBoxUsuarios.Items.Add(Select[i].NombreUsuario);
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login L1 = new Login();
            this.Hide();
            L1.Show();
        }
    }
}
