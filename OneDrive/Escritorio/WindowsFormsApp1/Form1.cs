using System.Collections.Generic;
using System.Data;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataAccess conectionAcces = new DataAccess();
        Model modelo;
        List<Model> todos; 
        Cursor_ cursor1 = new Cursor_();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Cargar_Click(object sender, System.EventArgs e)
        {
            todos = conectionAcces.ObtenerTodosLosUsuarios();
            if (todos.Count > 0)
            {
                cursor1.totalRegistros = todos.Count;
                cursor1.current = 0;
                MostrarRegistro();
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        private void buttonBuscarById_Click(object sender, EventArgs e)
        {
            DataRow resp = conectionAcces.LeerPorId(int.Parse(ID.Text));
            if (resp != null)
            {
                NAME.Text = resp["nombre_consola"].ToString();
                COMPANIA.Text = resp["compania"].ToString();
                FECHA.Value= (DateTime)resp["anio_lanzamiento"];
                GENERACION.Value = (int)resp["generacion"];
                ID.Text = resp["id_consola"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }

        private void MostrarRegistro()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.totalRegistros)
            {
                Usuario u = todos[cursor1.current];
                textBoxID.Text = u.ID.ToString();
                textBoxNombre.Text = u.Nombre;
                textBoxApellido.Text = u.Apellido;
                dateTimePickerFechaNacimiento.Value = u.FechaNacimiento;
                textBoxEmail.Text = u.Email;
                textBoxSaldo.Text = u.Saldo.ToString();
                checkBox1.Checked = u.Activo;
                //incrementar el cursor y validar que no se pase del total de registros
                cursor1.current++;
                if (cursor1.current >= cursor1.totalRegistros)
                {
                    cursor1.current = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Model juego = new Model(int.Parse(ID.Text), NAME.Text, COMPANIA.Text, FECHA.Value, (int)GENERACION.Value);
            conectionAcces.Insertar(juego);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model juego = new Model(int.Parse(ID.Text), NAME.Text, COMPANIA.Text, FECHA.Value, (int)GENERACION.Value);
            conectionAcces.Actualizar(juego);
        }
    }
}
