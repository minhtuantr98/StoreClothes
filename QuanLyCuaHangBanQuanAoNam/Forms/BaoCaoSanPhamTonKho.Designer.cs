﻿namespace QuanLyCuaHangBanQuanAoNam
{
	partial class BaoCaoSanPhamTonKho
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
			this.txtThangTon = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnTim = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightSlateGray;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(97, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(614, 55);
			this.label1.TabIndex = 4;
			this.label1.Text = "Báo Cáo Sản Phẩm Tồn Kho";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(28, 160);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(760, 260);
			this.dataGridView1.TabIndex = 18;
			// 
			// txtThangTon
			// 
			this.txtThangTon.Location = new System.Drawing.Point(383, 106);
			this.txtThangTon.Multiline = true;
			this.txtThangTon.Name = "txtThangTon";
			this.txtThangTon.Size = new System.Drawing.Size(47, 24);
			this.txtThangTon.TabIndex = 20;
			this.txtThangTon.MouseEnter += new System.EventHandler(this.txtThangTon_MouseEnter);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(299, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 21);
			this.label2.TabIndex = 19;
			this.label2.Text = "Tồn quá ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(436, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 21);
			this.label3.TabIndex = 21;
			this.label3.Text = "Tháng";
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(531, 106);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(75, 23);
			this.btnTim.TabIndex = 22;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// BaoCaoSanPhamTonKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtThangTon);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "BaoCaoSanPhamTonKho";
			this.Text = "BaoCaoSanPhamTonKho";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtThangTon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnTim;
	}
}