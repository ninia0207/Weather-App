namespace Weather_App
{
    partial class Form2
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
            this.longtitude = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.temperature = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.currentWeather = new System.Windows.Forms.Label();
            this.cityName = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.currentlySummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // longtitude
            // 
            this.longtitude.AutoSize = true;
            this.longtitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longtitude.Location = new System.Drawing.Point(11, 12);
            this.longtitude.Name = "longtitude";
            this.longtitude.Size = new System.Drawing.Size(93, 20);
            this.longtitude.TabIndex = 0;
            this.longtitude.Text = "Longtitude: ";
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitude.Location = new System.Drawing.Point(11, 46);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(71, 20);
            this.latitude.TabIndex = 1;
            this.latitude.Text = "Latitude:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(318, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 401);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.Location = new System.Drawing.Point(164, 159);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(0, 55);
            this.temperature.TabIndex = 3;
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeed.Location = new System.Drawing.Point(11, 259);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(104, 20);
            this.windSpeed.TabIndex = 4;
            this.windSpeed.Text = "Wind Speed: ";
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.backBtn.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(609, 335);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(203, 54);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // currentWeather
            // 
            this.currentWeather.AutoSize = true;
            this.currentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeather.Location = new System.Drawing.Point(11, 110);
            this.currentWeather.Name = "currentWeather";
            this.currentWeather.Size = new System.Drawing.Size(185, 25);
            this.currentWeather.TabIndex = 6;
            this.currentWeather.Text = "Current Weather";
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.Location = new System.Drawing.Point(11, 77);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(43, 20);
            this.cityName.TabIndex = 7;
            this.cityName.Text = "City: ";
            // 
            // weatherIcon
            // 
            this.weatherIcon.Location = new System.Drawing.Point(16, 146);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(112, 82);
            this.weatherIcon.TabIndex = 8;
            this.weatherIcon.TabStop = false;
            // 
            // currentlySummary
            // 
            this.currentlySummary.AutoSize = true;
            this.currentlySummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlySummary.Location = new System.Drawing.Point(12, 294);
            this.currentlySummary.Name = "currentlySummary";
            this.currentlySummary.Size = new System.Drawing.Size(84, 20);
            this.currentlySummary.TabIndex = 9;
            this.currentlySummary.Text = "Summary: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(824, 401);
            this.Controls.Add(this.currentlySummary);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.currentWeather);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.longtitude);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label longtitude;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label currentWeather;
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label currentlySummary;
    }
}