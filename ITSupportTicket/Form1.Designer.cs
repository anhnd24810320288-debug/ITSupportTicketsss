namespace ITSupportTicket
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label lblNguoiYeuCau;
        private System.Windows.Forms.Label lblNgayGhiNhan;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.Label lblLoaiSuCo;
        private System.Windows.Forms.Label lblThietBi;
        private System.Windows.Forms.Label lblAnhLoi;

        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtNguoiYeuCau;

        private System.Windows.Forms.DateTimePicker dtpNgayGhiNhan;

        private System.Windows.Forms.RadioButton rdoThap;
        private System.Windows.Forms.RadioButton rdoTrungBinh;
        private System.Windows.Forms.RadioButton rdoKhanCap;

        private System.Windows.Forms.ComboBox cboLoaiSuCo;

        private System.Windows.Forms.CheckBox chkMayTinhBan;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkMayIn;
        private System.Windows.Forms.CheckBox chkDienThoai;

        private System.Windows.Forms.PictureBox picAnhLoi;

        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Button btnNhapLai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();

            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.lblNguoiYeuCau = new System.Windows.Forms.Label();
            this.lblNgayGhiNhan = new System.Windows.Forms.Label();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.lblLoaiSuCo = new System.Windows.Forms.Label();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.lblAnhLoi = new System.Windows.Forms.Label();

            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();

            this.dtpNgayGhiNhan = new System.Windows.Forms.DateTimePicker();

            this.rdoThap = new System.Windows.Forms.RadioButton();
            this.rdoTrungBinh = new System.Windows.Forms.RadioButton();
            this.rdoKhanCap = new System.Windows.Forms.RadioButton();

            this.cboLoaiSuCo = new System.Windows.Forms.ComboBox();

            this.chkMayTinhBan = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkMayIn = new System.Windows.Forms.CheckBox();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();

            this.picAnhLoi = new System.Windows.Forms.PictureBox();

            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).BeginInit();

            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(650, 620);
            this.Name = "Form1";
            this.Text = "IT Support Ticket Form";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            // Tiêu đề
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    16F,
                    System.Drawing.FontStyle.Bold);

            this.lblTieuDe.Location =
                new System.Drawing.Point(175, 20);

            this.lblTieuDe.Text =
                "TIẾP NHẬN & PHÂN LOẠI SỰ CỐ IT";

            // Mã phiếu
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Location =
                new System.Drawing.Point(40, 75);

            this.lblMaPhieu.Text = "Mã phiếu:";

            this.txtMaPhieu.Location =
                new System.Drawing.Point(180, 72);

            this.txtMaPhieu.Size =
                new System.Drawing.Size(400, 23);

            this.txtMaPhieu.TabIndex = 0;

            // Người yêu cầu
            this.lblNguoiYeuCau.AutoSize = true;
            this.lblNguoiYeuCau.Location =
                new System.Drawing.Point(40, 115);

            this.lblNguoiYeuCau.Text =
                "Người yêu cầu:";

            this.txtNguoiYeuCau.Location =
                new System.Drawing.Point(180, 112);

            this.txtNguoiYeuCau.Size =
                new System.Drawing.Size(400, 23);

            this.txtNguoiYeuCau.TabIndex = 1;

            // Ngày ghi nhận
            this.lblNgayGhiNhan.AutoSize = true;
            this.lblNgayGhiNhan.Location =
                new System.Drawing.Point(40, 155);

            this.lblNgayGhiNhan.Text =
                "Ngày ghi nhận:";

            this.dtpNgayGhiNhan.Location =
                new System.Drawing.Point(180, 152);

            this.dtpNgayGhiNhan.Size =
                new System.Drawing.Size(200, 23);

            this.dtpNgayGhiNhan.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpNgayGhiNhan.TabIndex = 2;

            // Mức độ
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Location =
                new System.Drawing.Point(40, 200);

            this.lblMucDo.Text =
                "Mức độ ưu tiên:";

            // Radio thấp
            this.rdoThap.AutoSize = true;
            this.rdoThap.Location =
                new System.Drawing.Point(180, 198);

            this.rdoThap.Text = "Thấp";
            this.rdoThap.TabIndex = 3;
            this.rdoThap.UseVisualStyleBackColor = true;

            // Radio trung bình
            this.rdoTrungBinh.AutoSize = true;
            this.rdoTrungBinh.Location =
                new System.Drawing.Point(260, 198);

            this.rdoTrungBinh.Text =
                "Trung bình";

            this.rdoTrungBinh.TabIndex = 4;
            this.rdoTrungBinh.UseVisualStyleBackColor = true;

            // Radio khẩn cấp
            this.rdoKhanCap.AutoSize = true;
            this.rdoKhanCap.Location =
                new System.Drawing.Point(370, 198);

            this.rdoKhanCap.Text =
                "Khẩn cấp";

            this.rdoKhanCap.TabIndex = 5;
            this.rdoKhanCap.UseVisualStyleBackColor = true;

            // Loại sự cố
            this.lblLoaiSuCo.AutoSize = true;
            this.lblLoaiSuCo.Location =
                new System.Drawing.Point(40, 245);

            this.lblLoaiSuCo.Text =
                "Loại sự cố:";

            this.cboLoaiSuCo.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboLoaiSuCo.FormattingEnabled = true;

            this.cboLoaiSuCo.Items.AddRange(
                new object[]
                {
                    "Phần cứng",
                    "Phần mềm",
                    "Mạng",
                    "Tài khoản"
                });

            this.cboLoaiSuCo.Location =
                new System.Drawing.Point(180, 242);

            this.cboLoaiSuCo.Size =
                new System.Drawing.Size(250, 23);

            this.cboLoaiSuCo.TabIndex = 6;

            // Thiết bị
            this.lblThietBi.AutoSize = true;
            this.lblThietBi.Location =
                new System.Drawing.Point(40, 290);

            this.lblThietBi.Text =
                "Thiết bị ảnh hưởng:";

            // Máy tính bàn
            this.chkMayTinhBan.AutoSize = true;
            this.chkMayTinhBan.Location =
                new System.Drawing.Point(180, 288);

            this.chkMayTinhBan.Text =
                "Máy tính bàn";

            this.chkMayTinhBan.TabIndex = 7;
            this.chkMayTinhBan.UseVisualStyleBackColor = true;

            // Laptop
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location =
                new System.Drawing.Point(300, 288);

            this.chkLaptop.Text =
                "Laptop";

            this.chkLaptop.TabIndex = 8;
            this.chkLaptop.UseVisualStyleBackColor = true;

            // Máy in
            this.chkMayIn.AutoSize = true;
            this.chkMayIn.Location =
                new System.Drawing.Point(390, 288);

            this.chkMayIn.Text =
                "Máy in";

            this.chkMayIn.TabIndex = 9;
            this.chkMayIn.UseVisualStyleBackColor = true;

            // Điện thoại
            this.chkDienThoai.AutoSize = true;
            this.chkDienThoai.Location =
                new System.Drawing.Point(470, 288);

            this.chkDienThoai.Text =
                "Điện thoại";

            this.chkDienThoai.TabIndex = 10;
            this.chkDienThoai.UseVisualStyleBackColor = true;

            // Ảnh lỗi
            this.lblAnhLoi.AutoSize = true;
            this.lblAnhLoi.Location =
                new System.Drawing.Point(40, 335);

            this.lblAnhLoi.Text =
                "Ảnh chụp lỗi:";

            // PictureBox
            this.picAnhLoi.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.picAnhLoi.Location =
                new System.Drawing.Point(180, 330);

            this.picAnhLoi.Size =
                new System.Drawing.Size(250, 150);

            this.picAnhLoi.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // Tải ảnh
            this.btnTaiAnh.Location =
                new System.Drawing.Point(450, 385);

            this.btnTaiAnh.Size =
                new System.Drawing.Size(120, 35);

            this.btnTaiAnh.Text =
                "Tải ảnh lỗi";

            this.btnTaiAnh.TabIndex = 11;

            this.btnTaiAnh.UseVisualStyleBackColor = true;

            this.btnTaiAnh.Click +=
                new System.EventHandler(this.btnTaiAnh_Click);

            // Gửi yêu cầu
            this.btnGuiYeuCau.Location =
                new System.Drawing.Point(180, 520);

            this.btnGuiYeuCau.Size =
                new System.Drawing.Size(140, 40);

            this.btnGuiYeuCau.Text =
                "Gửi yêu cầu";

            this.btnGuiYeuCau.TabIndex = 12;

            this.btnGuiYeuCau.UseVisualStyleBackColor = true;

            this.btnGuiYeuCau.Click +=
                new System.EventHandler(this.btnGuiYeuCau_Click);

            // Nhập lại
            this.btnNhapLai.Location =
                new System.Drawing.Point(340, 520);

            this.btnNhapLai.Size =
                new System.Drawing.Size(140, 40);

            this.btnNhapLai.Text =
                "Nhập lại";

            this.btnNhapLai.TabIndex = 13;

            this.btnNhapLai.UseVisualStyleBackColor = true;

            this.btnNhapLai.Click +=
                new System.EventHandler(this.btnNhapLai_Click);

            // Add controls
            this.Controls.Add(this.lblTieuDe);

            this.Controls.Add(this.lblMaPhieu);
            this.Controls.Add(this.txtMaPhieu);

            this.Controls.Add(this.lblNguoiYeuCau);
            this.Controls.Add(this.txtNguoiYeuCau);

            this.Controls.Add(this.lblNgayGhiNhan);
            this.Controls.Add(this.dtpNgayGhiNhan);

            this.Controls.Add(this.lblMucDo);
            this.Controls.Add(this.rdoThap);
            this.Controls.Add(this.rdoTrungBinh);
            this.Controls.Add(this.rdoKhanCap);

            this.Controls.Add(this.lblLoaiSuCo);
            this.Controls.Add(this.cboLoaiSuCo);

            this.Controls.Add(this.lblThietBi);
            this.Controls.Add(this.chkMayTinhBan);
            this.Controls.Add(this.chkLaptop);
            this.Controls.Add(this.chkMayIn);
            this.Controls.Add(this.chkDienThoai);

            this.Controls.Add(this.lblAnhLoi);
            this.Controls.Add(this.picAnhLoi);
            this.Controls.Add(this.btnTaiAnh);

            this.Controls.Add(this.btnGuiYeuCau);
            this.Controls.Add(this.btnNhapLai);

            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}