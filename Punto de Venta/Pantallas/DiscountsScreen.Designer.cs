
namespace Punto_de_Venta
{
    partial class DiscountsScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYesNoDiscounts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInDiscounts = new System.Windows.Forms.DateTimePicker();
            this.dtpOutDiscounts = new System.Windows.Forms.DateTimePicker();
            this.btnEditDiscounts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descuentos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 474);
            this.dataGridView1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tiene Descuento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fechas del Descuento:";
            // 
            // cbYesNoDiscounts
            // 
            this.cbYesNoDiscounts.FormattingEnabled = true;
            this.cbYesNoDiscounts.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbYesNoDiscounts.Location = new System.Drawing.Point(39, 152);
            this.cbYesNoDiscounts.Name = "cbYesNoDiscounts";
            this.cbYesNoDiscounts.Size = new System.Drawing.Size(194, 21);
            this.cbYesNoDiscounts.TabIndex = 37;
            this.cbYesNoDiscounts.Text = "Seleccione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Inicia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Finaliza";
            // 
            // dtpInDiscounts
            // 
            this.dtpInDiscounts.Location = new System.Drawing.Point(39, 258);
            this.dtpInDiscounts.Name = "dtpInDiscounts";
            this.dtpInDiscounts.Size = new System.Drawing.Size(200, 20);
            this.dtpInDiscounts.TabIndex = 40;
            // 
            // dtpOutDiscounts
            // 
            this.dtpOutDiscounts.Location = new System.Drawing.Point(39, 332);
            this.dtpOutDiscounts.Name = "dtpOutDiscounts";
            this.dtpOutDiscounts.Size = new System.Drawing.Size(200, 20);
            this.dtpOutDiscounts.TabIndex = 41;
            // 
            // btnEditDiscounts
            // 
            this.btnEditDiscounts.BackColor = System.Drawing.Color.Navy;
            this.btnEditDiscounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDiscounts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDiscounts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditDiscounts.Location = new System.Drawing.Point(39, 536);
            this.btnEditDiscounts.Name = "btnEditDiscounts";
            this.btnEditDiscounts.Size = new System.Drawing.Size(139, 51);
            this.btnEditDiscounts.TabIndex = 53;
            this.btnEditDiscounts.Text = "Editar";
            this.btnEditDiscounts.UseVisualStyleBackColor = false;
            // 
            // DiscountsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnEditDiscounts);
            this.Controls.Add(this.dtpOutDiscounts);
            this.Controls.Add(this.dtpInDiscounts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbYesNoDiscounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "DiscountsScreen";
            this.Text = "Descuentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYesNoDiscounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInDiscounts;
        private System.Windows.Forms.DateTimePicker dtpOutDiscounts;
        private System.Windows.Forms.Button btnEditDiscounts;
    }
}