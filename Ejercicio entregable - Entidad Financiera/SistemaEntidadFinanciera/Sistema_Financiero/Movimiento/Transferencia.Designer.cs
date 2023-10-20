namespace Sistema_Financiero.Movimiento
{
    partial class Transferencia
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
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(621, 283);
            button2.Name = "button2";
            button2.Size = new Size(82, 39);
            button2.TabIndex = 39;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(444, 283);
            button1.Name = "button1";
            button1.Size = new Size(114, 39);
            button1.TabIndex = 38;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(205, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 162);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 35;
            label3.Text = "Monto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 120);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 33;
            label2.Text = "Cuenta destino";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 79);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 32;
            label1.Text = "Cuenta origen";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(368, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(386, 165);
            dataGridView1.TabIndex = 40;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cuenta origen";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Cuenta destino";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Monto";
            Column3.Name = "Column3";
            // 
            // Transferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Transferencia";
            Text = "Tranferencia";
            Load += Transferencia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}