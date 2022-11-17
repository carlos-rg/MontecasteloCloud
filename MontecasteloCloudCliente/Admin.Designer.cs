namespace MontecasteloCloudCliente
{
    partial class Admin
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
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.Location = new System.Drawing.Point(54, 117);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(305, 212);
            this.listBoxUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Montecastelo Cloud";
            // 
            // DeleteUser
            // 
            this.DeleteUser.ForeColor = System.Drawing.Color.IndianRed;
            this.DeleteUser.Image = global::MontecasteloCloudCliente.Properties.Resources.delete;
            this.DeleteUser.Location = new System.Drawing.Point(388, 198);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(40, 43);
            this.DeleteUser.TabIndex = 8;
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MontecasteloCloudCliente.Properties.Resources.montecasteloicon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 62);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = global::MontecasteloCloudCliente.Properties.Resources.logout1;
            this.buttonLogout.Location = new System.Drawing.Point(388, 27);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(40, 42);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUsuarios);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogout;
    }
}