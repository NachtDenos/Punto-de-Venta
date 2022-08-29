
namespace Punto_de_Venta
{
    partial class EmployeesScreen
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
            this.buttonExitEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExitEmployees
            // 
            this.buttonExitEmployees.Location = new System.Drawing.Point(873, 12);
            this.buttonExitEmployees.Name = "buttonExitEmployees";
            this.buttonExitEmployees.Size = new System.Drawing.Size(49, 34);
            this.buttonExitEmployees.TabIndex = 0;
            this.buttonExitEmployees.Text = "MENU";
            this.buttonExitEmployees.UseVisualStyleBackColor = true;
            this.buttonExitEmployees.Click += new System.EventHandler(this.buttonExitEmployees_Click);
            // 
            // EmployeesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.buttonExitEmployees);
            this.Name = "EmployeesScreen";
            this.Text = "EmployeesScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitEmployees;
    }
}