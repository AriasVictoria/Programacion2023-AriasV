namespace Sistema_Financiero.Movimiento
{
    partial class Extracción
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(600, 288);
            button2.Name = "button2";
            button2.Size = new Size(82, 39);
            button2.TabIndex = 47;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(423, 288);
            button1.Name = "button1";
            button1.Size = new Size(114, 39);
            button1.TabIndex = 46;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(250, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 53;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 155);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 51;
            label3.Text = "Monto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 113);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 49;
            label2.Text = "Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(410, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(334, 165);
            dataGridView1.TabIndex = 54;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Monto";
            Column2.Name = "Column2";
            // 
            // Extracción
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Extracción";
            Text = "Extracción";
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
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}