namespace Weather_App
{
    partial class Form1
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
            this.Lng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lat = new System.Windows.Forms.TextBox();
            this.celcius = new System.Windows.Forms.RadioButton();
            this.farenheit = new System.Windows.Forms.RadioButton();
            this.languages = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lng
            // 
            this.Lng.Location = new System.Drawing.Point(12, 36);
            this.Lng.Multiline = true;
            this.Lng.Name = "Lng";
            this.Lng.Size = new System.Drawing.Size(243, 40);
            this.Lng.TabIndex = 0;
            this.Lng.TextChanged += new System.EventHandler(this.Lng_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Longtitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Latitude";
            // 
            // Lat
            // 
            this.Lat.Location = new System.Drawing.Point(12, 126);
            this.Lat.Multiline = true;
            this.Lat.Name = "Lat";
            this.Lat.Size = new System.Drawing.Size(243, 40);
            this.Lat.TabIndex = 2;
            // 
            // celcius
            // 
            this.celcius.AutoSize = true;
            this.celcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celcius.Location = new System.Drawing.Point(12, 261);
            this.celcius.Name = "celcius";
            this.celcius.Size = new System.Drawing.Size(78, 24);
            this.celcius.TabIndex = 6;
            this.celcius.TabStop = true;
            this.celcius.Text = "Celcius";
            this.celcius.UseVisualStyleBackColor = true;
            // 
            // farenheit
            // 
            this.farenheit.AutoSize = true;
            this.farenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farenheit.Location = new System.Drawing.Point(12, 291);
            this.farenheit.Name = "farenheit";
            this.farenheit.Size = new System.Drawing.Size(95, 24);
            this.farenheit.TabIndex = 7;
            this.farenheit.TabStop = true;
            this.farenheit.Text = "Farenheit";
            this.farenheit.UseVisualStyleBackColor = true;
            // 
            // languages
            // 
            this.languages.FormattingEnabled = true;
            this.languages.Location = new System.Drawing.Point(12, 370);
            this.languages.Name = "languages";
            this.languages.Size = new System.Drawing.Size(88, 21);
            this.languages.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose The Language";
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueBtn.Location = new System.Drawing.Point(12, 431);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(139, 35);
            this.continueBtn.TabIndex = 10;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.AutoSize = true;
            this.saveLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocation.Location = new System.Drawing.Point(12, 188);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(160, 24);
            this.saveLocation.TabIndex = 11;
            this.saveLocation.Text = "Save The Location";
            this.saveLocation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(315, 478);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.languages);
            this.Controls.Add(this.farenheit);
            this.Controls.Add(this.celcius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Lat;
        private System.Windows.Forms.RadioButton celcius;
        private System.Windows.Forms.RadioButton farenheit;
        private System.Windows.Forms.ComboBox languages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.CheckBox saveLocation;
    }
}

