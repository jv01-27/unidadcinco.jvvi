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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace unidadcinco.jvvi
{
    public partial class tablapieza : Form
    {
        public tablapieza()
        {
            InitializeComponent();
        }
        conectarjvvi conexionjvi = new conectarjvvi();

        private void tablapieza_Load(object sender, EventArgs e)
        {            
            actualizarDataGrid();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if (emptyField() == 1)
            {
                try {
                    insert();
                    //limpiar campos
                    clearDataFields();
                    MessageBox.Show("Datos insertados correctamente");
                    //actualizar datagrid
                    actualizarDataGrid();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Número de error específico para violación de clave primaria
                    {
                        MessageBox.Show("El folio ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }                        
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if(emptyField() == 1)
            {
               update();
                //limpiar campos
                clearDataFields();                
                //actualizar datagrid
                actualizarDataGrid();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (folio_pieza_in.TextLength != 18)
            {
                MessageBox.Show("La longitud del folio debe ser de 18 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                delete();
                //limpiar campos
                clearDataFields();
                //actualizar datagrid
                actualizarDataGrid();
            }            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            clearDataFields();
        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void folio_pieza_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.textNumbersV(e);
        }

        private void name_pieza_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.textSpaceV(e);
        }

        private void planned_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.enterosV(e);
        }

        private void realized_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.enterosV(e);
        }

        private void actualizarDataGrid()
        {
            SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
            //SqlDataAdapter adapter = new SqlDataAdapter("select *from produccion.pieza", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter("select produccion.pieza.folio_pieza, produccion.pieza.nombre, produccion.pieza.cantidad_planeada, produccion.pieza.cantidad_realizada, produccion.pieza.estado, produccion.linea_de_produccion.nombre as 'LDP nombre' from produccion.pieza inner join produccion.linea_de_produccion on produccion.pieza.numero_de_linea = produccion.linea_de_produccion.numero_de_linea;", conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridPieza.DataSource = table;
        }

        private void clearDataFields()
        {
            folio_pieza_in.Text = "";
            name_pieza_in.Text = "";
            realized.Text = "";
            planned.Text = "";

        }

        private int radioCheckState() {
            if (state_complete.Checked)
            {                
                return 1;                
            }
            else {                
                return 0;                
            }
        }

        private int emptyField()
        {
            string selected_line = production_line.SelectedItem as string;
            if (folio_pieza_in.TextLength != 18)
            {
                MessageBox.Show("La longitud del folio debe ser de 18 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            else if (name_pieza_in.TextLength == 0)
            {
                MessageBox.Show("El nombre de la pieza no puede estar vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            else if (planned.TextLength == 0)
            {
                MessageBox.Show("El campo cantidad planeada no puede estar vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            else if (planned.TextLength > 9)
            {
                MessageBox.Show("El valor del campo cantidad planeada no puede exceder las 999,999,999 unidades", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            else if (realized.TextLength == 0)
            {
                MessageBox.Show("El campo cantidad relizada no puede estar vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            else if (planned.TextLength > 9)
            {
                MessageBox.Show("El valor del campo relizada planeada no puede exceder las 999,999,999 unidades", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            else if (string.IsNullOrEmpty(selected_line))
            {
                MessageBox.Show("Seleccione el número de linea", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        private int comboBoxPL() {
            string selected_line = production_line.SelectedItem as string;

            if (selected_line.Equals("Por Pedido"))
            {
                return 1;
            } else if (selected_line.Equals("Por Lotes")) {
                return 2;
            } else {
                return 3;
            }
        }

        private void production_line_KeyPress(object sender, KeyPressEventArgs e)
        {
            textFieldEvent.nothingV(e);
        }

        private void insert() {
            SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
            conexion.Open();
            String cadena = "insert into produccion.pieza " +
                "values (" +
                "'" + folio_pieza_in.Text + "'," +
                "'" + name_pieza_in.Text + "'," +
                "" + planned.Text + "," +
                "" + realized.Text + "," +
                "" + radioCheckState() + "," +
                "" + comboBoxPL() + ")";
            SqlCommand order = new SqlCommand(cadena, conexion);
            order.ExecuteNonQuery();
            conexion.Close();                       
        }

        private void update() {
            SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
            conexion.Open();
            String cadena = "update produccion.pieza set " +
                "nombre = '" + name_pieza_in.Text + "'," +
                "cantidad_planeada = " + planned.Text + "," +
                "cantidad_realizada = " + realized.Text + "," +
                "estado = " + radioCheckState() + "," +
                "numero_de_linea = " + comboBoxPL() + "" +
                "where folio_pieza = '" + folio_pieza_in.Text + "'";
            SqlCommand order = new SqlCommand(cadena, conexion);            
            int rowsAffected = order.ExecuteNonQuery();

            if (rowsAffected >= 1)
            {
                // La actualización se realizó correctamente
                MessageBox.Show("Filas actualizadas: " + rowsAffected);
            }
            else
            {
                // No se encontró ninguna fila para actualizar
                MessageBox.Show("No se encontró ninguna fila para actualizar.");                
            }
            conexion.Close();
        }

        private void delete() {
            SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
            conexion.Open();
            String cadena = "delete from produccion.pieza where folio_pieza = '" + folio_pieza_in.Text + "'";
            SqlCommand order = new SqlCommand(cadena, conexion);
            int rowsAffected = order.ExecuteNonQuery();

            if (rowsAffected >= 1)
            {
                // La eliminación se realizó correctamente
                MessageBox.Show("Fila eliminada: " + folio_pieza_in.Text);
            }
            else
            {
                // No se encontró ninguna fila para eliminar
                MessageBox.Show("No se encontró ninguna fila para eliminar.");
            }
            conexion.Close();
        }

        private void dataGridPieza_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            folio_pieza_in.Text = Convert.ToString(dataGridPieza[0, row].Value);
            name_pieza_in.Text = Convert.ToString(dataGridPieza[1, row].Value);
            planned.Text = Convert.ToString(dataGridPieza[2, row].Value);
            realized.Text = Convert.ToString(dataGridPieza[3, row].Value);
        }
    }
}
