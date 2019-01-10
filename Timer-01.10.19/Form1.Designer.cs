namespace Timer_01._10._19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clock = new System.Windows.Forms.Label();
            this.bakuBtn = new System.Windows.Forms.Button();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clock.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ForeColor = System.Drawing.Color.Crimson;
            this.clock.Location = new System.Drawing.Point(183, 155);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(266, 40);
            this.clock.TabIndex = 0;
            this.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bakuBtn
            // 
            this.bakuBtn.Location = new System.Drawing.Point(183, 211);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Size = new System.Drawing.Size(128, 27);
            this.bakuBtn.TabIndex = 1;
            this.bakuBtn.Text = "Baku";
            this.bakuBtn.UseVisualStyleBackColor = true;
            this.bakuBtn.Click += new System.EventHandler(this.bakuBtn_Click);
            // 
            // LondonBtn
            // 
            this.LondonBtn.Location = new System.Drawing.Point(317, 211);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(132, 27);
            this.LondonBtn.TabIndex = 2;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = true;
            this.LondonBtn.Click += new System.EventHandler(this.LondonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 361);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.bakuBtn);
            this.Controls.Add(this.clock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button bakuBtn;
        private System.Windows.Forms.Button LondonBtn;
    }
}

