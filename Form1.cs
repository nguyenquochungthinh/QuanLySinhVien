using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void XoattGiaoDien1()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            cbGioiTinh.Text = "";
            txtLop.Text = "";
            cbTruong.Text = "";
            txtQueQuan.Text = "";
        }
        private void XoattGiaoDien2()
        {
            txtMaSV1.Text = "";
            cbGioiTinh1.Text = "";
            txtLop1.Text = "";
            cbTruong1.Text = "";
            txtQueQuan1.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text != "")
            {
                if(txtHoTen.Text != "")
                {
                    if(cbGioiTinh.Text != "")
                    {
                        if(txtLop.Text != "")
                        {
                            if(cbTruong.Text != "")
                            {
                                if(txtQueQuan.Text != "")
                                {
                                    dataGridViewSinhVien.Rows.Add(txtMaSV.Text, txtHoTen.Text, dateTimePicker1.Text, cbGioiTinh.Text, txtLop.Text, cbTruong.Text, txtQueQuan.Text);
                                    MessageBox.Show("Thêm Thành Công");
                                    XoattGiaoDien1();
                                }
                                else
                                {
                                    MessageBox.Show("Chưa nhập thông tin Quê quán");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chưa nhập thông tin Trường");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chưa nhập thông tin Lớp");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập thông tin Giới tính");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin họ tên");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin Mã sinh viên");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridViewSinhVien.SelectedCells.Count >0)
            {
                int vitri = dataGridViewSinhVien.CurrentCell.RowIndex;
                dataGridViewSinhVien[0,vitri].Value = txtMaSV.Text;
                dataGridViewSinhVien[1, vitri].Value = txtHoTen.Text;
                dataGridViewSinhVien[2, vitri].Value = dateTimePicker1.Text;
                dataGridViewSinhVien[3, vitri].Value = cbGioiTinh.Text;
                dataGridViewSinhVien[4, vitri].Value = txtLop.Text;
                dataGridViewSinhVien[5, vitri].Value = cbTruong.Text;
                dataGridViewSinhVien[6, vitri].Value = txtQueQuan.Text;
                XoattGiaoDien1();
            }
            else
            {
                MessageBox.Show("Không có gì để sửa");
            }
        }

        private void dataGridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewSinhVien.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridViewSinhVien.Rows[dataGridViewSinhVien.CurrentCell.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                cbGioiTinh.Text = row.Cells[3].Value.ToString();
                txtLop.Text = row.Cells[4].Value.ToString();
                cbTruong.Text = row.Cells[5].Value.ToString();
                txtQueQuan.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                int index = dataGridViewSinhVien.CurrentCell.RowIndex;
                dataGridViewSinhVien.Rows.RemoveAt(index);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(radMaSV.Checked)
            {
                for(int i = 0;i <dataGridViewSinhVien.Rows.Count - 1; i++)
                {
                    if(txtMaSV1.Text == dataGridViewSinhVien[0, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSinhVien[0, i].Value, dataGridViewSinhVien[1, i].Value, dataGridViewSinhVien[2, i].Value, dataGridViewSinhVien[3, i].Value,
                            dataGridViewSinhVien[4, i].Value, dataGridViewSinhVien[5, i].Value, dataGridViewSinhVien[6, i].Value);


                    XoattGiaoDien2();
                            }
                }
            }
            else if(radNgaySinh.Checked)
            {

            }
            else if(radGioiTinh.Checked)
            {

            }
            else if(radLop.Checked)
            {

            }
            else if (radTruong.Checked)
            {

            }
            else if (radQueQuan.Checked)
            {

            }

        }
    }
}
