using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionesAlumnos
{
    public partial class Form1 : Form
    {
        public string _Nombre = string.Empty;
        public double _Calificacion = 0;
        public double[] _ListCalificaciones = new double[20];
        public string[] _ListNombres = new string[20];
        public int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty && txtCalificacion.Text == string.Empty)
            {
                MessageBox.Show("Debes ingresar el Nombre y la calificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _Nombre = txtName.Text;
                _ListNombres[x] = _Nombre;
                _Calificacion = double.Parse(txtCalificacion.Text);
                _ListCalificaciones[x] = _Calificacion;
                x++;
                MessageBox.Show("Se registro la informacion", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = "";
                txtCalificacion.Text = "";
            }
           

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int i;

            if (txtName.Text != string.Empty)
            {
             
                    _Nombre = (txtName.Text);
                for (i = 0; i < 10; i++)
                {
                    while (_ListNombres[i] == _Nombre)
                    {
                        _ListCalificaciones[i] = _ListCalificaciones[i + 1];
                        _ListNombres[i] = _ListNombres[i + 1];
                        _ListCalificaciones[i + 1] = _ListCalificaciones[i + 2];
                        _ListNombres[i + 1] = _ListNombres[i + 2];
                        _ListCalificaciones[i + 2] = _ListCalificaciones[i + 3];
                        _ListNombres[i + 2] = _ListNombres[i + 3];
                        _ListCalificaciones[i + 3] = _ListCalificaciones[i + 4];
                        _ListNombres[i + 3] = _ListNombres[i + 4];
                        _ListCalificaciones[i + 4] = _ListCalificaciones[i + 5];
                        _ListNombres[i + 4] = _ListNombres[i + 5];
                        _ListCalificaciones[i + 5] = _ListCalificaciones[i + 6];
                        _ListNombres[i + 5] = _ListNombres[i + 6];
                        _ListCalificaciones[i + 6] = _ListCalificaciones[i + 7];
                        _ListNombres[i + 6] = _ListNombres[i + 7];
                        _ListCalificaciones[i + 7] = _ListCalificaciones[i + 8];
                        _ListNombres[i + 8] = _ListNombres[i + 8];
                        _ListCalificaciones[i + 8] = _ListCalificaciones[i + 9];
                        _ListNombres[i + 9] = _ListNombres[i + 9];
                        _ListCalificaciones[i + 9] = 0;
                        _ListNombres[i + 10] = "";

                    }
                }
                i = 1 - i;
                MessageBox.Show("Se elimino el registro correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = "";
                txtCalificacion.Text = "";
                ListarDatos();

            }
            else
            {
                MessageBox.Show("Introduce el nombre del registro a borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ListarDatos();
        }

        public void ListarDatos()
        {
            int i;
            dataGridView1.Rows.Clear();
            for (i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(_ListNombres[i], _ListCalificaciones[i].ToString());
                if (i > 10)
                {
                    MessageBox.Show("No se puede ingresar más datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int i;
            string nom;
            if (txtName.Text != "")
            {                nom = (txtName.Text);
                for (i = 0; i < _ListCalificaciones.Length; i++)
                {
                    if (nom == _ListNombres[i])
                    {
                        _Calificacion = double.Parse(txtCalificacion.Text);
                        _ListCalificaciones[i] = _Calificacion;
                    }
                }
                txtName.Text = "";
                txtCalificacion.Text = "";
                ListarDatos();
            }
            else
            {
                MessageBox.Show("Introduce el nombre a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < _ListCalificaciones.Length; i++)
            {
                _ListCalificaciones[i] = 0;
                _ListNombres[i] = string.Empty;
            }
            ListarDatos();
        }
    }
    public class Calificaciones
    {
        public string Nombre { get; set; }
        public double Calificacion { get; set; }

    }
}
