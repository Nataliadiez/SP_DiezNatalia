using Entidades;
using SP_DiezNatalia;

namespace CRUD2
{
    public partial class FrmPrincipal : Form
    {
        DataEmpleado data;
        List<Empleado> listaEmpleados;
        public FrmPrincipal()
        {
            InitializeComponent();
            data = new DataEmpleado("localhost", "empresa");
            listaEmpleados = data.SeleccionarEmpleados();
            dg_MostrarTodos.DataSource = listaEmpleados;
        }


        public void btn_MenuMostrar_Click(Object sender, EventArgs e)
        {
            FrmMostrar formMostrar = new FrmMostrar();
            if (formMostrar.ShowDialog() == DialogResult.OK)
            {
                //hacer lo que vayamos a hacer
            }
            
        }

        public void btn_MenuCrear_Click(Object sender, EventArgs e)
        {
            FrmCrear formCrear = new FrmCrear();
            if (formCrear.ShowDialog() == DialogResult.OK)
            {
                //hacer la lógica dentro
            }
            
        }
    }
}
