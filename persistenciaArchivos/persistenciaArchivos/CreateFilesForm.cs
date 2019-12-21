using persistenciaArchivos.UNA.Cheques;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Cheques;

namespace persistenciaArchivos
{
    public partial class CreateFilesForm : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        private readonly string userPassword = "El20Examen20Estaba20Faci20";

        public CreateFilesForm()
        {
            InitializeComponent();
        }

        private void CreateFilesForm_Load(object sender, EventArgs e)
        {
            InformacionRutaLabel.Text = $"Los archivos serán creados por defecto en la ruta {rutaPorDefecto}";
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void LimpiarInterfaz()
        {
            NombreTXT.Text = "";
            NumeroChequeTXT.Text = "";
            MontoTXT.Text = "";
            DescripcionTXT.Text = "";
            receptorTXT.Text = "";
            institicionTXT.Text = "";
            monedaTXT.Text = "";


        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (InformacionEsValida())
            {
                Cheque cheque = RellenarCheque();
                ChequesDataGridView.Rows.Add(cheque.Nombre,cheque.Receptor,cheque.Fecha,cheque.Numero, cheque.Monto,cheque.Institucion, cheque.Descripcion,cheque.Moneda);
            }

        }

        private bool InformacionEsValida()
        {
            LimpiarErrorProviders();
            bool esValida = true;
            if (NombreTXT.Text.Length < 3)
            {
                esValida = false;
                ErrorProvider.SetError(NombreTXT, "Debe especificar un nombre de más de 3 caracteres");
            }
            if (NumeroChequeTXT.Text.Length < 5)
            {
                esValida = false;
                ErrorProvider.SetError(NumeroChequeTXT, "Debe especificar un número de cheque de más de 5 caracteres");
            }

            if (!EsUnValorNumerico(MontoTXT.Text))
            {
                esValida = false;
                ErrorProvider.SetError(MontoTXT, "Debe especificar un monto númerico");
            }
            if (DescripcionTXT.Text.Length < 10)
            {
                esValida = false;
                ErrorProvider.SetError(DescripcionTXT, "Debe especificar una Descripción de más de 10 caracteres");
            }
            return esValida;
        }

        private bool EsUnValorNumerico(string valor)
        {
            return Double.TryParse(valor, out _);
        }

        private Cheque RellenarCheque()
        {
            return new Cheque
            {
                Nombre = NombreTXT.Text,
                Receptor= receptorTXT.Text,
                Fecha= fechaDTP.Value,
                Numero = NumeroChequeTXT.Text,
                Monto = Convert.ToDouble(MontoTXT.Text),
                Institucion=institicionTXT.Text,
                Descripcion = DescripcionTXT.Text,
                Moneda= monedaTXT.Text,
            };
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool HayInformacionEnLaGrid()
        {
            return ChequesDataGridView.Rows.Count >= 1;
        }

        private void BorrarRenglonButton_Click(object sender, EventArgs e)
        {

            if (HayInformacionEnLaGrid())
            {
                LimpiarErrorProviders();
                ChequesDataGridView.Rows.RemoveAt(ChequesDataGridView.Rows.Count - 1);
            }
            else
            {
                InformationProvider.SetError(BorrarRenglonButton, "No hay renglones para borrar");
            }
        }

        private void CreateFilesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HayInformacionEnLaGrid() && DeseaCerrarSinGuardar())
            {
                e.Cancel = true;
            }

        }

        private bool DeseaCerrarSinGuardar()
        {
            return MessageBox.Show("No se ha guardado la información, realmente desea cerrar este formulario",
                                        "¿Desea Continuar?", MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void CrearArchivoButton_Click(object sender, EventArgs e)
        {
            if (HayInformacionEnLaGrid())
            {
                LimpiarErrorProviders();

                ArchivoManager archivoManager = new ArchivoManager();

                CargarInformacion(archivoManager);

                ConstruirElArchivo(archivoManager);

                ChequesDataGridView.Rows.Clear();
            }
            else
            {
                ErrorProvider.SetError(ChequesDataGridView, "No hay información para crear el archivo");
                InformationProvider.SetError(CrearArchivoButton, "Primero agregue información para crear el archivo");
            }
        }

        private void LimpiarErrorProviders()
        {
            ErrorProvider.SetError(NombreTXT, "");
            ErrorProvider.SetError(NumeroChequeTXT, "");
            ErrorProvider.SetError(MontoTXT, "");
            ErrorProvider.SetError(DescripcionTXT, "");

            ErrorProvider.SetError(ChequesDataGridView, "");
            InformationProvider.SetError(CrearArchivoButton, "");
            InformationProvider.SetError(CerrarButton, "");

        }

        private void CargarInformacion(ArchivoManager archivoManager)
        {
            for (int rowIndex = 0; rowIndex < ChequesDataGridView.Rows.Count; rowIndex++)
            {
                String descripcion = ChequesDataGridView.Rows[rowIndex].Cells[6].Value.ToString();
                string descripcionEncriptada = Encriptacion.EncriptarString(descripcion, userPassword);

                archivoManager.ChequesList.Add(new Cheque
                {
                    Nombre = ChequesDataGridView.Rows[rowIndex].Cells[0].Value.ToString(),
                    Receptor = ChequesDataGridView.Rows[rowIndex].Cells[1].Value.ToString(),
                    Fecha = Convert.ToDateTime(ChequesDataGridView.Rows[rowIndex].Cells[2].Value.ToString()),
                    Numero = ChequesDataGridView.Rows[rowIndex].Cells[3].Value.ToString(),
                    Monto = Convert.ToDouble(ChequesDataGridView.Rows[rowIndex].Cells[4].Value.ToString()),
                    Institucion = ChequesDataGridView.Rows[rowIndex].Cells[5].Value.ToString(),
                    Moneda = ChequesDataGridView.Rows[rowIndex].Cells[7].Value.ToString(),
                    
                    Descripcion = descripcionEncriptada,
                });
            }
        }

        private void ConstruirElArchivo(ArchivoManager archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearArchivo(rutaPorDefecto);
                MessageBox.Show($"El archivo {nombreNuevoArchivo} se creo de manera correcta", "Excelente!", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Se ha presentado el siguiente inconveniente al crear el archivo: {exception.Message}", "Atención", MessageBoxButtons.OK);
            }
        }

    }
}
