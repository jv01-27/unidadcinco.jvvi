using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidadcinco.jvvi
{
    public partial class JVVI : Form
    {
        public JVVI()
        {
            InitializeComponent();
        }

        conectarjvvi conexionjvi = new conectarjvvi();

        private void JVVI_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'unidad4DataSet.persona' Puede moverla o quitarla según sea necesario.
            actualizarDataGrid();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if (folio_in.TextLength != 8)
            {
                MessageBox.Show("La longitud del folio debe ser de 8 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (idrol.TextLength != 8)
            {
                MessageBox.Show("La longitud del id Rol debe ser de 8 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
                conexion.Open();
                String cadena = "insert into personal.persona " +
                    "values (" +
                    "'" + folio_in.Text + "'," +
                    "'" + name_in.Text + "'," +
                    "'" + apepatin.Text + "'," +
                    "'" + apematin.Text + "'," +
                    "'" + idrol.Text + "')";
                SqlCommand order = new SqlCommand(cadena, conexion);
                order.ExecuteNonQuery();
                //limpiar campos
                clearDataFields();
                MessageBox.Show("Datos insertados correctamente");
                //actualizar datagrid
                actualizarDataGrid();
                conexion.Close();
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            clearDataFields();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (folio_in.TextLength != 8)
            {
                MessageBox.Show("La longitud del folio debe ser de 8 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (idrol.TextLength != 8)
            {
                MessageBox.Show("La longitud del id Rol debe ser de 8 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
                conexion.Open();
                String cadena = "update personal.persona set " +
                    "nombre = '" + name_in.Text + "'," +
                    "apepat = '" + apepatin.Text + "'," +
                    "apemat = '" + apematin.Text + "'," +
                    "id_rol = '" + idrol.Text + "'" +
                    "where folio = '" + folio_in.Text + "'";
                SqlCommand order = new SqlCommand(cadena, conexion);
                order.ExecuteNonQuery();
                //limpiar campos
                clearDataFields();
                MessageBox.Show("Datos modificados correctamente");
                //actualizar datagrid
                actualizarDataGrid();
                conexion.Close();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (folio_in.TextLength != 8)
            {
                MessageBox.Show("La longitud del folio debe ser de 8 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
                conexion.Open();
                String cadena = "delete from personal.persona where folio = '" + folio_in.Text + "'";
                SqlCommand order = new SqlCommand(cadena, conexion);
                order.ExecuteNonQuery();
                //limpiar campos
                clearDataFields();
                MessageBox.Show("Datos eliminados correctamente");
                //actualizar datagrid
                actualizarDataGrid();
                conexion.Close();
            }
        }

        private void folio_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.textNumbersV(e);
        }

        private void name_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.textSpaceV(e);
        }

        private void apepatin_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.textSpaceV(e);
        }

        private void apematin_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.textSpaceV(e);

        }

        private void idrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.textNumbersV(e);
        }

        private void actualizarDataGrid() {
            SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
            SqlDataAdapter adapter = new SqlDataAdapter("select *from personal.persona", conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGrid.DataSource = table;
        }

        private void clearDataFields()
        {
            folio_in.Text = "";
            name_in.Text = "";
            apepatin.Text = "";
            apematin.Text = "";
            idrol.Text = "";
        }

        private void next_win_Click(object sender, EventArgs e)
        {
            tablapieza form2 = new tablapieza();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }
    }
}
