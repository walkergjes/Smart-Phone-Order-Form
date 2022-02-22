namespace _1ExamWalkerJessica
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.motorolaCheckbox = new System.Windows.Forms.CheckBox();
            this.iphoneCheckbox = new System.Windows.Forms.CheckBox();
            this.samsungCheckbox = new System.Windows.Forms.CheckBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.orderTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(101, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Mobile Device";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.motorolaCheckbox);
            this.groupBox1.Controls.Add(this.iphoneCheckbox);
            this.groupBox1.Controls.Add(this.samsungCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(85, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phone Models";
            // 
            // motorolaCheckbox
            // 
            this.motorolaCheckbox.AutoSize = true;
            this.motorolaCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorolaCheckbox.Location = new System.Drawing.Point(9, 77);
            this.motorolaCheckbox.Name = "motorolaCheckbox";
            this.motorolaCheckbox.Size = new System.Drawing.Size(105, 17);
            this.motorolaCheckbox.TabIndex = 2;
            this.motorolaCheckbox.Text = "Motorola Razr";
            this.motorolaCheckbox.UseVisualStyleBackColor = true;
            this.motorolaCheckbox.CheckedChanged += new System.EventHandler(this.motorolaCheckbox_CheckedChanged);
            // 
            // iphoneCheckbox
            // 
            this.iphoneCheckbox.AutoSize = true;
            this.iphoneCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphoneCheckbox.Location = new System.Drawing.Point(9, 54);
            this.iphoneCheckbox.Name = "iphoneCheckbox";
            this.iphoneCheckbox.Size = new System.Drawing.Size(83, 17);
            this.iphoneCheckbox.TabIndex = 1;
            this.iphoneCheckbox.Text = "iPhone 11";
            this.iphoneCheckbox.UseVisualStyleBackColor = true;
            this.iphoneCheckbox.CheckedChanged += new System.EventHandler(this.iphoneCheckbox_CheckedChanged);
            // 
            // samsungCheckbox
            // 
            this.samsungCheckbox.AutoSize = true;
            this.samsungCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samsungCheckbox.Location = new System.Drawing.Point(9, 30);
            this.samsungCheckbox.Name = "samsungCheckbox";
            this.samsungCheckbox.Size = new System.Drawing.Size(103, 17);
            this.samsungCheckbox.TabIndex = 0;
            this.samsungCheckbox.Text = "Samsung S20";
            this.samsungCheckbox.UseVisualStyleBackColor = true;
            this.samsungCheckbox.CheckedChanged += new System.EventHandler(this.samsungCheckbox_CheckedChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.quantityLabel.Location = new System.Drawing.Point(354, 205);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(54, 13);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.quantityTextbox.Location = new System.Drawing.Point(429, 202);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextbox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priceLabel.Location = new System.Drawing.Point(354, 243);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Unit Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priceTextbox.Location = new System.Drawing.Point(429, 240);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(100, 20);
            this.priceTextbox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.calculateButton.Location = new System.Drawing.Point(274, 293);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(106, 36);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Press to Display Your Order";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // orderTextbox
            // 
            this.orderTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.orderTextbox.Location = new System.Drawing.Point(152, 344);
            this.orderTextbox.Name = "orderTextbox";
            this.orderTextbox.Size = new System.Drawing.Size(358, 20);
            this.orderTextbox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_1ExamJessicaWalker.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 118);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.orderTextbox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mobile Device Order Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox motorolaCheckbox;
        private System.Windows.Forms.CheckBox iphoneCheckbox;
        private System.Windows.Forms.CheckBox samsungCheckbox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox orderTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

