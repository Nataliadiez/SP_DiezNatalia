


namespace SP_DiezNatalia
{
    public class Empleado
    {
        int id;
        string nombre;
        string puesto;
        float salario;

        public int Id { 
            get => id; 
            set => id = value; 
        }
        public string Nombre { 
            get => nombre; set => nombre = value; 
        }
        public string Puesto { 
            get => puesto; set => puesto = value; 
        }
        public float Salario { 
            get => salario; set => salario = value; 
        }

        public Empleado(int id, string nombre, string puesto, float salario) 
        { 
            this.id = id;
            this.nombre = nombre; 
            this.puesto = puesto; 
            this.salario = salario;
        }

        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            bool esIgual = false;

            if (ReferenceEquals(emp1, emp2))
            {
                esIgual = true;
            }
            else if ((object)emp1 != null && (object)emp2 != null &&
                     (emp1.Id == emp2.Id || (emp1.Nombre == emp2.Nombre && emp1.Puesto == emp2.Puesto)))
            {
                esIgual = true;
            }

            return esIgual;
        }

        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
