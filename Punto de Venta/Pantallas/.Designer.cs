
namespace Punto_de_Venta
{
    partial class departamentScreen
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
            this.txtFilterDepartament = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridDepartament = new System.Windows.Forms.DataGridView();
            this.IdDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteDepartament = new System.Windows.Forms.Button();
            this.btnEditDepartament = new System.Windows.Forms.Button();
            this.btnAddDepartament = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameDepartament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDepartament = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDevolutionDepartament = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartament)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterDepartament
            // 
            this.txtFilterDepartament.Location = new System.Drawing.Point(115, 688);
            this.txtFilterDepartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterDepartament.Multiline = true;
            this.txtFilterDepartament.Name = "txtFilterDepartament";
            this.txtFilterDepartament.Size = new System.Drawing.Size(320, 26);
            this.txtFilterDepartament.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 688);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 30);
            this.label12.TabIndex = 78;
            this.label12.Text = "Filtro:";
            // 
            // dataGridDepartament
            // 
            this.dataGridDepartament.AllowUserToDeleteRows = false;
            this.dataGridDepartament.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridDepartament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDepartament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDepartament,
            this.nameDepartament,
            this.returnDepartament});
            this.dataGridDepartament.Location = new System.Drawing.Point(35, 302);
            this.dataGridDepartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridDepartament.Name = "dataGridDepartament";
            this.dataGridDepartament.ReadOnly = true;
            this.dataGridDepartament.RowHeadersWidth = 51;
            this.dataGridDepartament.Size = new System.Drawing.Size(657, 358);
            this.dataGridDepartament.TabIndex = 77;
            // 
            // IdDepartament
            // 
            this.IdDepartament.HeaderText = "Clave";
            this.IdDepartament.MinimumWidth = 6;
            this.IdDepartament.Name = "IdDepartament";
            this.IdDepartament.ReadOnly = true;
            this.IdDepartament.Width = 150;
            // 
            // nameDepartament
            // 
            this.nameDepartament.HeaderText = "Departamento";
            this.nameDepartament.MinimumWidth = 6;
            this.nameDepartament.Name = "nameDepartament";
            this.nameDepartament.ReadOnly = true;
            this.nameDepartament.Width = 150;
            // 
            // returnDepartament
            // 
            this.returnDepartament.HeaderText = "Devolución";
            this.returnDepartament.MinimumWidth = 6;
            this.returnDepartament.Name = "returnDepartament";
            this.returnDepartament.ReadOnly = true;
            this.returnDepartament.Width = 150;
            // 
            // btnDeleteDepartament
            // 
            this.btnDeleteDepartament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteDepartament.Location = new System.Drawing.Point(1023, 672);
            this.btnDeleteDepartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteDepartament.Name = "btnDeleteDepartament";
            this.btnDeleteDepartament.Size = new System.Drawing.Size(185, 63);
            this.btnDeleteDepartament.TabIndex = 76;
            this.btnDeleteDepartament.Text = "Eliminar";
            this.btnDeleteDepartament.UseVisualStyleBackColor = false;
            // 
            // btnEditDepartament
            // 
            this.btnEditDepartament.BackColor = System.Drawing.Color.Navy;
            this.btnEditDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditDepartament.Location = new System.Drawing.Point(816, 672);
            this.btnEditDepartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditDepartament.Name = "btnEditDepartament";
            this.btnEditDepartament.Size = new System.Drawing.Size(185, 63);
            this.btnEditDepartament.TabIndex = 75;
            this.btnEditDepartament.Text = "Editar";
            this.btnEditDepartament.UseVisualStyleBackColor = false;
            // 
            // btnAddDepartament
            // 
            this.btnAddDepartament.BackColor = System.Drawing.Color.Green;
            this.btnAddDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDepartament.Location = new System.Drawing.Point(605, 672);
            this.btnAddDepartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDepartament.Name = "btnAddDepartament";
            this.btnAddDepartament.Size = new System.Drawing.Size(185, 63);
            this.btnAddDepartament.TabIndex = 74;
            this.btnAddDepartament.Text = "Agregar";
            this.btnAddDepartament.UseVisualStyleBackColor = false;
            this.btnAddDepartament.Click += new System.EventHandler(this.btnAddDepartament_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 56);
            this.label2.TabIndex = 61;
            this.label2.Text = "Departamentos";
            // 
            // txtNameDepartament
            // 
            this.txtNameDepartament.Location = new System.Drawing.Point(48, 151);
            this.txtNameDepartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameDepartament.Multiline = true;
            this.txtNameDepartament.Name = "txtNameDepartament";
            this.txtNameDepartament.Size = new System.Drawing.Size(387, 26);
            this.txtNameDepartament.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre";
            // 
            // txtIdDepartament
            // 
            this.txtIdDepartament.Location = new System.Drawing.Point(48, 247);
            this.txtIdDepartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdDepartament.Multiline = true;
            this.txtIdDepartament.Name = "txtIdDepartament";
            this.txtIdDepartament.Size = new System.Drawing.Size(387, 26);
            this.txtIdDepartament.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 30);
            this.label3.TabIndex = 80;
            this.label3.Text = "Clave del departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 30);
            this.label4.TabIndex = 82;
            this.label4.Text = "Devolución";
            // 
            // cbDevolutionDepartament
            // 
            this.cbDevolutionDepartament.FormattingEnabled = true;
            this.cbDevolutionDepartament.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbDevolutionDepartament.Location = new System.Drawing.Point(519, 151);
            this.cbDevolutionDepartament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDevolutionDepartament.Name = "cbDevolutionDepartament";
            this.cbDevolutionDepartament.Size = new System.Drawing.Size(277, 24);
            this.cbDevolutionDepartament.TabIndex = 83;
            this.cbDevolutionDepartament.Text = "Seleccione";
            // 
            // departamentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1245, 777);
            this.Controls.Add(this.cbDevolutionDepartament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdDepartament);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterDepartament);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridDepartament);
            this.Controls.Add(this.btnDeleteDepartament);
            this.Controls.Add(this.btnEditDepartament);
            this.Controls.Add(this.btnAddDepartament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameDepartament);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "departamentScreen";
            this.Text = "Departament";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilterDepartament;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridDepartament;
        private System.Windows.Forms.Button btnDeleteDepartament;
        private System.Windows.Forms.Button btnEditDepartament;
        private System.Windows.Forms.Button btnAddDepartament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameDepartament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDepartament;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDevolutionDepartament;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDepartament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDepartament;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDepartament;
    }
}