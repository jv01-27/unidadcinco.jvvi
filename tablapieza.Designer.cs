namespace unidadcinco.jvvi
{
    partial class tablapieza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridPieza = new System.Windows.Forms.DataGridView();
            this.planned = new System.Windows.Forms.TextBox();
            this.folio_pieza_in = new System.Windows.Forms.TextBox();
            this.realized = new System.Windows.Forms.TextBox();
            this.name_pieza_in = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.state_complete = new System.Windows.Forms.RadioButton();
            this.state_uncompleted = new System.Windows.Forms.RadioButton();
            this.back = new System.Windows.Forms.Button();
            this.production_line = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPieza)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPieza
            // 
            this.dataGridPieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPieza.Location = new System.Drawing.Point(12, 12);
            this.dataGridPieza.Name = "dataGridPieza";
            this.dataGridPieza.Size = new System.Drawing.Size(643, 240);
            this.dataGridPieza.TabIndex = 0;
            this.dataGridPieza.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridPieza_RowHeaderMouseDoubleClick);
            // 
            // planned
            // 
            this.planned.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.planned.Location = new System.Drawing.Point(180, 321);
            this.planned.Name = "planned";
            this.planned.ShortcutsEnabled = false;
            this.planned.Size = new System.Drawing.Size(474, 19);
            this.planned.TabIndex = 28;
            this.planned.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.planned_KeyPress);
            // 
            // folio_pieza_in
            // 
            this.folio_pieza_in.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.folio_pieza_in.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.folio_pieza_in.Location = new System.Drawing.Point(180, 269);
            this.folio_pieza_in.Name = "folio_pieza_in";
            this.folio_pieza_in.ShortcutsEnabled = false;
            this.folio_pieza_in.Size = new System.Drawing.Size(475, 19);
            this.folio_pieza_in.TabIndex = 26;
            this.folio_pieza_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.folio_pieza_in_KeyPress);
            // 
            // realized
            // 
            this.realized.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.realized.Location = new System.Drawing.Point(180, 347);
            this.realized.Name = "realized";
            this.realized.ShortcutsEnabled = false;
            this.realized.Size = new System.Drawing.Size(474, 19);
            this.realized.TabIndex = 25;
            this.realized.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.realized_KeyPress);
            // 
            // name_pieza_in
            // 
            this.name_pieza_in.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.name_pieza_in.Location = new System.Drawing.Point(180, 295);
            this.name_pieza_in.MaxLength = 30;
            this.name_pieza_in.Name = "name_pieza_in";
            this.name_pieza_in.ShortcutsEnabled = false;
            this.name_pieza_in.Size = new System.Drawing.Size(474, 19);
            this.name_pieza_in.TabIndex = 24;
            this.name_pieza_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_pieza_in_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label5.Location = new System.Drawing.Point(8, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label4.Location = new System.Drawing.Point(8, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cantidad Realizada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label3.Location = new System.Drawing.Point(11, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label2.Location = new System.Drawing.Point(9, 323);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cantidad Planeada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label1.Location = new System.Drawing.Point(11, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Folio Pieza";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold);
            this.btn_eliminar.Location = new System.Drawing.Point(285, 436);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 45);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(423, 436);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 45);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modificar.Location = new System.Drawing.Point(143, 436);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 45);
            this.btn_modificar.TabIndex = 16;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold);
            this.btn_insertar.Location = new System.Drawing.Point(11, 436);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(100, 45);
            this.btn_insertar.TabIndex = 15;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minecraft", 12F);
            this.label6.Location = new System.Drawing.Point(9, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Numero de Linea";
            // 
            // state_complete
            // 
            this.state_complete.AutoSize = true;
            this.state_complete.Checked = true;
            this.state_complete.Location = new System.Drawing.Point(162, 376);
            this.state_complete.Name = "state_complete";
            this.state_complete.Size = new System.Drawing.Size(69, 17);
            this.state_complete.TabIndex = 31;
            this.state_complete.TabStop = true;
            this.state_complete.Text = "Completa";
            this.state_complete.UseVisualStyleBackColor = true;
            // 
            // state_uncompleted
            // 
            this.state_uncompleted.AutoSize = true;
            this.state_uncompleted.Location = new System.Drawing.Point(254, 376);
            this.state_uncompleted.Name = "state_uncompleted";
            this.state_uncompleted.Size = new System.Drawing.Size(77, 17);
            this.state_uncompleted.TabIndex = 32;
            this.state_uncompleted.Text = "Incompleta";
            this.state_uncompleted.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Enabled = false;
            this.back.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(555, 436);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 45);
            this.back.TabIndex = 33;
            this.back.Text = "Persona";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // production_line
            // 
            this.production_line.FormattingEnabled = true;
            this.production_line.Items.AddRange(new object[] {
            "Por Pedido",
            "Por Lotes",
            "En Masa"});
            this.production_line.Location = new System.Drawing.Point(162, 401);
            this.production_line.Name = "production_line";
            this.production_line.Size = new System.Drawing.Size(121, 21);
            this.production_line.TabIndex = 34;
            this.production_line.Text = "Seleccione";
            this.production_line.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.production_line_KeyPress);
            // 
            // tablapieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 503);
            this.Controls.Add(this.production_line);
            this.Controls.Add(this.back);
            this.Controls.Add(this.state_uncompleted);
            this.Controls.Add(this.state_complete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.planned);
            this.Controls.Add(this.folio_pieza_in);
            this.Controls.Add(this.realized);
            this.Controls.Add(this.name_pieza_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.dataGridPieza);
            this.Name = "tablapieza";
            this.Text = "tablapieza";
            this.Load += new System.EventHandler(this.tablapieza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPieza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPieza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton state_complete;
        private System.Windows.Forms.RadioButton state_uncompleted;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox production_line;
        public System.Windows.Forms.TextBox planned;
        public System.Windows.Forms.TextBox folio_pieza_in;
        public System.Windows.Forms.TextBox realized;
        public System.Windows.Forms.TextBox name_pieza_in;
    }
}