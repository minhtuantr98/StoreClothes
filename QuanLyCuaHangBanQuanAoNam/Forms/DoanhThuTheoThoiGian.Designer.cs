namespace QuanLyCuaHangBanQuanAoNam
{
	partial class DoanhThuTheoThoiGian
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxMonth = new System.Windows.Forms.ComboBox();
			this.cbxYear = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(90, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(589, 55);
			this.label1.TabIndex = 2;
			this.label1.Text = "Doanh Thu Theo Thời Gian";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(47, 200);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(711, 238);
			this.dataGridView1.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(289, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 21);
			this.label4.TabIndex = 20;
			this.label4.Text = "Tháng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(394, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 21);
			this.label6.TabIndex = 22;
			this.label6.Text = "Năm";
			// 
			// cbxMonth
			// 
			this.cbxMonth.FormattingEnabled = true;
			this.cbxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "null"});
			this.cbxMonth.Location = new System.Drawing.Point(293, 143);
			this.cbxMonth.Name = "cbxMonth";
			this.cbxMonth.Size = new System.Drawing.Size(53, 21);
			this.cbxMonth.TabIndex = 24;
			this.cbxMonth.Text = "null";
			this.cbxMonth.SelectedValueChanged += new System.EventHandler(this.cbxMonth_SelectedValueChanged);
			// 
			// cbxYear
			// 
			this.cbxYear.FormattingEnabled = true;
			this.cbxYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
			this.cbxYear.Location = new System.Drawing.Point(398, 143);
			this.cbxYear.Name = "cbxYear";
			this.cbxYear.Size = new System.Drawing.Size(53, 21);
			this.cbxYear.TabIndex = 26;
			this.cbxYear.Text = "2019";
			this.cbxYear.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
			this.cbxYear.SelectedValueChanged += new System.EventHandler(this.cbxYear_SelectedValueChanged);
			// 
			// DoanhThuTheoThoiGian
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbxYear);
			this.Controls.Add(this.cbxMonth);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "DoanhThuTheoThoiGian";
			this.Text = "DoanhThuTheoThoiGian";
			this.Load += new System.EventHandler(this.DoanhThuTheoThoiGian_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxMonth;
		private System.Windows.Forms.ComboBox cbxYear;
	}
}