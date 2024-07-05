using Entidades;
using SP_DiezNatalia;

namespace CRUD2
{
    public partial class FrmPrincipal : Form
    {
        Data data;
        List<Empleado> listaEmpleados;
        public FrmPrincipal()
        {
            InitializeComponent();
            data = new Data("localhost", "empresa");
            listaEmpleados = data.SeleccionarEmpleados();
            dg_MostrarTodos.DataSource = listaEmpleados;
        }

        public void btn_MenuMostrar_Click(Object sender, EventArgs e)
        {
            FrmMostrar formMostrar = new FrmMostrar();
            formMostrar.ShowDialog();
            listaEmpleados = data.SeleccionarEmpleados();
            dg_MostrarTodos.DataSource = listaEmpleados;
        }

        public void btn_MenuCrear_Click(Object sender, EventArgs e)
        {
            FrmCrear formCrear = new FrmCrear();
            formCrear.ShowDialog();
            listaEmpleados = data.SeleccionarEmpleados();
            dg_MostrarTodos.DataSource = listaEmpleados;

        }
    }
}
