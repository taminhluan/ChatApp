//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatApp.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoan
    {
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string TenHienThi { get; set; }
        public string HinhAnh { get; set; }
        public string SoDienThoai { get; set; }
        public Nullable<int> MaLoaiTaiKhoan { get; set; }
    
        public virtual LoaiTaiKhoan LoaiTaiKhoan { get; set; }
    }
}