namespace Project_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.cbAlcohol = new System.Windows.Forms.CheckBox();
            this.cbAggressive = new System.Windows.Forms.CheckBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.cbPermitLaneChange = new System.Windows.Forms.ComboBox();
            this.lblPermitLaneChange = new System.Windows.Forms.Label();
            this.lblAccident = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.cmbDisplay = new System.Windows.Forms.ComboBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(941, 337);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(860, 337);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cbAlcohol
            // 
            this.cbAlcohol.AutoSize = true;
            this.cbAlcohol.Location = new System.Drawing.Point(860, 12);
            this.cbAlcohol.Name = "cbAlcohol";
            this.cbAlcohol.Size = new System.Drawing.Size(83, 17);
            this.cbAlcohol.TabIndex = 3;
            this.cbAlcohol.Text = "Add &Alcohol";
            this.cbAlcohol.UseVisualStyleBackColor = true;
            // 
            // cbAggressive
            // 
            this.cbAggressive.AutoSize = true;
            this.cbAggressive.Location = new System.Drawing.Point(860, 36);
            this.cbAggressive.Name = "cbAggressive";
            this.cbAggressive.Size = new System.Drawing.Size(100, 17);
            this.cbAggressive.TabIndex = 4;
            this.cbAggressive.Text = "Add A&ggression";
            this.cbAggressive.UseVisualStyleBackColor = true;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Blue;
            this.lblClock.Location = new System.Drawing.Point(9, 12);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(405, 37);
            this.lblClock.TabIndex = 5;
            this.lblClock.Text = "SIMULATED TIME =          ";
            // 
            // cbPermitLaneChange
            // 
            this.cbPermitLaneChange.FormattingEnabled = true;
            this.cbPermitLaneChange.Items.AddRange(new object[] {
            "NONE",
            "OVERTAKE ONLY",
            "LOW",
            "MODERATE",
            "HIGH",
            "AGGRESSIVE",
            "EXTREME"});
            this.cbPermitLaneChange.Location = new System.Drawing.Point(246, 88);
            this.cbPermitLaneChange.Name = "cbPermitLaneChange";
            this.cbPermitLaneChange.Size = new System.Drawing.Size(121, 21);
            this.cbPermitLaneChange.TabIndex = 6;
            // 
            // lblPermitLaneChange
            // 
            this.lblPermitLaneChange.AutoSize = true;
            this.lblPermitLaneChange.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermitLaneChange.ForeColor = System.Drawing.Color.Green;
            this.lblPermitLaneChange.Location = new System.Drawing.Point(12, 83);
            this.lblPermitLaneChange.Name = "lblPermitLaneChange";
            this.lblPermitLaneChange.Size = new System.Drawing.Size(228, 24);
            this.lblPermitLaneChange.TabIndex = 7;
            this.lblPermitLaneChange.Text = "Permit Lane Change?";
            // 
            // lblAccident
            // 
            this.lblAccident.AutoSize = true;
            this.lblAccident.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccident.ForeColor = System.Drawing.Color.Red;
            this.lblAccident.Location = new System.Drawing.Point(286, 337);
            this.lblAccident.Name = "lblAccident";
            this.lblAccident.Size = new System.Drawing.Size(190, 37);
            this.lblAccident.TabIndex = 8;
            this.lblAccident.Text = "ACCIDENT!";
            this.lblAccident.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 380);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(30, 13);
            this.lblStart.TabIndex = 9;
            this.lblStart.Text = "km 0";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(981, 380);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(30, 13);
            this.lblEnd.TabIndex = 10;
            this.lblEnd.Text = "km 1";
            // 
            // cmbDisplay
            // 
            this.cmbDisplay.FormattingEnabled = true;
            this.cmbDisplay.Items.AddRange(new object[] {
            "  0 to   1 km",
            "  1 to   2 km",
            "  2 to   3 km",
            "  3 to   4 km",
            "  4 to   5 km",
            "  5 to   6 km",
            "  6 to   7 km",
            "  7 to   8 km",
            "  8 to   9 km",
            "  9 to 10 km",
            "10 to 11 km",
            "11 to 12 km"});
            this.cmbDisplay.Location = new System.Drawing.Point(101, 306);
            this.cmbDisplay.Name = "cmbDisplay";
            this.cmbDisplay.Size = new System.Drawing.Size(121, 21);
            this.cmbDisplay.TabIndex = 11;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(5, 301);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(90, 24);
            this.lblDisplay.TabIndex = 12;
            this.lblDisplay.Text = "Display:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 442);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.cmbDisplay);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblAccident);
            this.Controls.Add(this.lblPermitLaneChange);
            this.Controls.Add(this.cbPermitLaneChange);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.cbAggressive);
            this.Controls.Add(this.cbAlcohol);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox cbAlcohol;
        private System.Windows.Forms.CheckBox cbAggressive;
        private System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbPermitLaneChange;
        private System.Windows.Forms.Label lblPermitLaneChange;
        private System.Windows.Forms.Label lblAccident;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.ComboBox cmbDisplay;
        private System.Windows.Forms.Label lblDisplay;
    }
}

