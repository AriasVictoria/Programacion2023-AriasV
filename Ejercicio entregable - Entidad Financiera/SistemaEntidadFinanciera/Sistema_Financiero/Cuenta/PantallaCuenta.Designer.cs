namespace Sistema_Financiero
{
    partial class PantallaCuenta
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
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            dueñoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipocuentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroCuentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saldoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cuentaBancariaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuentaBancariaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(671, 290);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 21;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(334, 290);
            button1.Name = "button1";
            button1.Size = new Size(103, 29);
            button1.TabIndex = 20;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 178);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 15;
            label4.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 129);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 14;
            label3.Text = "Numero Cuenta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 11;
            label1.Text = "Id dueño";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 87);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 22;
            label5.Text = "Tipo cuenta";
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(499, 290);
            button3.Name = "button3";
            button3.Size = new Size(112, 29);
            button3.TabIndex = 24;
            button3.Text = "MOVIMIENTOS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dueñoDataGridViewTextBoxColumn, tipocuentaDataGridViewTextBoxColumn, numeroCuentaDataGridViewTextBoxColumn, saldoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cuentaBancariaBindingSource;
            dataGridView1.Location = new Point(307, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(446, 209);
            dataGridView1.TabIndex = 25;
            // 
            // dueñoDataGridViewTextBoxColumn
            // 
            dueñoDataGridViewTextBoxColumn.DataPropertyName = "Dueño";
            dueñoDataGridViewTextBoxColumn.HeaderText = "Dueño";
            dueñoDataGridViewTextBoxColumn.Name = "dueñoDataGridViewTextBoxColumn";
            // 
            // tipocuentaDataGridViewTextBoxColumn
            // 
            tipocuentaDataGridViewTextBoxColumn.DataPropertyName = "tipo_cuenta";
            tipocuentaDataGridViewTextBoxColumn.HeaderText = "tipo_cuenta";
            tipocuentaDataGridViewTextBoxColumn.Name = "tipocuentaDataGridViewTextBoxColumn";
            // 
            // numeroCuentaDataGridViewTextBoxColumn
            // 
            numeroCuentaDataGridViewTextBoxColumn.DataPropertyName = "Numero_Cuenta";
            numeroCuentaDataGridViewTextBoxColumn.HeaderText = "Numero_Cuenta";
            numeroCuentaDataGridViewTextBoxColumn.Name = "numeroCuentaDataGridViewTextBoxColumn";
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            saldoDataGridViewTextBoxColumn.HeaderText = "saldo";
            saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            // 
            // cuentaBancariaBindingSource
            // 
            cuentaBancariaBindingSource.DataSource = typeof(Back_Aplicación_Bancaria.Cuenta_Bancaria);
            // 
            // PantallaCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PantallaCuenta";
            Text = "PantallaCuenta";
            Load += PantallaCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuentaBancariaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dueñoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipocuentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroCuentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private BindingSource cuentaBancariaBindingSource;
    }
}