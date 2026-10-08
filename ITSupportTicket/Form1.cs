using System;
using System.Text;
using System.Windows.Forms;

namespace ITSupportTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rdoTrungBinh.Checked = true;
            cboLoaiSuCo.SelectedIndex = 0;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter =
                "Tệp hình ảnh (*.jpg;*.png)|*.jpg;*.png";

            openFileDialog.Title = "Chọn ảnh lỗi";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAnhLoi.Image = Image.FromFile(openFileDialog.FileName);
                picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã phiếu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập người yêu cầu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNguoiYeuCau.Focus();
                return;
            }

            string mucDo = "";

            if (rdoThap.Checked)
                mucDo = "Thấp";
            else if (rdoTrungBinh.Checked)
                mucDo = "Trung bình";
            else if (rdoKhanCap.Checked)
                mucDo = "Khẩn cấp";

            string thietBi = "";

            if (chkMayTinhBan.Checked)
                thietBi += "Máy tính bàn, ";

            if (chkLaptop.Checked)
                thietBi += "Laptop, ";

            if (chkMayIn.Checked)
                thietBi += "Máy in, ";

            if (chkDienThoai.Checked)
                thietBi += "Điện thoại, ";

            if (thietBi == "")
                thietBi = "Không có";

            string loaiSuCo = cboLoaiSuCo.SelectedItem.ToString();

            StringBuilder thongTin = new StringBuilder();

            thongTin.AppendLine("===== THÔNG TIN PHIẾU HỖ TRỢ =====");
            thongTin.AppendLine();
            thongTin.AppendLine("Mã phiếu: " + txtMaPhieu.Text);
            thongTin.AppendLine("Người yêu cầu: " + txtNguoiYeuCau.Text);
            thongTin.AppendLine(
                "Ngày ghi nhận: " +
                dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy"));

            thongTin.AppendLine("Mức độ ưu tiên: " + mucDo);
            thongTin.AppendLine("Loại sự cố: " + loaiSuCo);

            thongTin.AppendLine(
                "Thiết bị ảnh hưởng: " +
                thietBi.TrimEnd(' ', ','));

            if (picAnhLoi.Image != null)
                thongTin.AppendLine("Ảnh lỗi: Đã tải ảnh");
            else
                thongTin.AppendLine("Ảnh lỗi: Chưa có");

            MessageBox.Show(
                thongTin.ToString(),
                "Tóm tắt yêu cầu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();

            dtpNgayGhiNhan.Value = DateTime.Now;

            rdoTrungBinh.Checked = true;

            cboLoaiSuCo.SelectedIndex = 0;

            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            picAnhLoi.Image = null;

            txtMaPhieu.Focus();
        }
    }
}