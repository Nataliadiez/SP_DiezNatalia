using Entidades;
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

namespace CRUD2
{
    public partial class FrmMostrar : Form
    {
        Data data;
        List<Empleado> listaEmpleados;
        int indiceRegistro;
        public FrmMostrar()
        {
            InitializeComponent();
            data = new Data("localhost", "empresa");
            listaEmpleados = data.SeleccionarEmpleados();
            dg_MostrarElementos.DataSource = listaEmpleados;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            FrmCrear crearEmp = new FrmCrear(this.indiceRegistro);
            crearEmp.ShowDialog();
            listaEmpleados = data.SeleccionarEmpleados();
            dg_MostrarElementos.DataSource = listaEmpleados;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = listaEmpleados[this.indiceRegistro].Id;
            DialogResult eliminar = MessageBox.Show($"¿Está seguro de que desea eliminar el usuario?\n{idAEliminar}", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eliminar == DialogResult.Yes)
            {
                try
                {
                    data.EliminarEmpleado(idAEliminar);
                    MessageBox.Show("Usuario eliminado");
                    listaEmpleados = data.SeleccionarEmpleados();
                    dg_MostrarElementos.DataSource = listaEmpleados;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dg_MostrarElementos_SelectionChanged(object sender, EventArgs e)
        {
            this.indiceRegistro = dg_MostrarElementos.CurrentRow.Index;
        }

    }
}
