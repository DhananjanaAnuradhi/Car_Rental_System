namespace CourseWorkEx_1
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.pB_Car = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblCarCare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCarRentalSystem
            // 
            this.lblCarRentalSystem.AutoSize = true;
            this.lblCarRentalSystem.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRentalSystem.ForeColor = System.Drawing.Color.MintCream;
            this.lblCarRentalSystem.Location = new System.Drawing.Point(274, 21);
            this.lblCarRentalSystem.Name = "lblCarRentalSystem";
            this.lblCarRentalSystem.Size = new System.Drawing.Size(375, 53);
            this.lblCarRentalSystem.TabIndex = 0;
            this.lblCarRentalSystem.Text = "CAR  RENTAL  SYSTEM";
            // 
            // pB_Car
            // 
            this.pB_Car.Image = ((System.Drawing.Image)(resources.GetObject("pB_Car.Image")));
            this.pB_Car.Location = new System.Drawing.Point(335, 126);
            this.pB_Car.Name = "pB_Car";
            this.pB_Car.Size = new System.Drawing.Size(249, 192);
            this.pB_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Car.TabIndex = 1;
            this.pB_Car.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.MintCream;
            this.lblLoading.Location = new System.Drawing.Point(355, 467);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(229, 53);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading . . . . .";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.MintCream;
            this.progressBar1.Location = new System.Drawing.Point(140, 418);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(657, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.MintCream;
            this.lblPercentage.Location = new System.Drawing.Point(446, 362);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(40, 32);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "%";
            // 
            // lblCarCare
            // 
            this.lblCarCare.AutoSize = true;
            this.lblCarCare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCare.ForeColor = System.Drawing.Color.MintCream;
            this.lblCarCare.Location = new System.Drawing.Point(405, 545);
            this.lblCarCare.Name = "lblCarCare";
            this.lblCarCare.Size = new System.Drawing.Size(108, 31);
            this.lblCarCare.TabIndex = 5;
            this.lblCarCare.Text = "Car Care";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(943, 585);
            this.Controls.Add(this.lblCarCare);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pB_Car);
            this.Controls.Add(this.lblCarRentalSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.PictureBox pB_Car;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblCarCare;
    }
}

