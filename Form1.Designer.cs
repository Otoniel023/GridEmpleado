namespace GridEmpleado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnnombre = new Label();
            txtbname = new TextBox();
            txtbnumero = new TextBox();
            txtbapellido = new TextBox();
            label5 = new Label();
            lblnombrersl = new Label();
            btnfinalizar = new Button();
            lblresultado = new Label();
            lblresultado1 = new Label();
            pictureBox1 = new PictureBox();
            txtbid = new TextBox();
            dtgvresumen = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnsalir = new Button();
            btneliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvresumen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 23);
            label1.TabIndex = 0;
            label1.Text = "Registro de Empleados ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(577, 250);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(591, 185);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 2;
            label3.Text = "Cedula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(21, 247);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // btnnombre
            // 
            btnnombre.AutoSize = true;
            btnnombre.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnnombre.ForeColor = SystemColors.ActiveCaptionText;
            btnnombre.Location = new Point(23, 186);
            btnnombre.Name = "btnnombre";
            btnnombre.Size = new Size(77, 19);
            btnnombre.TabIndex = 4;
            btnnombre.Text = "Nombre:";
            // 
            // txtbname
            // 
            txtbname.Location = new Point(106, 186);
            txtbname.Name = "txtbname";
            txtbname.Size = new Size(194, 22);
            txtbname.TabIndex = 6;
            // 
            // txtbnumero
            // 
            txtbnumero.Location = new Point(665, 247);
            txtbnumero.Name = "txtbnumero";
            txtbnumero.Size = new Size(194, 22);
            txtbnumero.TabIndex = 7;
            // 
            // txtbapellido
            // 
            txtbapellido.Location = new Point(106, 247);
            txtbapellido.Name = "txtbapellido";
            txtbapellido.Size = new Size(194, 22);
            txtbapellido.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 324);
            label5.Name = "label5";
            label5.Size = new Size(0, 14);
            label5.TabIndex = 9;
            // 
            // lblnombrersl
            // 
            lblnombrersl.AutoSize = true;
            lblnombrersl.Location = new Point(75, 365);
            lblnombrersl.Name = "lblnombrersl";
            lblnombrersl.Size = new Size(0, 14);
            lblnombrersl.TabIndex = 11;
            // 
            // btnfinalizar
            // 
            btnfinalizar.BackColor = SystemColors.ButtonHighlight;
            btnfinalizar.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnfinalizar.Location = new Point(809, 365);
            btnfinalizar.Name = "btnfinalizar";
            btnfinalizar.Size = new Size(78, 24);
            btnfinalizar.TabIndex = 12;
            btnfinalizar.Text = "Guardar";
            btnfinalizar.UseVisualStyleBackColor = false;
            btnfinalizar.Click += btnfinalizar_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(329, 249);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 14);
            lblresultado.TabIndex = 15;
            // 
            // lblresultado1
            // 
            lblresultado1.AutoSize = true;
            lblresultado1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblresultado1.ForeColor = SystemColors.ActiveCaptionText;
            lblresultado1.Location = new Point(357, 293);
            lblresultado1.Name = "lblresultado1";
            lblresultado1.Size = new Size(229, 19);
            lblresultado1.TabIndex = 16;
            lblresultado1.Text = "Empleado creado con exito!!";
            lblresultado1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2023_10_31_151738_removebg_preview1;
            pictureBox1.Location = new Point(300, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtbid
            // 
            txtbid.Location = new Point(665, 182);
            txtbid.Name = "txtbid";
            txtbid.Size = new Size(194, 22);
            txtbid.TabIndex = 18;
            // 
            // dtgvresumen
            // 
            dtgvresumen.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvresumen.BorderStyle = BorderStyle.None;
            dtgvresumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvresumen.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgvresumen.Location = new Point(185, 324);
            dtgvresumen.Name = "dtgvresumen";
            dtgvresumen.ReadOnly = true;
            dtgvresumen.RowTemplate.Height = 25;
            dtgvresumen.Size = new Size(543, 147);
            dtgvresumen.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Numero";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cedula ";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ButtonHighlight;
            btnsalir.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnsalir.Location = new Point(809, 447);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(78, 24);
            btnsalir.TabIndex = 20;
            btnsalir.Text = "Salir ";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = SystemColors.ButtonHighlight;
            btneliminar.Location = new Point(809, 409);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(78, 24);
            btneliminar.TabIndex = 21;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(899, 470);
            Controls.Add(btneliminar);
            Controls.Add(btnsalir);
            Controls.Add(dtgvresumen);
            Controls.Add(txtbid);
            Controls.Add(pictureBox1);
            Controls.Add(lblresultado1);
            Controls.Add(lblresultado);
            Controls.Add(btnfinalizar);
            Controls.Add(lblnombrersl);
            Controls.Add(label5);
            Controls.Add(txtbapellido);
            Controls.Add(txtbnumero);
            Controls.Add(txtbname);
            Controls.Add(btnnombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvresumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label btnnombre;
        private TextBox txtbname;
        private TextBox txtbnumero;
        private TextBox txtbapellido;
        private Label label5;
        private Label lblnombrersl;
        private Button btnfinalizar;
        private Label lblresultado;
        private Label lblresultado1;
        private PictureBox pictureBox1;
        private TextBox txtbid;
        private DataGridView dtgvresumen;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnsalir;
        private Button btneliminar;
    }
}