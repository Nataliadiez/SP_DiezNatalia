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
        DataEmpleado data;
        List<Empleado> listaEmpleados;
        Empleado empAModificar;
        public FrmMostrar()
        {
            InitializeComponent();
            data = new DataEmpleado("localhost", "empresa");
            listaEmpleados = data.SeleccionarEmpleados();
            dg_MostrarElementos.DataSource = listaEmpleados;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            FrmCrear crearEmp = new FrmCrear(this.empAModificar);
            crearEmp.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult eliminar = MessageBox.Show("¿Está seguro de que desea eliminar el usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eliminar == DialogResult.Yes)
            {
                MessageBox.Show("Usuario eliminado");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_MostrarElementos_SelectionChanged(object sender, EventArgs e)
        {
            int index = dg_MostrarElementos.CurrentRow.Index;
            this.empAModificar = listaEmpleados[index];
        }
    }
}
