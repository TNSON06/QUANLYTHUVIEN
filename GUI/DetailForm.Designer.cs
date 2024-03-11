namespace GUI
{
    partial class DetailForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBMaSach = new System.Windows.Forms.TextBox();
            this.txtBTenSach = new System.Windows.Forms.TextBox();
            this.txtBSoLuong = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCon = new System.Windows.Forms.RadioButton();
            this.rbtnHet = new System.Windows.Forms.RadioButton();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NXB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tác giả";
            // 
            // txtBMaSach
            // 
            this.txtBMaSach.Location = new System.Drawing.Point(174, 46);
            this.txtBMaSach.Name = "txtBMaSach";
            this.txtBMaSach.Size = new System.Drawing.Size(100, 20);
            this.txtBMaSach.TabIndex = 6;
            // 
            // txtBTenSach
            // 
            this.txtBTenSach.Location = new System.Drawing.Point(174, 100);
            this.txtBTenSach.Name = "txtBTenSach";
            this.txtBTenSach.Size = new System.Drawing.Size(100, 20);
            this.txtBTenSach.TabIndex = 7;
            // 
            // txtBSoLuong
            // 
            this.txtBSoLuong.Location = new System.Drawing.Point(174, 158);
            this.txtBSoLuong.Name = "txtBSoLuong";
            this.txtBSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtBSoLuong.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHet);
            this.groupBox1.Controls.Add(this.rbtnCon);
            this.groupBox1.Location = new System.Drawing.Point(461, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 45);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbtnCon
            // 
            this.rbtnCon.AutoSize = true;
            this.rbtnCon.Location = new System.Drawing.Point(6, 18);
            this.rbtnCon.Name = "rbtnCon";
            this.rbtnCon.Size = new System.Drawing.Size(44, 17);
            this.rbtnCon.TabIndex = 0;
            this.rbtnCon.TabStop = true;
            this.rbtnCon.Text = "Còn";
            this.rbtnCon.UseVisualStyleBackColor = true;
            // 
            // rbtnHet
            // 
            this.rbtnHet.AutoSize = true;
            this.rbtnHet.Location = new System.Drawing.Point(68, 18);
            this.rbtnHet.Name = "rbtnHet";
            this.rbtnHet.Size = new System.Drawing.Size(42, 17);
            this.rbtnHet.TabIndex = 1;
            this.rbtnHet.TabStop = true;
            this.rbtnHet.Text = "Hết";
            this.rbtnHet.UseVisualStyleBackColor = true;
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(467, 157);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(121, 21);
            this.cbbTacGia.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(247, 252);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 32);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(384, 252);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(78, 32);
            this.btnCal.TabIndex = 13;
            this.btnCal.Text = "Cancel";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbbTacGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBSoLuong);
            this.Controls.Add(this.txtBTenSach);
            this.Controls.Add(this.txtBMaSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBMaSach;
        private System.Windows.Forms.TextBox txtBTenSach;
        private System.Windows.Forms.TextBox txtBSoLuong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHet;
        private System.Windows.Forms.RadioButton rbtnCon;
        private System.Windows.Forms.ComboBox cbbTacGia;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCal;
    }
}