namespace MontecasteloCloudCliente
{
    internal class ArchivosPublicos
    {
        public int IDArchivoPublico { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaPublico { get; set; }
        public int IDUsuario { get; set; }
        public int IDTipoArchivo { get; set; }

        public ArchivosPublicos(int iDArchivoPublico, string nombreArchivo, string rutaPublico, int iDUsuario, int iDTipoArchivo)
        {
            IDArchivoPublico = iDArchivoPublico;
            NombreArchivo = nombreArchivo;
            RutaPublico = rutaPublico;
            IDUsuario = iDUsuario;
            IDTipoArchivo = iDTipoArchivo;
        }
    }
}
