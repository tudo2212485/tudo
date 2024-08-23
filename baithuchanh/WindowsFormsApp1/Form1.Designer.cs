namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdxanh = new System.Windows.Forms.RadioButton();
            this.rddo = new System.Windows.Forms.RadioButton();
            this.btnTomau = new System.Windows.Forms.Button();
            this.txtHopMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(382, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Giới tính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(31, 34);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(31, 75);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTomau);
            this.groupBox2.Controls.Add(this.rdxanh);
            this.groupBox2.Controls.Add(this.rddo);
            this.groupBox2.Location = new System.Drawing.Point(274, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Màu";
            // 
            // rdxanh
            // 
            this.rdxanh.AutoSize = true;
            this.rdxanh.Location = new System.Drawing.Point(31, 75);
            this.rdxanh.Name = "rdxanh";
            this.rdxanh.Size = new System.Drawing.Size(73, 17);
            this.rdxanh.TabIndex = 1;
            this.rdxanh.Text = "màu Xanh";
            this.rdxanh.UseVisualStyleBackColor = true;
            // 
            // rddo
            // 
            this.rddo.AutoSize = true;
            this.rddo.Checked = true;
            this.rddo.Location = new System.Drawing.Point(31, 34);
            this.rddo.Name = "rddo";
            this.rddo.Size = new System.Drawing.Size(61, 17);
            this.rddo.TabIndex = 0;
            this.rddo.TabStop = true;
            this.rddo.Text = "màu đỏ";
            this.rddo.UseVisualStyleBackColor = true;
            // 
            // btnTomau
            // 
            this.btnTomau.Location = new System.Drawing.Point(157, 46);
            this.btnTomau.Name = "btnTomau";
            this.btnTomau.Size = new System.Drawing.Size(76, 46);
            this.btnTomau.TabIndex = 2;
            this.btnTomau.Text = "Tô Màu";
            this.btnTomau.UseVisualStyleBackColor = true;
            this.btnTomau.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHopMau
            // 
            this.txtHopMau.Location = new System.Drawing.Point(610, 198);
            this.txtHopMau.Multiline = true;
            this.txtHopMau.Name = "txtHopMau";
            this.txtHopMau.Size = new System.Drawing.Size(161, 87);
            this.txtHopMau.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHopMau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Bài tập 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTomau;
        private System.Windows.Forms.RadioButton rdxanh;
        private System.Windows.Forms.RadioButton rddo;
        private System.Windows.Forms.TextBox txtHopMau;
    }
}

