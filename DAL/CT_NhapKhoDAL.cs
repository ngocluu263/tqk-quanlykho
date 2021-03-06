﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public class CT_NhapKhoDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertCT_NhapKho(CT_NhapKhoDTO dtoCT_NhapKho)
        {
            string strQuery = "Insert Into CT_NHAPKHO Values(";
            strQuery += "N'" + dtoCT_NhapKho.MaCTNhapKho + "',";
            strQuery += "N'" + dtoCT_NhapKho.MaNhapKho + "',";
            strQuery += "N'" + dtoCT_NhapKho.MaMatHang + "',";
            strQuery += dtoCT_NhapKho.SoLuongNhap + ",";
            strQuery += dtoCT_NhapKho.GiaNhap + ",";
            strQuery += dtoCT_NhapKho.ThanhTien + ", " + dtoCT_NhapKho.TinhTrang + ")";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateCT_NhapKho(CT_NhapKhoDTO dtoCT_NhapKho)
        {
            string strQuery = "Update CT_NHAPKHO Set ";
            strQuery += "MAMATHANG = N'" + dtoCT_NhapKho.MaMatHang + "',";
            strQuery += "SOLUONGNHAP = " + dtoCT_NhapKho.SoLuongNhap + ",";
            strQuery += "GIANHAP = " + dtoCT_NhapKho.GiaNhap + ",";
            strQuery += "THANHTIEN = " + dtoCT_NhapKho.ThanhTien ;
            strQuery += "Where MACTNHAPKHO = N'" + dtoCT_NhapKho.MaCTNhapKho + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelCT_NhapKho(string strMaNhapKho)
        {
            string strQuery = "Update CT_NHAPKHO Set TINHTRANG = False Where MANHAPKHO = N'" + strMaNhapKho + "'";
            return dp.ExecuteNonQuery(strQuery);
            
        }

    }
}
