
namespace Punto_de_Venta
{
    partial class ticketScreen
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
            this.dataGridTicket = new System.Windows.Forms.DataGridView();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTicket
            // 
            this.dataGridTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTicket.Location = new System.Drawing.Point(72, 64);
            this.dataGridTicket.Name = "dataGridTicket";
            this.dataGridTicket.Size = new System.Drawing.Size(446, 460);
            this.dataGridTicket.TabIndex = 0;
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.BackColor = System.Drawing.Color.Green;
            this.btnPrintTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintTicket.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintTicket.Location = new System.Drawing.Point(472, 530);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(111, 44);
            this.btnPrintTicket.TabIndex = 43;
            this.btnPrintTicket.Text = "Imprimir";
            this.btnPrintTicket.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 44);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ticket";
            // 
            // ticketScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintTicket);
            this.Controls.Add(this.dataGridTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ticketScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTicket;
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.Label label1;
    }
}