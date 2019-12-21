namespace persistenciaArchivos
{
    partial class CreateFilesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilesForm));
            this.CerrarButton = new System.Windows.Forms.Button();
            this.CrearArchivoButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpsertPanel = new System.Windows.Forms.Panel();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTXT = new System.Windows.Forms.TextBox();
            this.DescripcionLlabel = new System.Windows.Forms.Label();
            this.DescripcionTXT = new System.Windows.Forms.TextBox();
            this.NumeroChequeLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NumeroChequeTXT = new System.Windows.Forms.TextBox();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.InformacionRutaLabel = new System.Windows.Forms.Label();
            this.BorrarRenglonButton = new System.Windows.Forms.Button();
            this.InformationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.emisorDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptorDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroChequeDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institucionDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptorLBL = new System.Windows.Forms.Label();
            this.receptorTXT = new System.Windows.Forms.TextBox();
            this.fechaDTP = new System.Windows.Forms.DateTimePicker();
            this.fechaLBL = new System.Windows.Forms.Label();
            this.instucionLBL = new System.Windows.Forms.Label();
            this.institicionTXT = new System.Windows.Forms.TextBox();
            this.monedaLBL = new System.Windows.Forms.Label();
            this.monedaTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.UpsertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(273, 338);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CrearArchivoButton
            // 
            this.CrearArchivoButton.Location = new System.Drawing.Point(657, 338);
            this.CrearArchivoButton.Name = "CrearArchivoButton";
            this.CrearArchivoButton.Size = new System.Drawing.Size(93, 23);
            this.CrearArchivoButton.TabIndex = 11;
            this.CrearArchivoButton.Text = "Crear Archivo";
            this.CrearArchivoButton.UseVisualStyleBackColor = true;
            this.CrearArchivoButton.Click += new System.EventHandler(this.CrearArchivoButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // UpsertPanel
            // 
            this.UpsertPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UpsertPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.UpsertPanel.Controls.Add(this.monedaTXT);
            this.UpsertPanel.Controls.Add(this.monedaLBL);
            this.UpsertPanel.Controls.Add(this.institicionTXT);
            this.UpsertPanel.Controls.Add(this.instucionLBL);
            this.UpsertPanel.Controls.Add(this.fechaLBL);
            this.UpsertPanel.Controls.Add(this.fechaDTP);
            this.UpsertPanel.Controls.Add(this.receptorTXT);
            this.UpsertPanel.Controls.Add(this.receptorLBL);
            this.UpsertPanel.Controls.Add(this.MontoLabel);
            this.UpsertPanel.Controls.Add(this.MontoTXT);
            this.UpsertPanel.Controls.Add(this.DescripcionLlabel);
            this.UpsertPanel.Controls.Add(this.DescripcionTXT);
            this.UpsertPanel.Controls.Add(this.NumeroChequeLabel);
            this.UpsertPanel.Controls.Add(this.NombreLabel);
            this.UpsertPanel.Controls.Add(this.NumeroChequeTXT);
            this.UpsertPanel.Controls.Add(this.NombreTXT);
            this.UpsertPanel.Controls.Add(this.AgregarButton);
            this.UpsertPanel.Controls.Add(this.LimpiarButton);
            this.UpsertPanel.Location = new System.Drawing.Point(0, 0);
            this.UpsertPanel.Name = "UpsertPanel";
            this.UpsertPanel.Size = new System.Drawing.Size(251, 375);
            this.UpsertPanel.TabIndex = 12;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.ForeColor = System.Drawing.Color.White;
            this.MontoLabel.Location = new System.Drawing.Point(18, 165);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(110, 13);
            this.MontoLabel.TabIndex = 20;
            this.MontoLabel.Text = "Monto (Solo números)";
            // 
            // MontoTXT
            // 
            this.MontoTXT.Location = new System.Drawing.Point(21, 181);
            this.MontoTXT.Name = "MontoTXT";
            this.MontoTXT.Size = new System.Drawing.Size(205, 20);
            this.MontoTXT.TabIndex = 4;
            // 
            // DescripcionLlabel
            // 
            this.DescripcionLlabel.AutoSize = true;
            this.DescripcionLlabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLlabel.Location = new System.Drawing.Point(18, 243);
            this.DescripcionLlabel.Name = "DescripcionLlabel";
            this.DescripcionLlabel.Size = new System.Drawing.Size(212, 13);
            this.DescripcionLlabel.TabIndex = 18;
            this.DescripcionLlabel.Text = "Descripción( min 10 caractéres, encriptada)";
            // 
            // DescripcionTXT
            // 
            this.DescripcionTXT.Location = new System.Drawing.Point(21, 258);
            this.DescripcionTXT.Multiline = true;
            this.DescripcionTXT.Name = "DescripcionTXT";
            this.DescripcionTXT.Size = new System.Drawing.Size(205, 32);
            this.DescripcionTXT.TabIndex = 6;
            // 
            // NumeroChequeLabel
            // 
            this.NumeroChequeLabel.AutoSize = true;
            this.NumeroChequeLabel.ForeColor = System.Drawing.Color.White;
            this.NumeroChequeLabel.Location = new System.Drawing.Point(18, 126);
            this.NumeroChequeLabel.Name = "NumeroChequeLabel";
            this.NumeroChequeLabel.Size = new System.Drawing.Size(185, 13);
            this.NumeroChequeLabel.TabIndex = 16;
            this.NumeroChequeLabel.Text = "Número de cheque (min 5 caractéres)";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.ForeColor = System.Drawing.Color.White;
            this.NombreLabel.Location = new System.Drawing.Point(18, 12);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(131, 13);
            this.NombreLabel.TabIndex = 15;
            this.NombreLabel.Text = "Nombre (min 3 caractéres)";
            // 
            // NumeroChequeTXT
            // 
            this.NumeroChequeTXT.Location = new System.Drawing.Point(21, 142);
            this.NumeroChequeTXT.Name = "NumeroChequeTXT";
            this.NumeroChequeTXT.Size = new System.Drawing.Size(205, 20);
            this.NumeroChequeTXT.TabIndex = 3;
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(21, 28);
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(205, 20);
            this.NombreTXT.TabIndex = 0;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(151, 336);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(21, 336);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ListaChequesLabel
            // 
            this.ListaChequesLabel.AutoSize = true;
            this.ListaChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListaChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaChequesLabel.ForeColor = System.Drawing.Color.Black;
            this.ListaChequesLabel.Location = new System.Drawing.Point(448, 12);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(169, 24);
            this.ListaChequesLabel.TabIndex = 15;
            this.ListaChequesLabel.Text = "Lista de cheques";
            // 
            // InformacionRutaLabel
            // 
            this.InformacionRutaLabel.Location = new System.Drawing.Point(279, 37);
            this.InformacionRutaLabel.Name = "InformacionRutaLabel";
            this.InformacionRutaLabel.Size = new System.Drawing.Size(471, 41);
            this.InformacionRutaLabel.TabIndex = 16;
            this.InformacionRutaLabel.Text = "@InformacionRutaArchivos";
            // 
            // BorrarRenglonButton
            // 
            this.BorrarRenglonButton.Location = new System.Drawing.Point(373, 338);
            this.BorrarRenglonButton.Name = "BorrarRenglonButton";
            this.BorrarRenglonButton.Size = new System.Drawing.Size(95, 23);
            this.BorrarRenglonButton.TabIndex = 11;
            this.BorrarRenglonButton.Text = "Borrar renglón";
            this.BorrarRenglonButton.UseVisualStyleBackColor = true;
            this.BorrarRenglonButton.Click += new System.EventHandler(this.BorrarRenglonButton_Click);
            // 
            // InformationProvider
            // 
            this.InformationProvider.ContainerControl = this;
            this.InformationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InformationProvider.Icon")));
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emisorDTG,
            this.receptorDTG,
            this.fechaDTG,
            this.numeroChequeDTG,
            this.montoDTG,
            this.institucionDTG,
            this.descripcionDTG,
            this.monedaDTG});
            this.ChequesDataGridView.Location = new System.Drawing.Point(257, 81);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.Size = new System.Drawing.Size(519, 236);
            this.ChequesDataGridView.TabIndex = 17;
            // 
            // emisorDTG
            // 
            this.emisorDTG.HeaderText = "Emisor";
            this.emisorDTG.Name = "emisorDTG";
            this.emisorDTG.ReadOnly = true;
            // 
            // receptorDTG
            // 
            this.receptorDTG.HeaderText = "Receptor";
            this.receptorDTG.Name = "receptorDTG";
            this.receptorDTG.ReadOnly = true;
            // 
            // fechaDTG
            // 
            this.fechaDTG.HeaderText = "Fecha";
            this.fechaDTG.Name = "fechaDTG";
            this.fechaDTG.ReadOnly = true;
            // 
            // numeroChequeDTG
            // 
            this.numeroChequeDTG.HeaderText = "Numero de cheque";
            this.numeroChequeDTG.Name = "numeroChequeDTG";
            this.numeroChequeDTG.ReadOnly = true;
            // 
            // montoDTG
            // 
            this.montoDTG.HeaderText = "Monto";
            this.montoDTG.Name = "montoDTG";
            this.montoDTG.ReadOnly = true;
            // 
            // institucionDTG
            // 
            this.institucionDTG.HeaderText = "Institucion financiera";
            this.institucionDTG.Name = "institucionDTG";
            this.institucionDTG.ReadOnly = true;
            // 
            // descripcionDTG
            // 
            this.descripcionDTG.HeaderText = "Descripción";
            this.descripcionDTG.Name = "descripcionDTG";
            this.descripcionDTG.ReadOnly = true;
            // 
            // monedaDTG
            // 
            this.monedaDTG.HeaderText = "Moneda";
            this.monedaDTG.Name = "monedaDTG";
            this.monedaDTG.ReadOnly = true;
            // 
            // receptorLBL
            // 
            this.receptorLBL.AutoSize = true;
            this.receptorLBL.ForeColor = System.Drawing.Color.White;
            this.receptorLBL.Location = new System.Drawing.Point(18, 51);
            this.receptorLBL.Name = "receptorLBL";
            this.receptorLBL.Size = new System.Drawing.Size(138, 13);
            this.receptorLBL.TabIndex = 21;
            this.receptorLBL.Text = "Receptor (min 3 caractéres)";
            // 
            // receptorTXT
            // 
            this.receptorTXT.Location = new System.Drawing.Point(21, 67);
            this.receptorTXT.Name = "receptorTXT";
            this.receptorTXT.Size = new System.Drawing.Size(205, 20);
            this.receptorTXT.TabIndex = 1;
            // 
            // fechaDTP
            // 
            this.fechaDTP.Location = new System.Drawing.Point(21, 103);
            this.fechaDTP.Name = "fechaDTP";
            this.fechaDTP.Size = new System.Drawing.Size(200, 20);
            this.fechaDTP.TabIndex = 2;
            // 
            // fechaLBL
            // 
            this.fechaLBL.AutoSize = true;
            this.fechaLBL.ForeColor = System.Drawing.Color.White;
            this.fechaLBL.Location = new System.Drawing.Point(18, 90);
            this.fechaLBL.Name = "fechaLBL";
            this.fechaLBL.Size = new System.Drawing.Size(37, 13);
            this.fechaLBL.TabIndex = 24;
            this.fechaLBL.Text = "Fecha";
            // 
            // instucionLBL
            // 
            this.instucionLBL.AutoSize = true;
            this.instucionLBL.ForeColor = System.Drawing.Color.White;
            this.instucionLBL.Location = new System.Drawing.Point(18, 204);
            this.instucionLBL.Name = "instucionLBL";
            this.instucionLBL.Size = new System.Drawing.Size(191, 13);
            this.instucionLBL.TabIndex = 25;
            this.instucionLBL.Text = "Institución financiera (min 5 caractéres)";
            // 
            // institicionTXT
            // 
            this.institicionTXT.Location = new System.Drawing.Point(21, 220);
            this.institicionTXT.Name = "institicionTXT";
            this.institicionTXT.Size = new System.Drawing.Size(205, 20);
            this.institicionTXT.TabIndex = 5;
            // 
            // monedaLBL
            // 
            this.monedaLBL.AutoSize = true;
            this.monedaLBL.ForeColor = System.Drawing.Color.White;
            this.monedaLBL.Location = new System.Drawing.Point(18, 293);
            this.monedaLBL.Name = "monedaLBL";
            this.monedaLBL.Size = new System.Drawing.Size(46, 13);
            this.monedaLBL.TabIndex = 27;
            this.monedaLBL.Text = "Moneda";
            // 
            // monedaTXT
            // 
            this.monedaTXT.Location = new System.Drawing.Point(21, 309);
            this.monedaTXT.Name = "monedaTXT";
            this.monedaTXT.Size = new System.Drawing.Size(205, 20);
            this.monedaTXT.TabIndex = 7;
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 373);
            this.Controls.Add(this.ChequesDataGridView);
            this.Controls.Add(this.InformacionRutaLabel);
            this.Controls.Add(this.BorrarRenglonButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.UpsertPanel);
            this.Controls.Add(this.CrearArchivoButton);
            this.Controls.Add(this.ListaChequesLabel);
            this.Name = "CreateFilesForm";
            this.Text = "Información de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFilesForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.UpsertPanel.ResumeLayout(false);
            this.UpsertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button CrearArchivoButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel UpsertPanel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox MontoTXT;
        private System.Windows.Forms.Label DescripcionLlabel;
        private System.Windows.Forms.TextBox DescripcionTXT;
        private System.Windows.Forms.Label NumeroChequeLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NumeroChequeTXT;
        private System.Windows.Forms.TextBox NombreTXT;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label InformacionRutaLabel;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.Button BorrarRenglonButton;
        private System.Windows.Forms.ErrorProvider InformationProvider;
        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisorDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptorDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroChequeDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn institucionDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaDTG;
        private System.Windows.Forms.Label fechaLBL;
        private System.Windows.Forms.DateTimePicker fechaDTP;
        private System.Windows.Forms.TextBox receptorTXT;
        private System.Windows.Forms.Label receptorLBL;
        private System.Windows.Forms.TextBox monedaTXT;
        private System.Windows.Forms.Label monedaLBL;
        private System.Windows.Forms.TextBox institicionTXT;
        private System.Windows.Forms.Label instucionLBL;
    }
}

