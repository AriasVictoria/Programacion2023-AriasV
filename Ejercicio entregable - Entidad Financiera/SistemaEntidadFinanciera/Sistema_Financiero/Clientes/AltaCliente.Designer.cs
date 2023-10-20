namespace Sistema_Financiero
{
    partial class AltaCliente
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            clienteBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreclienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoclienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 53);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 100);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Dni";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 143);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 183);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Apellido";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(317, 258);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 9;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(520, 258);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 10;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, nombreclienteDataGridViewTextBoxColumn, apellidoclienteDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource;
            dataGridView1.Location = new Point(334, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(445, 150);
            dataGridView1.TabIndex = 11;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Back_Aplicación_Bancaria.Cliente);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_cliente";
            nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre_cliente";
            nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            // 
            // apellidoclienteDataGridViewTextBoxColumn
            // 
            apellidoclienteDataGridViewTextBoxColumn.DataPropertyName = "Apellido_cliente";
            apellidoclienteDataGridViewTextBoxColumn.HeaderText = "Apellido_cliente";
            apellidoclienteDataGridViewTextBoxColumn.Name = "apellidoclienteDataGridViewTextBoxColumn";
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaCliente";
            Text = "AltaCliente";
            Load += AltaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoclienteDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
    }
}