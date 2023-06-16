using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2_Tema_1
{



    public partial class Form1 : Form
    {

        //Declaracion de las listas de los Vehiculos
        List<Tesla> listaTeslas = new List<Tesla>();
        //List<SpaceX> listaSpaceX = new List<SpaceX>();


        public Form1()
        {
            InitializeComponent();


            //El combo con las marcas
            comboMarca.Items.Add("Tesla");
            comboMarca.Items.Add("SpaceX");


        }

        public class Tesla
        {
            //Creacion de la clase Tesla
            public string Modelo { get; set; }
            public int Anio { get; set; }
            public double kmsActual { get; set; }
            public string Color { get; set; }
            public string Duenio { get; set; }

            //Constructor
            public Tesla(string Modelo, int Anio, double kmsActual, string Color, string Duenio)
            {
                this.Modelo = Modelo;
                this.Anio = Anio;
                this.kmsActual = kmsActual;
                this.Color = Color;
                this.Duenio = Duenio;
            }


        }
        //Declaracion por herencia de ModeloX
        public class ModeloX : Tesla
        {
            // Declaración de las propiedades específicas
            public static int Autonomia { get; } = 560;
            public static int Asientos { get; } = 7;
            public static int Service { get; } = 1000;

            public ModeloX(int Anio, double kmsActual, string Color, string Duenio)
                : base("Modelo X", Anio, kmsActual, Color, Duenio)
            {
                // Constructor de la clase ModeloX
            }
        }

        //Declaracion por herencia de ModeloS
        public class ModeloS : Tesla
        {
            // Declaración de las propiedades específicas
            public static int Autonomia { get; } = 650;
            public static int Asientos { get; } = 7;
            public static int Service { get; } = 2000;

            public ModeloS(int Anio, double kmsActual, string Color, string Duenio)
                : base("Modelo S", Anio, kmsActual, Color, Duenio)
            {
                // Constructor de la clase ModeloX
            }
        }

        //Declaracion por herencia de Cybertruck
        public class Cybertruck : Tesla
        {
            // Declaración de las propiedades específicas
            public static int Autonomia { get; } = 800;
            public static int Asientos { get; } = 6;
            public static int Service { get; } = 3000;

            public Cybertruck(int Anio, double kmsActual, string Color, string Duenio)
                : base("Cybertruck", Anio, kmsActual, Color, Duenio)
            {
                // Constructor de la clase ModeloX
            }
        }

        public class SpaceX
        {
            //Creacion de la clase Tesla
            public string Modelo { get; set; }
            public int Anio { get; set; }
            public double horasVuelo { get; set; }
            public string Color { get; set; }
            public string Empresa { get; set; }

            //Constructor
            public SpaceX(string Modelo, int Anio, double horasVuelo, string Color, string Empresa)
            {
                this.Modelo = Modelo;
                this.Anio = Anio;
                this.horasVuelo = horasVuelo;
                this.Color = Color;
                this.Empresa = Empresa;
            }


        }
        //Declaracion por herencia de Starship
        public class Starship : SpaceX
        {
            // Declaración de las propiedades específicas
            public static int Autonomia { get; } = 500;
            public static int Service { get; } = 1000;

            public Starship(int Anio, double horasVuelo, string Color, string Empresa)
                : base("Starship", Anio, horasVuelo, Color, Empresa)
            {
                // Constructor de la clase Starship
            }
        }

        //Declaracion por herencia de Starship
        public class Falcon9 : Tesla
        {
            // Declaración de las propiedades específicas
            public static int Autonomia { get; } = 200;
            public static int Service { get; } = 400;

            public Falcon9(int Anio, double horasVuelo, string Color, string Empresa)
                : base("Falcon 9", Anio, horasVuelo, Color, Empresa)
            {
                // Constructor de la clase Falcon 9
            }
        }


        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionMarca = comboMarca.SelectedItem.ToString();
            //borro el comboBox para que no me aparezca lo q seleccione antes
            comboModelo.Items.Clear();

            //si se selecciona tesla se abren las opciones de modelos
            if (seleccionMarca == "Tesla")
            {
                lblAlta.Visible = true;
                comboModelo.Visible = true;
                comboModelo.Items.Clear();
                //agrego opciones de modelos cuando se selecciona Tesla
                comboModelo.Items.AddRange(new string[] { "Modelo X", "Modelo S", "Cybertruck" });


                //Muestro los inputs
                lblAnio.Visible = true;
                txtAnio.Visible = true;
                lblKms.Visible = true;
                txtKms.Visible = true;
                lblColor.Visible = true;
                txtColor.Visible = true;
                lblColor.Visible = true;
                txtDuenio.Visible = true;

            }
            else if (seleccionMarca == "SpaceX")
            {
                lblAlta.Visible = true;
                comboModelo.Visible = true;
                comboModelo.Items.Clear();
                //agrego opciones de modelos cuando se selecciona SpaceX
                comboModelo.Items.AddRange(new string[] { "Starship", "Falcon 9"});
            }

            //no muestro nada
            else
            {
                lblAlta.Visible= false;
                comboModelo.Visible= false;
                comboModelo.Items.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionModelo = comboModelo.SelectedItem.ToString();
            //comboModelo.Items.Clear();

            //Mostrara depende la seleccion los datos especificos de cada modelo
            if(seleccionModelo == "Modelo X")
            {
                gbModelo.Enabled = true;
                gbModelo.Text = seleccionModelo;
                lblAutonomia.Enabled = true;
                lblAutonomiaTXT.Text = ModeloX.Autonomia.ToString();
                lblAsientos.Enabled = true;
                lblAsientosTXT.Text = ModeloX.Asientos.ToString();
                lblService.Enabled = true;
                lblServiceTXT.Text = ModeloX.Service.ToString();
            }
            else if (seleccionModelo == "Modelo S")
            {
                gbModelo.Enabled = true;
                gbModelo.Text = seleccionModelo;
                lblAutonomia.Enabled = true;
                lblAutonomiaTXT.Text = ModeloS.Autonomia.ToString();
                lblAsientos.Enabled = true;
                lblAsientosTXT.Text = ModeloS.Asientos.ToString();
                lblService.Enabled = true;
                lblServiceTXT.Text = ModeloS.Service.ToString();
            }
            else if (seleccionModelo == "Cybertruck")
            {
                gbModelo.Enabled = true;
                gbModelo.Text = seleccionModelo;
                lblAutonomia.Enabled = true;
                lblAutonomiaTXT.Text = Cybertruck.Autonomia.ToString();
                lblAsientos.Enabled = true;
                lblAsientosTXT.Text = Cybertruck.Asientos.ToString();
                lblService.Enabled = true;
                lblServiceTXT.Text = Cybertruck.Service.ToString();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Crear el vehiculo dependiendo el modelo
            // Obtener los valores ingresados en los TextBox
            string Modelo = comboModelo.SelectedItem.ToString();
            int Anio = int.Parse(txtAnio.Text);
            double kmsActual = double.Parse(txtKms.Text);
            string Color = txtColor.Text;
            string Duenio = txtDuenio.Text;

            Tesla nuevoVehiculo;

            if (Modelo == "Modelo X")
            {
                nuevoVehiculo = new ModeloX(Anio, kmsActual, Color, Duenio);
                listaTeslas.Add(nuevoVehiculo);

                // Mostramos un mensaje de que funciono todo correctamente
                MessageBox.Show("Vehículo creado exitosamente y agregado a la lista.");

            }
            else if (Modelo == "Modelo S")
            {
                nuevoVehiculo = new ModeloS(Anio, kmsActual, Color, Duenio);
                listaTeslas.Add(nuevoVehiculo);
                // Mostramos un mensaje de que funciono todo correctamente
                MessageBox.Show("Vehículo creado exitosamente y agregado a la lista.");
            }
            else if (Modelo == "Cybertruck")
            {
                nuevoVehiculo = new Cybertruck(Anio, kmsActual, Color, Duenio);
                listaTeslas.Add(nuevoVehiculo);
                // Mostramos un mensaje de que funciono todo correctamente
                MessageBox.Show("Vehículo creado exitosamente y agregado a la lista.");
            }

            //vuelvo todos los valores a cero
            txtAnio.Text = string.Empty;
            txtKms.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtDuenio.Text = string.Empty;
            comboMarca.SelectedItem = -1;
            comboModelo.SelectedItem = -1;
            gbModelo.Text = string.Empty;
            gbModelo.Enabled = false;

            //Cuando se ejecuta el boton se agrega a la grilla
            ActualizarDataGridView();
        }

        //la funcion que agrega a los Tesla en la grilla
        private void ActualizarDataGridView()
        {
            //Limpio la grilla
            dgvVehiculos.Rows.Clear();

            foreach (Tesla vehiculo in listaTeslas)
            {
                //Recorro la lista para incoporar dato por dato a la grilla
                //creo el indice para luego poder usarlo
                int rowIndex = dgvVehiculos.Rows.Add();
                //dgvVehiculos.Rows[rowIndex].Cells["cCod"].Value = vehiculo.Modelo;
                dgvVehiculos.Rows[rowIndex].Cells["cModelo"].Value = vehiculo.Modelo;
                dgvVehiculos.Rows[rowIndex].Cells["cAnio"].Value = vehiculo.Anio;
                dgvVehiculos.Rows[rowIndex].Cells["cKms"].Value = vehiculo.kmsActual;
                dgvVehiculos.Rows[rowIndex].Cells["cColor"].Value = vehiculo.Color;
                dgvVehiculos.Rows[rowIndex].Cells["cDuenio"].Value = vehiculo.Duenio;

                //Como estos tres datos fueron especificos para cada modelo, son propios de la clase
                if (vehiculo is ModeloX)
                {
                    dgvVehiculos.Rows[rowIndex].Cells["cAutonomia"].Value = ModeloX.Autonomia;
                    dgvVehiculos.Rows[rowIndex].Cells["cAsientos"].Value = ModeloX.Asientos;
                    dgvVehiculos.Rows[rowIndex].Cells["cService"].Value = ModeloX.Service;
                } else if (vehiculo is ModeloS)
                {
                    dgvVehiculos.Rows[rowIndex].Cells["cAutonomia"].Value = ModeloS.Autonomia;
                    dgvVehiculos.Rows[rowIndex].Cells["cAsientos"].Value = ModeloS.Asientos;
                    dgvVehiculos.Rows[rowIndex].Cells["cService"].Value = ModeloS.Service;
                }else if (vehiculo is Cybertruck)
                {
                    dgvVehiculos.Rows[rowIndex].Cells["cAutonomia"].Value = Cybertruck.Autonomia;
                    dgvVehiculos.Rows[rowIndex].Cells["cAsientos"].Value = Cybertruck.Asientos;
                    dgvVehiculos.Rows[rowIndex].Cells["cService"].Value = Cybertruck.Service;
                }


            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //capturamos el click de la eleccion
            int eleccion = e.RowIndex;

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int eleccion = dgvVehiculos.SelectedRows.Count;

            if (eleccion >= 0) //significa q seleccionamos algo q no sea el encabezado
            {
                //obtenemos el vehiculo
                Tesla vehiculo = listaTeslas[eleccion];

                //eliminamos
                listaTeslas.RemoveAt(eleccion);

                //eliminamos de la grilla
                dgvVehiculos.Rows.RemoveAt(eleccion);

                MessageBox.Show("Vehiculo eliminado correctamente");
            }
        }

        private void btnMasViejo_Click(object sender, EventArgs e)
        {
            dgvVehiculos.Rows.Clear();

            //verifico que la lista tenga algo dentro
            if (listaTeslas.Count > 0)
            {
                //busco en la lista por orden el del anio mas antiguo mostrando el primero q se encuentra
                var masViejo = listaTeslas.OrderBy(vehiculo => vehiculo.Anio).FirstOrDefault();

                int rowIndex = dgvVehiculos.Rows.Add();
                dgvVehiculos.Rows[rowIndex].Cells["cModelo"].Value = masViejo.Modelo;
                dgvVehiculos.Rows[rowIndex].Cells["cAnio"].Value = masViejo.Anio;
                dgvVehiculos.Rows[rowIndex].Cells["cKms"].Value = masViejo.kmsActual;
                dgvVehiculos.Rows[rowIndex].Cells["cColor"].Value = masViejo.Color;
                dgvVehiculos.Rows[rowIndex].Cells["cDuenio"].Value = masViejo.Duenio;

                //Como estos tres datos fueron especificos para cada modelo, son propios de la clase
                if (masViejo is ModeloX)
                {
                    dgvVehiculos.Rows[rowIndex].Cells["cAutonomia"].Value = ModeloX.Autonomia;
                    dgvVehiculos.Rows[rowIndex].Cells["cAsientos"].Value = ModeloX.Asientos;
                    dgvVehiculos.Rows[rowIndex].Cells["cService"].Value = ModeloX.Service;
                }
                else if (masViejo is ModeloS)
                {
                    dgvVehiculos.Rows[rowIndex].Cells["cAutonomia"].Value = ModeloS.Autonomia;
                    dgvVehiculos.Rows[rowIndex].Cells["cAsientos"].Value = ModeloS.Asientos;
                    dgvVehiculos.Rows[rowIndex].Cells["cService"].Value = ModeloS.Service;
                }
                else if (masViejo is Cybertruck)
                {
                    dgvVehiculos.Rows[rowIndex].Cells["cAutonomia"].Value = Cybertruck.Autonomia;
                    dgvVehiculos.Rows[rowIndex].Cells["cAsientos"].Value = Cybertruck.Asientos;
                    dgvVehiculos.Rows[rowIndex].Cells["cService"].Value = Cybertruck.Service;
                }
            }

            

        }
    }
}
