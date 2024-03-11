using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia
    {
        private int _MaTacGia;
        private String _TenTacGia;

        public int MaTacGia { get => _MaTacGia; set => _MaTacGia = value; }
        public string TenTacGia { get => _TenTacGia; set => _TenTacGia = value; }
        public TacGia(int matg, String tentg)
        {
            this.MaTacGia = matg;
            this.TenTacGia = tentg;
        }
    }
}
