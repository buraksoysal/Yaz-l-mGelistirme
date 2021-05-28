namespace CardGame
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
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnEzz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Countdown = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDifficulty.Location = new System.Drawing.Point(264, 15);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(106, 19);
            this.lblDifficulty.TabIndex = 0;
            this.lblDifficulty.Text = "Zorluk derecesi:";
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHard.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHard.Location = new System.Drawing.Point(376, 11);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 28);
            this.btnHard.TabIndex = 1;
            this.btnHard.Text = "Zor (4x5)";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnMid
            // 
            this.btnMid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMid.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMid.Location = new System.Drawing.Point(457, 11);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(75, 28);
            this.btnMid.TabIndex = 2;
            this.btnMid.Text = "Orta (3x6)";
            this.btnMid.UseVisualStyleBackColor = false;
            this.btnMid.Click += new System.EventHandler(this.btnMid_Click);
            // 
            // btnEzz
            // 
            this.btnEzz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEzz.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEzz.Location = new System.Drawing.Point(538, 11);
            this.btnEzz.Name = "btnEzz";
            this.btnEzz.Size = new System.Drawing.Size(75, 28);
            this.btnEzz.TabIndex = 3;
            this.btnEzz.Text = "Kolay (2x5)";
            this.btnEzz.UseVisualStyleBackColor = false;
            this.btnEzz.Click += new System.EventHandler(this.btnEzz_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 366);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // Countdown
            // 
            this.Countdown.AccessibleDescription = "Countdown";
            this.Countdown.AccessibleName = "";
            this.Countdown.AutoSize = true;
            this.Countdown.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Countdown.Location = new System.Drawing.Point(3, 1);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(255, 39);
            this.Countdown.TabIndex = 0;
            this.Countdown.Text = "Kalan Süre : 3.00";
            this.Countdown.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoints.Location = new System.Drawing.Point(654, 12);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(0, 25);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEzz);
            this.Controls.Add(this.btnMid);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.lblDifficulty);
            this.Name = "Form1";
            this.Text = "Kart Eşleştirme Oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnEzz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Label lblPoints;
    }
}

