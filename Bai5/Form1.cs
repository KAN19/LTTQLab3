using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        int selectedRow = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewLoad();
        }

        private void DataGridViewLoad()
        {
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Mã tài khoản", typeof(string));
            table.Columns.Add("Tên tài khoản", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));
            table.Columns.Add("Số tiền", typeof(long));

            //table.Columns["STT"].AutoIncrement = true;
            //table.Columns["STT"].AutoIncrementSeed = 0;
            //table.Columns["STT"].AutoIncrementStep = 1;

            dataGridView1.DataSource = table;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (!CheckNullOrInvalidTextBox())
            {
                if (!CheckTextBoxModify())
                {
                    dataGridView1_AddNewData();
                }
                else
                    dataGridView1_UpdateData();

                TotalMoneyCalculate(); 
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckNullOrInvalidTextBox()
        {
            int a = 0;
            if (String.IsNullOrEmpty(textBox_TenKH.Text) ||
                String.IsNullOrEmpty(textBox_SoTaiKhoan.Text) ||
                String.IsNullOrEmpty(textBox_DiaChi.Text) ||
                String.IsNullOrEmpty(textBox_SoTienTrongTK.Text) ||
                !int.TryParse(textBox_SoTienTrongTK.Text, out a))
            {
                return true;
            }
            return false;
        }

        private bool CheckTextBoxModify()
        {
            if (selectedRow != 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                if (row.Cells[1].Value != null)
                {
                    if (textBox_SoTaiKhoan.Text != row.Cells[1].Value.ToString() ||
                   textBox_TenKH.Text != row.Cells[2].Value.ToString() ||
                   textBox_DiaChi.Text != row.Cells[3].Value.ToString() ||
                   textBox_SoTienTrongTK.Text != row.Cells[4].Value.ToString())
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            textBox_SoTaiKhoan.Text = row.Cells[1].Value.ToString();
            textBox_TenKH.Text = row.Cells[2].Value.ToString();
            textBox_DiaChi.Text = row.Cells[3].Value.ToString();
            textBox_SoTienTrongTK.Text = row.Cells[4].Value.ToString();

        }

        private void dataGridView1_UpdateData()
        {
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            row.Cells[1].Value = textBox_SoTaiKhoan.Text;
            row.Cells[2].Value = textBox_TenKH.Text;
            row.Cells[3].Value = textBox_DiaChi.Text;
            row.Cells[4].Value = textBox_SoTienTrongTK.Text;

            MessageBox.Show("Cập nhật thông tin thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_AddNewData()
        {
            table.Rows.Add(null, textBox_SoTaiKhoan.Text, textBox_TenKH.Text, textBox_DiaChi.Text, textBox_SoTienTrongTK.Text);
            dataGridView1.DataSource = table;

            IdentifyNumberUpdate();

            MessageBox.Show("Thêm mới thông tin thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentCell != null)
            {
                selectedRow = dataGridView1.CurrentCell.RowIndex;

                if (MessageBox.Show("Bạn có chắc sẽ xóa dòng này?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(selectedRow);
                    IdentifyNumberUpdate();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dòng cần xóa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void IdentifyNumberUpdate()
        {
            int i = 1;
            if (dataGridView1.Rows != null)
            {
                DataGridViewRowCollection rows = dataGridView1.Rows;
                foreach (DataGridViewRow item in rows)
                {
                    item.Cells[0].Value = i.ToString();
                    i++;
                }
            }
        }

        private void TotalMoneyCalculate()
        {
            long total = 0;
            if (dataGridView1.Rows != null)
            {
                DataGridViewRowCollection rows = dataGridView1.Rows;
                foreach (DataGridViewRow item in rows)
                {
                    if (item.Cells[4].Value != null)
                    {
                        total += (long)item.Cells[4].Value;
                    }
                }
            }
            textBox_SumMoney.Text = total.ToString(); 
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
