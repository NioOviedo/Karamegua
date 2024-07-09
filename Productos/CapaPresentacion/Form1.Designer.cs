namespace CapaPresentacion
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(475, 231);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(122, 281);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(26, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 61);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 100);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 130);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 163);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 201);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Stock:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(613, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(613, 92);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(127, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(613, 127);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(127, 23);
            txtMarca.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(613, 163);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(127, 23);
            txtPrecio.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(613, 201);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(127, 23);
            txtStock.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(518, 240);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(222, 35);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 329);
            Controls.Add(btnGuardar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnGuardar;
    }
}