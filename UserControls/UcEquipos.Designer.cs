namespace SolverMaintApp.Frontend.UserControls
{
    partial class UcEquipos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 

            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(325, 159);
            label1.Name = "label1";
            label1.Size = new Size(202, 78);
            label1.TabIndex = 0;
            label1.Text = "Equipos";

            // 
            // UcEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Name = "UcEquipos";
            Size = new Size(759, 392);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
