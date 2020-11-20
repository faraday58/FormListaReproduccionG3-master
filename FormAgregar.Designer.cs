namespace FormListaReproduccionG3
{
    partial class FormAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtbCancion = new System.Windows.Forms.TextBox();
            this.txtbArtista = new System.Windows.Forms.TextBox();
            this.txtbAlbum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Álbum";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(534, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 68);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtbCancion
            // 
            this.txtbCancion.Location = new System.Drawing.Point(221, 50);
            this.txtbCancion.Name = "txtbCancion";
            this.txtbCancion.Size = new System.Drawing.Size(248, 26);
            this.txtbCancion.TabIndex = 2;
            // 
            // txtbArtista
            // 
            this.txtbArtista.Location = new System.Drawing.Point(221, 101);
            this.txtbArtista.Name = "txtbArtista";
            this.txtbArtista.Size = new System.Drawing.Size(248, 26);
            this.txtbArtista.TabIndex = 2;
            // 
            // txtbAlbum
            // 
            this.txtbAlbum.Location = new System.Drawing.Point(221, 152);
            this.txtbAlbum.Name = "txtbAlbum";
            this.txtbAlbum.Size = new System.Drawing.Size(248, 26);
            this.txtbAlbum.TabIndex = 2;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 246);
            this.Controls.Add(this.txtbAlbum);
            this.Controls.Add(this.txtbArtista);
            this.Controls.Add(this.txtbCancion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtbCancion;
        private System.Windows.Forms.TextBox txtbArtista;
        private System.Windows.Forms.TextBox txtbAlbum;
    }
}