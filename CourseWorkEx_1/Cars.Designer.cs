namespace CourseWorkEx_1
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblManageCars = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCarCare = new System.Windows.Forms.Label();
            this.datagridview_Car = new System.Windows.Forms.DataGridView();
            this.AvailableCMB = new System.Windows.Forms.ComboBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblCarList = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lblManageCars);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCarRentalSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 101);
            this.panel1.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.MintCream;
            this.lblClose.Location = new System.Drawing.Point(1125, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(39, 38);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblManageCars
            // 
            this.lblManageCars.AutoSize = true;
            this.lblManageCars.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCars.ForeColor = System.Drawing.Color.MintCream;
            this.lblManageCars.Location = new System.Drawing.Point(439, 63);
            this.lblManageCars.Name = "lblManageCars";
            this.lblManageCars.Size = new System.Drawing.Size(182, 28);
            this.lblManageCars.TabIndex = 4;
            this.lblManageCars.Text = "Manage Cars ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblCarRentalSystem
            // 
            this.lblCarRentalSystem.AutoSize = true;
            this.lblCarRentalSystem.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRentalSystem.ForeColor = System.Drawing.Color.MintCream;
            this.lblCarRentalSystem.Location = new System.Drawing.Point(341, 0);
            this.lblCarRentalSystem.Name = "lblCarRentalSystem";
            this.lblCarRentalSystem.Size = new System.Drawing.Size(375, 53);
            this.lblCarRentalSystem.TabIndex = 1;
            this.lblCarRentalSystem.Text = "CAR  RENTAL  SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.lblCarCare);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 632);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 38);
            this.panel2.TabIndex = 2;
            // 
            // lblCarCare
            // 
            this.lblCarCare.AutoSize = true;
            this.lblCarCare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCare.ForeColor = System.Drawing.Color.MintCream;
            this.lblCarCare.Location = new System.Drawing.Point(429, 3);
            this.lblCarCare.Name = "lblCarCare";
            this.lblCarCare.Size = new System.Drawing.Size(108, 31);
            this.lblCarCare.TabIndex = 6;
            this.lblCarCare.Text = "Car Care";
            // 
            // datagridview_Car
            // 
            this.datagridview_Car.BackgroundColor = System.Drawing.Color.MintCream;
            this.datagridview_Car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_Car.Location = new System.Drawing.Point(459, 205);
            this.datagridview_Car.Name = "datagridview_Car";
            this.datagridview_Car.RowHeadersWidth = 51;
            this.datagridview_Car.RowTemplate.Height = 24;
            this.datagridview_Car.Size = new System.Drawing.Size(665, 391);
            this.datagridview_Car.TabIndex = 85;
            this.datagridview_Car.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_Car_CellContentClick);
            // 
            // AvailableCMB
            // 
            this.AvailableCMB.BackColor = System.Drawing.Color.MintCream;
            this.AvailableCMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableCMB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.AvailableCMB.FormattingEnabled = true;
            this.AvailableCMB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.AvailableCMB.Location = new System.Drawing.Point(172, 393);
            this.AvailableCMB.Name = "AvailableCMB";
            this.AvailableCMB.Size = new System.Drawing.Size(205, 28);
            this.AvailableCMB.TabIndex = 84;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAvailability.Location = new System.Drawing.Point(30, 392);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(116, 25);
            this.lblAvailability.TabIndex = 82;
            this.lblAvailability.Text = "Availability";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.MintCream;
            this.btnBack.Location = new System.Drawing.Point(159, 507);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 37);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.Location = new System.Drawing.Point(286, 451);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 37);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.MintCream;
            this.btnEdit.Location = new System.Drawing.Point(159, 451);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 37);
            this.btnEdit.TabIndex = 78;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MintCream;
            this.btnAdd.Location = new System.Drawing.Point(25, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 37);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtModel.Location = new System.Drawing.Point(172, 289);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(205, 27);
            this.txtModel.TabIndex = 76;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblModel.Location = new System.Drawing.Point(30, 291);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(71, 25);
            this.lblModel.TabIndex = 75;
            this.lblModel.Text = "Model";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtRegNo.Location = new System.Drawing.Point(172, 178);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(205, 27);
            this.txtRegNo.TabIndex = 74;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtBrand.Location = new System.Drawing.Point(172, 233);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(205, 27);
            this.txtBrand.TabIndex = 73;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblBrand.Location = new System.Drawing.Point(30, 235);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(69, 25);
            this.lblBrand.TabIndex = 72;
            this.lblBrand.Text = "Brand";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRegNo.Location = new System.Drawing.Point(30, 177);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(77, 25);
            this.lblRegNo.TabIndex = 71;
            this.lblRegNo.Text = "RegNo";
            // 
            // lblCarList
            // 
            this.lblCarList.AutoSize = true;
            this.lblCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarList.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCarList.Location = new System.Drawing.Point(741, 114);
            this.lblCarList.Name = "lblCarList";
            this.lblCarList.Size = new System.Drawing.Size(99, 25);
            this.lblCarList.TabIndex = 70;
            this.lblCarList.Text = "Car  List ";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MintCream;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.Location = new System.Drawing.Point(159, 564);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 32);
            this.btnReset.TabIndex = 86;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtPrice.Location = new System.Drawing.Point(172, 342);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 27);
            this.txtPrice.TabIndex = 90;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPrice.Location = new System.Drawing.Point(30, 344);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 25);
            this.lblPrice.TabIndex = 89;
            this.lblPrice.Text = "Price";
            // 
            // cmbSearch
            // 
            this.cmbSearch.BackColor = System.Drawing.Color.MintCream;
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Available",
            "Rented"});
            this.cmbSearch.Location = new System.Drawing.Point(682, 159);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(205, 28);
            this.cmbSearch.TabIndex = 91;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.MintCream;
            this.btnSearch.Location = new System.Drawing.Point(883, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 35);
            this.btnSearch.TabIndex = 92;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1165, 670);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.datagridview_Car);
            this.Controls.Add(this.AvailableCMB);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.lblCarList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblManageCars;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCarCare;
        private System.Windows.Forms.DataGridView datagridview_Car;
        private System.Windows.Forms.ComboBox AvailableCMB;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblCarList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}