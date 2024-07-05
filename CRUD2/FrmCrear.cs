using SP_DiezNatalia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CRUD2
{
    public partial class FrmCrear : Form
    {
        Data data;
        List<Empleado> listaEmpleados;
        Empleado empleadoAmodificar;
        int index;

        public FrmCrear()
        {
            InitializeComponent();
            data = new Data("localhost", "empresa");
            listaEmpleados = data.SeleccionarEmpleados();
            this.index = -5;
        }

        public FrmCrear(int index) : this()
        {
            this.index = index;
        }

      
        private void FrmCrear_Load(object sender, EventArgs e)
        {
            if (this.index != -5)
            {
                empleadoAmodificar = listaEmpleados[index];
                txt_Nombre.Text = empleadoAmodificar.Nombre;
                txt_Puesto.Text = empleadoAmodificar.Puesto;
                txt_Salario.Text = empleadoAmodificar.Salario.ToString();
                btn_CrearUsuario.Text = "Modificar";
            }
            else
            {
                btn_CrearUsuario.Text = "Crear";
            }
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (index != -5)
                {
                    empleadoAmodificar.Nombre = txt_Nombre.Text;
                    empleadoAmodificar.Puesto = txt_Puesto.Text;
                    empleadoAmodificar.Salario = float.Parse(txt_Salario.Text);
                    data.ModificarEmpleado(empleadoAmodificar);
                    MessageBox.Show("Empleado modificado con éxito!");
                    this.Close();
                }
                else
                {
                    string nombre = txt_Nombre.Text;
                    string puesto = txt_Puesto.Text;
                    float salario = float.Parse(txt_Salario.Text);
                    Empleado nuevoEmpleado = new Empleado(0,nombre, puesto, salario);
                    data.InsertarEmpleado(nuevoEmpleado);
                    MessageBox.Show("Empleado agregado con éxito!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
