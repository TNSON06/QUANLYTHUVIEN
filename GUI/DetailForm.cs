using BUS;
using DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class DetailForm : Form
    {
        public delegate void MyDel(string name);
        public MyDel d { get; set; }
        public DetailForm()
        {
            InitializeComponent();
            SetCBBTG();
        }
        public DetailForm(string maSach,string tenSach,string soLuong, DateTime NXB,string tinhTrang,int tacGia)
        {
            InitializeComponent();
            SetCBBTG();
            txtBMaSach.Text = maSach;
            txtBTenSach.Text = tenSach;
            txtBSoLuong.Text = soLuong;
            dateTimePicker1.Value = NXB;
            if (tinhTrang == "True")
            {
                rbtnCon.Checked = true;
                rbtnHet.Checked = false;
            }
            else if (tinhTrang == "False")
            {
                rbtnCon.Checked = false;
                rbtnHet.Checked = true;
            }
            else
            {
              
                rbtnCon.Checked = false;
                rbtnHet.Checked = false;
            }
            foreach (CBBItem item in cbbTacGia.Items)
            {
                if (item.value == tacGia)
                {
                    cbbTacGia.SelectedItem = item;
                    break;
                }
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool? tt = null;
            if (rbtnCon.Checked == false && rbtnHet.Checked == true)
            {
                tt = false;
            }
            else if (rbtnCon.Checked == true && rbtnHet.Checked == false)
            {
                tt = true;
            }
            else if (rbtnCon.Checked == false && rbtnHet.Checked == false)
            {
                tt = null;
            }

            CBBItem selectedCBBItem = (CBBItem)cbbTacGia.SelectedItem;

            int itemValue = (selectedCBBItem != null) ? selectedCBBItem.value : 0;

            Sach s = new Sach
            (
                 int.TryParse(txtBMaSach.Text, out int maSach) ? maSach : 0,
                txtBTenSach.Text,
                  int.TryParse(txtBSoLuong.Text, out int SL) ? SL : 0,
                   (DateTime?)dateTimePicker1?.Value,
                tt,
                itemValue

             
          

    
            );


            if (s != null)
            {
                TVBUS.Instance.ExcuteDB(s);
                MessageBox.Show("Thanh cong");
            }

          
         
            if (d != null)
            {
                d.Invoke(null); 
            }
            this.Dispose();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
