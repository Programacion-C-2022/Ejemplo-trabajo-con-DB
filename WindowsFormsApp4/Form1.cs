using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool checkInput(string input)
        {
            List<string> palabrasFeas = new List<string>();
            palabrasFeas.Add("WHERE");
            palabrasFeas.Add("DROP");
            palabrasFeas.Add(";");
            palabrasFeas.Add("FROM");


            foreach(string palabra in palabrasFeas)
            {
                if (input.Contains(palabra)) return false;

            }

            return true;
        } 
        private void BotonInsertar_Click(object sender, EventArgs e)
        {
            if (
                !checkInput(TextBoxID.Text) ||
                !checkInput(TextBoxNombre.Text) ||
                !checkInput(TextBoxApellido.Text) ||
                !checkInput(TextBoxTelefono.Text) ||
                !checkInput(TextBoxEmail.Text)
            )
            {
                MessageBox.Show("Hubo un problema, intente nuevamente");
                return;
            }
            
            
            MySqlConnection conexion = new MySqlConnection(
                "server = 127.0.0.1; " +
                "uid = root;" +
                "pwd=root;" +
                "database=pruebita"
               );

            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;

            if (TextBoxID.Text == "")
            {
                comando.CommandText = "INSERT INTO " +
                "personita (nombre, apellido, telefono, email) " +
                "VALUES (@nombre,@apellido,@telefono,@email)";

                comando.Parameters.AddWithValue("@nombre", TextBoxNombre.Text);
                comando.Parameters.AddWithValue("@apellido", TextBoxApellido.Text);
                comando.Parameters.AddWithValue("@telefono", TextBoxTelefono.Text);
                comando.Parameters.AddWithValue("@email", TextBoxEmail.Text);
               



            }
            else { 
                comando.CommandText = "INSERT INTO " +
                "personita VALUES (@id, @nombre,@apellido,@email,@telefono)";

                comando.Parameters.AddWithValue("@id", TextBoxID.Text);
                comando.Parameters.AddWithValue("@nombre", TextBoxNombre.Text);
                comando.Parameters.AddWithValue("@apellido", TextBoxApellido.Text);
                comando.Parameters.AddWithValue("@telefono", TextBoxTelefono.Text);
                comando.Parameters.AddWithValue("@email", TextBoxEmail.Text);
            }

            comando.Prepare();
            comando.ExecuteNonQuery();

            MessageBox.Show("Personita cargada");




            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show("Desea eliminar la personita?","Confirmar",MessageBoxButtons.YesNo);

            if(resultado == DialogResult.Yes)
            {
                MySqlConnection conexion = new MySqlConnection(
                "server = 127.0.0.1; " +
                "uid = root;" +
                "pwd=root;" +
                "database=pruebita"
               );

                conexion.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;


                comando.CommandText = "DELETE FROM personita WHERE id = @id";
                comando.Parameters.AddWithValue("@id", TextBoxID.Text);

                comando.Prepare();
                comando.ExecuteNonQuery();
                MessageBox.Show("Personita Eliminada");

            }
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(
            "server = 127.0.0.1; " +
            "uid = root;" +
            "pwd=root;" +
            "database=pruebita"
           );

            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;


            comando.CommandText = "UPDATE personita SET " +
                "nombre = @nombre, " +
                "apellido = @apellido, " +
                "telefono = @telefono, " +
                "email = @email " +
                "WHERE id = @id";
            comando.Parameters.AddWithValue("@id", TextBoxID.Text);
            comando.Parameters.AddWithValue("@nombre", TextBoxNombre.Text);
            comando.Parameters.AddWithValue("@apellido", TextBoxApellido.Text);
            comando.Parameters.AddWithValue("@telefono", TextBoxTelefono.Text);
            comando.Parameters.AddWithValue("@email", TextBoxEmail.Text);

            comando.Prepare();
            comando.ExecuteNonQuery();

        }

        private void Listar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(
                        "server = 127.0.0.1; " +
                        "uid = root;" +
                        "pwd=root;" +
                        "database=pruebita"
                       );

            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader reader;
            DataTable tablita = new DataTable();
            comando.Connection = conexion;


            comando.CommandText = "SELECT * FROM personita";

            // Guardo el resultado de la query en el DataReader
            reader = comando.ExecuteReader();
            // Cargo la informacion del DataReader en el DataTable
            tablita.Load(reader);
            // Uso el DataTable como origen de datos del DataGridView
            Grillita.DataSource = tablita; 

            
        }

        private void BotonEnumerar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(
                        "server = 127.0.0.1; " +
                        "uid = root;" +
                        "pwd=root;" +
                        "database=pruebita"
                       );

            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader reader;
            comando.Connection = conexion;


            comando.CommandText = "SELECT * FROM personita";

            reader = comando.ExecuteReader();

            while (reader.Read()) 
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                string apellido = reader.GetString(2);
                string email = reader.GetString(3);
                int telefono = reader.GetInt32(4);

                MessageBox.Show("Nombre: " + nombre + " - Apellido: " + apellido);
            }
        }
    }
}
