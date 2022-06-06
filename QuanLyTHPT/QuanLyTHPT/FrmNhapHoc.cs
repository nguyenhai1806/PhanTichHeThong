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
        List<Tinh> dataAddress = null;
        public frmNhapHoc()
        {
            InitializeComponent();
            CenterToScreen();
            nhanVien = BienToanCuc.Instance.NguoiDung;
            lblNhanVien.Text = "Chào mừng bạn " + nhanVien.TenNV + " - " + nhanVien.MaNV;
            loadTinh();
            EniableControls(false);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDanhSachUngTuyen frmDanhSachUngTuyen = new frmDanhSachUngTuyen();
            frmDanhSachUngTuyen.ShowDialog();
            txtCCCDFind.Text = frmDanhSachUngTuyen.result;
            txtCCCDFind.Focus();
        }

        private void LoadHoSo()
        {
            dataGridView.AutoGenerateColumns = false;
            hoSo_PPs = HoSoBLL.Instance.GetHoSo();
            dataGridView.DataSource = hoSo_PPs;
            dataGridView.Columns[0].DataPropertyName = "MaHoSo";
            dataGridView.Columns[1].DataPropertyName = "TenHS";
            dataGridView.Columns[2].DataPropertyName = "SoLuongToiDan";
            dataGridView.Columns[3].DataPropertyName = "SoLuongGhiNhan";
            dataGridView.Columns[4].DataPropertyName = "GhiChu";
        }
        
        private void loadTinh()
        {
            dataAddress = DiaChiBLL.Instance.getData();
            cbbTinh.DataSource = dataAddress;
            cbbTinh.DisplayMember = "name";
            cbbTinh.ValueMember = "code";
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
                if (item is Button || item is Label || item is RadioButton)
                    continue;
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
                }
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
            rdbNam.Checked = true;
            dataGridView.DataSource = null;
        }
        private void FillHocSinhToControl()
        {
            txtMaHS.Text = hocSinh.MaHS;
            txtCCCD.Text = hocSinh.CCCD;
            txtTenHS.Text = hocSinh.TenHS;
            txtSDT.Text = hocSinh.SoDienThoai;
            rdbNam.Checked =  hocSinh.GioiTinh;
            rdbNu.Checked = !hocSinh.GioiTinh;
            dptNgaySinh.Value = hocSinh.NgaySinh;
            Tinh tinh = new Tinh();
            Huyen huyen = new Huyen(); 
            Phuong phuong = new Phuong();
            string duong = "";
            DiaChiBLL.Instance.fillAddress(out tinh, out huyen, out phuong, out duong, hocSinh.DiaChi, dataAddress);
            cbbTinh.SelectedItem = tinh;
            cbbQuan.SelectedItem = huyen;
            cbbPhuong.SelectedItem = phuong;
            txtDuong.Text = duong;
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
                    hoSo_PP.MaHoSo = dataGridView.Rows[i].Cells[0].Value.ToString();
                    hoSo_PP.TenHS = dataGridView.Rows[i].Cells[1].Value.ToString();
                    hoSo_PP.SoLuongGhiNhan = int.Parse(dataGridView.Rows[i].Cells[3].Value.ToString());
                    hoSo_PP.GhiChu = dataGridView.Rows[i].Cells[4].Value.ToString();
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

        private void cbbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tinh tinh = dataAddress.Where(t => t.Code == (cbbTinh.SelectedItem as Tinh).Code).FirstOrDefault();
            cbbQuan.DataSource = tinh.Districts;
            cbbQuan.DisplayMember = "Name";
            cbbQuan.ValueMember = "code";
        }

        private void cbbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tinh tinh = dataAddress.Where(t => t.Code == (cbbTinh.SelectedItem as Tinh).Code).FirstOrDefault();
            Huyen huyen = tinh.Districts.Where(h => h.Code == (cbbQuan.SelectedItem as Huyen).Code).FirstOrDefault();
            cbbPhuong.DataSource = huyen.Wards;
            cbbPhuong.DisplayMember = "Name";
            cbbPhuong.ValueMember = "code";
        }
    }
}
