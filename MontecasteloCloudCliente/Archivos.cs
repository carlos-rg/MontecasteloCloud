using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace MontecasteloCloudCliente
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
        }

        const string ConnectionString = "Initial Catalog=montecastelocloud;Data Source=CARLOS-PC;Integrated Security=SSPI;";

        private void Archivos_Load(object sender, EventArgs e)
        {
            int IDUsuario = Login.ID;
            string NombreUsuario = Login.UserName;
            labelUser.Text = NombreUsuario;
            try
            {
                using (IDbConnection Conn = new SqlConnection(ConnectionString))
                {
                    var Query1 = "SELECT * FROM ArchivosPrivados WHERE IDUsuario = '" + IDUsuario + "'";
                    var Query2 = "SELECT * FROM ArchivosPublicos";
                    var Select1 = Conn.Query<ArchivosPrivados>(Query1).ToList();
                    var Select2 = Conn.Query<ArchivosPublicos>(Query2).ToList();
                    for (int i = 0; i < Select1.Count; i++)
                    {
                        listBoxPrivado.Items.Add(Select1[i].NombreArchivo);
                    }
                    for (int i = 0; i < Select2.Count; i++)
                    {
                        listBoxPublico.Items.Add(Select2[i].NombreArchivo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DownloadPrivate_Click(object sender, EventArgs e)
        {
            try
            {
                int IDUsuario = Login.ID;
                string Username = Login.UserName;
                string Archivo = listBoxPrivado.SelectedItem.ToString();
                using (IDbConnection Conn = new SqlConnection(ConnectionString))
                {
                    var Query1 = "SELECT * FROM ArchivosPrivados WHERE NombreArchivo = '" + Archivo + "' AND IDUsuario = " + IDUsuario;
                    var Select1 = Conn.QuerySingle<ArchivosPrivados>(Query1);
                    string Ruta = $"{Select1.RutaPrivado}";
                    int Ext = Select1.IDTipoArchivo;
                    if (Select1 != null)
                    {
                        FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://127.0.0.1:21/" + Ruta);
                        Request.Method = WebRequestMethods.Ftp.DownloadFile;
                        Request.Credentials = new NetworkCredential("test", "test");
                        if (Ext == 1)
                        {
                            using (Stream ftpStream = Request.GetResponse().GetResponseStream())
                            using (Stream fileStream = File.Create(@"D:\" + Archivo + ".zip"))
                            {
                                ftpStream.CopyTo(fileStream);
                            }
                        }
                        else if (Ext == 2)
                        {
                            using (Stream ftpStream = Request.GetResponse().GetResponseStream())
                            using (Stream fileStream = File.Create(@"D:\" + Archivo + ".rar"))
                            {
                                ftpStream.CopyTo(fileStream);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido un error", "Error!");
                        }
                        MessageBox.Show("Se ha descargado un archivo", "Felicidades!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletePrivate_Click(object sender, EventArgs e)
        {
            try
            {
                int IDUsuario = Login.ID;
                string Username = Login.UserName;
                string Archivo = listBoxPrivado.SelectedItem.ToString();
                using (IDbConnection Conn = new SqlConnection(ConnectionString))
                {
                    var Query1 = "SELECT * FROM ArchivosPrivados WHERE NombreArchivo = '" + Archivo + "' AND IDUsuario = " + IDUsuario;
                    var Select1 = Conn.QuerySingle<ArchivosPrivados>(Query1);
                    string NombreArchivo = $"{Select1.NombreArchivo}";
                    string Ruta = $"{Select1.RutaPrivado}";
                    int Ext = Select1.IDTipoArchivo;
                    var Query = $@"DELETE FROM ArchivosPrivados WHERE NombreArchivo = @NombreArchivo AND IDUsuario = @IDUsuario";
                    var Delete = Conn.Execute(Query, new { NombreArchivo, IDUsuario });
                    if (Delete != 0)
                    {
                        WebRequest Request = WebRequest.Create("ftp://127.0.0.1:21/" + Ruta);
                        Request.Method = WebRequestMethods.Ftp.DeleteFile;
                        Request.Credentials = new NetworkCredential("test", "test");
                        Request.GetResponse();
                        MessageBox.Show("Se ha eliminado el archivo", "Felicidades!");
                        listBoxPrivado.Items.Remove(Archivo);
                        listBoxPrivado.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Se ha producido un error", "Error");
                    }
                    Conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DownloadPublic_Click(object sender, EventArgs e)
        {
            try
            {
                int IDUsuario = Login.ID;
                string Username = Login.UserName;
                string Archivo = listBoxPrivado.SelectedItem.ToString();
                using (IDbConnection Conn = new SqlConnection(ConnectionString))
                {
                    var Query1 = "SELECT * FROM ArchivosPublicos WHERE NombreArchivo = '" + Archivo + "' AND IDUsuario = " + IDUsuario;
                    var Select1 = Conn.QuerySingle<ArchivosPublicos>(Query1);
                    string Ruta = $"{Select1.RutaPublico}";
                    int Ext = Select1.IDTipoArchivo;
                    if (Select1 != null)
                    {
                        FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://127.0.0.1:21/" + Ruta);
                        Request.Method = WebRequestMethods.Ftp.DownloadFile;
                        Request.Credentials = new NetworkCredential("test", "test");
                        if (Ext == 1)
                        {
                            using (Stream ftpStream = Request.GetResponse().GetResponseStream())
                            using (Stream fileStream = File.Create(@"D:\" + Archivo + ".zip"))
                            {
                                ftpStream.CopyTo(fileStream);
                            }
                        }
                        else if (Ext == 2)
                        {
                            using (Stream ftpStream = Request.GetResponse().GetResponseStream())
                            using (Stream fileStream = File.Create(@"D:\" + Archivo + ".rar"))
                            {
                                ftpStream.CopyTo(fileStream);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido un error", "Error!");
                        }
                        MessageBox.Show("Se ha descargado un archivo", "Felicidades!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletePublic_Click(object sender, EventArgs e)
        {
            try
            {
                int IDUsuario = Login.ID;
                string Username = Login.UserName;
                string Archivo = listBoxPrivado.SelectedItem.ToString();
                using (IDbConnection Conn = new SqlConnection(ConnectionString))
                {
                    var Query1 = "SELECT * FROM ArchivosPublicos WHERE NombreArchivo = '" + Archivo + "' AND IDUsuario = " + IDUsuario;
                    var Select1 = Conn.QuerySingle<ArchivosPublicos>(Query1);
                    string NombreArchivo = $"{Select1.NombreArchivo}";
                    string Ruta = $"{Select1.RutaPublico}";
                    int Ext = Select1.IDTipoArchivo;
                    var Query = $@"DELETE FROM ArchivosPublicos WHERE NombreArchivo = @NombreArchivo AND IDUsuario = @IDUsuario";
                    var Delete = Conn.Execute(Query, new { NombreArchivo, IDUsuario });
                    if (Delete != 0)
                    {
                        WebRequest Request = WebRequest.Create("ftp://127.0.0.1:21/public" + Ruta);
                        Request.Method = WebRequestMethods.Ftp.DeleteFile;
                        Request.Credentials = new NetworkCredential("test", "test");
                        Request.GetResponse();
                        MessageBox.Show("Se ha eliminado el archivo", "Felicidades!");
                        listBoxPrivado.Items.Remove(Archivo);
                        listBoxPublico.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Se ha producido un error", "Error");
                    }
                    Conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UploadPrivate_Click(object sender, EventArgs e)
        {
            if (ArchivoDialog.ShowDialog() == DialogResult.OK)
            {
                string Username = Login.UserName;
                string Archivo = Path.GetFileNameWithoutExtension(ArchivoDialog.FileName);
                string RutaExt = ArchivoDialog.FileName;
                string Extension = Path.GetExtension(RutaExt);
                string Ruta = "/" + Username + "/" + Archivo + Extension;
                int ID = Login.ID;
                try
                {
                    using (IDbConnection Conn = new SqlConnection(ConnectionString))
                    {
                        var Query = $@"INSERT INTO ArchivosPrivados (NombreArchivo, RutaPrivado, IDUsuario, IDTipoArchivo) VALUES (@NombreArchivo, @RutaPrivado, @IDUsuario, @IDTipoArchivo)";
                        var Insert = Conn.Execute(Query, new { NombreArchivo = Archivo, RutaPrivado = Ruta, IDUsuario = ID, IDTipoArchivo = 1 });
                        if (Insert != 0)
                        {
                            FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://127.0.0.1:21/" + Username + "/" + Archivo + Extension);
                            Request.Method = WebRequestMethods.Ftp.UploadFile;
                            Request.UsePassive = true;
                            Request.UseBinary = true;
                            Request.KeepAlive = false;
                            Request.Credentials = new NetworkCredential("test", "test");
                            FileStream Stream = File.OpenRead(RutaExt);
                            byte[] Buffer = new byte[Stream.Length];
                            Stream.Read(Buffer, 0, Buffer.Length);
                            Stream.Close();
                            Stream ReqFtp = Request.GetRequestStream();
                            ReqFtp.Write(Buffer, 0, Buffer.Length);
                            ReqFtp.Flush();
                            ReqFtp.Close();
                            MessageBox.Show("Se ha subido un archivo", "Felicidades!");
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido un error", "Error");
                        }
                        Conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                listBoxPrivado.Items.Add(Archivo);
                listBoxPrivado.Refresh();
            }
        }

        private void UploadPublic_Click(object sender, EventArgs e)
        {
            if (ArchivoDialog.ShowDialog() == DialogResult.OK)
            {
                string Username = Login.UserName;
                string Archivo = Path.GetFileNameWithoutExtension(ArchivoDialog.FileName);
                string RutaExt = ArchivoDialog.FileName;
                string Extension = Path.GetExtension(RutaExt);
                string Ruta = Archivo + Extension;
                int ID = Login.ID;
                try
                {
                    using (IDbConnection Conn = new SqlConnection(ConnectionString))
                    {
                        var Query = $@"INSERT INTO ArchivosPublicos (NombreArchivo, RutaPublico, IDUsuario, IDTipoArchivo) VALUES (@NombreArchivo, @RutaPrivado, @IDUsuario, @IDTipoArchivo)";
                        var Insert = Conn.Execute(Query, new { NombreArchivo = Archivo, RutaPrivado = Ruta, IDUsuario = ID, IDTipoArchivo = 1 });
                        if (Insert != 0)
                        {
                            FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://127.0.0.1:21/public/" + Archivo + Extension);
                            Request.Method = WebRequestMethods.Ftp.UploadFile;
                            Request.UsePassive = true;
                            Request.UseBinary = true;
                            Request.KeepAlive = false;
                            Request.Credentials = new NetworkCredential("test", "test");
                            FileStream Stream = File.OpenRead(RutaExt);
                            byte[] Buffer = new byte[Stream.Length];
                            Stream.Read(Buffer, 0, Buffer.Length);
                            Stream.Close();
                            Stream ReqFtp = Request.GetRequestStream();
                            ReqFtp.Write(Buffer, 0, Buffer.Length);
                            ReqFtp.Flush();
                            ReqFtp.Close();
                            MessageBox.Show("Se ha subido un archivo", "Felicidades!");
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido un error", "Error");
                        }
                        Conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                listBoxPublico.Items.Add(Archivo);
                listBoxPublico.Refresh();
            }
        }

        private void SearchPrivado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPrivado.Text))
            {
                int index = listBoxPrivado.FindString(textBoxPrivado.Text);
                if (index != -1)
                    listBoxPrivado.SetSelected(index, true);
                else
                    MessageBox.Show("El archivo no existe...", "Error");
            }
        }

        private void SearchPublico_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPublico.Text))
            {
                int index = listBoxPublico.FindString(textBoxPrivado.Text);
                if (index != -1)
                    listBoxPublico.SetSelected(index, true);
                else
                    MessageBox.Show("El archivo no existe...", "Error");
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Opciones O1 = new Opciones();
            O1.Show();
        }
    }
}
