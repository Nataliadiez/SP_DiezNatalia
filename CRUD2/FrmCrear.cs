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
    public partial class FrmCrear : Form
    {
        Empleado emp;
        public FrmCrear()
        {
            InitializeComponent();
        }

        public FrmCrear(Empleado emp) : this()
        {
            this.emp = emp;
        }

        private void FrmCrear_Load(object sender, EventArgs e)
        {
            if (emp != null)
            {
                txt_Nombre.Text = emp.Nombre;
                txt_Puesto.Text = emp.Puesto;
                txt_Salario.Text = emp.Salario.ToString();
            }

        }
    }
}
