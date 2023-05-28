namespace unidadcinco.jvvi
{
    partial class JVVI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_in = new System.Windows.Forms.TextBox();
            this.apematin = new System.Windows.Forms.TextBox();
            this.folio_in = new System.Windows.Forms.TextBox();
            this.idrol = new System.Windows.Forms.TextBox();
            this.apepatin = new System.Windows.Forms.TextBox();
            this.next_win = new System.Windows.Forms.Button();
            this.unidad4DataSet = new unidadcinco.jvvi.unidad4DataSet();
            this.piezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piezaTableAdapter = new unidadcinco.jvvi.unidad4DataSetTableAdapters.piezaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidad4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(543, 201);
            this.dataGrid.TabIndex = 0;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold);
            this.btn_insertar.Location = new System.Drawing.Point(12, 354);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(100, 45);
            this.btn_insertar.TabIndex = 1;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modificar.Location = new System.Drawing.Point(123, 354);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 45);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(349, 354);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 45);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold);
            this.btn_eliminar.Location = new System.Drawing.Point(238, 354);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 45);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label2.Location = new System.Drawing.Point(10, 273);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label4.Location = new System.Drawing.Point(9, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label5.Location = new System.Drawing.Point(9, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID Rol";
            // 
            // name_in
            // 
            this.name_in.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.name_in.Location = new System.Drawing.Point(163, 245);
            this.name_in.Name = "name_in";
            this.name_in.ShortcutsEnabled = false;
            this.name_in.Size = new System.Drawing.Size(393, 19);
            this.name_in.TabIndex = 10;
            this.name_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_in_KeyPress);
            // 
            // apematin
            // 
            this.apematin.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.apematin.Location = new System.Drawing.Point(163, 297);
            this.apematin.Name = "apematin";
            this.apematin.ShortcutsEnabled = false;
            this.apematin.Size = new System.Drawing.Size(393, 19);
            this.apematin.TabIndex = 11;
            this.apematin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apematin_KeyPress);
            // 
            // folio_in
            // 
            this.folio_in.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.folio_in.Location = new System.Drawing.Point(163, 219);
            this.folio_in.Name = "folio_in";
            this.folio_in.ShortcutsEnabled = false;
            this.folio_in.Size = new System.Drawing.Size(395, 19);
            this.folio_in.TabIndex = 12;
            this.folio_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.folio_in_KeyPress);
            // 
            // idrol
            // 
            this.idrol.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.idrol.Location = new System.Drawing.Point(163, 323);
            this.idrol.Name = "idrol";
            this.idrol.ShortcutsEnabled = false;
            this.idrol.Size = new System.Drawing.Size(393, 19);
            this.idrol.TabIndex = 13;
            this.idrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idrol_KeyPress);
            // 
            // apepatin
            // 
            this.apepatin.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.apepatin.Location = new System.Drawing.Point(163, 271);
            this.apepatin.Name = "apepatin";
            this.apepatin.ShortcutsEnabled = false;
            this.apepatin.Size = new System.Drawing.Size(393, 19);
            this.apepatin.TabIndex = 14;
            this.apepatin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apepatin_KeyPress);
            // 
            // next_win
            // 
            this.next_win.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_win.Location = new System.Drawing.Point(456, 354);
            this.next_win.Name = "next_win";
            this.next_win.Size = new System.Drawing.Size(100, 45);
            this.next_win.TabIndex = 15;
            this.next_win.Text = "Pieza";
            this.next_win.UseVisualStyleBackColor = true;
            this.next_win.Click += new System.EventHandler(this.next_win_Click);
            // 
            // unidad4DataSet
            // 
            this.unidad4DataSet.DataSetName = "unidad4DataSet";
            this.unidad4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // piezaBindingSource
            // 
            this.piezaBindingSource.DataMember = "pieza";
            this.piezaBindingSource.DataSource = this.unidad4DataSet;
            // 
            // piezaTableAdapter
            // 
            this.piezaTableAdapter.ClearBeforeFill = true;
            // 
            // JVVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 407);
            this.Controls.Add(this.next_win);
            this.Controls.Add(this.apepatin);
            this.Controls.Add(this.idrol);
            this.Controls.Add(this.folio_in);
            this.Controls.Add(this.apematin);
            this.Controls.Add(this.name_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.dataGrid);
            this.Name = "JVVI";
            this.Text = "JVVI";
            this.Load += new System.EventHandler(this.JVVI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidad4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.TextBox apematin;
        private System.Windows.Forms.TextBox folio_in;
        private System.Windows.Forms.TextBox idrol;
        private System.Windows.Forms.TextBox apepatin;
        private System.Windows.Forms.Button next_win;
        private unidad4DataSet unidad4DataSet;
        private System.Windows.Forms.BindingSource piezaBindingSource;
        private unidad4DataSetTableAdapters.piezaTableAdapter piezaTableAdapter;
    }
}

