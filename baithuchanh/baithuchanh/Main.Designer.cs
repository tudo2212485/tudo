namespace baithuchanh
{
    partial class Main
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
            this.txtten = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.btnsaochep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên Của Bạn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(165, 46);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(148, 20);
            this.txtten.TabIndex = 1;
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(94, 104);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Xử Lý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bạn Đã Nhập";
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(165, 159);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.Size = new System.Drawing.Size(148, 20);
            this.txtSaoChep.TabIndex = 4;
            this.txtSaoChep.TextChanged += new System.EventHandler(this.txtSaoChep_TextChanged);
            // 
            // btnsaochep
            // 
            this.btnsaochep.Location = new System.Drawing.Point(223, 104);
            this.btnsaochep.Name = "btnsaochep";
            this.btnsaochep.Size = new System.Drawing.Size(75, 29);
            this.btnsaochep.TabIndex = 5;
            this.btnsaochep.Text = "Sao Chép";
            this.btnsaochep.UseVisualStyleBackColor = true;
            this.btnsaochep.Click += new System.EventHandler(this.btnsaochep_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsaochep);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Chương trình đầu tiên";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button btnsaochep;
    }
}

