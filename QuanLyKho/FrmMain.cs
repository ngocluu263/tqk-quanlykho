﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyKho
{
    public partial class FrmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int CheckExist(SuperTabControl tabControlName, string tabName)
        {
            int intIndex = -1;
            for (int i = 0; i < tabControlName.Tabs.Count; i++)
            {
                if (tabControlName.Tabs[i].Name == tabName)
                {
                    intIndex = i;
                    return intIndex;
                }
            }
            return intIndex;
        }

        void CreateTab(SuperTabControl tabControlName, string strTextSuperTabItem, string strNameSuperTabItem, string strNameSuperTabControlPanel, Office2007RibbonForm Form)
        {
            int intCheck = CheckExist(tabControlName, strNameSuperTabItem);
            if (intCheck > -1)
            {
                tabControlName.SelectedTabIndex = intCheck;
                Variable.stiSelected = tabControlName.SelectedTab;
            }
            else
            {
                SuperTabItem sti = new SuperTabItem();
                sti.Name = strNameSuperTabItem;
                sti.Text = strTextSuperTabItem;
                SuperTabControlPanel stcp = new SuperTabControlPanel();
                stcp.Name = strNameSuperTabControlPanel;
                stcp.Dock = DockStyle.Fill;
                tabControlName.Controls.Add(stcp);
                sti.AttachedControl = stcp;
                tabControlName.SelectedPanel = stcp;
                tabControlName.Tabs.Add(sti);
                Form.TopLevel = false;
                Form.Parent = stcp;
                Form.Show();
                Form.Dock = DockStyle.Fill;
                tabControlName.SelectedTab = sti;
                Variable.stiSelected = sti;
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            FrmNhapKho frm = new FrmNhapKho();
            CreateTab(stcMenu, "Nhập Kho", "stiNhapKho", "stcpNhapKho", frm);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            CreateTab(stcMenu ,"Nhân Viên", "stiNhanVien", "stcpNhanVien", frm);            
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            FrmBoPhan frm = new FrmBoPhan();
            CreateTab(stcMenu, "Bộ Phận", "stiBoPhan", "stcpBoPhan", frm);
        }

        private void btnDoanhNghiep_Click(object sender, EventArgs e)
        {
            FrmTTDoanhNghiep frmDoanhNghiep = new FrmTTDoanhNghiep();
            frmDoanhNghiep.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmThayDoiMatKhau frmThayDoiMatKhau = new FrmThayDoiMatKhau();
            frmThayDoiMatKhau.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbNgayThang.Text = "Hôm nay là ngày : " + DateTime.Today.ToShortDateString();
            if (Variable.strMaNhanVien == "" || Variable.strTenNhanVien == "")
            {
                lbUser.Text = "Chưa đăng nhập";
            }
            else
            {
                lbUser.Text = Variable.strTenNhanVien;
            }
            btnNhapKho_Click(sender, e);
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void btnNhomHang_Click(object sender, EventArgs e)
        {
            FrmNhomHang frm = new FrmNhomHang();
            CreateTab(stcMenu, "Nhóm Hàng", "stiNhomHang", "stcpNhomHang", frm);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            FrmKhoHang frm = new FrmKhoHang();
            CreateTab(stcMenu, "Kho Hàng", "stiKhoHang", "stcpKhoHang", frm);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmThayDoiMatKhau frmThayDoiMatKhau = new FrmThayDoiMatKhau();
            frmThayDoiMatKhau.ShowDialog();
        }

        private void btnThoatX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            FrmMatHang frm = new FrmMatHang();
            CreateTab(stcMenu, "Mặt Hàng", "stiMatHang", "stcpMatHang", frm);
        }

        private void btnDonViTinh_Click(object sender, EventArgs e)
        {
            FrmDonViTinh frm = new FrmDonViTinh();
            CreateTab(stcMenu, "Đơn Vị Tính", "stiDonViTinh", "stcpDonViTinh", frm);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            CreateTab(stcMenu, "Khách Hàng", "stiKhachHang", "stcpKhachHang", frm);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frm = new FrmNhaCungCap();
            CreateTab(stcMenu, "Nhà Cung Cấp", "stiNhaCungCap", "stcpNhaCungCap", frm);
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            FrmXuatKho frm = new FrmXuatKho();
            CreateTab(stcMenu, "Xuất Kho", "stiXuatKho", "stcpXuatKho", frm);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Variable.strMaNhanVien = "";
            Variable.strTenNhanVien= "";
            lbUser.Text = "Chưa đăng nhập";
        }

        private void btnMucThue_Click(object sender, EventArgs e)
        {
            FrmMucThue frm = new FrmMucThue();
            CreateTab(stcMenu, "Mức Thuế", "stiMucThue", "stcpMucThue", frm);

        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            FrmPhieuThu frm = new FrmPhieuThu();
            frm.Show();
            //CreateTab(stcMenu, "Phiếu Thu", "stiPhieuThu", "stcpPhieuThu", frm);
        }

        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            FrmPhieuChi frm = new FrmPhieuChi();
            frm.Show();
            //CreateTab(stcMenu, "Phiếu Chi", "stiPhieuChi", "stcpPhieuChi", frm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Variable.strMaNhanVien = "";
            Variable.strTenNhanVien = "";
            lbUser.Text = "Chưa đăng nhập";
        }

        private void btnNhapXuatTon_Click(object sender, EventArgs e)
        {
            FrmTonKho frm = new FrmTonKho();
            //frm.ShowDialog();
            CreateTab(stcMenu, "Tồn kho", "stiTonKho", "stcpTonKho", frm);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FrmCNHangTon frm = new FrmCNHangTon();
            CreateTab(stcMenu, "Cập nhật hàng tồn", "stiHangTon", "stcpHangTon", frm);
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            FrmCNCongNoKH frm = new FrmCNCongNoKH();
            CreateTab(stcMenu, "CN Công Nợ Khách Hàng", "stiCNCongNoKH", "stcpCNCongNoKH", frm);
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            FrmTaiKhoanNganHang frm = new FrmTaiKhoanNganHang();
            CreateTab(stcMenu, "Tiền ngân hàng", "stiTCTienNganHang", "stcpTCTienNganHang", frm);
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmTienMat frmTienMat = new FrmTienMat();
            frmTienMat.Show();
        }

        private void btnCongNoThu_Click(object sender, EventArgs e)
        {
            FrmCongNoThu frm = new FrmCongNoThu();
            //frm.ShowDialog();
            CreateTab(stcMenu, "Công Nợ Thu", "stiCNThu", "stcpCNThu", frm);
        }

        private void btnCongNoChi_Click(object sender, EventArgs e)
        {
            FrmCongNoChi frm = new FrmCongNoChi();
            //frm.ShowDialog();
            CreateTab(stcMenu, "Công Nợ Chi", "stiCNChi", "stcpCNChi", frm);
        }

        private void btnCNNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmCNCongNoNCC frm = new FrmCNCongNoNCC();
            //frm.ShowDialog();
            CreateTab(stcMenu, "CN Công Nợ Nhà Cung Cấp", "stiCNCongNoNCC", "stcpCNCongNoNCC", frm);
        }

    }
}