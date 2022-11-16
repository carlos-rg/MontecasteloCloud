namespace MontecasteloCloudCliente
{
    internal class Usuarios
    {
        public int IDUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Pass { get; set; }
        public int IfAdmin { get; set; }

        public Usuarios(int iDUsuario, string nombreUsuario, string pass, int ifAdmin)
        {
            IDUsuario = iDUsuario;
            NombreUsuario = nombreUsuario;
            Pass = pass;
            IfAdmin = ifAdmin;
        }
    }
}
