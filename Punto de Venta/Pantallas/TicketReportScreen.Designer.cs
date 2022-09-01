
namespace Punto_de_Venta
{
    partial class TicketReportScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.pbTemporal = new System.Windows.Forms.PictureBox();
            this.txtIdTicketReport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultTicketReport1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTicketReport = new System.Windows.Forms.DateTimePicker();
            this.cbTicketReport = new System.Windows.Forms.ComboBox();
            this.btnConsultTicketReport2 = new System.Windows.Forms.Button();
            this.btnReprintTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemporal)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 44);
            this.label2.TabIndex = 85;
            this.label2.Text = "Recibos / Notas de crédito";
            // 
            // pbTemporal
            // 
            this.pbTemporal.Location = new System.Drawing.Point(474, 95);
            this.pbTemporal.Name = "pbTemporal";
            this.pbTemporal.Size = new System.Drawing.Size(364, 493);
            this.pbTemporal.TabIndex = 86;
            this.pbTemporal.TabStop = false;
            // 
            // txtIdTicketReport
            // 
            this.txtIdTicketReport.Location = new System.Drawing.Point(43, 144);
            this.txtIdTicketReport.Multiline = true;
            this.txtIdTicketReport.Name = "txtIdTicketReport";
            this.txtIdTicketReport.Size = new System.Drawing.Size(235, 22);
            this.txtIdTicketReport.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 22);
            this.label1.TabIndex = 87;
            this.label1.Text = "Número de recibo / Nota de crédito";
            // 
            // btnConsultTicketReport1
            // 
            this.btnConsultTicketReport1.BackColor = System.Drawing.Color.Navy;
            this.btnConsultTicketReport1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultTicketReport1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultTicketReport1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultTicketReport1.Location = new System.Drawing.Point(43, 172);
            this.btnConsultTicketReport1.Name = "btnConsultTicketReport1";
            this.btnConsultTicketReport1.Size = new System.Drawing.Size(139, 51);
            this.btnConsultTicketReport1.TabIndex = 89;
            this.btnConsultTicketReport1.Text = "Consultar";
            this.btnConsultTicketReport1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 90;
            this.label3.Text = "Fecha de venta y Caja ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 22);
            this.label4.TabIndex = 91;
            this.label4.Text = "Número de recibo / Nota de crédito";
            // 
            // dtpTicketReport
            // 
            this.dtpTicketReport.Location = new System.Drawing.Point(43, 272);
            this.dtpTicketReport.Name = "dtpTicketReport";
            this.dtpTicketReport.Size = new System.Drawing.Size(235, 20);
            this.dtpTicketReport.TabIndex = 92;
            // 
            // cbTicketReport
            // 
            this.cbTicketReport.FormattingEnabled = true;
            this.cbTicketReport.Items.AddRange(new object[] {
            "Caja 1",
            "Caja 2",
            "Caja 3",
            "Caja 4",
            "Caja 5"});
            this.cbTicketReport.Location = new System.Drawing.Point(43, 326);
            this.cbTicketReport.Name = "cbTicketReport";
            this.cbTicketReport.Size = new System.Drawing.Size(235, 21);
            this.cbTicketReport.TabIndex = 93;
            this.cbTicketReport.Text = "Seleccionar";
            // 
            // btnConsultTicketReport2
            // 
            this.btnConsultTicketReport2.BackColor = System.Drawing.Color.Navy;
            this.btnConsultTicketReport2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultTicketReport2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultTicketReport2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultTicketReport2.Location = new System.Drawing.Point(43, 353);
            this.btnConsultTicketReport2.Name = "btnConsultTicketReport2";
            this.btnConsultTicketReport2.Size = new System.Drawing.Size(139, 51);
            this.btnConsultTicketReport2.TabIndex = 94;
            this.btnConsultTicketReport2.Text = "Consultar";
            this.btnConsultTicketReport2.UseVisualStyleBackColor = false;
            // 
            // btnReprintTicket
            // 
            this.btnReprintTicket.BackColor = System.Drawing.Color.Green;
            this.btnReprintTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReprintTicket.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprintTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReprintTicket.Location = new System.Drawing.Point(43, 548);
            this.btnReprintTicket.Name = "btnReprintTicket";
            this.btnReprintTicket.Size = new System.Drawing.Size(139, 51);
            this.btnReprintTicket.TabIndex = 95;
            this.btnReprintTicket.Text = "Reimprimir";
            this.btnReprintTicket.UseVisualStyleBackColor = false;
            // 
            // TicketReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnReprintTicket);
            this.Controls.Add(this.btnConsultTicketReport2);
            this.Controls.Add(this.cbTicketReport);
            this.Controls.Add(this.dtpTicketReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultTicketReport1);
            this.Controls.Add(this.txtIdTicketReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTemporal);
            this.Controls.Add(this.label2);
            this.Name = "TicketReportScreen";
            this.Text = "Consulta de Recibos";
            ((System.ComponentModel.ISupportInitialize)(this.pbTemporal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbTemporal;
        private System.Windows.Forms.TextBox txtIdTicketReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultTicketReport1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTicketReport;
        private System.Windows.Forms.ComboBox cbTicketReport;
        private System.Windows.Forms.Button btnConsultTicketReport2;
        private System.Windows.Forms.Button btnReprintTicket;
    }
}