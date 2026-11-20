namespace PATITAS
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.lblPET = new System.Windows.Forms.Label();
            this.lblSIS = new System.Windows.Forms.Label();
            this.lblMENU = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAimales = new System.Windows.Forms.Button();
            this.btnAdopcion = new System.Windows.Forms.Button();
            this.btnSalud = new System.Windows.Forms.Button();
            this.btnAlimentacin = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.lblMENU);
            this.pnlLateral.Controls.Add(this.lblSIS);
            this.pnlLateral.Controls.Add(this.lblPET);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(231, 450);
            this.pnlLateral.TabIndex = 0;
            // 
            // lblPET
            // 
            this.lblPET.AutoSize = true;
            this.lblPET.Location = new System.Drawing.Point(58, 92);
            this.lblPET.Name = "lblPET";
            this.lblPET.Size = new System.Drawing.Size(60, 13);
            this.lblPET.TabIndex = 0;
            this.lblPET.Text = "PET CARE";
            // 
            // lblSIS
            // 
            this.lblSIS.AutoSize = true;
            this.lblSIS.Location = new System.Drawing.Point(63, 123);
            this.lblSIS.Name = "lblSIS";
            this.lblSIS.Size = new System.Drawing.Size(133, 13);
            this.lblSIS.TabIndex = 1;
            this.lblSIS.Text = "SISTEMA DE ALBERGUE";
            // 
            // lblMENU
            // 
            this.lblMENU.AutoSize = true;
            this.lblMENU.Location = new System.Drawing.Point(65, 157);
            this.lblMENU.Name = "lblMENU";
            this.lblMENU.Size = new System.Drawing.Size(98, 13);
            this.lblMENU.TabIndex = 2;
            this.lblMENU.Text = "MENU PRINCIPAL";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(255, 30);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(77, 27);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashbord";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnAimales
            // 
            this.btnAimales.Location = new System.Drawing.Point(345, 32);
            this.btnAimales.Name = "btnAimales";
            this.btnAimales.Size = new System.Drawing.Size(69, 24);
            this.btnAimales.TabIndex = 2;
            this.btnAimales.Text = "Animales";
            this.btnAimales.UseVisualStyleBackColor = true;
            // 
            // btnAdopcion
            // 
            this.btnAdopcion.Location = new System.Drawing.Point(428, 36);
            this.btnAdopcion.Name = "btnAdopcion";
            this.btnAdopcion.Size = new System.Drawing.Size(85, 20);
            this.btnAdopcion.TabIndex = 3;
            this.btnAdopcion.Text = "Adopciones";
            this.btnAdopcion.UseVisualStyleBackColor = true;
            // 
            // btnSalud
            // 
            this.btnSalud.Location = new System.Drawing.Point(529, 36);
            this.btnSalud.Name = "btnSalud";
            this.btnSalud.Size = new System.Drawing.Size(64, 19);
            this.btnSalud.TabIndex = 4;
            this.btnSalud.Text = "Salud";
            this.btnSalud.UseVisualStyleBackColor = true;
            // 
            // btnAlimentacin
            // 
            this.btnAlimentacin.Location = new System.Drawing.Point(607, 35);
            this.btnAlimentacin.Name = "btnAlimentacin";
            this.btnAlimentacin.Size = new System.Drawing.Size(79, 21);
            this.btnAlimentacin.TabIndex = 5;
            this.btnAlimentacin.Text = "Alimentacion";
            this.btnAlimentacin.UseVisualStyleBackColor = true;
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(348, 103);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(65, 20);
            this.btnPersonal.TabIndex = 6;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.btnAlimentacin);
            this.Controls.Add(this.btnSalud);
            this.Controls.Add(this.btnAdopcion);
            this.Controls.Add(this.btnAimales);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.pnlLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\tPET CARE | Gestión de Albergue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Label lblPET;
        private System.Windows.Forms.Label lblMENU;
        private System.Windows.Forms.Label lblSIS;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAimales;
        private System.Windows.Forms.Button btnAdopcion;
        private System.Windows.Forms.Button btnSalud;
        private System.Windows.Forms.Button btnAlimentacin;
        private System.Windows.Forms.Button btnPersonal;
    }
}

