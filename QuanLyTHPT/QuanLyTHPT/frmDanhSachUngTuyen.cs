using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace QuanLyTHPT
{
    public partial class frmDanhSachUngTuyen : Form
    {
        public frmDanhSachUngTuyen()
        {
            InitializeComponent();
            CenterToScreen();
        }
        List<DSTrungTuyen> dSTrungTuyens = new List<DSTrungTuyen>();
        private void frmDanhSachUngTuyen_Load(object sender, EventArgs e)
        {
            dSTrungTuyens = ThiSinhTrungTuyenBLL.Instance.layDSTrungTuyen();
            dataGridView.DataSource = dSTrungTuyens;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearch.Text))
                dataGridView.DataSource = dSTrungTuyens;
            else
                dataGridView.DataSource = ThiSinhTrungTuyenBLL.Instance.TimDSTrungTuyens(dSTrungTuyens, txtSearch.Text);
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectRow = dataGridView.CurrentRow.Index;
            result = dataGridView.Rows[selectRow].Cells["CCCD"].Value.ToString();
            MyMessageBox.ShowInformation("Đã chọn TS " + dataGridView.Rows[selectRow].Cells["TenTS"].Value.ToString());
        }
        public string result = null;
    }
}
