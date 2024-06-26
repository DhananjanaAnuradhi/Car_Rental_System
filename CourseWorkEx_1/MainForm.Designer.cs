namespace CourseWorkEx_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMainForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCarCare = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lblMainForm);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCarRentalSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 96);
            this.panel1.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.MintCream;
            this.lblClose.Location = new System.Drawing.Point(944, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(39, 38);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMainForm
            // 
            this.lblMainForm.AutoSize = true;
            this.lblMainForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm.ForeColor = System.Drawing.Color.MintCream;
            this.lblMainForm.Location = new System.Drawing.Point(413, 63);
            this.lblMainForm.Name = "lblMainForm";
            this.lblMainForm.Size = new System.Drawing.Size(142, 28);
            this.lblMainForm.TabIndex = 4;
            this.lblMainForm.Text = "Main Form";
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
            this.lblCarRentalSystem.Location = new System.Drawing.Point(308, 0);
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
            this.panel2.Location = new System.Drawing.Point(0, 624);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 43);
            this.panel2.TabIndex = 1;
            // 
            // lblCarCare
            // 
            this.lblCarCare.AutoSize = true;
            this.lblCarCare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCare.ForeColor = System.Drawing.Color.MintCream;
            this.lblCarCare.Location = new System.Drawing.Point(437, 3);
            this.lblCarCare.Name = "lblCarCare";
            this.lblCarCare.Size = new System.Drawing.Size(108, 31);
            this.lblCarCare.TabIndex = 6;
            this.lblCarCare.Text = "Car Care";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(336, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.ForeColor = System.Drawing.Color.MintCream;
            this.btnCar.Location = new System.Drawing.Point(33, 133);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(137, 39);
            this.btnCar.TabIndex = 9;
            this.btnCar.Text = "CAR";
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.MintCream;
            this.btnCustomer.Location = new System.Drawing.Point(186, 133);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(137, 39);
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRental.ForeColor = System.Drawing.Color.MintCream;
            this.btnRental.Location = new System.Drawing.Point(338, 133);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(137, 39);
            this.btnRental.TabIndex = 11;
            this.btnRental.Text = "RENTAL";
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.MintCream;
            this.btnUsers.Location = new System.Drawing.Point(498, 133);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(137, 39);
            this.btnUsers.TabIndex = 12;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.MintCream;
            this.btnReturn.Location = new System.Drawing.Point(655, 133);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(137, 39);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.MintCream;
            this.btnDashBoard.Location = new System.Drawing.Point(810, 133);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(158, 39);
            this.btnDashBoard.TabIndex = 14;
            this.btnDashBoard.Text = "DASHBOARD";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.MintCream;
            this.btnlogout.Location = new System.Drawing.Point(408, 537);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(137, 39);
            this.btnlogout.TabIndex = 15;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(980, 667);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCarCare;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMainForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnlogout;
    }
}