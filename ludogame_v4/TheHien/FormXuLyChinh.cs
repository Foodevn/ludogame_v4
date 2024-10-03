using ludogame_v4.XuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ludogame_v4.TheHien
{
	public partial class FormXuLyChinh : Form
	{
		private Panel panelBC;

		private Button btnDoXiNgau;

		private Button btnSapBanCo;

		private Label label1;

		private PictureBox picLuotQC;

		private TheHienXiNgau TheHienXN;

		private XiNgau XN = new XiNgau();

		private Button btnTuyChon;

		private Button btnThoat;



		private BanCo BC = new BanCo();

		private TuyChon TuyChonThamSo = new TuyChon();

		private bool bEnter = false;

		public FormXuLyChinh()
		{
			InitializeComponent();
		}

		

		//[STAThread]
		//private static void Main()
		//{
		//	Application.Run(new FormXuLyChinh());
		//}

		private void XuLyChinh_Load(object sender, EventArgs e)
		{
			LoadHinhBC();
			XN.SoXN = TuyChonThamSo.tc.SoHotXiNgau;
			btnDoXiNgau.Enabled = false;
          
        }

		public void LoadHinhBC()
		{
			panelBC.BackgroundImage = new Bitmap(TuyChonThamSo.tc.HinhBanCo);
		}

		public string GetStrImage()
		{
			string text = Application.StartupPath + "/hinhngua/";
			switch (BC.DLBC.UserHienTai)
			{
				case 1:
					text += "duong.gif";
					break;
				case 2:
					text += "do.gif";
					break;
				case 3:
					text += "vang.gif";
					break;
				case 4:
					text += "xanh.gif";
					break;
			}
			return text;
		}

		public void ResetManHinh()
		{
			panelBC.BackgroundImage = new Bitmap(TuyChonThamSo.tc.HinhBanCo);
			TheHienXN = new TheHienXiNgau();
			TheHienXN.SoXiNgauTheHien = TuyChonThamSo.tc.SoHotXiNgau;
			TheHienXN.DinhViXiNgau();
			this.panelXN.Controls.Clear();

            BC.DLBC.CapNhatDL(TuyChonThamSo.tc);
		}

		public bool KiemTraRaQuan()
		{
			if (XN.SoXN == 1)
			{
				if (XN.gt1 == BC.DLBC.gtRQ1 || XN.gt1 == BC.DLBC.gtRQ2)
				{
					return true;
				}
			}
			else if ((XN.gt1 == BC.DLBC.gtRQ1 && XN.gt2 == BC.DLBC.gtRQ1) || (XN.gt1 == BC.DLBC.gtRQ2 && XN.gt2 == BC.DLBC.gtRQ2))
			{
				return true;
			}
			return false;
		}

		private void btnDoXiNgau_Click(object sender, EventArgs e)
		{
			XN.DoXingau(TheHienXN,panelXN);
			picLuotQC.Image = new Bitmap(GetStrImage());
			BC.DLBC.CapNhatGTXN(XN);
			bEnter = (KiemTraRaQuan() ? true : false);
			BC.XuLyBanCo();
			if (!bEnter)
			{
				BC.DLBC.UserHienTai = BC.DLBC.UserHienTai % BC.DLBC.SoNguoichoi + 1;
			}
		}

		private void btnTuyChon_Click(object sender, EventArgs e)
		{
			TuyChonThamSo.ShowDialog(this);
			btnSapBanCo.Enabled = true;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSapBanCo_Click(object sender, EventArgs e)
		{
			ResetManHinh();
            this.panelXN.Controls.Add(TheHienXN);
            BC.SapBanCo(panelBC, TuyChonThamSo.tc);
			btnSapBanCo.Enabled = true;
			btnDoXiNgau.Enabled = true;
		}
	}
}
