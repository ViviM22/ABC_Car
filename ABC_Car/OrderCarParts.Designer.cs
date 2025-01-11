namespace ABC_Car
{
    partial class OrderCarParts
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picPartImage = new System.Windows.Forms.PictureBox();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.dgvCarParts = new System.Windows.Forms.DataGridView();
            this.cmbCarModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnOrder.Location = new System.Drawing.Point(385, 413);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(193, 47);
            this.btnOrder.TabIndex = 118;
            this.btnOrder.Text = "Place an Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::ABC_Car.Properties.Resources.magnifying_glass;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(907, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 33);
            this.btnSearch.TabIndex = 111;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(651, 59);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(224, 31);
            this.txtYear.TabIndex = 110;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNIC.Location = new System.Drawing.Point(649, 30);
            this.lblNIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(48, 24);
            this.lblNIC.TabIndex = 109;
            this.lblNIC.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(372, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 123;
            this.label2.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Engine",
            "Brake System",
            "Suspension",
            "Electrical",
            "Transmission",
            "Exhaust",
            "Cooling System",
            "Fuel System",
            "Steering",
            "Lighting",
            "Interior",
            "Exterior",
            "Tires",
            "Wipers",
            "Battery"});
            this.cmbCategory.Location = new System.Drawing.Point(376, 61);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(224, 28);
            this.cmbCategory.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(60, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 121;
            this.label7.Text = "Car Model";
            // 
            // picPartImage
            // 
            this.picPartImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPartImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPartImage.Location = new System.Drawing.Point(171, 134);
            this.picPartImage.Name = "picPartImage";
            this.picPartImage.Size = new System.Drawing.Size(290, 245);
            this.picPartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPartImage.TabIndex = 125;
            this.picPartImage.TabStop = false;
            // 
            // txtPartID
            // 
            this.txtPartID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPartID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPartID.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtPartID.Location = new System.Drawing.Point(513, 134);
            this.txtPartID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartID.Multiline = true;
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(224, 34);
            this.txtPartID.TabIndex = 126;
            this.txtPartID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCarModel
            // 
            this.txtCarModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarModel.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtCarModel.Location = new System.Drawing.Point(514, 216);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarModel.Multiline = true;
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(224, 34);
            this.txtCarModel.TabIndex = 127;
            this.txtCarModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMake
            // 
            this.txtMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtMake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMake.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtMake.Location = new System.Drawing.Point(514, 258);
            this.txtMake.Margin = new System.Windows.Forms.Padding(4);
            this.txtMake.Multiline = true;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(224, 34);
            this.txtMake.TabIndex = 128;
            this.txtMake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtStockQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQuantity.Location = new System.Drawing.Point(602, 300);
            this.txtStockQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockQuantity.Multiline = true;
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(135, 34);
            this.txtStockQuantity.TabIndex = 129;
            this.txtStockQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(513, 342);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(224, 34);
            this.txtPrice.TabIndex = 130;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPartName
            // 
            this.txtPartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPartName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPartName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtPartName.Location = new System.Drawing.Point(514, 174);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartName.Multiline = true;
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(224, 34);
            this.txtPartName.TabIndex = 131;
            this.txtPartName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCarParts
            // 
            this.dgvCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarParts.Location = new System.Drawing.Point(39, 479);
            this.dgvCarParts.Name = "dgvCarParts";
            this.dgvCarParts.RowHeadersWidth = 51;
            this.dgvCarParts.RowTemplate.Height = 24;
            this.dgvCarParts.Size = new System.Drawing.Size(934, 206);
            this.dgvCarParts.TabIndex = 132;
            this.dgvCarParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarParts_CellClick);
            // 
            // cmbCarModel
            // 
            this.cmbCarModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbCarModel.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.cmbCarModel.FormattingEnabled = true;
            this.cmbCarModel.Items.AddRange(new object[] {
            "ALLION",
            "ALTO Axia",
            "Aqua",
            "BEZZA",
            "EVERY",
            "FIT",
            "FREEZER",
            "MIRA PASSO",
            "PIXIS",
            "RAIZE",
            "VITZ",
            "WAGON - R",
            "YARIS"});
            this.cmbCarModel.Location = new System.Drawing.Point(64, 59);
            this.cmbCarModel.Name = "cmbCarModel";
            this.cmbCarModel.Size = new System.Drawing.Size(224, 28);
            this.cmbCarModel.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 134;
            this.label3.Text = "Available";
            // 
            // OrderCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCarModel);
            this.Controls.Add(this.dgvCarParts);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.picPartImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderCarParts";
            this.Text = "OrderCarParts";
            this.Load += new System.EventHandler(this.OrderCarParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picPartImage;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.DataGridView dgvCarParts;
        private System.Windows.Forms.ComboBox cmbCarModel;
        private System.Windows.Forms.Label label3;
    }
}