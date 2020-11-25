namespace FormListaReproduccionG3
{
    partial class FormRepro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listReproduccion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCancion = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.lbArtista = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarCancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.reproducciónAutomáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bucleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCancion = new System.Windows.Forms.Timer(this.components);
            this.pbrTiempoTrans = new System.Windows.Forms.ProgressBar();
            this.lbTiempoTrans = new System.Windows.Forms.Label();
            this.lbTiempoDuracion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listReproduccion
            // 
            this.listReproduccion.FormattingEnabled = true;
            this.listReproduccion.ItemHeight = 20;
            this.listReproduccion.Location = new System.Drawing.Point(40, 112);
            this.listReproduccion.Name = "listReproduccion";
            this.listReproduccion.Size = new System.Drawing.Size(243, 324);
            this.listReproduccion.TabIndex = 0;
            this.listReproduccion.SelectedIndexChanged += new System.EventHandler(this.listReproduccion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Canción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Artista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Álbum";
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Location = new System.Drawing.Point(551, 84);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(51, 20);
            this.lbCancion.TabIndex = 1;
            this.lbCancion.Text = "label1";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(551, 184);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(51, 20);
            this.lbAlbum.TabIndex = 1;
            this.lbAlbum.Text = "label1";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.Location = new System.Drawing.Point(551, 129);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(51, 20);
            this.lbArtista.TabIndex = 1;
            this.lbArtista.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Reproducción";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproduccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarCancionesToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarCancionesToolStripMenuItem
            // 
            this.cargarCancionesToolStripMenuItem.Name = "cargarCancionesToolStripMenuItem";
            this.cargarCancionesToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.cargarCancionesToolStripMenuItem.Text = "Cargar canciones";
            this.cargarCancionesToolStripMenuItem.Click += new System.EventHandler(this.cargarCancionesToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // reproduccionToolStripMenuItem
            // 
            this.reproduccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.siguienteToolStripMenuItem,
            this.anteriorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reproducciónAutomáticaToolStripMenuItem,
            this.bucleToolStripMenuItem,
            this.aleatoriaToolStripMenuItem});
            this.reproduccionToolStripMenuItem.Name = "reproduccionToolStripMenuItem";
            this.reproduccionToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.reproduccionToolStripMenuItem.Text = "Reproducción";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.pausarToolStripMenuItem.Text = "Pausar";
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.siguienteToolStripMenuItem.Text = "Siguiente";
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.anteriorToolStripMenuItem.Text = "Anterior";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(316, 6);
            // 
            // reproducciónAutomáticaToolStripMenuItem
            // 
            this.reproducciónAutomáticaToolStripMenuItem.Name = "reproducciónAutomáticaToolStripMenuItem";
            this.reproducciónAutomáticaToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.reproducciónAutomáticaToolStripMenuItem.Text = "Reproducción Automática";
            // 
            // bucleToolStripMenuItem
            // 
            this.bucleToolStripMenuItem.Name = "bucleToolStripMenuItem";
            this.bucleToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.bucleToolStripMenuItem.Text = "Bucle";
            // 
            // aleatoriaToolStripMenuItem
            // 
            this.aleatoriaToolStripMenuItem.Name = "aleatoriaToolStripMenuItem";
            this.aleatoriaToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.aleatoriaToolStripMenuItem.Text = "Aleatoria";
            // 
            // timerCancion
            // 
            this.timerCancion.Interval = 1000;
            this.timerCancion.Tick += new System.EventHandler(this.timerCancion_Tick);
            // 
            // pbrTiempoTrans
            // 
            this.pbrTiempoTrans.Location = new System.Drawing.Point(423, 276);
            this.pbrTiempoTrans.Name = "pbrTiempoTrans";
            this.pbrTiempoTrans.Size = new System.Drawing.Size(552, 13);
            this.pbrTiempoTrans.TabIndex = 3;
            // 
            // lbTiempoTrans
            // 
            this.lbTiempoTrans.AutoSize = true;
            this.lbTiempoTrans.Location = new System.Drawing.Point(380, 276);
            this.lbTiempoTrans.Name = "lbTiempoTrans";
            this.lbTiempoTrans.Size = new System.Drawing.Size(18, 20);
            this.lbTiempoTrans.TabIndex = 1;
            this.lbTiempoTrans.Text = "0";
            // 
            // lbTiempoDuracion
            // 
            this.lbTiempoDuracion.AutoSize = true;
            this.lbTiempoDuracion.Location = new System.Drawing.Point(999, 269);
            this.lbTiempoDuracion.Name = "lbTiempoDuracion";
            this.lbTiempoDuracion.Size = new System.Drawing.Size(73, 20);
            this.lbTiempoDuracion.TabIndex = 1;
            this.lbTiempoDuracion.Text = "Duración";
            // 
            // FormRepro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 497);
            this.Controls.Add(this.pbrTiempoTrans);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lbTiempoDuracion);
            this.Controls.Add(this.lbTiempoTrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.lbArtista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listReproduccion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRepro";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRepro_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listReproduccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCancion;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCancionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reproducciónAutomáticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bucleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatoriaToolStripMenuItem;
        private System.Windows.Forms.Timer timerCancion;
        private System.Windows.Forms.ProgressBar pbrTiempoTrans;
        private System.Windows.Forms.Label lbTiempoTrans;
        private System.Windows.Forms.Label lbTiempoDuracion;
    }
}

