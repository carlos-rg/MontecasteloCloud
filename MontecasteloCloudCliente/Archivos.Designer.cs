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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archivos));
            this.listBoxPrivado = new System.Windows.Forms.ListBox();
            this.listBoxPublico = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ArchivoDialog = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrivado = new System.Windows.Forms.TextBox();
            this.textBoxPublico = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SearchPublico = new System.Windows.Forms.Button();
            this.SearchPrivado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.UploadPublic = new System.Windows.Forms.Button();
            this.UploadPrivate = new System.Windows.Forms.Button();
            this.DeletePublic = new System.Windows.Forms.Button();
            this.DownloadPublic = new System.Windows.Forms.Button();
            this.DeletePrivate = new System.Windows.Forms.Button();
            this.DownloadPrivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPrivado
            // 
            this.listBoxPrivado.FormattingEnabled = true;
            this.listBoxPrivado.Location = new System.Drawing.Point(12, 194);
            this.listBoxPrivado.Name = "listBoxPrivado";
            this.listBoxPrivado.Size = new System.Drawing.Size(267, 355);
            this.listBoxPrivado.TabIndex = 0;
            // 
            // listBoxPublico
            // 
            this.listBoxPublico.FormattingEnabled = true;
            this.listBoxPublico.Location = new System.Drawing.Point(621, 194);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Archivos Privados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Archivos Públicos";
            // 
            // textBoxPrivado
            // 
            this.textBoxPrivado.Location = new System.Drawing.Point(12, 157);
            this.textBoxPrivado.Name = "textBoxPrivado";
            this.textBoxPrivado.Size = new System.Drawing.Size(186, 20);
            this.textBoxPrivado.TabIndex = 14;
            // 
            // textBoxPublico
            // 
            this.textBoxPublico.Location = new System.Drawing.Point(621, 157);
            this.textBoxPublico.Name = "textBoxPublico";
            this.textBoxPublico.Size = new System.Drawing.Size(186, 20);
            this.textBoxPublico.TabIndex = 16;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelUser.Location = new System.Drawing.Point(774, 39);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(33, 16);
            this.labelUser.TabIndex = 19;
            this.labelUser.Text = "user";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Image = global::MontecasteloCloudCliente.Properties.Resources.settings;
            this.buttonSettings.Location = new System.Drawing.Point(912, 24);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(40, 43);
            this.buttonSettings.TabIndex = 18;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // SearchPublico
            // 
            this.SearchPublico.Image = global::MontecasteloCloudCliente.Properties.Resources.search;
            this.SearchPublico.Location = new System.Drawing.Point(813, 145);
            this.SearchPublico.Name = "SearchPublico";
            this.SearchPublico.Size = new System.Drawing.Size(40, 43);
            this.SearchPublico.TabIndex = 17;
            this.SearchPublico.UseVisualStyleBackColor = true;
            this.SearchPublico.Click += new System.EventHandler(this.SearchPublico_Click);
            // 
            // SearchPrivado
            // 
            this.SearchPrivado.Image = global::MontecasteloCloudCliente.Properties.Resources.search;
            this.SearchPrivado.Location = new System.Drawing.Point(204, 145);
            this.SearchPrivado.Name = "SearchPrivado";
            this.SearchPrivado.Size = new System.Drawing.Size(40, 43);
            this.SearchPrivado.TabIndex = 15;
            this.SearchPrivado.UseVisualStyleBackColor = true;
            this.SearchPrivado.Click += new System.EventHandler(this.SearchPrivado_Click);
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
            this.UploadPublic.Location = new System.Drawing.Point(621, 109);
            this.UploadPublic.Name = "UploadPublic";
            this.UploadPublic.Size = new System.Drawing.Size(40, 42);
            this.UploadPublic.TabIndex = 8;
            this.UploadPublic.UseVisualStyleBackColor = true;
            this.UploadPublic.Click += new System.EventHandler(this.UploadPublic_Click);
            // 
            // UploadPrivate
            // 
            this.UploadPrivate.Image = global::MontecasteloCloudCliente.Properties.Resources.upload;
            this.UploadPrivate.Location = new System.Drawing.Point(12, 109);
            this.UploadPrivate.Name = "UploadPrivate";
            this.UploadPrivate.Size = new System.Drawing.Size(40, 42);
            this.UploadPrivate.TabIndex = 7;
            this.UploadPrivate.UseVisualStyleBackColor = true;
            this.UploadPrivate.Click += new System.EventHandler(this.UploadPrivate_Click);
            // 
            // DeletePublic
            // 
            this.DeletePublic.Image = global::MontecasteloCloudCliente.Properties.Resources.delete;
            this.DeletePublic.Location = new System.Drawing.Point(906, 366);
            this.DeletePublic.Name = "DeletePublic";
            this.DeletePublic.Size = new System.Drawing.Size(40, 42);
            this.DeletePublic.TabIndex = 5;
            this.DeletePublic.UseVisualStyleBackColor = true;
            this.DeletePublic.Click += new System.EventHandler(this.DeletePublic_Click);
            // 
            // DownloadPublic
            // 
            this.DownloadPublic.Image = global::MontecasteloCloudCliente.Properties.Resources.download;
            this.DownloadPublic.Location = new System.Drawing.Point(906, 298);
            this.DownloadPublic.Name = "DownloadPublic";
            this.DownloadPublic.Size = new System.Drawing.Size(40, 42);
            this.DownloadPublic.TabIndex = 4;
            this.DownloadPublic.UseVisualStyleBackColor = true;
            this.DownloadPublic.Click += new System.EventHandler(this.DownloadPublic_Click);
            // 
            // DeletePrivate
            // 
            this.DeletePrivate.Image = global::MontecasteloCloudCliente.Properties.Resources.delete;
            this.DeletePrivate.Location = new System.Drawing.Point(298, 375);
            this.DeletePrivate.Name = "DeletePrivate";
            this.DeletePrivate.Size = new System.Drawing.Size(40, 42);
            this.DeletePrivate.TabIndex = 3;
            this.DeletePrivate.UseVisualStyleBackColor = true;
            this.DeletePrivate.Click += new System.EventHandler(this.DeletePrivate_Click);
            // 
            // DownloadPrivate
            // 
            this.DownloadPrivate.Image = global::MontecasteloCloudCliente.Properties.Resources.download;
            this.DownloadPrivate.Location = new System.Drawing.Point(298, 307);
            this.DownloadPrivate.Name = "DownloadPrivate";
            this.DownloadPrivate.Size = new System.Drawing.Size(40, 42);
            this.DownloadPrivate.TabIndex = 2;
            this.DownloadPrivate.UseVisualStyleBackColor = true;
            this.DownloadPrivate.Click += new System.EventHandler(this.DownloadPrivate_Click);
            // 
            // Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 564);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.SearchPublico);
            this.Controls.Add(this.textBoxPublico);
            this.Controls.Add(this.SearchPrivado);
            this.Controls.Add(this.textBoxPrivado);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Archivos";
            this.Text = "Montecastelo Cloud - Archivos";
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
        private System.Windows.Forms.TextBox textBoxPrivado;
        private System.Windows.Forms.Button SearchPrivado;
        private System.Windows.Forms.Button SearchPublico;
        private System.Windows.Forms.TextBox textBoxPublico;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelUser;
    }
}