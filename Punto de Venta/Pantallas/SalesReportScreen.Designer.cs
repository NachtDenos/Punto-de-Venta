
namespace Punto_de_Venta
{
    partial class SalesReportScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridSalesReport = new System.Windows.Forms.DataGridView();
            this.fcV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSalesReportCaja = new System.Windows.Forms.ComboBox();
            this.cbSalesReportDepart = new System.Windows.Forms.ComboBox();
            this.dtpSalesReport1 = new System.Windows.Forms.DateTimePicker();
            this.dtpSalesReport2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 88;
            this.label3.Text = "Caja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 86;
            this.label12.Text = "Filtros:";
            // 
            // dataGridSalesReport
            // 
            this.dataGridSalesReport.AllowUserToAddRows = false;
            this.dataGridSalesReport.AllowUserToDeleteRows = false;
            this.dataGridSalesReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fcV,
            this.Dep,
            this.Cod,
            this.Precio,
            this.UniV,
            this.Sub,
            this.Desc,
            this.Ven,
            this.Uti});
            this.dataGridSalesReport.Location = new System.Drawing.Point(94, 228);
            this.dataGridSalesReport.Name = "dataGridSalesReport";
            this.dataGridSalesReport.ReadOnly = true;
            this.dataGridSalesReport.Size = new System.Drawing.Size(758, 362);
            this.dataGridSalesReport.TabIndex = 85;
            // 
            // fcV
            // 
            this.fcV.HeaderText = "Fecha de Venta";
            this.fcV.Name = "fcV";
            this.fcV.ReadOnly = true;
            // 
            // Dep
            // 
            this.Dep.HeaderText = "Departamento";
            this.Dep.Name = "Dep";
            this.Dep.ReadOnly = true;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Código de artículo";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // UniV
            // 
            this.UniV.HeaderText = "Unidades Vendidas";
            this.UniV.Name = "UniV";
            this.UniV.ReadOnly = true;
            // 
            // Sub
            // 
            this.Sub.HeaderText = "Subtotal";
            this.Sub.Name = "Sub";
            this.Sub.ReadOnly = true;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descuento";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // Ven
            // 
            this.Ven.HeaderText = "Venta";
            this.Ven.Name = "Ven";
            this.Ven.ReadOnly = true;
            // 
            // Uti
            // 
            this.Uti.HeaderText = "Utilidad";
            this.Uti.Name = "Uti";
            this.Uti.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 44);
            this.label2.TabIndex = 84;
            this.label2.Text = "Reporte de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "Rango de fechas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Departamento";
            // 
            // cbSalesReportCaja
            // 
            this.cbSalesReportCaja.FormattingEnabled = true;
            this.cbSalesReportCaja.Items.AddRange(new object[] {
            "Caja 1",
            "Caja 2",
            "Caja 3",
            "Caja 4",
            "Todas las cajas"});
            this.cbSalesReportCaja.Location = new System.Drawing.Point(94, 172);
            this.cbSalesReportCaja.Name = "cbSalesReportCaja";
            this.cbSalesReportCaja.Size = new System.Drawing.Size(141, 21);
            this.cbSalesReportCaja.TabIndex = 91;
            this.cbSalesReportCaja.Text = "Seleccionar";
            // 
            // cbSalesReportDepart
            // 
            this.cbSalesReportDepart.FormattingEnabled = true;
            this.cbSalesReportDepart.Items.AddRange(new object[] {
            "Frutería",
            "Carnes",
            "Lacteos",
            "Bebidas",
            "Todos los departamentos"});
            this.cbSalesReportDepart.Location = new System.Drawing.Point(368, 172);
            this.cbSalesReportDepart.Name = "cbSalesReportDepart";
            this.cbSalesReportDepart.Size = new System.Drawing.Size(141, 21);
            this.cbSalesReportDepart.TabIndex = 92;
            this.cbSalesReportDepart.Text = "Seleccionar";
            // 
            // dtpSalesReport1
            // 
            this.dtpSalesReport1.Location = new System.Drawing.Point(624, 173);
            this.dtpSalesReport1.Name = "dtpSalesReport1";
            this.dtpSalesReport1.Size = new System.Drawing.Size(110, 20);
            this.dtpSalesReport1.TabIndex = 93;
            // 
            // dtpSalesReport2
            // 
            this.dtpSalesReport2.Location = new System.Drawing.Point(785, 173);
            this.dtpSalesReport2.Name = "dtpSalesReport2";
            this.dtpSalesReport2.Size = new System.Drawing.Size(110, 20);
            this.dtpSalesReport2.TabIndex = 94;
            // 
            // SalesReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.dtpSalesReport2);
            this.Controls.Add(this.dtpSalesReport1);
            this.Controls.Add(this.cbSalesReportDepart);
            this.Controls.Add(this.cbSalesReportCaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridSalesReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalesReportScreen";
            this.Text = "Reporte de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridSalesReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSalesReportCaja;
        private System.Windows.Forms.ComboBox cbSalesReportDepart;
        private System.Windows.Forms.DateTimePicker dtpSalesReport1;
        private System.Windows.Forms.DateTimePicker dtpSalesReport2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uti;
    }
}