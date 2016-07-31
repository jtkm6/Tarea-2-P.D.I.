namespace PDI_Tarea_2 {
	partial class Form {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.imagenBox = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.imageInfoBox = new System.Windows.Forms.GroupBox();
			this.fileDimentions = new System.Windows.Forms.Label();
			this.bitsProfundidad = new System.Windows.Forms.Label();
			this.fileMb = new System.Windows.Forms.Label();
			this.fileName = new System.Windows.Forms.Label();
			this.textBitsInfo = new System.Windows.Forms.Label();
			this.textImageMB = new System.Windows.Forms.Label();
			this.textImageSize = new System.Windows.Forms.Label();
			this.textImageName = new System.Windows.Forms.Label();
			this.primariMenu = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.basicControlBox = new System.Windows.Forms.GroupBox();
			this.zoomOut = new System.Windows.Forms.Button();
			this.zoomIn = new System.Windows.Forms.Button();
			this.negativo = new System.Windows.Forms.Button();
			this.flipVertical = new System.Windows.Forms.Button();
			this.flipHorizontal = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textNoBrillo = new System.Windows.Forms.Label();
			this.textTotalBrillo = new System.Windows.Forms.Label();
			this.textCeroBrillo = new System.Windows.Forms.Label();
			this.trackBarBrillo = new System.Windows.Forms.TrackBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textNadaContraste = new System.Windows.Forms.Label();
			this.textTodoContraste = new System.Windows.Forms.Label();
			this.textCeroContraste = new System.Windows.Forms.Label();
			this.trackBarContraste = new System.Windows.Forms.TrackBar();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBarUmbral = new System.Windows.Forms.TrackBar();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.trackBarRotacion = new System.Windows.Forms.TrackBar();
			this.interpolaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nearestNeighborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bilinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imagenBox.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.histogram)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.imageInfoBox.SuspendLayout();
			this.primariMenu.SuspendLayout();
			this.basicControlBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBrillo)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarContraste)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarUmbral)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRotacion)).BeginInit();
			this.SuspendLayout();
			// 
			// imagenBox
			// 
			resources.ApplyResources(this.imagenBox, "imagenBox");
			this.imagenBox.Controls.Add(this.panel1);
			this.imagenBox.Controls.Add(this.pictureBox);
			this.imagenBox.Name = "imagenBox";
			this.imagenBox.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.histogram);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// histogram
			// 
			this.histogram.BackColor = System.Drawing.Color.Transparent;
			this.histogram.BackImageTransparentColor = System.Drawing.Color.Transparent;
			this.histogram.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
			this.histogram.BackSecondaryColor = System.Drawing.Color.Transparent;
			this.histogram.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea4.BackColor = System.Drawing.Color.Transparent;
			chartArea4.BackImageTransparentColor = System.Drawing.Color.Transparent;
			chartArea4.Name = "ChartArea1";
			this.histogram.ChartAreas.Add(chartArea4);
			this.histogram.Cursor = System.Windows.Forms.Cursors.Cross;
			resources.ApplyResources(this.histogram, "histogram");
			this.histogram.Name = "histogram";
			this.histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.histogram.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Green,
        System.Drawing.Color.Blue};
			series10.ChartArea = "ChartArea1";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series10.Name = "R";
			series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			series11.ChartArea = "ChartArea1";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series11.Name = "G";
			series12.ChartArea = "ChartArea1";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series12.Name = "B";
			series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			this.histogram.Series.Add(series10);
			this.histogram.Series.Add(series11);
			this.histogram.Series.Add(series12);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
			resources.ApplyResources(this.pictureBox, "pictureBox");
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.TabStop = false;
			// 
			// imageInfoBox
			// 
			resources.ApplyResources(this.imageInfoBox, "imageInfoBox");
			this.imageInfoBox.Controls.Add(this.fileDimentions);
			this.imageInfoBox.Controls.Add(this.bitsProfundidad);
			this.imageInfoBox.Controls.Add(this.fileMb);
			this.imageInfoBox.Controls.Add(this.fileName);
			this.imageInfoBox.Controls.Add(this.textBitsInfo);
			this.imageInfoBox.Controls.Add(this.textImageMB);
			this.imageInfoBox.Controls.Add(this.textImageSize);
			this.imageInfoBox.Controls.Add(this.textImageName);
			this.imageInfoBox.Name = "imageInfoBox";
			this.imageInfoBox.TabStop = false;
			// 
			// fileDimentions
			// 
			resources.ApplyResources(this.fileDimentions, "fileDimentions");
			this.fileDimentions.Name = "fileDimentions";
			// 
			// bitsProfundidad
			// 
			resources.ApplyResources(this.bitsProfundidad, "bitsProfundidad");
			this.bitsProfundidad.Name = "bitsProfundidad";
			// 
			// fileMb
			// 
			resources.ApplyResources(this.fileMb, "fileMb");
			this.fileMb.Name = "fileMb";
			// 
			// fileName
			// 
			resources.ApplyResources(this.fileName, "fileName");
			this.fileName.Name = "fileName";
			// 
			// textBitsInfo
			// 
			resources.ApplyResources(this.textBitsInfo, "textBitsInfo");
			this.textBitsInfo.Name = "textBitsInfo";
			// 
			// textImageMB
			// 
			resources.ApplyResources(this.textImageMB, "textImageMB");
			this.textImageMB.Name = "textImageMB";
			// 
			// textImageSize
			// 
			resources.ApplyResources(this.textImageSize, "textImageSize");
			this.textImageSize.Name = "textImageSize";
			// 
			// textImageName
			// 
			resources.ApplyResources(this.textImageName, "textImageName");
			this.textImageName.Name = "textImageName";
			// 
			// primariMenu
			// 
			this.primariMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.interpolaciónToolStripMenuItem});
			resources.ApplyResources(this.primariMenu, "primariMenu");
			this.primariMenu.Name = "primariMenu";
			this.primariMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
			// 
			// abrirToolStripMenuItem
			// 
			resources.ApplyResources(this.abrirToolStripMenuItem, "abrirToolStripMenuItem");
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
			// 
			// guardarToolStripMenuItem
			// 
			resources.ApplyResources(this.guardarToolStripMenuItem, "guardarToolStripMenuItem");
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
			// 
			// guardarComoToolStripMenuItem
			// 
			resources.ApplyResources(this.guardarComoToolStripMenuItem, "guardarComoToolStripMenuItem");
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
			// 
			// verToolStripMenuItem
			// 
			this.verToolStripMenuItem.Name = "verToolStripMenuItem";
			resources.ApplyResources(this.verToolStripMenuItem, "verToolStripMenuItem");
			this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
			// 
			// basicControlBox
			// 
			resources.ApplyResources(this.basicControlBox, "basicControlBox");
			this.basicControlBox.Controls.Add(this.zoomOut);
			this.basicControlBox.Controls.Add(this.zoomIn);
			this.basicControlBox.Controls.Add(this.negativo);
			this.basicControlBox.Controls.Add(this.flipVertical);
			this.basicControlBox.Controls.Add(this.flipHorizontal);
			this.basicControlBox.Name = "basicControlBox";
			this.basicControlBox.TabStop = false;
			// 
			// zoomOut
			// 
			this.zoomOut.Image = global::PDI_Tarea_2.Properties.Resources.zoom_out;
			resources.ApplyResources(this.zoomOut, "zoomOut");
			this.zoomOut.Name = "zoomOut";
			this.zoomOut.UseVisualStyleBackColor = true;
			this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
			// 
			// zoomIn
			// 
			this.zoomIn.Image = global::PDI_Tarea_2.Properties.Resources.zoom_in;
			resources.ApplyResources(this.zoomIn, "zoomIn");
			this.zoomIn.Name = "zoomIn";
			this.zoomIn.UseVisualStyleBackColor = true;
			this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
			// 
			// negativo
			// 
			resources.ApplyResources(this.negativo, "negativo");
			this.negativo.Name = "negativo";
			this.negativo.UseVisualStyleBackColor = true;
			this.negativo.Click += new System.EventHandler(this.negativo_Click);
			// 
			// flipVertical
			// 
			resources.ApplyResources(this.flipVertical, "flipVertical");
			this.flipVertical.Name = "flipVertical";
			this.flipVertical.UseVisualStyleBackColor = true;
			this.flipVertical.Click += new System.EventHandler(this.flipVertical_Click);
			// 
			// flipHorizontal
			// 
			resources.ApplyResources(this.flipHorizontal, "flipHorizontal");
			this.flipHorizontal.Name = "flipHorizontal";
			this.flipHorizontal.UseVisualStyleBackColor = true;
			this.flipHorizontal.Click += new System.EventHandler(this.flipHorizontal_Click);
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.textNoBrillo);
			this.groupBox1.Controls.Add(this.textTotalBrillo);
			this.groupBox1.Controls.Add(this.textCeroBrillo);
			this.groupBox1.Controls.Add(this.trackBarBrillo);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// textNoBrillo
			// 
			resources.ApplyResources(this.textNoBrillo, "textNoBrillo");
			this.textNoBrillo.Name = "textNoBrillo";
			// 
			// textTotalBrillo
			// 
			resources.ApplyResources(this.textTotalBrillo, "textTotalBrillo");
			this.textTotalBrillo.Name = "textTotalBrillo";
			// 
			// textCeroBrillo
			// 
			resources.ApplyResources(this.textCeroBrillo, "textCeroBrillo");
			this.textCeroBrillo.Name = "textCeroBrillo";
			// 
			// trackBarBrillo
			// 
			resources.ApplyResources(this.trackBarBrillo, "trackBarBrillo");
			this.trackBarBrillo.Maximum = 255;
			this.trackBarBrillo.Minimum = -255;
			this.trackBarBrillo.Name = "trackBarBrillo";
			this.trackBarBrillo.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarBrillo.ValueChanged += new System.EventHandler(this.trackBarBrillo_ValueChanged);
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this.textNadaContraste);
			this.groupBox2.Controls.Add(this.textTodoContraste);
			this.groupBox2.Controls.Add(this.textCeroContraste);
			this.groupBox2.Controls.Add(this.trackBarContraste);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// textNadaContraste
			// 
			resources.ApplyResources(this.textNadaContraste, "textNadaContraste");
			this.textNadaContraste.Name = "textNadaContraste";
			// 
			// textTodoContraste
			// 
			resources.ApplyResources(this.textTodoContraste, "textTodoContraste");
			this.textTodoContraste.Name = "textTodoContraste";
			// 
			// textCeroContraste
			// 
			resources.ApplyResources(this.textCeroContraste, "textCeroContraste");
			this.textCeroContraste.Name = "textCeroContraste";
			// 
			// trackBarContraste
			// 
			resources.ApplyResources(this.trackBarContraste, "trackBarContraste");
			this.trackBarContraste.Maximum = 300;
			this.trackBarContraste.Minimum = -300;
			this.trackBarContraste.Name = "trackBarContraste";
			this.trackBarContraste.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarContraste.ValueChanged += new System.EventHandler(this.trackBarContraste_ValueChanged);
			// 
			// groupBox3
			// 
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.Controls.Add(this.checkBox2);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// checkBox2
			// 
			resources.ApplyResources(this.checkBox2, "checkBox2");
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox1
			// 
			resources.ApplyResources(this.checkBox1, "checkBox1");
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// groupBox4
			// 
			resources.ApplyResources(this.groupBox4, "groupBox4");
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.trackBarUmbral);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// trackBarUmbral
			// 
			resources.ApplyResources(this.trackBarUmbral, "trackBarUmbral");
			this.trackBarUmbral.Maximum = 255;
			this.trackBarUmbral.Name = "trackBarUmbral";
			this.trackBarUmbral.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarUmbral.Value = 127;
			this.trackBarUmbral.ValueChanged += new System.EventHandler(this.trackBarUmbral_ValueChanged);
			// 
			// groupBox5
			// 
			resources.ApplyResources(this.groupBox5, "groupBox5");
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.trackBarRotacion);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.TabStop = false;
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// trackBarRotacion
			// 
			resources.ApplyResources(this.trackBarRotacion, "trackBarRotacion");
			this.trackBarRotacion.Maximum = 360;
			this.trackBarRotacion.Name = "trackBarRotacion";
			this.trackBarRotacion.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarRotacion.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// interpolaciónToolStripMenuItem
			// 
			this.interpolaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nearestNeighborToolStripMenuItem,
            this.bilinealToolStripMenuItem});
			this.interpolaciónToolStripMenuItem.Name = "interpolaciónToolStripMenuItem";
			resources.ApplyResources(this.interpolaciónToolStripMenuItem, "interpolaciónToolStripMenuItem");
			// 
			// nearestNeighborToolStripMenuItem
			// 
			this.nearestNeighborToolStripMenuItem.Checked = true;
			this.nearestNeighborToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			resources.ApplyResources(this.nearestNeighborToolStripMenuItem, "nearestNeighborToolStripMenuItem");
			this.nearestNeighborToolStripMenuItem.Name = "nearestNeighborToolStripMenuItem";
			this.nearestNeighborToolStripMenuItem.Click += new System.EventHandler(this.nearestNeighborToolStripMenuItem_Click);
			// 
			// bilinealToolStripMenuItem
			// 
			this.bilinealToolStripMenuItem.Name = "bilinealToolStripMenuItem";
			resources.ApplyResources(this.bilinealToolStripMenuItem, "bilinealToolStripMenuItem");
			this.bilinealToolStripMenuItem.Click += new System.EventHandler(this.bilinealToolStripMenuItem_Click);
			// 
			// Form
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.basicControlBox);
			this.Controls.Add(this.imageInfoBox);
			this.Controls.Add(this.imagenBox);
			this.Controls.Add(this.primariMenu);
			this.MainMenuStrip = this.primariMenu;
			this.Name = "Form";
			this.imagenBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.histogram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.imageInfoBox.ResumeLayout(false);
			this.imageInfoBox.PerformLayout();
			this.primariMenu.ResumeLayout(false);
			this.primariMenu.PerformLayout();
			this.basicControlBox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBrillo)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarContraste)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarUmbral)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRotacion)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox imagenBox;
		private System.Windows.Forms.GroupBox imageInfoBox;
		private System.Windows.Forms.MenuStrip primariMenu;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.GroupBox basicControlBox;
		private System.Windows.Forms.Button negativo;
		private System.Windows.Forms.Button flipVertical;
		private System.Windows.Forms.Button flipHorizontal;
		private System.Windows.Forms.Label textImageMB;
		private System.Windows.Forms.Label textImageSize;
		private System.Windows.Forms.Label textImageName;
		private System.Windows.Forms.Label textBitsInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TrackBar trackBarBrillo;
		private System.Windows.Forms.Label textNoBrillo;
		private System.Windows.Forms.Label textTotalBrillo;
		private System.Windows.Forms.Label textCeroBrillo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label textNadaContraste;
		private System.Windows.Forms.Label textTodoContraste;
		private System.Windows.Forms.Label textCeroContraste;
		private System.Windows.Forms.TrackBar trackBarContraste;
		private System.Windows.Forms.DataVisualization.Charting.Chart histogram;
		private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
		private System.Windows.Forms.Label fileName;
		private System.Windows.Forms.Label fileDimentions;
		private System.Windows.Forms.Label bitsProfundidad;
		private System.Windows.Forms.Label fileMb;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBarUmbral;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar trackBarRotacion;
		private System.Windows.Forms.Button zoomIn;
		private System.Windows.Forms.Button zoomOut;
		private System.Windows.Forms.ToolStripMenuItem interpolaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nearestNeighborToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bilinealToolStripMenuItem;
	}
}

