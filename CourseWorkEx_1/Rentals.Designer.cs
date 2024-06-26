namespace CourseWorkEx_1
{
    partial class Rentals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rentals));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblRental = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCarCare = new System.Windows.Forms.Label();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.dtReturnedDate = new System.Windows.Forms.DateTimePicker();
            this.dtRentalDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.cmbCarReg = new System.Windows.Forms.ComboBox();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.txtRentFee = new System.Windows.Forms.TextBox();
            this.lblRfee = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCusID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lblRental);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCarRentalSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 101);
            this.panel1.TabIndex = 3;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.MintCream;
            this.lblClose.Location = new System.Drawing.Point(1309, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(37, 36);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.ForeColor = System.Drawing.Color.MintCream;
            this.lblRental.Location = new System.Drawing.Point(629, 56);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(88, 29);
            this.lblRental.TabIndex = 4;
            this.lblRental.Text = "Rental";
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
            this.lblCarRentalSystem.Location = new System.Drawing.Point(495, 3);
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
            this.panel2.Location = new System.Drawing.Point(0, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 38);
            this.panel2.TabIndex = 4;
            // 
            // lblCarCare
            // 
            this.lblCarCare.AutoSize = true;
            this.lblCarCare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCare.ForeColor = System.Drawing.Color.MintCream;
            this.lblCarCare.Location = new System.Drawing.Point(593, 0);
            this.lblCarCare.Name = "lblCarCare";
            this.lblCarCare.Size = new System.Drawing.Size(108, 31);
            this.lblCarCare.TabIndex = 6;
            this.lblCarCare.Text = "Car Care";
            // 
            // dgvRental
            // 
            this.dgvRental.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Location = new System.Drawing.Point(456, 126);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.RowHeadersWidth = 51;
            this.dgvRental.RowTemplate.Height = 24;
            this.dgvRental.Size = new System.Drawing.Size(854, 400);
            this.dgvRental.TabIndex = 149;
            this.dgvRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRental_CellContentClick);
            // 
            // dtReturnedDate
            // 
            this.dtReturnedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReturnedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturnedDate.Location = new System.Drawing.Point(205, 359);
            this.dtReturnedDate.Name = "dtReturnedDate";
            this.dtReturnedDate.Size = new System.Drawing.Size(200, 27);
            this.dtReturnedDate.TabIndex = 148;
            // 
            // dtRentalDate
            // 
            this.dtRentalDate.CalendarForeColor = System.Drawing.Color.MintCream;
            this.dtRentalDate.CalendarMonthBackground = System.Drawing.Color.LightSeaGreen;
            this.dtRentalDate.CalendarTitleBackColor = System.Drawing.Color.LightSeaGreen;
            this.dtRentalDate.CalendarTitleForeColor = System.Drawing.Color.MintCream;
            this.dtRentalDate.CalendarTrailingForeColor = System.Drawing.Color.LightSeaGreen;
            this.dtRentalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRentalDate.Location = new System.Drawing.Point(205, 306);
            this.dtRentalDate.Name = "dtRentalDate";
            this.dtRentalDate.Size = new System.Drawing.Size(200, 27);
            this.dtRentalDate.TabIndex = 147;
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.BackColor = System.Drawing.Color.MintCream;
            this.cmbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbCustomerID.Location = new System.Drawing.Point(205, 216);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(200, 28);
            this.cmbCustomerID.TabIndex = 146;
            this.cmbCustomerID.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomerID_SelectionChangeCommitted);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblReturnDate.Location = new System.Drawing.Point(39, 359);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(126, 25);
            this.lblReturnDate.TabIndex = 145;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalDate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRentalDate.Location = new System.Drawing.Point(41, 306);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(124, 25);
            this.lblRentalDate.TabIndex = 144;
            this.lblRentalDate.Text = "Rental Date";
            // 
            // cmbCarReg
            // 
            this.cmbCarReg.BackColor = System.Drawing.Color.MintCream;
            this.cmbCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarReg.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cmbCarReg.FormattingEnabled = true;
            this.cmbCarReg.Location = new System.Drawing.Point(205, 170);
            this.cmbCarReg.Name = "cmbCarReg";
            this.cmbCarReg.Size = new System.Drawing.Size(200, 28);
            this.cmbCarReg.TabIndex = 143;
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCarReg.Location = new System.Drawing.Point(36, 169);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(91, 25);
            this.lblCarReg.TabIndex = 142;
            this.lblCarReg.Text = "Car Reg";
            // 
            // txtRentFee
            // 
            this.txtRentFee.BackColor = System.Drawing.Color.MintCream;
            this.txtRentFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentFee.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtRentFee.Location = new System.Drawing.Point(205, 412);
            this.txtRentFee.Name = "txtRentFee";
            this.txtRentFee.Size = new System.Drawing.Size(200, 27);
            this.txtRentFee.TabIndex = 141;
            // 
            // lblRfee
            // 
            this.lblRfee.AutoSize = true;
            this.lblRfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfee.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRfee.Location = new System.Drawing.Point(39, 414);
            this.lblRfee.Name = "lblRfee";
            this.lblRfee.Size = new System.Drawing.Size(116, 25);
            this.lblRfee.TabIndex = 140;
            this.lblRfee.Text = "Rental Fee";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.MintCream;
            this.btnBack.Location = new System.Drawing.Point(177, 529);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 37);
            this.btnBack.TabIndex = 139;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.Location = new System.Drawing.Point(304, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 37);
            this.btnDelete.TabIndex = 138;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.MintCream;
            this.btnEdit.Location = new System.Drawing.Point(177, 467);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 37);
            this.btnEdit.TabIndex = 137;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MintCream;
            this.btnAdd.Location = new System.Drawing.Point(51, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 37);
            this.btnAdd.TabIndex = 136;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblName.Location = new System.Drawing.Point(39, 263);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 134;
            this.lblName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.MintCream;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtID.Location = new System.Drawing.Point(205, 124);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 27);
            this.txtID.TabIndex = 133;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCusID.Location = new System.Drawing.Point(36, 215);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(132, 25);
            this.lblCusID.TabIndex = 132;
            this.lblCusID.Text = "Customer ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblID.Location = new System.Drawing.Point(39, 126);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 25);
            this.lblID.TabIndex = 131;
            this.lblID.Text = "ID";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MintCream;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.Location = new System.Drawing.Point(177, 592);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 32);
            this.btnReset.TabIndex = 150;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.MintCream;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtName.Location = new System.Drawing.Point(206, 261);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 151;
            // 
            // Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1348, 680);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvRental);
            this.Controls.Add(this.dtReturnedDate);
            this.Controls.Add(this.dtRentalDate);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblRentalDate);
            this.Controls.Add(this.cmbCarReg);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.txtRentFee);
            this.Controls.Add(this.lblRfee);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rentals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentals";
            this.Load += new System.EventHandler(this.Rentals_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCarCare;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.DateTimePicker dtReturnedDate;
        private System.Windows.Forms.DateTimePicker dtRentalDate;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.ComboBox cmbCarReg;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.TextBox txtRentFee;
        private System.Windows.Forms.Label lblRfee;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtName;
    }
}