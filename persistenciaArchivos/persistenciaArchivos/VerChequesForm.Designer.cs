namespace persistenciaArchivos
{
    partial class VerChequesForm
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
            this.ChequesVDataGridView = new System.Windows.Forms.DataGridView();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.AgregarVButton = new System.Windows.Forms.Button();
            this.refrescarBtn = new System.Windows.Forms.Button();
            this.emisorVDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptorVDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroChequeVDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoVDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institucionVDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionVDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaVDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesVDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChequesVDataGridView
            // 
            this.ChequesVDataGridView.AllowUserToAddRows = false;
            this.ChequesVDataGridView.AllowUserToDeleteRows = false;
            this.ChequesVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesVDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emisorVDTG,
            this.receptorVDTG,
            this.fechaVDTG,
            this.numeroChequeVDTG,
            this.montoVDTG,
            this.institucionVDTG,
            this.descripcionVDTG,
            this.monedaVDTG});
            this.ChequesVDataGridView.Location = new System.Drawing.Point(12, 86);
            this.ChequesVDataGridView.Name = "ChequesVDataGridView";
            this.ChequesVDataGridView.ReadOnly = true;
            this.ChequesVDataGridView.Size = new System.Drawing.Size(759, 307);
            this.ChequesVDataGridView.TabIndex = 18;
            // 
            // ListaChequesLabel
            // 
            this.ListaChequesLabel.AutoSize = true;
            this.ListaChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListaChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaChequesLabel.ForeColor = System.Drawing.Color.Black;
            this.ListaChequesLabel.Location = new System.Drawing.Point(276, 36);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(169, 24);
            this.ListaChequesLabel.TabIndex = 19;
            this.ListaChequesLabel.Text = "Lista de cheques";
            // 
            // AgregarVButton
            // 
            this.AgregarVButton.Location = new System.Drawing.Point(696, 399);
            this.AgregarVButton.Name = "AgregarVButton";
            this.AgregarVButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarVButton.TabIndex = 20;
            this.AgregarVButton.Text = "Agregar";
            this.AgregarVButton.UseVisualStyleBackColor = true;
            this.AgregarVButton.Click += new System.EventHandler(this.AgregarVButton_Click);
            // 
            // refrescarBtn
            // 
            this.refrescarBtn.Location = new System.Drawing.Point(595, 399);
            this.refrescarBtn.Name = "refrescarBtn";
            this.refrescarBtn.Size = new System.Drawing.Size(75, 23);
            this.refrescarBtn.TabIndex = 21;
            this.refrescarBtn.Text = "Refrescar";
            this.refrescarBtn.UseVisualStyleBackColor = true;
            // 
            // emisorVDTG
            // 
            this.emisorVDTG.HeaderText = "Emisor";
            this.emisorVDTG.Name = "emisorVDTG";
            this.emisorVDTG.ReadOnly = true;
            // 
            // receptorVDTG
            // 
            this.receptorVDTG.HeaderText = "Receptor";
            this.receptorVDTG.Name = "receptorVDTG";
            this.receptorVDTG.ReadOnly = true;
            // 
            // fechaVDTG
            // 
            this.fechaVDTG.HeaderText = "Fecha";
            this.fechaVDTG.Name = "fechaVDTG";
            this.fechaVDTG.ReadOnly = true;
            // 
            // numeroChequeVDTG
            // 
            this.numeroChequeVDTG.HeaderText = "Numero de cheque";
            this.numeroChequeVDTG.Name = "numeroChequeVDTG";
            this.numeroChequeVDTG.ReadOnly = true;
            // 
            // montoVDTG
            // 
            this.montoVDTG.HeaderText = "Monto";
            this.montoVDTG.Name = "montoVDTG";
            this.montoVDTG.ReadOnly = true;
            // 
            // institucionVDTG
            // 
            this.institucionVDTG.HeaderText = "Institucion financiera";
            this.institucionVDTG.Name = "institucionVDTG";
            this.institucionVDTG.ReadOnly = true;
            // 
            // descripcionVDTG
            // 
            this.descripcionVDTG.HeaderText = "Descripción";
            this.descripcionVDTG.Name = "descripcionVDTG";
            this.descripcionVDTG.ReadOnly = true;
            // 
            // monedaVDTG
            // 
            this.monedaVDTG.HeaderText = "Moneda";
            this.monedaVDTG.Name = "monedaVDTG";
            this.monedaVDTG.ReadOnly = true;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(21, 399);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 22;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // VerChequesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.refrescarBtn);
            this.Controls.Add(this.AgregarVButton);
            this.Controls.Add(this.ListaChequesLabel);
            this.Controls.Add(this.ChequesVDataGridView);
            this.Name = "VerChequesForm";
            this.Text = "VerChequesForm";
            this.Load += new System.EventHandler(this.VerChequesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesVDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesVDataGridView;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.Button AgregarVButton;
        private System.Windows.Forms.Button refrescarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisorVDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptorVDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroChequeVDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoVDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn institucionVDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionVDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaVDTG;
        private System.Windows.Forms.Button CerrarButton;
    }
}