using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT
{
    public partial class frmNhapHoc : Form
    {
        NhanVien nhanVien = null;
        HOCSINH hocSinh = null;
        List<HoSo_PP> hoSo_PPs = null;
        public frmNhapHoc()
        {
            InitializeComponent();
            CenterToScreen();
            nhanVien = BienToanCuc.Instance.NguoiDung;
            lblNhanVien.Text = "Chào mừng bạn " + nhanVien.TenNV + " - " + nhanVien.MaNV;
            EniableControls(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDanhSachUngTuyen frmDanhSachUngTuyen = new frmDanhSachUngTuyen();
            frmDanhSachUngTuyen.ShowDialog();
            txtCCCDFind.Text = frmDanhSachUngTuyen.result;
            txtCCCDFind.Focus();
        }
        private DataTable ListToDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã hồ sơ");
            dataTable.Columns.Add("Tên hồ sơ");
            dataTable.Columns.Add("Số lượng tối đa");
            dataTable.Columns.Add("Số luọng ghi nhận");
            dataTable.Columns.Add("Ghi chú");

            foreach (HoSo_PP item in hoSo_PPs)
            {
                dataTable.Rows.Add(item.maHoSo, item.tenHS, item.soLuongToiDan, item.soLuongGhiNhan, item.ghiChu);
            }
            return dataTable;
        }
        private void LoadHoSo()
        {
            hoSo_PPs = HoSoBLL.Instance.GetHoSo();
            dataGridView.DataSource = ListToDataTable();
            dataGridView.Columns[1].Width = 200;

            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = true;
            dataGridView.Columns[2].ReadOnly = true;
        }
        private void EniableControls(bool trangThai)
        {
            foreach (Control item in groupBienNhanHS.Controls)
            {
                item.Enabled = trangThai;
            }
            foreach (Control item in groupBoxThongTinHS.Controls)
            {
                item.Enabled = trangThai;
            }
            foreach (Control item in panelIN.Controls)
            {
                item.Enabled = trangThai;
            }
            btnInPhieuBienNhan.Enabled = false;
        }
        private void ResetControls()
        {
            foreach (Control item in groupBienNhanHS.Controls)
            {
                if (item is Button || item is Label)
                    continue;
                else
                    item.Text = null;
            }
            foreach (Control item in groupBoxThongTinHS.Controls)
            {
                if (item is Button || item is Label)
                    continue;
                else
                    item.Text = null;
            }
            foreach (Control item in panelIN.Controls)
            {
                if (item is Button || item is Label)
                    continue;
                else
                    item.Text = null;
            }
            foreach (Control item in groupBoxKiemTra.Controls)
            {
                if (item is Button || item is Label)
                    continue;
                else
                    item.Text = null;
            }
            hocSinh = null;
            hoSo_PPs = null;
            dataGridView.DataSource = null;
        }
        private void FillHocSinhToControl()
        {
            txtMaHS.Text = hocSinh.MaHS;
            txtCCCD.Text = hocSinh.CCCD;
            txtDiaChi.Text = hocSinh.DiaChi;
            txtTenHS.Text = hocSinh.TenHS;
            txtSDT.Text = hocSinh.SoDienThoai;
        }
        private void txtCCCDFind_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCCCDFind.Text))
            {
                DSTrungTuyen thiSinh = ThiSinhTrungTuyenBLL.Instance.layThiSinhTheoCCCD(txtCCCDFind.Text);
                if (thiSinh != null)
                {
                    if (!HocSinhBLL.Instance.HocSinhDaNhapHoc(thiSinh.CCCD))
                    {
                        EniableControls(true);
                        hocSinh = HocSinhBLL.Instance.ThiSinhToHocSinh(thiSinh);
                        FillHocSinhToControl();
                        LoadHoSo();
                    }
                    else
                    {
                        MyMessageBox.ShowError("Thi sinh nay da nhap học");
                    }
                }
                else
                {
                    MyMessageBox.ShowError("Không tìm thấy thí sinh");
                    EniableControls(false);
                    ResetControls();
                    hocSinh = null;
                }
            }
            
        }
        private void txtCCCDFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (txtCCCDFind.Text.Length >= 13 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ResetControls();
            EniableControls(false);
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int selectRowIndex = dataGridView.CurrentCell.RowIndex;
            int selectColumnIndex = dataGridView.CurrentCell.ColumnIndex;
            if (selectColumnIndex == 3)
            {
                if (String.IsNullOrWhiteSpace(dataGridView.CurrentCell.Value.ToString()))
                    dataGridView.CurrentCell.Value = "0";
                else
                {
                    int soLuongToiDa = int.Parse(dataGridView.Rows[selectRowIndex].Cells[selectColumnIndex - 1].Value.ToString());
                    int soLuongGhiNhan = int.Parse(dataGridView.CurrentCell.Value.ToString());
                    if (soLuongToiDa < soLuongGhiNhan)
                    {
                        dataGridView.CurrentCell.Value = "0";
                        MyMessageBox.ShowError("Vượt quá số lượng cho phép");
                    }
                }
            }
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
                e.Control.KeyPress -= new KeyPressEventHandler(Column3_KeyPress);
                if (dataGridView.CurrentCell.ColumnIndex == 3) //Desired Column
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column3_KeyPress);
                    }
                }
        }
        private void Column3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnInPhieuBienNhan_Click(object sender, EventArgs e)
        {
            List<HoSo_PP> hoSo_s = new List<HoSo_PP>();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                int soLuong = int.Parse(dataGridView.Rows[i].Cells[3].Value.ToString());
                if (soLuong != 0)
                {
                    HoSo_PP hoSo_PP = new HoSo_PP();
                    hoSo_PP.maHoSo = dataGridView.Rows[i].Cells[0].Value.ToString();
                    hoSo_PP.tenHS = dataGridView.Rows[i].Cells[1].Value.ToString();
                    hoSo_PP.soLuongGhiNhan = int.Parse(dataGridView.Rows[i].Cells[3].Value.ToString());
                    hoSo_PP.ghiChu = dataGridView.Rows[i].Cells[4].Value.ToString();
                    hoSo_s.Add(hoSo_PP);
                }
            }
            if (PhieuBienNhanHoSoBLL.Instance.ThemPhieuBienNhan(hocSinh, nhanVien, hoSo_s))
            {
                Export export = new Export();
                export.XuatBienNhanHoSo(hocSinh, nhanVien, hoSo_s);
            }
            else
                MyMessageBox.ShowError("Loi them phieu bien nhan");
        }

        private void btnInGiayXacNhan_Click(object sender, EventArgs e)
        {
            if (HocSinhBLL.Instance.ThemHocSinh(hocSinh))
            {
                if (GiayXacNhanNhapHocBLL.Instance.LuuGiayXacNhan(hocSinh, nhanVien))
                {
                    MyMessageBox.ShowInformation("Luu thong cong");
                    Export export = new Export();
                    export.InGiayXacNhanNhapHoc(hocSinh, nhanVien, "Khối 10", hocSinh.MaHS, hocSinh.MaHS, "Nam");
                    btnInPhieuBienNhan.Enabled = true;
                }
                else
                {
                    btnInPhieuBienNhan.Enabled = false;
                    MyMessageBox.ShowError("Loi them phieu nhap hoc");
                }
            }
            else
            {
                btnInPhieuBienNhan.Enabled = false;
                MyMessageBox.ShowError("Loi them hoc sinh");
            }    
                
        }
    }
}
