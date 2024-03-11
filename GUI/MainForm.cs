using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetCBBTG();
        }
        private void ShowDGV(string name)
        {
            dataGridView1.DataSource = TVBUS.Instance.GetListSach(name);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowDGV(null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> LMS = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    LMS.Add(row.Cells["MaSach"].Value.ToString());
                }
                TVBUS.Instance.DelSach(LMS);

                ShowDGV(null);
                MessageBox.Show("Xoa thanh cong");
                
            }
            else
            {
                MessageBox.Show("Chon hang di cu");
            }
        }
        public void SetCBBTG()
        {
            cbbTacGia.Items.Add(new CBBItem
            {
                value = 0,
                Text = "All"
            });
            cbbTacGia.Items.AddRange(TVBUS.Instance.GetTGCBB().ToArray());
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Sach> listSach = new List<Sach>();
            if (txtSearch.Text.Length == 0)
            {
                listSach = TVBUS.Instance.GetListSach(null);
            }
            else
            {
                listSach = TVBUS.Instance.GetListSach(txtSearch.Text);
            }
            listSach.Sort((x, y) => x.MaSach.CompareTo(y.MaSach));
            MessageBox.Show("Sap xep thanh cong");
            dataGridView1.DataSource = listSach;
            dataGridView1.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailForm add = new DetailForm();
            add.d = new DetailForm.MyDel(ShowDGV);
            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng đang được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị của các ô trong hàng đang được chọn
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();
                string tenSach = selectedRow.Cells["TenSach"].Value.ToString();
                string soLuong = selectedRow.Cells["SoLuong"].Value.ToString();
              
             
                DateTime NXB = (DateTime)selectedRow.Cells["NXB"].Value;
                string tinhTrang = selectedRow.Cells["TinhTrang"].Value.ToString();
                int maTG = (int)selectedRow.Cells["MaTacGia"].Value;
                Console.WriteLine(maTG);
                DetailForm df = new DetailForm(maSach, tenSach, soLuong, NXB, tinhTrang, maTG);

                df.d = new DetailForm.MyDel(ShowDGV);
                df.Show();

            }
            else
            {

                MessageBox.Show("Không có hàng nào được chọn.");
            }
          
        
        }

        private void cbbTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBBItem selectedCBBItem = (CBBItem)cbbTacGia.SelectedItem;
            string itemValue = (selectedCBBItem != null) ? selectedCBBItem.value.ToString() : null;
            Console.WriteLine(itemValue);
            ShowDGV(itemValue);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowDGV(null);
        }
    }
}
