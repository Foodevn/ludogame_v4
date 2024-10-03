namespace ludogame_v4.TheHien
{
	partial class FormXuLyChinh
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
            this.panelBC = new System.Windows.Forms.Panel();
            this.btnDoXiNgau = new System.Windows.Forms.Button();
            this.btnSapBanCo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picLuotQC = new System.Windows.Forms.PictureBox();
            this.btnTuyChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelXN = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLuotQC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBC
            // 
            this.panelBC.Location = new System.Drawing.Point(4, 4);
            this.panelBC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBC.Name = "panelBC";
            this.panelBC.Size = new System.Drawing.Size(477, 465);
            this.panelBC.TabIndex = 0;
            // 
            // btnDoXiNgau
            // 
            this.btnDoXiNgau.Location = new System.Drawing.Point(548, 102);
            this.btnDoXiNgau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDoXiNgau.Name = "btnDoXiNgau";
            this.btnDoXiNgau.Size = new System.Drawing.Size(68, 21);
            this.btnDoXiNgau.TabIndex = 1;
            this.btnDoXiNgau.Text = "Do xi ngau";
            this.btnDoXiNgau.Click += new System.EventHandler(this.btnDoXiNgau_Click);
            // 
            // btnSapBanCo
            // 
            this.btnSapBanCo.Location = new System.Drawing.Point(548, 146);
            this.btnSapBanCo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSapBanCo.Name = "btnSapBanCo";
            this.btnSapBanCo.Size = new System.Drawing.Size(68, 21);
            this.btnSapBanCo.TabIndex = 4;
            this.btnSapBanCo.Text = "Sap Ban Co";
            this.btnSapBanCo.Click += new System.EventHandler(this.btnSapBanCo_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(555, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Luot di";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLuotQC
            // 
            this.picLuotQC.BackColor = System.Drawing.Color.Transparent;
            this.picLuotQC.Location = new System.Drawing.Point(569, 364);
            this.picLuotQC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLuotQC.Name = "picLuotQC";
            this.picLuotQC.Size = new System.Drawing.Size(22, 22);
            this.picLuotQC.TabIndex = 7;
            this.picLuotQC.TabStop = false;
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.Location = new System.Drawing.Point(548, 169);
            this.btnTuyChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Size = new System.Drawing.Size(68, 21);
            this.btnTuyChon.TabIndex = 9;
            this.btnTuyChon.Text = "Tuy Chon";
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(548, 191);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 22);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelXN
            // 
            this.panelXN.BackColor = System.Drawing.Color.Transparent;
            this.panelXN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelXN.Location = new System.Drawing.Point(523, 29);
            this.panelXN.Margin = new System.Windows.Forms.Padding(2);
            this.panelXN.Name = "panelXN";
            this.panelXN.Size = new System.Drawing.Size(120, 60);
            this.panelXN.TabIndex = 11;
            // 
            // FormXuLyChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(749, 487);
            this.Controls.Add(this.panelXN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTuyChon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSapBanCo);
            this.Controls.Add(this.btnDoXiNgau);
            this.Controls.Add(this.panelBC);
            this.Controls.Add(this.picLuotQC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormXuLyChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Co Ca Ngua";
            this.Load += new System.EventHandler(this.XuLyChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLuotQC)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panelXN;
    }
}