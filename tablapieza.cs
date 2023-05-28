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

            //agregar opciones a combobox
            /*
            production_line.Items.Add("Por Pedido");
            production_line.Items.Add("Por Lotes");
            production_line.Items.Add("En Masa");
            */

        }

        /*
        private void dataGridPieza_SelectionChanged(object sender, EventArgs e)
        {
            //verificar si hay alguna seleccion hecha
            if (dataGridPieza.SelectedRows.Count > 0){
                //c obtinene la fila seleccionada
                DataGridViewRow selectdRow = dataGridPieza.SelectedRows[0];

                //obtenemos los valores de las celdas de la fila seleccionada
                string folio = selectdRow.Cells["folio_pieza"].Value.ToString();
                string nombre = selectdRow.Cells["nombre"].Value.ToString();
                string cantidad_planeada = selectdRow.Cells["cantidad_planeada"].Value.ToString();
                string cantidad_realizada = selectdRow.Cells["cantidad_realizada"].Value.ToString();
                string estado = selectdRow.Cells["estado"].Value.ToString();
                string numero_de_linea = selectdRow.Cells["numero_de_linea"].Value.ToString();

                folio_pieza_in.Text = folio;
                name_pieza_in.Text = nombre;
                planned.Text = cantidad_planeada;
                realized.Text = cantidad_realizada;
            }
        } */

        conectarjvvi conexionjvi = new conectarjvvi();

        private void tablapieza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'unidad4DataSet1.pieza' Puede moverla o quitarla según sea necesario.
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
                    MessageBox.Show("Error al realizar la inserción, verifique que el folio sea único", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show(ex.ToString(), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }                        
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if(emptyField() == 1)
            {
                try
                {
                    update();
                    //limpiar campos
                    clearDataFields();
                    MessageBox.Show("Datos modificados correctamente");
                    //actualizar datagrid
                    actualizarDataGrid();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al realizar la modificación, verifique que el folio que desea editar, exista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                MessageBox.Show("Datos eliminados correctamente");
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
            SqlDataAdapter adapter = new SqlDataAdapter("select *from produccion.pieza", conexion);
            //SqlDataAdapter adapter = new SqlDataAdapter("select produccion.pieza.folio_pieza, produccion.pieza.nombre, produccion.pieza.cantidad_planeada, produccion.pieza.cantidad_realizada, produccion.pieza.estado, produccion.linea_de_produccion.nombre from produccion.pieza inner join produccion.linea_de_produccion on produccion.pieza.numero_de_linea = produccion.linea_de_produccion.numero_de_linea;", conexion);
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
            order.ExecuteNonQuery();
            conexion.Close();
        }

        private void delete() {
            SqlConnection conexion = new SqlConnection(conexionjvi.conectabd);
            conexion.Open();
            String cadena = "delete from produccion.pieza where folio_pieza = '" + folio_pieza_in.Text + "'";
            SqlCommand order = new SqlCommand(cadena, conexion);
            order.ExecuteNonQuery();
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
