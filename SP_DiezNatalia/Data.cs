using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SP_DiezNatalia;

namespace Entidades
{
    public class Data
    {
        string connectionString;

        public Data(string server, string db)
        {
            this.connectionString = $"Server={server}; Database={db}; User ID=root;";
        }

        private MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(connectionString);
        }

        public List<Empleado> SeleccionarEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            using (var conexion = ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM empleados";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);//comando que quiero ejecutar y la conexión activa
                    MySqlDataReader reader = cmd.ExecuteReader();//representa un puntero en memoria, y es de sólo avance y solo lectura. Va leyendo y avanzando la lista o coleccion de la consulta.
                    while (reader.Read())
                    {
                        var empleado = new Empleado(
                            reader.GetInt32("id"),
                            reader.GetString("nombre"),
                            reader.GetString("puesto"),
                            reader.GetFloat("salario")
                            );

                        listaEmpleados.Add(empleado);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return listaEmpleados;
        }

        public void InsertarEmpleado(Empleado nuevoEmpleado)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO empleados(nombre,puesto,salario)" +
                    $"VALUES(@nombre,@puesto,@salario)";//el arroba es convención
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nuevoEmpleado.Nombre);
                comando.Parameters.AddWithValue("@puesto", nuevoEmpleado.Puesto);
                comando.Parameters.AddWithValue("@salario", nuevoEmpleado.Salario);

                comando.ExecuteNonQuery();//
            }
        }

        public void ModificarEmpleado(Empleado nuevoEmpleado)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "UPDATE empleados SET nombre = @nombre, puesto = @puesto, salario = @salario " +
                    $"WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", nuevoEmpleado.Id);
                comando.Parameters.AddWithValue("@nombre", nuevoEmpleado.Nombre);
                comando.Parameters.AddWithValue("@puesto", nuevoEmpleado.Puesto);
                comando.Parameters.AddWithValue("@salario", nuevoEmpleado.Salario);

                comando.ExecuteNonQuery();//
            }
        }

        public void EliminarEmpleado(int id)//después puedo sobrecargarlo y eliminar de acuerdo a otras condiciones
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "DELETE FROM empleados WHERE id = @id";//borra todo un registro
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();//
            }
        }
    }
}
