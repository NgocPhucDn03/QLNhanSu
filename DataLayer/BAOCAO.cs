//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BAOCAO
    {
        public string MABC { get; set; }
        public string MANV { get; set; }
        public string MACV { get; set; }
        public string MANP { get; set; }
        public string MAL { get; set; }
        public string MAHD { get; set; }
        public string LOAIBAOCAO { get; set; }
        public Nullable<System.DateTime> NGAYTAO { get; set; }
        public string TRANGTHAI { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual HOPDONG HOPDONG { get; set; }
        public virtual PHIEULUONG PHIEULUONG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual NGHIPHEP NGHIPHEP { get; set; }
    }
}