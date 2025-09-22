using System;
using System.Globalization;
using System.Windows.Forms;

namespace BAITAPBUOI4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn event (nếu bạn chưa double–click trong Designer)
            this.Load += Form1_Load;
            btnthemsua.Click += btnthemsua_Click;
            btnxoa.Click += btnxoa_Click;
            dgvhs.CellClick += dgvhs_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbltuade.Text = "Quản Lý Thông Tin Sinh Viên";

            // Combobox khoa
            cmbchuyennganh.Items.Clear();
            cmbchuyennganh.Items.AddRange(new object[] { "QTKD", "CNTT", "NNA" });
            cmbchuyennganh.SelectedIndex = 0;

            // Giới tính mặc định
            rdonu.Checked = true;

            // DataGridView
            dgvhs.AllowUserToAddRows = false;
            dgvhs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvhs.MultiSelect = false;
            dgvhs.AutoGenerateColumns = false;
            dgvhs.Columns.Clear();
            dgvhs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMSSV", HeaderText = "MSSV" });
            dgvhs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHoTen", HeaderText = "Họ Tên", Width = 180 });
            dgvhs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGioiTinh", HeaderText = "Giới Tính" });
            dgvhs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDTB", HeaderText = "ĐTB" });
            dgvhs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKhoa", HeaderText = "Khoa" });

            UpdateCounters();
        }

        private void btnthemsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtma.Text) ||
                string.IsNullOrWhiteSpace(txthoten.Text) ||
                string.IsNullOrWhiteSpace(txtdtb.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryParseFloat(txtdtb.Text, out float dtb) || dtb < 0 || dtb > 10)
            {
                MessageBox.Show("Điểm TB phải là số từ 0 đến 10.", "Sai định dạng",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdtb.Focus();
                return;
            }

            string id = txtma.Text.Trim();
            string gt = rdonu.Checked ? "Nữ" : "Nam";
            int row = GetRowIndexById(id);

            if (row == -1) // Thêm
            {
                dgvhs.Rows.Add(id, txthoten.Text.Trim(), gt, dtb.ToString("0.00"), cmbchuyennganh.Text);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");
            }
            else          // Sửa
            {
                dgvhs.Rows[row].Cells[0].Value = id;
                dgvhs.Rows[row].Cells[1].Value = txthoten.Text.Trim();
                dgvhs.Rows[row].Cells[2].Value = gt;
                dgvhs.Rows[row].Cells[3].Value = dtb.ToString("0.00");
                dgvhs.Rows[row].Cells[4].Value = cmbchuyennganh.Text;
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
            }

            UpdateCounters();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string id = txtma.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nhập MSSV cần xoá trước.", "Thiếu MSSV");
                return;
            }

            int row = GetRowIndexById(id);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xoá!", "Không tồn tại");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xoá MSSV {id}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvhs.Rows.RemoveAt(row);
                MessageBox.Show("Xóa sinh viên thành công!", "Đã xoá");
                UpdateCounters();
                ClearInputs();
            }
        }

        private void dgvhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgvhs.Rows[e.RowIndex];
            txtma.Text = (r.Cells[0].Value ?? "").ToString();
            txthoten.Text = (r.Cells[1].Value ?? "").ToString();
            string gt = (r.Cells[2].Value ?? "").ToString();
            rdonam.Checked = gt == "Nam";
            rdonu.Checked = gt == "Nữ";
            txtdtb.Text = (r.Cells[3].Value ?? "").ToString();
            cmbchuyennganh.Text = (r.Cells[4].Value ?? "").ToString();
        }

        private int GetRowIndexById(string id)
        {
            for (int i = 0; i < dgvhs.Rows.Count; i++)
            {
                var v = dgvhs.Rows[i].Cells[0].Value;
                if (v != null && string.Equals(v.ToString(), id, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        private bool TryParseFloat(string s, out float value)
        {
            if (float.TryParse(s, NumberStyles.Float, CultureInfo.CurrentCulture, out value)) return true;
            if (float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out value)) return true;
            return false;
        }

        private void UpdateCounters()
        {
            int nam = 0, nu = 0;
            for (int i = 0; i < dgvhs.Rows.Count; i++)
            {
                var gt = (dgvhs.Rows[i].Cells[2].Value ?? "").ToString();
                if (gt == "Nam") nam++;
                else if (gt == "Nữ") nu++;
            }

            txttongnam.Text = nam.ToString();
            txttongnu.Text = nu.ToString();
        }

        private void ClearInputs()
        {
            txtma.Clear();
            txthoten.Clear();
            txtdtb.Clear();
            rdonu.Checked = true;
            cmbchuyennganh.SelectedIndex = 0;
            txtma.Focus();
        }
    }
}
