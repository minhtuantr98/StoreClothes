namespace QuanLyCuaHangBanQuanAoNam
{
	partial class TimKiemMatHang
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
			this.cbxMaMH = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenHang = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnTim = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(275, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(235, 55);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tìm Kiếm";
			// 
			// cbxMaMH
			// 
			this.cbxMaMH.FormattingEnabled = true;
			this.cbxMaMH.Items.AddRange(new object[] {
            "null"});
			this.cbxMaMH.Location = new System.Drawing.Point(195, 115);
			this.cbxMaMH.Name = "cbxMaMH";
			this.cbxMaMH.Size = new System.Drawing.Size(121, 21);
			this.cbxMaMH.TabIndex = 3;
			this.cbxMaMH.SelectionChangeCommitted += new System.EventHandler(this.cbxMaMH_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 21);
			this.label2.TabIndex = 15;
			this.label2.Text = "Mã Hàng Hóa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(351, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 21);
			this.label3.TabIndex = 16;
			this.label3.Text = "Tên Hàng";
			// 
			// txtTenHang
			// 
			this.txtTenHang.Location = new System.Drawing.Point(455, 117);
			this.txtTenHang.Name = "txtTenHang";
			this.txtTenHang.Size = new System.Drawing.Size(162, 20);
			this.txtTenHang.TabIndex = 17;
			this.txtTenHang.TextChanged += new System.EventHandler(this.txtTenHang_TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(55, 167);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(651, 250);
			this.dataGridView1.TabIndex = 18;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(639, 115);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(67, 23);
			this.btnTim.TabIndex = 19;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// TimKiemMatHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtTenHang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxMaMH);
			this.Controls.Add(this.label1);
			this.Name = "TimKiemMatHang";
			this.Text = "TimKiemMatHang";
			this.Load += new System.EventHandler(this.TimKiemMatHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxMaMH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTenHang;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnTim;
	}
}