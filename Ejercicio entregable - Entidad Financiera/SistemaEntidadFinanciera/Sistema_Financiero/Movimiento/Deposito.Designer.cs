namespace Sistema_Financiero.Movimiento
{
    partial class Deposito
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
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(209, 96);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 29;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 28;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 146);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 27;
            label3.Text = "Monto";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 104);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 25;
            label2.Text = "Cuenta";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(404, 277);
            button1.Name = "button1";
            button1.Size = new Size(114, 39);
            button1.TabIndex = 30;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(581, 277);
            button2.Name = "button2";
            button2.Size = new Size(82, 39);
            button2.TabIndex = 31;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            dataGridView1.Location = new Point(385, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(287, 149);
            dataGridView1.TabIndex = 32;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cuenta";
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "Monto";
            Column1.Name = "Column1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 63);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 33;
            label1.Text = "Id";
            // 
            // Deposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Deposito";
            Text = "Deposito";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBox1;
        private Label label1;
    }
}