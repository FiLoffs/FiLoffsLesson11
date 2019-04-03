namespace Lesson11Class1
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.trackBarDraught = new System.Windows.Forms.TrackBar();
            this.comboBoxVesselType = new System.Windows.Forms.ComboBox();
            this.hScrollMaxSpeed = new System.Windows.Forms.HScrollBar();
            this.comboBoxSpeedUnit = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDraught = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDraught)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(406, 13);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(262, 22);
            this.textBoxTitle.TabIndex = 0;
            // 
            // trackBarDraught
            // 
            this.trackBarDraught.Location = new System.Drawing.Point(406, 60);
            this.trackBarDraught.Maximum = 100;
            this.trackBarDraught.Minimum = 1;
            this.trackBarDraught.Name = "trackBarDraught";
            this.trackBarDraught.Size = new System.Drawing.Size(336, 56);
            this.trackBarDraught.TabIndex = 1;
            this.trackBarDraught.Value = 1;
            this.trackBarDraught.Scroll += new System.EventHandler(this.trackBarDraught_Scroll);
            this.trackBarDraught.ValueChanged += new System.EventHandler(this.trackBarDraught_ValueChanged);
            // 
            // comboBoxVesselType
            // 
            this.comboBoxVesselType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxVesselType.FormattingEnabled = true;
            this.comboBoxVesselType.Location = new System.Drawing.Point(406, 122);
            this.comboBoxVesselType.Name = "comboBoxVesselType";
            this.comboBoxVesselType.Size = new System.Drawing.Size(262, 28);
            this.comboBoxVesselType.TabIndex = 2;
            this.comboBoxVesselType.Text = "Select type";
            // 
            // hScrollMaxSpeed
            // 
            this.hScrollMaxSpeed.Location = new System.Drawing.Point(406, 179);
            this.hScrollMaxSpeed.Maximum = 109;
            this.hScrollMaxSpeed.Name = "hScrollMaxSpeed";
            this.hScrollMaxSpeed.Size = new System.Drawing.Size(262, 21);
            this.hScrollMaxSpeed.TabIndex = 3;
            this.hScrollMaxSpeed.ValueChanged += new System.EventHandler(this.hScrollMaxSpeed_ValueChanged);
            // 
            // comboBoxSpeedUnit
            // 
            this.comboBoxSpeedUnit.FormattingEnabled = true;
            this.comboBoxSpeedUnit.Location = new System.Drawing.Point(735, 179);
            this.comboBoxSpeedUnit.Name = "comboBoxSpeedUnit";
            this.comboBoxSpeedUnit.Size = new System.Drawing.Size(53, 24);
            this.comboBoxSpeedUnit.TabIndex = 4;
            this.comboBoxSpeedUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeedUnit_SelectedIndexChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(406, 231);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(262, 22);
            this.textBoxPrice.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(48, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(278, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Draught";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(278, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vessel type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(278, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(278, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // labelDraught
            // 
            this.labelDraught.AutoSize = true;
            this.labelDraught.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDraught.Location = new System.Drawing.Point(748, 60);
            this.labelDraught.Name = "labelDraught";
            this.labelDraught.Size = new System.Drawing.Size(18, 20);
            this.labelDraught.TabIndex = 13;
            this.labelDraught.Text = "1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(614, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 55);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(690, 180);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(18, 20);
            this.labelSpeed.TabIndex = 15;
            this.labelSpeed.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelDraught);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxSpeedUnit);
            this.Controls.Add(this.hScrollMaxSpeed);
            this.Controls.Add(this.comboBoxVesselType);
            this.Controls.Add(this.trackBarDraught);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDraught)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TrackBar trackBarDraught;
        private System.Windows.Forms.ComboBox comboBoxVesselType;
        private System.Windows.Forms.HScrollBar hScrollMaxSpeed;
        private System.Windows.Forms.ComboBox comboBoxSpeedUnit;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDraught;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSpeed;
    }
}

