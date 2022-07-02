
namespace PharmacyStock
{
    partial class SMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMP));
            this.pn_topbar = new System.Windows.Forms.Panel();
            this.btn_not = new DevExpress.XtraEditors.SimpleButton();
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.lp_titlebage = new System.Windows.Forms.Label();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.home_ptn = new DevExpress.XtraEditors.SimpleButton();
            this.Categories = new DevExpress.XtraEditors.SimpleButton();
            this.Suppliers = new DevExpress.XtraEditors.SimpleButton();
            this.Cardes = new DevExpress.XtraEditors.SimpleButton();
            this.Customers = new DevExpress.XtraEditors.SimpleButton();
            this.Sales = new DevExpress.XtraEditors.SimpleButton();
            this.Users = new DevExpress.XtraEditors.SimpleButton();
            this.Reports = new DevExpress.XtraEditors.SimpleButton();
            this.Settings = new DevExpress.XtraEditors.SimpleButton();
            this.pn_headernavbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_topbar.SuspendLayout();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_headernavbar.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_topbar
            // 
            this.pn_topbar.BackColor = System.Drawing.Color.Black;
            this.pn_topbar.Controls.Add(this.btn_not);
            this.pn_topbar.Controls.Add(this.btn_min);
            this.pn_topbar.Controls.Add(this.lp_titlebage);
            this.pn_topbar.Controls.Add(this.btn_max);
            this.pn_topbar.Controls.Add(this.btn_close);
            this.pn_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topbar.Location = new System.Drawing.Point(0, 0);
            this.pn_topbar.Name = "pn_topbar";
            this.pn_topbar.Size = new System.Drawing.Size(1264, 42);
            this.pn_topbar.TabIndex = 0;
            // 
            // btn_not
            // 
            this.btn_not.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_not.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_not.ImageOptions.Image")));
            this.btn_not.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_not.Location = new System.Drawing.Point(793, 3);
            this.btn_not.Name = "btn_not";
            this.btn_not.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_not.Size = new System.Drawing.Size(32, 32);
            this.btn_not.TabIndex = 0;
            this.btn_not.Click += new System.EventHandler(this.btn_not_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.ImageOptions.Image")));
            this.btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_min.Location = new System.Drawing.Point(857, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.Size = new System.Drawing.Size(32, 32);
            this.btn_min.TabIndex = 0;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // lp_titlebage
            // 
            this.lp_titlebage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lp_titlebage.AutoSize = true;
            this.lp_titlebage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp_titlebage.ForeColor = System.Drawing.Color.Gray;
            this.lp_titlebage.Location = new System.Drawing.Point(433, 9);
            this.lp_titlebage.Name = "lp_titlebage";
            this.lp_titlebage.Size = new System.Drawing.Size(75, 29);
            this.lp_titlebage.TabIndex = 1;
            this.lp_titlebage.Text = "Home";
            this.lp_titlebage.Click += new System.EventHandler(this.Home_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.ImageOptions.Image")));
            this.btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_max.Location = new System.Drawing.Point(921, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_max.Size = new System.Drawing.Size(32, 32);
            this.btn_max.TabIndex = 0;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(985, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(32, 32);
            this.btn_close.TabIndex = 0;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.Black;
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Controls.Add(this.pn_headernavbar);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_navbar.Location = new System.Drawing.Point(0, 42);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(188, 639);
            this.pn_navbar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.home_ptn);
            this.flowLayoutPanel1.Controls.Add(this.Categories);
            this.flowLayoutPanel1.Controls.Add(this.Suppliers);
            this.flowLayoutPanel1.Controls.Add(this.Cardes);
            this.flowLayoutPanel1.Controls.Add(this.Customers);
            this.flowLayoutPanel1.Controls.Add(this.Sales);
            this.flowLayoutPanel1.Controls.Add(this.Users);
            this.flowLayoutPanel1.Controls.Add(this.Reports);
            this.flowLayoutPanel1.Controls.Add(this.Settings);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 220);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 419);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // home_ptn
            // 
            this.home_ptn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.home_ptn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_ptn.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.home_ptn.Appearance.Options.UseFont = true;
            this.home_ptn.Appearance.Options.UseForeColor = true;
            this.home_ptn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.home_ptn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("home_ptn.ImageOptions.SvgImage")));
            this.home_ptn.Location = new System.Drawing.Point(3, 3);
            this.home_ptn.Name = "home_ptn";
            this.home_ptn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.home_ptn.Size = new System.Drawing.Size(182, 32);
            this.home_ptn.TabIndex = 0;
            this.home_ptn.Text = "Home";
            this.home_ptn.Click += new System.EventHandler(this.home_ptn_Click);
            // 
            // Categories
            // 
            this.Categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Categories.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Categories.Appearance.Options.UseFont = true;
            this.Categories.Appearance.Options.UseForeColor = true;
            this.Categories.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Categories.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Categories.ImageOptions.SvgImage")));
            this.Categories.Location = new System.Drawing.Point(3, 41);
            this.Categories.Name = "Categories";
            this.Categories.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Categories.Size = new System.Drawing.Size(182, 32);
            this.Categories.TabIndex = 0;
            this.Categories.Text = "Categories";
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // Suppliers
            // 
            this.Suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Suppliers.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppliers.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Suppliers.Appearance.Options.UseFont = true;
            this.Suppliers.Appearance.Options.UseForeColor = true;
            this.Suppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Suppliers.ImageOptions.Image")));
            this.Suppliers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Suppliers.Location = new System.Drawing.Point(3, 79);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Suppliers.Size = new System.Drawing.Size(182, 32);
            this.Suppliers.TabIndex = 0;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.Click += new System.EventHandler(this.Suppliers_Click);
            // 
            // Cardes
            // 
            this.Cardes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cardes.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cardes.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Cardes.Appearance.Options.UseFont = true;
            this.Cardes.Appearance.Options.UseForeColor = true;
            this.Cardes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Cardes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Cardes.ImageOptions.SvgImage")));
            this.Cardes.Location = new System.Drawing.Point(3, 117);
            this.Cardes.Name = "Cardes";
            this.Cardes.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Cardes.Size = new System.Drawing.Size(182, 32);
            this.Cardes.TabIndex = 0;
            this.Cardes.Text = "Cardes";
            this.Cardes.Click += new System.EventHandler(this.Cardes_Click);
            // 
            // Customers
            // 
            this.Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Customers.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Customers.Appearance.Options.UseFont = true;
            this.Customers.Appearance.Options.UseForeColor = true;
            this.Customers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Customers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Customers.ImageOptions.SvgImage")));
            this.Customers.Location = new System.Drawing.Point(3, 155);
            this.Customers.Name = "Customers";
            this.Customers.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Customers.Size = new System.Drawing.Size(182, 32);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Sales
            // 
            this.Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sales.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Sales.Appearance.Options.UseFont = true;
            this.Sales.Appearance.Options.UseForeColor = true;
            this.Sales.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Sales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Sales.ImageOptions.SvgImage")));
            this.Sales.Location = new System.Drawing.Point(3, 193);
            this.Sales.Name = "Sales";
            this.Sales.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Sales.Size = new System.Drawing.Size(182, 32);
            this.Sales.TabIndex = 0;
            this.Sales.Text = "Sales";
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // Users
            // 
            this.Users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Users.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Users.Appearance.Options.UseFont = true;
            this.Users.Appearance.Options.UseForeColor = true;
            this.Users.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton12.ImageOptions.SvgImage")));
            this.Users.Location = new System.Drawing.Point(3, 231);
            this.Users.Name = "Users";
            this.Users.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Users.Size = new System.Drawing.Size(182, 32);
            this.Users.TabIndex = 0;
            this.Users.Text = "Users";
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Reports
            // 
            this.Reports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reports.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Reports.Appearance.Options.UseFont = true;
            this.Reports.Appearance.Options.UseForeColor = true;
            this.Reports.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Reports.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton13.ImageOptions.SvgImage")));
            this.Reports.Location = new System.Drawing.Point(3, 269);
            this.Reports.Name = "Reports";
            this.Reports.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Reports.Size = new System.Drawing.Size(182, 32);
            this.Reports.TabIndex = 0;
            this.Reports.Text = "Reports";
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Settings.Appearance.Options.UseFont = true;
            this.Settings.Appearance.Options.UseForeColor = true;
            this.Settings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Settings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton14.ImageOptions.SvgImage")));
            this.Settings.Location = new System.Drawing.Point(3, 307);
            this.Settings.Name = "Settings";
            this.Settings.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Settings.Size = new System.Drawing.Size(182, 32);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // pn_headernavbar
            // 
            this.pn_headernavbar.Controls.Add(this.flowLayoutPanel2);
            this.pn_headernavbar.Controls.Add(this.label1);
            this.pn_headernavbar.Controls.Add(this.pictureBox1);
            this.pn_headernavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_headernavbar.Location = new System.Drawing.Point(0, 0);
            this.pn_headernavbar.Name = "pn_headernavbar";
            this.pn_headernavbar.Size = new System.Drawing.Size(188, 220);
            this.pn_headernavbar.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.simpleButton5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(40, 220);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton5.Location = new System.Drawing.Point(3, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton5.Size = new System.Drawing.Size(32, 32);
            this.simpleButton5.TabIndex = 0;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(99, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pn_navbar);
            this.Controls.Add(this.pn_topbar);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SMP";
            this.Text = "SMP";
            this.pn_topbar.ResumeLayout(false);
            this.pn_topbar.PerformLayout();
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_headernavbar.ResumeLayout(false);
            this.pn_headernavbar.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topbar;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Panel pn_navbar;
        private DevExpress.XtraEditors.SimpleButton btn_not;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private System.Windows.Forms.Panel pn_headernavbar;
        private System.Windows.Forms.Label lp_titlebage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton home_ptn;
        private DevExpress.XtraEditors.SimpleButton Categories;
        private DevExpress.XtraEditors.SimpleButton Suppliers;
        private DevExpress.XtraEditors.SimpleButton Cardes;
        private DevExpress.XtraEditors.SimpleButton Customers;
        private DevExpress.XtraEditors.SimpleButton Sales;
        private DevExpress.XtraEditors.SimpleButton Users;
        private DevExpress.XtraEditors.SimpleButton Reports;
        private DevExpress.XtraEditors.SimpleButton Settings;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}