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
        private void frmDanhSachUngTuyen_Load(object sender, EventArgs e)
        {
            List<DSTrungTuyen>  dSTrungTuyens = ThiSinhTrungTuyenBLL.Instance.layDSTrungTuyen();
            dataGridView.DataSource = dSTrungTuyens;

            ContextMenu cm = new ContextMenu();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearch.Text))
                dataGridView.DataSource = ThiSinhTrungTuyenBLL.Instance.layDSTrungTuyen();
            else
                dataGridView.DataSource = ThiSinhTrungTuyenBLL.Instance.TimDSTrungTuyens(txtSearch.Text);
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectRow = dataGridView.CurrentRow.Index;
            result = dataGridView.Rows[selectRow].Cells["CCCD"].Value.ToString();
            MyMessageBox.ShowInformation("Đã chọn TS " + dataGridView.Rows[selectRow].Cells["TenTS"].Value.ToString());
        }
        public string result = null;

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = dataGridView.CurrentRow.Index;
                if (index != -1)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add(new MenuItem("Chọn thí sinh"));
                    m.Show(dataGridView, new Point(e.X, e.Y));
                    m.MenuItems[0].Click += MenuItem_Click;
                }
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            int selectRow = dataGridView.CurrentRow.Index;
            result = dataGridView.Rows[selectRow].Cells["CCCD"].Value.ToString();
            MyMessageBox.ShowInformation("Đã chọn TS " + dataGridView.Rows[selectRow].Cells["TenTS"].Value.ToString());
        }
    }
}
