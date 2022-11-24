
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSalesReport1 = new System.Windows.Forms.DateTimePicker();
            this.dtpSalesReport2 = new System.Windows.Forms.DateTimePicker();
            this.txtVentaCajaReport = new System.Windows.Forms.TextBox();
            this.txtVentaDepaReport = new System.Windows.Forms.TextBox();
            this.btnFiltroFechaVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 123);
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
            this.dataGridSalesReport.Location = new System.Drawing.Point(94, 228);
            this.dataGridSalesReport.Name = "dataGridSalesReport";
            this.dataGridSalesReport.ReadOnly = true;
            this.dataGridSalesReport.Size = new System.Drawing.Size(758, 316);
            this.dataGridSalesReport.TabIndex = 85;
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
            this.label1.Location = new System.Drawing.Point(662, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "Rango de fechas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Departamento";
            // 
            // dtpSalesReport1
            // 
            this.dtpSalesReport1.Location = new System.Drawing.Point(622, 158);
            this.dtpSalesReport1.Name = "dtpSalesReport1";
            this.dtpSalesReport1.Size = new System.Drawing.Size(110, 20);
            this.dtpSalesReport1.TabIndex = 93;
            // 
            // dtpSalesReport2
            // 
            this.dtpSalesReport2.Location = new System.Drawing.Point(783, 158);
            this.dtpSalesReport2.Name = "dtpSalesReport2";
            this.dtpSalesReport2.Size = new System.Drawing.Size(110, 20);
            this.dtpSalesReport2.TabIndex = 94;
            // 
            // txtVentaCajaReport
            // 
            this.txtVentaCajaReport.Location = new System.Drawing.Point(94, 161);
            this.txtVentaCajaReport.Name = "txtVentaCajaReport";
            this.txtVentaCajaReport.Size = new System.Drawing.Size(123, 20);
            this.txtVentaCajaReport.TabIndex = 106;
            this.txtVentaCajaReport.TextChanged += new System.EventHandler(this.txtVentaCajaReport_TextChanged);
            this.txtVentaCajaReport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVentaCajaReport_KeyPress);
            // 
            // txtVentaDepaReport
            // 
            this.txtVentaDepaReport.Location = new System.Drawing.Point(353, 161);
            this.txtVentaDepaReport.Name = "txtVentaDepaReport";
            this.txtVentaDepaReport.Size = new System.Drawing.Size(134, 20);
            this.txtVentaDepaReport.TabIndex = 107;
            this.txtVentaDepaReport.TextChanged += new System.EventHandler(this.txtVentaDepaReport_TextChanged);
            // 
            // btnFiltroFechaVentas
            // 
            this.btnFiltroFechaVentas.BackColor = System.Drawing.Color.Navy;
            this.btnFiltroFechaVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroFechaVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroFechaVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltroFechaVentas.Location = new System.Drawing.Point(716, 184);
            this.btnFiltroFechaVentas.Name = "btnFiltroFechaVentas";
            this.btnFiltroFechaVentas.Size = new System.Drawing.Size(81, 28);
            this.btnFiltroFechaVentas.TabIndex = 108;
            this.btnFiltroFechaVentas.Text = "Filtrar";
            this.btnFiltroFechaVentas.UseVisualStyleBackColor = false;
            this.btnFiltroFechaVentas.Click += new System.EventHandler(this.btnFiltroFechaVentas_Click);
            // 
            // SalesReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnFiltroFechaVentas);
            this.Controls.Add(this.txtVentaDepaReport);
            this.Controls.Add(this.txtVentaCajaReport);
            this.Controls.Add(this.dtpSalesReport2);
            this.Controls.Add(this.dtpSalesReport1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridSalesReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalesReportScreen";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.SalesReportScreen_Load);
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
        private System.Windows.Forms.DateTimePicker dtpSalesReport1;
        private System.Windows.Forms.DateTimePicker dtpSalesReport2;
        private System.Windows.Forms.TextBox txtVentaCajaReport;
        private System.Windows.Forms.TextBox txtVentaDepaReport;
        private System.Windows.Forms.Button btnFiltroFechaVentas;
    }
}