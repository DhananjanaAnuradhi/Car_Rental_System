namespace CourseWorkEx_1
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lbl_Return = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.dgvCarsReturned = new System.Windows.Forms.DataGridView();
            this.dtCarOnRent = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.Delaytxt = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCarCare = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarOnRent)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lbl_Return);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCarRentalSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 101);
            this.panel1.TabIndex = 5;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.MintCream;
            this.lblClose.Location = new System.Drawing.Point(1382, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(37, 36);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lbl_Return
            // 
            this.lbl_Return.AutoSize = true;
            this.lbl_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Return.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_Return.Location = new System.Drawing.Point(710, 63);
            this.lbl_Return.Name = "lbl_Return";
            this.lbl_Return.Size = new System.Drawing.Size(90, 29);
            this.lbl_Return.TabIndex = 4;
            this.lbl_Return.Text = "Return";
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
            this.lblCarRentalSystem.Location = new System.Drawing.Point(590, 0);
            this.lblCarRentalSystem.Name = "lblCarRentalSystem";
            this.lblCarRentalSystem.Size = new System.Drawing.Size(375, 53);
            this.lblCarRentalSystem.TabIndex = 1;
            this.lblCarRentalSystem.Text = "CAR  RENTAL  SYSTEM";
            // 
            // dgvCarsReturned
            // 
            this.dgvCarsReturned.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvCarsReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarsReturned.Location = new System.Drawing.Point(498, 415);
            this.dgvCarsReturned.Name = "dgvCarsReturned";
            this.dgvCarsReturned.RowHeadersWidth = 51;
            this.dgvCarsReturned.RowTemplate.Height = 24;
            this.dgvCarsReturned.Size = new System.Drawing.Size(867, 223);
            this.dgvCarsReturned.TabIndex = 169;
            this.dgvCarsReturned.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarsReturned_CellContentClick);
            // 
            // dtCarOnRent
            // 
            this.dtCarOnRent.BackgroundColor = System.Drawing.Color.MintCream;
            this.dtCarOnRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCarOnRent.Location = new System.Drawing.Point(498, 160);
            this.dtCarOnRent.Name = "dtCarOnRent";
            this.dtCarOnRent.RowHeadersWidth = 51;
            this.dtCarOnRent.RowTemplate.Height = 24;
            this.dtCarOnRent.Size = new System.Drawing.Size(867, 215);
            this.dtCarOnRent.TabIndex = 168;
            this.dtCarOnRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCarOnRent_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(881, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 167;
            this.label7.Text = "Cars Returned";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(889, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 166;
            this.label6.Text = "Cars On Rent";
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.CalendarForeColor = System.Drawing.Color.MintCream;
            this.dtReturnDate.CalendarMonthBackground = System.Drawing.Color.LightSeaGreen;
            this.dtReturnDate.CalendarTitleBackColor = System.Drawing.Color.LightSeaGreen;
            this.dtReturnDate.CalendarTitleForeColor = System.Drawing.Color.MintCream;
            this.dtReturnDate.CalendarTrailingForeColor = System.Drawing.Color.LightSeaGreen;
            this.dtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturnDate.Location = new System.Drawing.Point(210, 323);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(200, 27);
            this.dtReturnDate.TabIndex = 165;
            // 
            // txtFine
            // 
            this.txtFine.BackColor = System.Drawing.Color.MintCream;
            this.txtFine.Enabled = false;
            this.txtFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtFine.Location = new System.Drawing.Point(211, 426);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(200, 27);
            this.txtFine.TabIndex = 164;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblFine.Location = new System.Drawing.Point(41, 425);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(54, 25);
            this.lblFine.TabIndex = 163;
            this.lblFine.Text = "Fine";
            // 
            // txtCar
            // 
            this.txtCar.BackColor = System.Drawing.Color.MintCream;
            this.txtCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtCar.Location = new System.Drawing.Point(210, 218);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(201, 27);
            this.txtCar.TabIndex = 162;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblReturnDate.Location = new System.Drawing.Point(41, 321);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(126, 25);
            this.lblReturnDate.TabIndex = 161;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCarID.Location = new System.Drawing.Point(41, 217);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(74, 25);
            this.lblCarID.TabIndex = 160;
            this.lblCarID.Text = "Car ID";
            // 
            // Delaytxt
            // 
            this.Delaytxt.BackColor = System.Drawing.Color.MintCream;
            this.Delaytxt.Enabled = false;
            this.Delaytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delaytxt.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Delaytxt.Location = new System.Drawing.Point(211, 376);
            this.Delaytxt.Name = "Delaytxt";
            this.Delaytxt.Size = new System.Drawing.Size(200, 27);
            this.Delaytxt.TabIndex = 159;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDelay.Location = new System.Drawing.Point(41, 375);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(67, 25);
            this.lblDelay.TabIndex = 158;
            this.lblDelay.Text = "Delay";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.MintCream;
            this.btnBack.Location = new System.Drawing.Point(182, 515);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 37);
            this.btnBack.TabIndex = 157;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.Location = new System.Drawing.Point(309, 515);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 37);
            this.btnDelete.TabIndex = 156;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MintCream;
            this.btnAdd.Location = new System.Drawing.Point(56, 515);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 37);
            this.btnAdd.TabIndex = 155;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.MintCream;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtName.Location = new System.Drawing.Point(211, 266);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 154;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblName.Location = new System.Drawing.Point(41, 266);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 153;
            this.lblName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.MintCream;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtID.Location = new System.Drawing.Point(210, 175);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(201, 27);
            this.txtID.TabIndex = 152;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblID.Location = new System.Drawing.Point(41, 174);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 25);
            this.lblID.TabIndex = 151;
            this.lblID.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.lblCarCare);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 666);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1421, 38);
            this.panel2.TabIndex = 170;
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MintCream;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.Location = new System.Drawing.Point(182, 577);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 32);
            this.btnReset.TabIndex = 171;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 704);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCarsReturned);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtCarOnRent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Delaytxt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarOnRent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lbl_Return;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.DataGridView dgvCarsReturned;
        private System.Windows.Forms.DataGridView dtCarOnRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.TextBox Delaytxt;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCarCare;
        private System.Windows.Forms.Button btnReset;
    }
}