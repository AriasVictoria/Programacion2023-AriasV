namespace Sistema_Financiero
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem1 = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            agregarCuentaToolStripMenuItem = new ToolStripMenuItem();
            tarjetaToolStripMenuItem = new ToolStripMenuItem();
            resumenTarjetaToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(267, 125);
            label1.Name = "label1";
            label1.Size = new Size(224, 22);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA FINANCIERO";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.BackColor = Color.IndianRed;
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem1 });
            clienteToolStripMenuItem.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clienteToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(72, 23);
            clienteToolStripMenuItem.Text = "MENÚ";
            // 
            // clienteToolStripMenuItem1
            // 
            clienteToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem, agregarCuentaToolStripMenuItem, tarjetaToolStripMenuItem });
            clienteToolStripMenuItem1.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            clienteToolStripMenuItem1.Size = new Size(180, 22);
            clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 192);
            altaToolStripMenuItem.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(180, 22);
            altaToolStripMenuItem.Text = "Alta cliente";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // agregarCuentaToolStripMenuItem
            // 
            agregarCuentaToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 128);
            agregarCuentaToolStripMenuItem.Name = "agregarCuentaToolStripMenuItem";
            agregarCuentaToolStripMenuItem.Size = new Size(180, 22);
            agregarCuentaToolStripMenuItem.Text = "Cuenta";
            agregarCuentaToolStripMenuItem.Click += agregarCuentaToolStripMenuItem_Click;
            // 
            // tarjetaToolStripMenuItem
            // 
            tarjetaToolStripMenuItem.BackColor = Color.Tomato;
            tarjetaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resumenTarjetaToolStripMenuItem1 });
            tarjetaToolStripMenuItem.Name = "tarjetaToolStripMenuItem";
            tarjetaToolStripMenuItem.Size = new Size(180, 22);
            tarjetaToolStripMenuItem.Text = "Tarjeta";
            tarjetaToolStripMenuItem.Click += tarjetaToolStripMenuItem_Click;
            // 
            // resumenTarjetaToolStripMenuItem1
            // 
            resumenTarjetaToolStripMenuItem1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            resumenTarjetaToolStripMenuItem1.Name = "resumenTarjetaToolStripMenuItem1";
            resumenTarjetaToolStripMenuItem1.Size = new Size(180, 22);
            resumenTarjetaToolStripMenuItem1.Text = "Resumen tarjeta";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Menu";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem1;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem agregarCuentaToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tarjetaToolStripMenuItem;
        private ToolStripMenuItem resumenTarjetaToolStripMenuItem1;
    }
}