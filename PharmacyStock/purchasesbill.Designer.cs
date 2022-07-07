
namespace PharmacyStock
{
    partial class purchasesbill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxitems1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty1 = new System.Windows.Forms.TextBox();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnPrint1 = new System.Windows.Forms.Button();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.Colitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "invoice number";
            // 
            // txtInvNum1
            // 
            this.txtInvNum1.ForeColor = System.Drawing.Color.Red;
            this.txtInvNum1.Location = new System.Drawing.Point(246, 139);
            this.txtInvNum1.Name = "txtInvNum1";
            this.txtInvNum1.Size = new System.Drawing.Size(245, 30);
            this.txtInvNum1.TabIndex = 3;
            this.txtInvNum1.Text = "929292929";
            this.txtInvNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "date";
            // 
            // txtDate1
            // 
            this.txtDate1.ForeColor = System.Drawing.Color.Purple;
            this.txtDate1.Location = new System.Drawing.Point(603, 139);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(245, 30);
            this.txtDate1.TabIndex = 5;
            this.txtDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate1.TextChanged += new System.EventHandler(this.txtDate1_TextChanged);
            this.txtDate1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDate1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "supplier name";
            // 
            // txtName1
            // 
            this.txtName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtName1.Location = new System.Drawing.Point(246, 179);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(602, 30);
            this.txtName1.TabIndex = 7;
            this.txtName1.Text = "name";
            this.txtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName1_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(981, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "_________________________________________________________________________________" +
    "_______";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "item:";
            // 
            // cbxitems1
            // 
            this.cbxitems1.FormattingEnabled = true;
            this.cbxitems1.Location = new System.Drawing.Point(88, 249);
            this.cbxitems1.Name = "cbxitems1";
            this.cbxitems1.Size = new System.Drawing.Size(563, 31);
            this.cbxitems1.TabIndex = 10;
            this.cbxitems1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxitems1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "price:";
            // 
            // txtPrice1
            // 
            this.txtPrice1.ForeColor = System.Drawing.Color.Black;
            this.txtPrice1.Location = new System.Drawing.Point(87, 286);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(213, 30);
            this.txtPrice1.TabIndex = 12;
            this.txtPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "quantity:";
            // 
            // txtQty1
            // 
            this.txtQty1.ForeColor = System.Drawing.Color.Black;
            this.txtQty1.Location = new System.Drawing.Point(442, 286);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.Size = new System.Drawing.Size(209, 30);
            this.txtQty1.TabIndex = 14;
            this.txtQty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal1
            // 
            this.txtTotal1.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtTotal1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal1.ForeColor = System.Drawing.Color.Yellow;
            this.txtTotal1.Location = new System.Drawing.Point(657, 267);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(209, 36);
            this.txtTotal1.TabIndex = 17;
            this.txtTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal1.TextChanged += new System.EventHandler(this.txtTotal1_TextChanged);
            this.txtTotal1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(728, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total";
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd1.ForeColor = System.Drawing.Color.White;
            this.btnAdd1.Location = new System.Drawing.Point(872, 248);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(67, 55);
            this.btnAdd1.TabIndex = 19;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = false;
            // 
            // btnPrint1
            // 
            this.btnPrint1.BackColor = System.Drawing.Color.Maroon;
            this.btnPrint1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint1.ForeColor = System.Drawing.Color.White;
            this.btnPrint1.Location = new System.Drawing.Point(946, 248);
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(67, 55);
            this.btnPrint1.TabIndex = 20;
            this.btnPrint1.Text = "Print";
            this.btnPrint1.UseVisualStyleBackColor = false;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colitem,
            this.colQty,
            this.colprice,
            this.colSubTotal});
            this.dgvInvoice.Location = new System.Drawing.Point(12, 322);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(1001, 191);
            this.dgvInvoice.TabIndex = 21;
            // 
            // Colitem
            // 
            this.Colitem.HeaderText = "item";
            this.Colitem.Name = "Colitem";
            // 
            // colQty
            // 
            this.colQty.HeaderText = "quantity";
            this.colQty.Name = "colQty";
            // 
            // colprice
            // 
            this.colprice.HeaderText = "unit price";
            this.colprice.Name = "colprice";
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "subtotal";
            this.colSubTotal.Name = "colSubTotal";
            // 
            // purchasesbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 516);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.btnPrint1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.txtQty1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxitems1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "purchasesbill";
            this.Text = "purchasesbill";
            this.Load += new System.EventHandler(this.purchasesbill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvNum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxitems1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty1;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnPrint1;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}