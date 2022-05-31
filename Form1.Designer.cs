
namespace Stadium_Seating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seatA_txbox = new System.Windows.Forms.TextBox();
            this.seatB_txtbox = new System.Windows.Forms.TextBox();
            this.seatC_txtbox = new System.Windows.Forms.TextBox();
            this.revA_txtbox = new System.Windows.Forms.TextBox();
            this.revB_txtbox = new System.Windows.Forms.TextBox();
            this.revC_txtbox = new System.Windows.Forms.TextBox();
            this.total_txtbox = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.seatC_txtbox);
            this.groupBox1.Controls.Add(this.seatB_txtbox);
            this.groupBox1.Controls.Add(this.seatA_txbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Sold:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.total_txtbox);
            this.groupBox2.Controls.Add(this.revC_txtbox);
            this.groupBox2.Controls.Add(this.revB_txtbox);
            this.groupBox2.Controls.Add(this.revA_txtbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(241, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold \r\nfor each class of seats.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Class C:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total:";
            // 
            // seatA_txbox
            // 
            this.seatA_txbox.Location = new System.Drawing.Point(107, 85);
            this.seatA_txbox.Name = "seatA_txbox";
            this.seatA_txbox.Size = new System.Drawing.Size(100, 20);
            this.seatA_txbox.TabIndex = 4;
            // 
            // seatB_txtbox
            // 
            this.seatB_txtbox.Location = new System.Drawing.Point(107, 142);
            this.seatB_txtbox.Name = "seatB_txtbox";
            this.seatB_txtbox.Size = new System.Drawing.Size(100, 20);
            this.seatB_txtbox.TabIndex = 5;
            // 
            // seatC_txtbox
            // 
            this.seatC_txtbox.Location = new System.Drawing.Point(107, 204);
            this.seatC_txtbox.Name = "seatC_txtbox";
            this.seatC_txtbox.Size = new System.Drawing.Size(100, 20);
            this.seatC_txtbox.TabIndex = 6;
            // 
            // revA_txtbox
            // 
            this.revA_txtbox.Location = new System.Drawing.Point(106, 28);
            this.revA_txtbox.Name = "revA_txtbox";
            this.revA_txtbox.Size = new System.Drawing.Size(100, 20);
            this.revA_txtbox.TabIndex = 5;
            // 
            // revB_txtbox
            // 
            this.revB_txtbox.Location = new System.Drawing.Point(106, 85);
            this.revB_txtbox.Name = "revB_txtbox";
            this.revB_txtbox.Size = new System.Drawing.Size(100, 20);
            this.revB_txtbox.TabIndex = 8;
            // 
            // revC_txtbox
            // 
            this.revC_txtbox.Location = new System.Drawing.Point(106, 142);
            this.revC_txtbox.Name = "revC_txtbox";
            this.revC_txtbox.Size = new System.Drawing.Size(100, 20);
            this.revC_txtbox.TabIndex = 9;
            // 
            // total_txtbox
            // 
            this.total_txtbox.Location = new System.Drawing.Point(106, 204);
            this.total_txtbox.Name = "total_txtbox";
            this.total_txtbox.Size = new System.Drawing.Size(100, 20);
            this.total_txtbox.TabIndex = 10;
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calculate_btn.Location = new System.Drawing.Point(62, 293);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(75, 56);
            this.calculate_btn.TabIndex = 2;
            this.calculate_btn.Text = "Calculate\r\nRevenue\r\n";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clear_btn.Location = new System.Drawing.Point(204, 293);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 56);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exit_btn.Location = new System.Drawing.Point(347, 293);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 56);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(474, 379);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox seatC_txtbox;
        private System.Windows.Forms.TextBox seatB_txtbox;
        private System.Windows.Forms.TextBox seatA_txbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox total_txtbox;
        private System.Windows.Forms.TextBox revC_txtbox;
        private System.Windows.Forms.TextBox revB_txtbox;
        private System.Windows.Forms.TextBox revA_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

