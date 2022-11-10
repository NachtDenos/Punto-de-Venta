
namespace Punto_de_Venta
{
    partial class WaytoPayScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaytoPayScreen));
            this.dataGridWayToPay = new System.Windows.Forms.DataGridView();
            this.CodigoPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCashPay = new System.Windows.Forms.TextBox();
            this.txtDebitCardPay = new System.Windows.Forms.TextBox();
            this.txtCreditCardPay = new System.Windows.Forms.TextBox();
            this.txtCheckPay = new System.Windows.Forms.TextBox();
            this.txtVoucherPay = new System.Windows.Forms.TextBox();
            this.txtOtherPay = new System.Windows.Forms.TextBox();
            this.btnPayPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCreditCardPay = new System.Windows.Forms.CheckBox();
            this.rbDebitCardPay = new System.Windows.Forms.CheckBox();
            this.rbCashPay = new System.Windows.Forms.CheckBox();
            this.rbCheckPay = new System.Windows.Forms.CheckBox();
            this.rbOtherPay = new System.Windows.Forms.CheckBox();
            this.rbVouchersPay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWayToPay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWayToPay
            // 
            this.dataGridWayToPay.AllowUserToDeleteRows = false;
            this.dataGridWayToPay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridWayToPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWayToPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPro,
            this.Nombre,
            this.Precio_Unitario,
            this.Cantidad,
            this.Descuento,
            this.Subtotal});
            this.dataGridWayToPay.Location = new System.Drawing.Point(75, 77);
            this.dataGridWayToPay.Name = "dataGridWayToPay";
            this.dataGridWayToPay.ReadOnly = true;
            this.dataGridWayToPay.Size = new System.Drawing.Size(452, 330);
            this.dataGridWayToPay.TabIndex = 0;
            // 
            // CodigoPro
            // 
            this.CodigoPro.HeaderText = "Código";
            this.CodigoPro.Name = "CodigoPro";
            this.CodigoPro.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Método de pago";
            // 
            // txtCashPay
            // 
            this.txtCashPay.Location = new System.Drawing.Point(277, 474);
            this.txtCashPay.Multiline = true;
            this.txtCashPay.Name = "txtCashPay";
            this.txtCashPay.Size = new System.Drawing.Size(64, 22);
            this.txtCashPay.TabIndex = 35;
            this.txtCashPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashPay_KeyPress);
            // 
            // txtDebitCardPay
            // 
            this.txtDebitCardPay.Location = new System.Drawing.Point(159, 525);
            this.txtDebitCardPay.Multiline = true;
            this.txtDebitCardPay.Name = "txtDebitCardPay";
            this.txtDebitCardPay.Size = new System.Drawing.Size(64, 22);
            this.txtDebitCardPay.TabIndex = 36;
            this.txtDebitCardPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebitCardPay_KeyPress);
            // 
            // txtCreditCardPay
            // 
            this.txtCreditCardPay.Location = new System.Drawing.Point(159, 474);
            this.txtCreditCardPay.Multiline = true;
            this.txtCreditCardPay.Name = "txtCreditCardPay";
            this.txtCreditCardPay.Size = new System.Drawing.Size(64, 22);
            this.txtCreditCardPay.TabIndex = 37;
            this.txtCreditCardPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditCardPay_KeyPress);
            // 
            // txtCheckPay
            // 
            this.txtCheckPay.Location = new System.Drawing.Point(277, 525);
            this.txtCheckPay.Multiline = true;
            this.txtCheckPay.Name = "txtCheckPay";
            this.txtCheckPay.Size = new System.Drawing.Size(64, 22);
            this.txtCheckPay.TabIndex = 38;
            this.txtCheckPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckPay_KeyPress);
            // 
            // txtVoucherPay
            // 
            this.txtVoucherPay.Location = new System.Drawing.Point(387, 474);
            this.txtVoucherPay.Multiline = true;
            this.txtVoucherPay.Name = "txtVoucherPay";
            this.txtVoucherPay.Size = new System.Drawing.Size(64, 22);
            this.txtVoucherPay.TabIndex = 39;
            this.txtVoucherPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoucherPay_KeyPress);
            // 
            // txtOtherPay
            // 
            this.txtOtherPay.Location = new System.Drawing.Point(387, 525);
            this.txtOtherPay.Multiline = true;
            this.txtOtherPay.Name = "txtOtherPay";
            this.txtOtherPay.Size = new System.Drawing.Size(64, 22);
            this.txtOtherPay.TabIndex = 41;
            this.txtOtherPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherPay_KeyPress);
            // 
            // btnPayPay
            // 
            this.btnPayPay.BackColor = System.Drawing.Color.Green;
            this.btnPayPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayPay.Location = new System.Drawing.Point(494, 540);
            this.btnPayPay.Name = "btnPayPay";
            this.btnPayPay.Size = new System.Drawing.Size(89, 34);
            this.btnPayPay.TabIndex = 42;
            this.btnPayPay.Text = "Pagar";
            this.btnPayPay.UseVisualStyleBackColor = false;
            this.btnPayPay.Click += new System.EventHandler(this.btnPayPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Seleccione los métodos de pago que usará y cuanto pagará";
            // 
            // rbCreditCardPay
            // 
            this.rbCreditCardPay.AutoSize = true;
            this.rbCreditCardPay.Location = new System.Drawing.Point(156, 451);
            this.rbCreditCardPay.Name = "rbCreditCardPay";
            this.rbCreditCardPay.Size = new System.Drawing.Size(110, 17);
            this.rbCreditCardPay.TabIndex = 44;
            this.rbCreditCardPay.Text = "Tarjeta de Crédito";
            this.rbCreditCardPay.UseVisualStyleBackColor = true;
            this.rbCreditCardPay.Click += new System.EventHandler(this.rbCreditCardPay_Click);
            // 
            // rbDebitCardPay
            // 
            this.rbDebitCardPay.AutoSize = true;
            this.rbDebitCardPay.Location = new System.Drawing.Point(156, 503);
            this.rbDebitCardPay.Name = "rbDebitCardPay";
            this.rbDebitCardPay.Size = new System.Drawing.Size(108, 17);
            this.rbDebitCardPay.TabIndex = 45;
            this.rbDebitCardPay.Text = "Tarjeta de Débito";
            this.rbDebitCardPay.UseVisualStyleBackColor = true;
            this.rbDebitCardPay.Click += new System.EventHandler(this.rbDebitCardPay_Click);
            // 
            // rbCashPay
            // 
            this.rbCashPay.AutoSize = true;
            this.rbCashPay.Location = new System.Drawing.Point(279, 451);
            this.rbCashPay.Name = "rbCashPay";
            this.rbCashPay.Size = new System.Drawing.Size(65, 17);
            this.rbCashPay.TabIndex = 46;
            this.rbCashPay.Text = "Efectivo";
            this.rbCashPay.UseVisualStyleBackColor = true;
            this.rbCashPay.Click += new System.EventHandler(this.rbCashPay_Click);
            // 
            // rbCheckPay
            // 
            this.rbCheckPay.AutoSize = true;
            this.rbCheckPay.Location = new System.Drawing.Point(277, 502);
            this.rbCheckPay.Name = "rbCheckPay";
            this.rbCheckPay.Size = new System.Drawing.Size(63, 17);
            this.rbCheckPay.TabIndex = 47;
            this.rbCheckPay.Text = "Cheque";
            this.rbCheckPay.UseVisualStyleBackColor = true;
            this.rbCheckPay.Click += new System.EventHandler(this.rbCheckPay_Click);
            // 
            // rbOtherPay
            // 
            this.rbOtherPay.AutoSize = true;
            this.rbOtherPay.Location = new System.Drawing.Point(387, 503);
            this.rbOtherPay.Name = "rbOtherPay";
            this.rbOtherPay.Size = new System.Drawing.Size(46, 17);
            this.rbOtherPay.TabIndex = 48;
            this.rbOtherPay.Text = "Otro";
            this.rbOtherPay.UseVisualStyleBackColor = true;
            this.rbOtherPay.Click += new System.EventHandler(this.rbOtherPay_Click);
            // 
            // rbVouchersPay
            // 
            this.rbVouchersPay.AutoSize = true;
            this.rbVouchersPay.Location = new System.Drawing.Point(387, 451);
            this.rbVouchersPay.Name = "rbVouchersPay";
            this.rbVouchersPay.Size = new System.Drawing.Size(52, 17);
            this.rbVouchersPay.TabIndex = 49;
            this.rbVouchersPay.Text = "Vales";
            this.rbVouchersPay.UseVisualStyleBackColor = true;
            this.rbVouchersPay.Click += new System.EventHandler(this.rbVouchersPay_Click);
            // 
            // WaytoPayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(595, 586);
            this.Controls.Add(this.rbVouchersPay);
            this.Controls.Add(this.rbOtherPay);
            this.Controls.Add(this.rbCheckPay);
            this.Controls.Add(this.rbCashPay);
            this.Controls.Add(this.rbDebitCardPay);
            this.Controls.Add(this.rbCreditCardPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPayPay);
            this.Controls.Add(this.txtOtherPay);
            this.Controls.Add(this.txtVoucherPay);
            this.Controls.Add(this.txtCheckPay);
            this.Controls.Add(this.txtCreditCardPay);
            this.Controls.Add(this.txtDebitCardPay);
            this.Controls.Add(this.txtCashPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridWayToPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaytoPayScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de pago";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWayToPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWayToPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCashPay;
        private System.Windows.Forms.TextBox txtDebitCardPay;
        private System.Windows.Forms.TextBox txtCreditCardPay;
        private System.Windows.Forms.TextBox txtCheckPay;
        private System.Windows.Forms.TextBox txtVoucherPay;
        private System.Windows.Forms.TextBox txtOtherPay;
        private System.Windows.Forms.Button btnPayPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.CheckBox rbCreditCardPay;
        private System.Windows.Forms.CheckBox rbDebitCardPay;
        private System.Windows.Forms.CheckBox rbCashPay;
        private System.Windows.Forms.CheckBox rbCheckPay;
        private System.Windows.Forms.CheckBox rbOtherPay;
        private System.Windows.Forms.CheckBox rbVouchersPay;
    }
}