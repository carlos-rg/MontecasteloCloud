namespace MontecasteloCloudCliente
{
    partial class Archivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxPrivado = new System.Windows.Forms.ListBox();
            this.listBoxPublico = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ArchivoDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.UploadPublic = new System.Windows.Forms.Button();
            this.UploadPrivate = new System.Windows.Forms.Button();
            this.DeletePublic = new System.Windows.Forms.Button();
            this.DownloadPublic = new System.Windows.Forms.Button();
            this.DeletePrivate = new System.Windows.Forms.Button();
            this.DownloadPrivate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPrivado
            // 
            this.listBoxPrivado.FormattingEnabled = true;
            this.listBoxPrivado.Location = new System.Drawing.Point(12, 131);
            this.listBoxPrivado.Name = "listBoxPrivado";
            this.listBoxPrivado.Size = new System.Drawing.Size(267, 355);
            this.listBoxPrivado.TabIndex = 0;
            // 
            // listBoxPublico
            // 
            this.listBoxPublico.FormattingEnabled = true;
            this.listBoxPublico.Location = new System.Drawing.Point(621, 131);
            this.listBoxPublico.Name = "listBoxPublico";
            this.listBoxPublico.Size = new System.Drawing.Size(267, 355);
            this.listBoxPublico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Montecastelo Cloud";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MontecasteloCloudCliente.Properties.Resources.montecasteloicon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 62);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = global::MontecasteloCloudCliente.Properties.Resources.logout1;
            this.buttonLogout.Location = new System.Drawing.Point(958, 24);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(40, 42);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // UploadPublic
            // 
            this.UploadPublic.Image = global::MontecasteloCloudCliente.Properties.Resources.upload;
            this.UploadPublic.Location = new System.Drawing.Point(621, 83);
            this.UploadPublic.Name = "UploadPublic";
            this.UploadPublic.Size = new System.Drawing.Size(40, 42);
            this.UploadPublic.TabIndex = 8;
            this.UploadPublic.UseVisualStyleBackColor = true;
            this.UploadPublic.Click += new System.EventHandler(this.UploadPublic_Click);
            // 
            // UploadPrivate
            // 
            this.UploadPrivate.Image = global::MontecasteloCloudCliente.Properties.Resources.upload;
            this.UploadPrivate.Location = new System.Drawing.Point(12, 83);
            this.UploadPrivate.Name = "UploadPrivate";
            this.UploadPrivate.Size = new System.Drawing.Size(40, 42);
            this.UploadPrivate.TabIndex = 7;
            this.UploadPrivate.UseVisualStyleBackColor = true;
            this.UploadPrivate.Click += new System.EventHandler(this.UploadPrivate_Click);
            // 
            // DeletePublic
            // 
            this.DeletePublic.Image = global::MontecasteloCloudCliente.Properties.Resources.delete;
            this.DeletePublic.Location = new System.Drawing.Point(906, 303);
            this.DeletePublic.Name = "DeletePublic";
            this.DeletePublic.Size = new System.Drawing.Size(40, 42);
            this.DeletePublic.TabIndex = 5;
            this.DeletePublic.UseVisualStyleBackColor = true;
            this.DeletePublic.Click += new System.EventHandler(this.DeletePublic_Click);
            // 
            // DownloadPublic
            // 
            this.DownloadPublic.Image = global::MontecasteloCloudCliente.Properties.Resources.download;
            this.DownloadPublic.Location = new System.Drawing.Point(906, 235);
            this.DownloadPublic.Name = "DownloadPublic";
            this.DownloadPublic.Size = new System.Drawing.Size(40, 42);
            this.DownloadPublic.TabIndex = 4;
            this.DownloadPublic.UseVisualStyleBackColor = true;
            this.DownloadPublic.Click += new System.EventHandler(this.DownloadPublic_Click);
            // 
            // DeletePrivate
            // 
            this.DeletePrivate.Image = global::MontecasteloCloudCliente.Properties.Resources.delete;
            this.DeletePrivate.Location = new System.Drawing.Point(298, 312);
            this.DeletePrivate.Name = "DeletePrivate";
            this.DeletePrivate.Size = new System.Drawing.Size(40, 42);
            this.DeletePrivate.TabIndex = 3;
            this.DeletePrivate.UseVisualStyleBackColor = true;
            this.DeletePrivate.Click += new System.EventHandler(this.DeletePrivate_Click);
            // 
            // DownloadPrivate
            // 
            this.DownloadPrivate.Image = global::MontecasteloCloudCliente.Properties.Resources.download;
            this.DownloadPrivate.Location = new System.Drawing.Point(298, 244);
            this.DownloadPrivate.Name = "DownloadPrivate";
            this.DownloadPrivate.Size = new System.Drawing.Size(40, 42);
            this.DownloadPrivate.TabIndex = 2;
            this.DownloadPrivate.UseVisualStyleBackColor = true;
            this.DownloadPrivate.Click += new System.EventHandler(this.DownloadPrivate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Archivos Privados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Archivos Públicos";
            // 
            // Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.UploadPublic);
            this.Controls.Add(this.UploadPrivate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeletePublic);
            this.Controls.Add(this.DownloadPublic);
            this.Controls.Add(this.DeletePrivate);
            this.Controls.Add(this.DownloadPrivate);
            this.Controls.Add(this.listBoxPublico);
            this.Controls.Add(this.listBoxPrivado);
            this.Name = "Archivos";
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.Archivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPrivado;
        private System.Windows.Forms.ListBox listBoxPublico;
        private System.Windows.Forms.Button DownloadPrivate;
        private System.Windows.Forms.Button DeletePrivate;
        private System.Windows.Forms.Button DownloadPublic;
        private System.Windows.Forms.Button DeletePublic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UploadPrivate;
        private System.Windows.Forms.Button UploadPublic;
        private System.Windows.Forms.OpenFileDialog ArchivoDialog;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}