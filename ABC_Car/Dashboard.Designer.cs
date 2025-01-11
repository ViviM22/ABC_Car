namespace ABC_Car
{
    partial class Dashboard
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
            this.txtToday = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarsAvailable = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPendingOrders = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewOrders = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME ADMIN";
            // 
            // txtToday
            // 
            this.txtToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToday.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToday.Location = new System.Drawing.Point(726, 55);
            this.txtToday.Name = "txtToday";
            this.txtToday.Size = new System.Drawing.Size(200, 22);
            this.txtToday.TabIndex = 1;
            this.txtToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ABC_Car.Properties.Resources.ava;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(696, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 189);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Available Cars";
            // 
            // txtCarsAvailable
            // 
            this.txtCarsAvailable.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCarsAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarsAvailable.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarsAvailable.ForeColor = System.Drawing.Color.White;
            this.txtCarsAvailable.Location = new System.Drawing.Point(781, 517);
            this.txtCarsAvailable.Name = "txtCarsAvailable";
            this.txtCarsAvailable.Size = new System.Drawing.Size(73, 36);
            this.txtCarsAvailable.TabIndex = 6;
            this.txtCarsAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ABC_Car.Properties.Resources.to_do;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(386, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 189);
            this.panel2.TabIndex = 3;
            // 
            // txtPendingOrders
            // 
            this.txtPendingOrders.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPendingOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPendingOrders.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendingOrders.ForeColor = System.Drawing.Color.White;
            this.txtPendingOrders.Location = new System.Drawing.Point(468, 517);
            this.txtPendingOrders.Name = "txtPendingOrders";
            this.txtPendingOrders.Size = new System.Drawing.Size(73, 36);
            this.txtPendingOrders.TabIndex = 5;
            this.txtPendingOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPendingOrders.TextChanged += new System.EventHandler(this.txtPendingOrders_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ABC_Car.Properties.Resources._9561783;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(77, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 189);
            this.panel1.TabIndex = 2;
            // 
            // txtNewOrders
            // 
            this.txtNewOrders.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNewOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewOrders.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewOrders.ForeColor = System.Drawing.Color.White;
            this.txtNewOrders.Location = new System.Drawing.Point(146, 517);
            this.txtNewOrders.Name = "txtNewOrders";
            this.txtNewOrders.Size = new System.Drawing.Size(73, 36);
            this.txtNewOrders.TabIndex = 4;
            this.txtNewOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 783);
            this.Controls.Add(this.txtPendingOrders);
            this.Controls.Add(this.txtCarsAvailable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNewOrders);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtToday);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPendingOrders;
        private System.Windows.Forms.TextBox txtCarsAvailable;
        private System.Windows.Forms.Label label2;
    }
}