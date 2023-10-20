namespace Sistema_Financiero.Cuenta
{
    partial class Movimientos
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(70, 142);
            button1.Name = "button1";
            button1.Size = new Size(123, 61);
            button1.TabIndex = 7;
            button1.Text = "Realizar deposito";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(589, 142);
            button2.Name = "button2";
            button2.Size = new Size(123, 61);
            button2.TabIndex = 7;
            button2.Text = "Realizar Extraccioón";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(332, 142);
            button3.Name = "button3";
            button3.Size = new Size(123, 61);
            button3.TabIndex = 8;
            button3.Text = "Realizar tranferencia";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(673, 358);
            button4.Name = "button4";
            button4.Size = new Size(82, 39);
            button4.TabIndex = 32;
            button4.Text = "VOLVER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Movimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Movimientos";
            Text = "Movimientos";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}