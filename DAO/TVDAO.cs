using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TVDAO
    {
        private static TVDAO instance;
        public static TVDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TVDAO();
                return instance;
            }
            private set => instance = value;
        }
        private TVDAO() { }
        public Sach GetSach(DataRow i)
        {
         
            int maSach = i["MaSach"] != DBNull.Value ? (int)i["MaSach"] : 0;
            string tenSach = i["TenSach"] != DBNull.Value ? i["TenSach"].ToString() : string.Empty;
            int soLuong = i["SoLuong"] != DBNull.Value ? (int)i["SoLuong"] : 0;
            DateTime? ngayXB = i["NXB"] != DBNull.Value ? (DateTime?)i["NXB"] : null;
           

            bool? tinhTrang = i["TinhTrang"] != DBNull.Value ? (bool?)i["TinhTrang"] : null;

            int matg = i["MaTacGia"] != DBNull.Value ? int.Parse(i["MaTacGia"].ToString()) : 0;








            return new Sach(maSach, tenSach, soLuong, ngayXB, tinhTrang,matg);

        }
        public List<Sach> GetAllSach()
        {
            List<Sach> listSach = new List<Sach>();
            string query = "select * from Sach";
            foreach (DataRow row in DataProvider.Instance.GetRecords(query).Rows)
            {
                listSach.Add(GetSach(row));
            }
            return listSach;
        }
        public void DeleteSach(string masach)
        {
            string query = "DELETE FROM Sach WHERE MaSach = " + masach;
            DataProvider.Instance.ExecuteDB(query);


        }
        public TacGia GetTacGia(DataRow i)
        {
            return new TacGia(
                (int)i["MaTacGia"],
                i["TenTacGia"].ToString()
                );
        }
        public List<TacGia> GetAllTacGia()
        {
            List<TacGia> listTG = new List<TacGia>();
            string query = "select * from TacGia";
            foreach (DataRow row in DataProvider.Instance.GetRecords(query).Rows)
            {
                listTG.Add(GetTacGia(row));
            }
            return listTG;
        }
        public List<Sach> GetSachSearch(string search)
        {
            List<Sach> listSach = new List<Sach>();
            string query = "SELECT * FROM Sach WHERE TenSach LIKE '%" + search + "%' OR NXB LIKE '%" + search + "%' OR MaSach LIKE '%" + search + "%' OR MaTacGia = " + search;

            foreach (DataRow row in DataProvider.Instance.GetRecords(query).Rows)
            {
                listSach.Add(GetSach(row));
            }
            Console.WriteLine(DataProvider.Instance.GetRecords(query).ToString());
            Console.WriteLine("Da vao day");
            return listSach;

        }
        public void AddSach(Sach d)
        {
            string query = "INSERT INTO Sach(MaSach,TenSach,SoLuong,NXB,TinhTrang,MaTacGia) VALUES(" + d.MaSach + ",'" + d.TenSach + "'," + d.SoLuong + ",'" + d.NXB + "','" + d.TinhTrang + "'," + d.MaTacGia + ")";
            DataProvider.Instance.ExecuteDB(query);

        }
        public void UpdateSach(Sach s)
        {
            string query = "UPDATE Sach SET TenSach='" + s.TenSach + "', SoLuong=" + s.SoLuong + ", NXB='" + s.NXB + "', TinhTrang='" + s.TinhTrang + "', MaTacGia=" + s.MaTacGia + " WHERE MaSach=" + s.MaSach;
            DataProvider.Instance.ExecuteDB(query);
            Console.WriteLine("Ham nay da duoc goi");
           
        }
    }
}
