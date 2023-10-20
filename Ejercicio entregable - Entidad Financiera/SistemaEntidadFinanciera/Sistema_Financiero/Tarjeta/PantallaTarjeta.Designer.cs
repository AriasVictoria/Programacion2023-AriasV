namespace Sistema_Financiero.Tarjeta
{
    partial class PantallaTarjeta
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
            textBox5 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroTarjetaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            limiteCreditoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saldoDisponibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoDeudaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueñoTarjetaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tarjetadeCréditoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarjetadeCréditoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(139, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 208);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 36;
            label5.Text = "Estado";
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(645, 284);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 35;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(343, 284);
            button1.Name = "button1";
            button1.Size = new Size(103, 29);
            button1.TabIndex = 34;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(139, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 32;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 163);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 29;
            label4.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 120);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 28;
            label3.Text = "Limite credito";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 26;
            label2.Text = "Numero Tarjeta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 25;
            label1.Text = "Id";
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(489, 284);
            button3.Name = "button3";
            button3.Size = new Size(103, 29);
            button3.TabIndex = 38;
            button3.Text = "PAUSAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, numeroTarjetaDataGridViewTextBoxColumn, limiteCreditoDataGridViewTextBoxColumn, saldoDisponibleDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, montoDeudaDataGridViewTextBoxColumn, dueñoTarjetaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tarjetadeCréditoBindingSource;
            dataGridView1.Location = new Point(260, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(528, 194);
            dataGridView1.TabIndex = 39;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numeroTarjetaDataGridViewTextBoxColumn
            // 
            numeroTarjetaDataGridViewTextBoxColumn.DataPropertyName = "numeroTarjeta";
            numeroTarjetaDataGridViewTextBoxColumn.HeaderText = "numeroTarjeta";
            numeroTarjetaDataGridViewTextBoxColumn.Name = "numeroTarjetaDataGridViewTextBoxColumn";
            // 
            // limiteCreditoDataGridViewTextBoxColumn
            // 
            limiteCreditoDataGridViewTextBoxColumn.DataPropertyName = "limiteCredito";
            limiteCreditoDataGridViewTextBoxColumn.HeaderText = "limiteCredito";
            limiteCreditoDataGridViewTextBoxColumn.Name = "limiteCreditoDataGridViewTextBoxColumn";
            // 
            // saldoDisponibleDataGridViewTextBoxColumn
            // 
            saldoDisponibleDataGridViewTextBoxColumn.DataPropertyName = "saldoDisponible";
            saldoDisponibleDataGridViewTextBoxColumn.HeaderText = "saldoDisponible";
            saldoDisponibleDataGridViewTextBoxColumn.Name = "saldoDisponibleDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // montoDeudaDataGridViewTextBoxColumn
            // 
            montoDeudaDataGridViewTextBoxColumn.DataPropertyName = "MontoDeuda";
            montoDeudaDataGridViewTextBoxColumn.HeaderText = "MontoDeuda";
            montoDeudaDataGridViewTextBoxColumn.Name = "montoDeudaDataGridViewTextBoxColumn";
            // 
            // dueñoTarjetaDataGridViewTextBoxColumn
            // 
            dueñoTarjetaDataGridViewTextBoxColumn.DataPropertyName = "DueñoTarjeta";
            dueñoTarjetaDataGridViewTextBoxColumn.HeaderText = "DueñoTarjeta";
            dueñoTarjetaDataGridViewTextBoxColumn.Name = "dueñoTarjetaDataGridViewTextBoxColumn";
            // 
            // tarjetadeCréditoBindingSource
            // 
            tarjetadeCréditoBindingSource.DataSource = typeof(Back_Aplicación_Bancaria.Tarjeta_de_Crédito);
            // 
            // PantallaTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(label5);
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
            Name = "PantallaTarjeta";
            Text = "PantallaTarjeta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarjetadeCréditoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox5;
        private Label label5;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroTarjetaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn limiteCreditoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saldoDisponibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDeudaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueñoTarjetaDataGridViewTextBoxColumn;
        private BindingSource tarjetadeCréditoBindingSource;
    }
}