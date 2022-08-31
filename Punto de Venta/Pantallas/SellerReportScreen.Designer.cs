
namespace Punto_de_Venta
{
    partial class SellerReportScreen
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
            this.dtpSellerReport2 = new System.Windows.Forms.DateTimePicker();
            this.dtpSellerReport1 = new System.Windows.Forms.DateTimePicker();
            this.cbSellerReportDept = new System.Windows.Forms.ComboBox();
            this.cbSellerReportSeller = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridSellerReport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSellerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSellerReport2
            // 
            this.dtpSellerReport2.Location = new System.Drawing.Point(782, 183);
            this.dtpSellerReport2.Name = "dtpSellerReport2";
            this.dtpSellerReport2.Size = new System.Drawing.Size(110, 20);
            this.dtpSellerReport2.TabIndex = 104;
            // 
            // dtpSellerReport1
            // 
            this.dtpSellerReport1.Location = new System.Drawing.Point(621, 183);
            this.dtpSellerReport1.Name = "dtpSellerReport1";
            this.dtpSellerReport1.Size = new System.Drawing.Size(110, 20);
            this.dtpSellerReport1.TabIndex = 103;
            // 
            // cbSellerReportDept
            // 
            this.cbSellerReportDept.FormattingEnabled = true;
            this.cbSellerReportDept.Items.AddRange(new object[] {
            "Frutería",
            "Carnes",
            "Lacteos",
            "Bebidas",
            "Todos los departamentos"});
            this.cbSellerReportDept.Location = new System.Drawing.Point(365, 182);
            this.cbSellerReportDept.Name = "cbSellerReportDept";
            this.cbSellerReportDept.Size = new System.Drawing.Size(141, 21);
            this.cbSellerReportDept.TabIndex = 102;
            this.cbSellerReportDept.Text = "Seleccionar";
            // 
            // cbSellerReportSeller
            // 
            this.cbSellerReportSeller.FormattingEnabled = true;
            this.cbSellerReportSeller.Items.AddRange(new object[] {
            "C123",
            "C115",
            "C117",
            "Todos"});
            this.cbSellerReportSeller.Location = new System.Drawing.Point(91, 182);
            this.cbSellerReportSeller.Name = "cbSellerReportSeller";
            this.cbSellerReportSeller.Size = new System.Drawing.Size(141, 21);
            this.cbSellerReportSeller.TabIndex = 101;
            this.cbSellerReportSeller.Text = "Seleccionar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 100;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 99;
            this.label3.Text = "Cajero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 98;
            this.label12.Text = "Filtros:";
            // 
            // dataGridSellerReport
            // 
            this.dataGridSellerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSellerReport.Location = new System.Drawing.Point(91, 238);
            this.dataGridSellerReport.Name = "dataGridSellerReport";
            this.dataGridSellerReport.Size = new System.Drawing.Size(758, 362);
            this.dataGridSellerReport.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 44);
            this.label2.TabIndex = 96;
            this.label2.Text = "Reporte de Cajeros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(661, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Rango de fechas";
            // 
            // SellerReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.dtpSellerReport2);
            this.Controls.Add(this.dtpSellerReport1);
            this.Controls.Add(this.cbSellerReportDept);
            this.Controls.Add(this.cbSellerReportSeller);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridSellerReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SellerReportScreen";
            this.Text = "Reporte por cajero";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSellerReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSellerReport2;
        private System.Windows.Forms.DateTimePicker dtpSellerReport1;
        private System.Windows.Forms.ComboBox cbSellerReportDept;
        private System.Windows.Forms.ComboBox cbSellerReportSeller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridSellerReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}