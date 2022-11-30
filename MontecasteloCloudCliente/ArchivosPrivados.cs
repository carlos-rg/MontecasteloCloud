namespace MontecasteloCloudCliente
{
    internal class ArchivosPrivados
    {
        public int IDArchivoPrivado { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaPrivado { get; set; }
        public int IDUsuario { get; set; }
        public int IDTipoArchivo { get; set; }

        public ArchivosPrivados(int iDArchivoPrivado, string nombreArchivo, string rutaPrivado, int iDUsuario, int iDTipoArchivo)
        {
            IDArchivoPrivado = iDArchivoPrivado;
            NombreArchivo = nombreArchivo;
            RutaPrivado = rutaPrivado;
            IDUsuario = iDUsuario;
            IDTipoArchivo = iDTipoArchivo;
        }
    }
}
