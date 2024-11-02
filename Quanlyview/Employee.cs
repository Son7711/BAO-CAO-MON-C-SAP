﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyview
{
    public class Employee
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; } = DateTime.Today; // Mặc định là ngày hiện tại
        public string MaLop { get; set; }
        public string NganhHoc { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string ImagePath { get; set; }
    }

}
