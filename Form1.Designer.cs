namespace SolverMaintApp.Frontend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            fichaTecnicaToolStripButton = new ToolStripButton();
            equiposToolStripButton = new ToolStripButton();
            panel1 = new Panel();
            panelUserControler = new Panel();
            lblTitle = new Label();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.White;
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, fichaTecnicaToolStripButton, equiposToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(41, 450);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(39, 30);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(39, 6);
            // 
            // fichaTecnicaToolStripButton
            // 
            fichaTecnicaToolStripButton.AutoSize = false;
            fichaTecnicaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fichaTecnicaToolStripButton.Image = (Image)resources.GetObject("fichaTecnicaToolStripButton.Image");
            fichaTecnicaToolStripButton.ImageTransparentColor = Color.Magenta;
            fichaTecnicaToolStripButton.Name = "fichaTecnicaToolStripButton";
            fichaTecnicaToolStripButton.Size = new Size(25, 20);
            fichaTecnicaToolStripButton.Text = "Ficha Técnica";
            fichaTecnicaToolStripButton.ToolTipText = "Ficha Técnica";
            fichaTecnicaToolStripButton.Click += fichaTecnicaToolStripButton_Click;
            // 
            // equiposToolStripButton
            // 
            equiposToolStripButton.AutoSize = false;
            equiposToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            equiposToolStripButton.Image = (Image)resources.GetObject("equiposToolStripButton.Image");
            equiposToolStripButton.ImageTransparentColor = Color.Magenta;
            equiposToolStripButton.Name = "equiposToolStripButton";
            equiposToolStripButton.Size = new Size(25, 20);
            equiposToolStripButton.Text = "Equipos";
            equiposToolStripButton.Click += equiposToolStripButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(41, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 58);
            panel1.TabIndex = 1;
            // 
            // panelUserControler
            // 
            panelUserControler.Dock = DockStyle.Fill;
            panelUserControler.Location = new Point(41, 58);
            panelUserControler.Name = "panelUserControler";
            panelUserControler.Size = new Size(759, 392);
            panelUserControler.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 10);
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(3, 2);
            lblTitle.TabIndex = 0;
            lblTitle.Text = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelUserControler);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton fichaTecnicaToolStripButton;
        private ToolStripButton equiposToolStripButton;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private Panel panel1;
        private Panel panelUserControler;
        private Label lblTitle;
    }
}