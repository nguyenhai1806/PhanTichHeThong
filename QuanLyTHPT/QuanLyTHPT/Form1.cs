using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Newtonsoft.Json;
using BLL;

namespace QuanLyTHPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Tinh> dataAddress;
        private void Form1_Load(object sender, EventArgs e)
        {
            loadTinh();
        }
        private void loadTinh()
        {
            dataAddress = DiaChiBLL.Instance.getData();
            comboBox1.DataSource = dataAddress;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "code";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tinh tinh = dataAddress.Where(t => t.Code == (comboBox1.SelectedItem as Tinh).Code).FirstOrDefault();
            comboBox2.DataSource = tinh.Districts;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "code";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tinh tinh = dataAddress.Where(t => t.Code == (comboBox1.SelectedItem as Tinh).Code).FirstOrDefault();
            comboBox2.DataSource = tinh.Districts;
            Huyen huyen= tinh.Districts.Where(h => h.Code == (comboBox2.SelectedItem as Huyen).Code).FirstOrDefault();
            comboBox3.DataSource = huyen.Wards;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "code";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Tinh tinh = comboBox1.SelectedItem as Tinh;
            Huyen huyen = comboBox2.SelectedItem as Huyen;
            Phuong phuong = comboBox3.SelectedItem as Phuong;
            string duong = textBox1.Text;
            string result = DiaChiBLL.Instance.GernerateAddress(tinh, huyen, phuong, duong);
            textBox2.Text = result;
        }
    }
}
