using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Cheques;
namespace persistenciaArchivos
{
    public partial class VerChequesForm : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        private readonly string userPassword = "El20Examen20Estaba20Faci20";
        public VerChequesForm()
        {
            InitializeComponent();
        }

        private void AgregarVButton_Click(object sender, EventArgs e)
        {
            CreateFilesForm createFile = new CreateFilesForm();
            createFile.ShowDialog();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerChequesForm_Load(object sender, EventArgs e)
        {
            Cheque cheque = new Cheque();
            string[] archivos = Directory.GetFiles(rutaPorDefecto, "*.csv");
            int n = 0;
            foreach (var x in archivos) 
            {
                
            }
        }
    }
}
