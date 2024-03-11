using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private int _MaSach;
        private String _TenSach;
        private int _SoLuong;
        private DateTime? _NXB;
        private bool? _TinhTrang;
        private int _MaTacGia;

        public int MaSach { get => _MaSach; set => _MaSach = value; }
        public string TenSach { get => _TenSach; set => _TenSach = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public DateTime? NXB { get => _NXB; set => _NXB = value; }
        public bool? TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
        public int MaTacGia { get => _MaTacGia; set => _MaTacGia = value; }
        public Sach(int masach, String tensach, int soluong,  DateTime? nxb, bool? tinhtrang,int matacgia)
        {
            this.MaSach = masach;
            this.TenSach = tensach;
            this.SoLuong = soluong;
            this.NXB = nxb;
            this.TinhTrang = tinhtrang;
            this.MaTacGia = matacgia;
        }
    }
}
