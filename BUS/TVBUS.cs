using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TVBUS
    {
        private static TVBUS instance;

        public static TVBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TVBUS();
                return instance;
            }

        }
        private TVBUS() { }
        public List<Sach> GetListSach(string tenSach)
        {
            List<Sach> listSach = new List<Sach>();
            if (tenSach == null )
            {
                listSach = TVDAO.Instance.GetAllSach();
            }
            if (tenSach != null)
            {
                listSach = TVDAO.Instance.GetSachSearch(tenSach);
            }
            Console.WriteLine(tenSach);
            return listSach;
        }
        public void DelSach(List<string> LMS)
        {
            foreach (string ms in LMS)
            {
                TVDAO.Instance.DeleteSach(ms);
                Console.WriteLine(ms);
            }
        }
        public List<CBBItem> GetTGCBB()
        {
            List<CBBItem> listTGCBB = new List<CBBItem>();
            foreach (TacGia tg in TVDAO.Instance.GetAllTacGia())
            {
                listTGCBB.Add(new CBBItem
                {
                    Text = tg.TenTacGia,
                    value = tg.MaTacGia
                });
            }
            return listTGCBB;
        }
        public void ExcuteDB(Sach d)
        {
            if (TVBUS.Instance.GetSachByMaSach(d.MaSach.ToString()) != null && d.MaSach == TVBUS.Instance.GetSachByMaSach(d.MaSach.ToString()).MaSach)
            {
               TVDAO.Instance.UpdateSach(d);
            }
            else
            {
                TVDAO.Instance.AddSach(d);

            }
        }
        public Sach GetSachByMaSach(string m)
        {
            Sach sach = null;
            foreach (Sach s in TVDAO.Instance.GetAllSach())
            {
                if (s.MaSach.ToString() == m)
                {
                    sach = s; ;
                    break;
                }

            }
            return sach;
        }
    }
}
