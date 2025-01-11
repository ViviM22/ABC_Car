namespace ABC_Car
{
    partial class OrderCar
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
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBodyStyle = new System.Windows.Forms.ComboBox();
            this.cmbCarModel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtModelYear = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.aBC_CarDataSet3 = new ABC_Car.ABC_CarDataSet3();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new ABC_Car.ABC_CarDataSet3TableAdapters.CarsTableAdapter();
            this.carsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_CarDataSet5 = new ABC_Car.ABC_CarDataSet5();
            this.carsTableAdapter1 = new ABC_Car.ABC_CarDataSet5TableAdapters.CarsTableAdapter();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.aBC_CarDataSet6 = new ABC_Car.ABC_CarDataSet6();
            this.carsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter2 = new ABC_Car.ABC_CarDataSet6TableAdapters.CarsTableAdapter();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picCarImage = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_CarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_CarDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_CarDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(405, 46);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 16);
            this.lblWelcome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(365, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 85;
            this.label1.Text = "Body Style";
            // 
            // cmbBodyStyle
            // 
            this.cmbBodyStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbBodyStyle.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.cmbBodyStyle.FormattingEnabled = true;
            this.cmbBodyStyle.Items.AddRange(new object[] {
            "ΑΧΙΑ",
            "Car",
            "Suv",
            "Trucks",
            "Vans"});
            this.cmbBodyStyle.Location = new System.Drawing.Point(369, 48);
            this.cmbBodyStyle.Name = "cmbBodyStyle";
            this.cmbBodyStyle.Size = new System.Drawing.Size(224, 28);
            this.cmbBodyStyle.TabIndex = 84;
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
            this.cmbCarModel.Location = new System.Drawing.Point(57, 48);
            this.cmbCarModel.Name = "cmbCarModel";
            this.cmbCarModel.Size = new System.Drawing.Size(224, 28);
            this.cmbCarModel.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(53, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 82;
            this.label7.Text = "Car Model";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtYear.Location = new System.Drawing.Point(653, 51);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(224, 31);
            this.txtYear.TabIndex = 87;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNIC.Location = new System.Drawing.Point(651, 22);
            this.lblNIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(48, 24);
            this.lblNIC.TabIndex = 86;
            this.lblNIC.Text = "Year";
            // 
            // txtCarID
            // 
            this.txtCarID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtCarID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarID.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtCarID.Location = new System.Drawing.Point(475, 126);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarID.Multiline = true;
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(224, 34);
            this.txtCarID.TabIndex = 90;
            this.txtCarID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCarModel
            // 
            this.txtCarModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarModel.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtCarModel.Location = new System.Drawing.Point(475, 168);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarModel.Multiline = true;
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(224, 34);
            this.txtCarModel.TabIndex = 91;
            this.txtCarModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModelYear
            // 
            this.txtModelYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtModelYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelYear.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtModelYear.Location = new System.Drawing.Point(475, 211);
            this.txtModelYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelYear.Multiline = true;
            this.txtModelYear.Name = "txtModelYear";
            this.txtModelYear.Size = new System.Drawing.Size(224, 34);
            this.txtModelYear.TabIndex = 92;
            this.txtModelYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColor.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtColor.Location = new System.Drawing.Point(475, 253);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(224, 34);
            this.txtColor.TabIndex = 93;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(475, 351);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(224, 34);
            this.txtPrice.TabIndex = 94;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnOrder.Location = new System.Drawing.Point(387, 418);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(193, 47);
            this.btnOrder.TabIndex = 95;
            this.btnOrder.Text = "Place an Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // aBC_CarDataSet3
            // 
            this.aBC_CarDataSet3.DataSetName = "ABC_CarDataSet3";
            this.aBC_CarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.aBC_CarDataSet3;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // carsBindingSource1
            // 
            this.carsBindingSource1.DataMember = "Cars";
            this.carsBindingSource1.DataSource = this.aBC_CarDataSet5;
            // 
            // aBC_CarDataSet5
            // 
            this.aBC_CarDataSet5.DataSetName = "ABC_CarDataSet5";
            this.aBC_CarDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter1
            // 
            this.carsTableAdapter1.ClearBeforeFill = true;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(734, 211);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(195, 34);
            this.txtStatus.TabIndex = 97;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aBC_CarDataSet6
            // 
            this.aBC_CarDataSet6.DataSetName = "ABC_CarDataSet6";
            this.aBC_CarDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource2
            // 
            this.carsBindingSource2.DataMember = "Cars";
            this.carsBindingSource2.DataSource = this.aBC_CarDataSet6;
            // 
            // carsTableAdapter2
            // 
            this.carsTableAdapter2.ClearBeforeFill = true;
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(27, 471);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.Size = new System.Drawing.Size(938, 212);
            this.dgvCars.TabIndex = 102;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick_2);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(475, 295);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(454, 48);
            this.txtDescription.TabIndex = 103;
            // 
            // picCarImage
            // 
            this.picCarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCarImage.Location = new System.Drawing.Point(150, 127);
            this.picCarImage.Name = "picCarImage";
            this.picCarImage.Size = new System.Drawing.Size(274, 233);
            this.picCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarImage.TabIndex = 89;
            this.picCarImage.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::ABC_Car.Properties.Resources.magnifying_glass;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(909, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 33);
            this.btnSearch.TabIndex = 88;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // OrderCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModelYear);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.picCarImage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBodyStyle);
            this.Controls.Add(this.cmbCarModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderCar";
            this.Text = "OrderCar";
            this.Load += new System.EventHandler(this.OrderCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aBC_CarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_CarDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_CarDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBodyStyle;
        private System.Windows.Forms.ComboBox cmbCarModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picCarImage;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtModelYear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnOrder;
        private ABC_CarDataSet3 aBC_CarDataSet3;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private ABC_CarDataSet3TableAdapters.CarsTableAdapter carsTableAdapter;
        private ABC_CarDataSet5 aBC_CarDataSet5;
        private System.Windows.Forms.BindingSource carsBindingSource1;
        private ABC_CarDataSet5TableAdapters.CarsTableAdapter carsTableAdapter1;
        private System.Windows.Forms.TextBox txtStatus;
        private ABC_CarDataSet6 aBC_CarDataSet6;
        private System.Windows.Forms.BindingSource carsBindingSource2;
        private ABC_CarDataSet6TableAdapters.CarsTableAdapter carsTableAdapter2;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.TextBox txtDescription;
    }
}