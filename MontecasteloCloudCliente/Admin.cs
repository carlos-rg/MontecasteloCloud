using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
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

                }
            }
        }
    }
}
