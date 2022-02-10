using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo5Guia2PED
{
    public partial class Form1 : Form
    {
        Queue<Empleados> Trabajadores = new Queue<Empleados>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados(); //creamos instancia de la clase empleado
                                                  //capturamos los datos del empleado
            empleado.Carnet = txtcarnet.Text;
            empleado.Nombre = txtnombre.Text;
            empleado.Salario = Decimal.Parse(txtsalario.Text);
            empleado.Fecha = fecha.Value;
            Trabajadores.Enqueue(empleado); //1lamamos al método encolar para meter a la estructura
            dgvCola.DataSource = null; //iniciamos el datagridview con null
            dgvCola.DataSource = Trabajadores.ToArray(); //para pasarlo al dgv convertimos la cola en arreglo
            Limpiar(); //se limpian los textbox
            txtcarnet.Focus(); //se coloca el cursor sobre el primer textbox
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Trabajadores.Count != 0) //mientras haya trabajadores en la cola
            {
                Empleados empleado = new Empleados(); 
                empleado = Trabajadores.Dequeue(); 
                txtcarnet.Text = empleado.Carnet;
                txtnombre.Text = empleado.Nombre;
                txtsalario.Text = empleado.Salario.ToString();
                
                fecha.Value = empleado.Fecha;
                //la estructura convertida en lista se le pasa al dgv (ahora tiene un empleado menos)
                dgvCola.DataSource = Trabajadores.ToList();
                MessageBox.Show("Se eliminó el registro en cola", "AVISO");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No hay empleados en cola", "AVISO");
                Limpiar();
            }
            txtcarnet.Focus();

        }
        public void Limpiar() //limpia los TextBox
        {
            txtcarnet.Clear();
            txtnombre.Clear();
            txtsalario.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
   
}
