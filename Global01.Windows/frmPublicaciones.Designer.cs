namespace Global01.Windows
{
	partial class frmPublicaciones
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
			splitContainer1 = new SplitContainer();
			dgvPublicaciones = new DataGridView();
			colPublicacion = new DataGridViewTextBoxColumn();
			btnSalir = new Button();
			btnVender = new Button();
			dgvVentas = new DataGridView();
			colNombre = new DataGridViewTextBoxColumn();
			colCantidad = new DataGridViewTextBoxColumn();
			colImporte = new DataGridViewTextBoxColumn();
			panel1 = new Panel();
			lblTotal = new Label();
			lblCantidad = new Label();
			label2 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvPublicaciones).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(dgvPublicaciones);
			splitContainer1.Panel1.Controls.Add(btnSalir);
			splitContainer1.Panel1.Controls.Add(btnVender);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(dgvVentas);
			splitContainer1.Panel2.Controls.Add(panel1);
			splitContainer1.Size = new Size(1070, 572);
			splitContainer1.SplitterDistance = 527;
			splitContainer1.TabIndex = 0;
			// 
			// dgvPublicaciones
			// 
			dgvPublicaciones.AllowUserToAddRows = false;
			dgvPublicaciones.AllowUserToDeleteRows = false;
			dgvPublicaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPublicaciones.Columns.AddRange(new DataGridViewColumn[] { colPublicacion });
			dgvPublicaciones.Location = new Point(19, 21);
			dgvPublicaciones.MultiSelect = false;
			dgvPublicaciones.Name = "dgvPublicaciones";
			dgvPublicaciones.ReadOnly = true;
			dgvPublicaciones.RowTemplate.Height = 25;
			dgvPublicaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvPublicaciones.Size = new Size(481, 352);
			dgvPublicaciones.TabIndex = 2;
			// 
			// colPublicacion
			// 
			colPublicacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colPublicacion.HeaderText = "Publicación";
			colPublicacion.Name = "colPublicacion";
			colPublicacion.ReadOnly = true;
			// 
			// btnSalir
			// 
			btnSalir.Location = new Point(21, 478);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(479, 59);
			btnSalir.TabIndex = 1;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click;
			// 
			// btnVender
			// 
			btnVender.Location = new Point(16, 413);
			btnVender.Name = "btnVender";
			btnVender.Size = new Size(484, 59);
			btnVender.TabIndex = 1;
			btnVender.Text = "Vender";
			btnVender.UseVisualStyleBackColor = true;
			btnVender.Click += btnVender_Click;
			// 
			// dgvVentas
			// 
			dgvVentas.AllowUserToAddRows = false;
			dgvVentas.AllowUserToDeleteRows = false;
			dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colNombre, colCantidad, colImporte });
			dgvVentas.Dock = DockStyle.Fill;
			dgvVentas.Location = new Point(0, 0);
			dgvVentas.Name = "dgvVentas";
			dgvVentas.ReadOnly = true;
			dgvVentas.RowTemplate.Height = 25;
			dgvVentas.Size = new Size(539, 492);
			dgvVentas.TabIndex = 1;
			// 
			// colNombre
			// 
			colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colNombre.HeaderText = "Nombre";
			colNombre.Name = "colNombre";
			colNombre.ReadOnly = true;
			// 
			// colCantidad
			// 
			colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colCantidad.HeaderText = "Cantidad";
			colCantidad.Name = "colCantidad";
			colCantidad.ReadOnly = true;
			// 
			// colImporte
			// 
			colImporte.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colImporte.HeaderText = "Importe";
			colImporte.Name = "colImporte";
			colImporte.ReadOnly = true;
			// 
			// panel1
			// 
			panel1.Controls.Add(lblTotal);
			panel1.Controls.Add(lblCantidad);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 492);
			panel1.Name = "panel1";
			panel1.Size = new Size(539, 80);
			panel1.TabIndex = 0;
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblTotal.Location = new Point(460, 32);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(21, 15);
			lblTotal.TabIndex = 0;
			lblTotal.Text = "$0";
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblCantidad.Location = new Point(83, 32);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(14, 15);
			lblCantidad.TabIndex = 0;
			lblCantidad.Text = "0";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(396, 32);
			label2.Name = "label2";
			label2.Size = new Size(35, 15);
			label2.TabIndex = 0;
			label2.Text = "Total:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 32);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 0;
			label1.Text = "Cantidad:";
			// 
			// frmPublicaciones
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1070, 572);
			Controls.Add(splitContainer1);
			Name = "frmPublicaciones";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmPublicaciones";
			Load += frmPublicaciones_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvPublicaciones).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Button btnSalir;
		private Button btnVender;
		private ListBox lstPublicaciones;
		private Panel panel1;
		private DataGridView dgvVentas;
		private Label lblTotal;
		private Label lblCantidad;
		private Label label2;
		private Label label1;
		private DataGridView dgvPublicaciones;
		private DataGridViewTextBoxColumn colPublicacion;
		private DataGridViewTextBoxColumn colNombre;
		private DataGridViewTextBoxColumn colCantidad;
		private DataGridViewTextBoxColumn colImporte;
	}
}