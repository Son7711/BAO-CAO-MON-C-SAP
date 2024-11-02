using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; // Ensure you have this using directive for Image
using System.Data.SqlClient;
using System.Net.WebSockets;


namespace Quanlyview
{
    public partial class Quanly : Form
    {
        private string strCon = @"Data Source=LEVANHIEU\MSSQLSERVER02;Initial Catalog=qlsinhvien;User ID=sa;Password=123;Encrypt=False;";
        private SqlConnection sqlCon; // Khai báo SqlConnection


        public List<Employee> lstEmp = new List<Employee>();
        private BindingSource bs = new BindingSource();
        public bool isThoat = true;
        public event EventHandler DangXuat;
        private string employeeImagePath = string.Empty; // Store the image path

        public Quanly()
        {
            InitializeComponent();
            SetupImageList();

            //ngay sinh
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            // Handle value changes (optional)
            dateTimePicker1.ShowUpDown = true;
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();
            bs.DataSource = lstEmp;
            dgvEmployee.DataSource = bs;
            SetupDataGridView(); // Setup DataGridView columns
            dateTimePicker1.Value = DateTime.Now; // Set the default date to now
            dgvEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        public List<Employee> GetData()
        {
            List<Employee> employee = new List<Employee>();

            using (sqlCon = new SqlConnection(strCon)) // Sử dụng từ khóa using để quản lý tài nguyên
            {
                sqlCon.Open(); // Mở kết nối

                // Câu truy vấn để lấy dữ liệu
                string query = "SELECT MaSV, TenSV, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaLop, NganhHoc, ImagePath FROM qlsinhvien";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon)) // Tạo SqlCommand
                {
                    using (SqlDataReader reader = cmd.ExecuteReader()) // Sử dụng using cho SqlDataReader
                    {
                        while (reader.Read()) // Đọc dữ liệu
                        {
                            Employee emp = new Employee
                            {
                                MaSV = reader.GetInt32(0),
                                TenSV = reader.GetString(1),
                                NgaySinh = reader.GetDateTime(2),
                                GioiTinh = reader.GetBoolean(3),
                                DiaChi = reader.GetString(4),
                                SoDienThoai = reader.GetString(5),
                                MaLop = reader.GetString(6),
                                NganhHoc = reader.GetString(7),
                                ImagePath = reader.IsDBNull(8) ? null : reader.GetString(8) // Chỉ số ImagePath được sửa lại
                            };

                            employee.Add(emp); // Thêm vào danh sách
                        }
                    }
                }
            }
            return employee; // Trả về danh sách nhân viên
        }


        private void AddEmployee(Employee newEmp)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "INSERT INTO qlsinhvien (MaSV, TenSV, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaLop, NganhHoc, ImagePath) VALUES (@MaSV, @TenSV, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @MaLop, @NganhHoc, @ImagePath)";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    // Thêm các tham số vào lệnh SQL
                    cmd.Parameters.AddWithValue("@MaSV", newEmp.MaSV);
                    cmd.Parameters.AddWithValue("@TenSV", newEmp.TenSV);
                    cmd.Parameters.AddWithValue("@NgaySinh", newEmp.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", newEmp.GioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", newEmp.DiaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", newEmp.SoDienThoai);
                    cmd.Parameters.AddWithValue("@MaLop", newEmp.MaLop);
                    cmd.Parameters.AddWithValue("@NganhHoc", newEmp.NganhHoc);
                    cmd.Parameters.AddWithValue("@ImagePath", newEmp.ImagePath);

                    // Thực thi lệnh
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        private void UpdateEmployee(Employee emp)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "UPDATE qlsinhvien SET TenSV=@TenSV, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, MaLop=@MaLop, NganhHoc=@NganhHoc, ImagePath=@ImagePath WHERE MaSV=@MaSV";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    // Thêm các tham số vào lệnh SQL
                    cmd.Parameters.AddWithValue("@MaSV", emp.MaSV);
                    cmd.Parameters.AddWithValue("@TenSV", emp.TenSV);
                    cmd.Parameters.AddWithValue("@NgaySinh", emp.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", emp.GioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", emp.DiaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", emp.SoDienThoai);
                    cmd.Parameters.AddWithValue("@MaLop", emp.MaLop);
                    cmd.Parameters.AddWithValue("@NganhHoc", emp.NganhHoc);
                    cmd.Parameters.AddWithValue("@ImagePath", emp.ImagePath);

                    // Thực thi lệnh
                    cmd.ExecuteNonQuery();
                }
            }
        }

       

        private void DeleteEmployee(int empId)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "DELETE FROM qlsinhvien WHERE MaSV=@MaSV";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    // Thêm tham số vào lệnh SQL
                    cmd.Parameters.AddWithValue("@MaSV", empId); // Đảm bảo tham số được thêm đúng cách
                    cmd.ExecuteNonQuery();
                }
            }
        }



        private void SetupDataGridView()
        {
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.Columns[0].HeaderText = "Mã";
            dgvEmployee.Columns[1].HeaderText = "Tên";
            dgvEmployee.Columns[2].HeaderText = "Giới Tính";
            dgvEmployee.Columns[3].HeaderText = "Ngày Sinh";
            dgvEmployee.Columns[4].HeaderText = "Mã Lớp";
            dgvEmployee.Columns[5].HeaderText = "Ngành Học";
            dgvEmployee.Columns[6].HeaderText = "Địa Chỉ";
            dgvEmployee.Columns[7].HeaderText = "Số Điện Thoại";
            dgvEmployee.Columns[8].HeaderText = "Ảnh";

            // Đặt định dạng cho cột Ngày Sinh
            dgvEmployee.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy"; // Thay đổi định dạng hiển thị ngày sinh

            // Đặt toàn bộ DataGridView thành chỉ đọc
            dgvEmployee.ReadOnly = true;

            // Tùy chọn: Thay đổi màu nền của các ô để dễ nhận biết
            dgvEmployee.DefaultCellStyle.BackColor = Color.LightGray;

            // Ngăn không cho chỉnh sửa ô và hiển thị thông báo nếu người dùng cố gắng chỉnh sửa
            dgvEmployee.CellBeginEdit += (s, e) =>
            {
                MessageBox.Show("Lỗi: Không thể chỉnh sửa dữ liệu trực tiếp trong bảng.");
                e.Cancel = true; // Hủy bỏ nỗ lực chỉnh sửa
            };
        }



        //--------------------------------------------------------------------------
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat?.Invoke(this, EventArgs.Empty);
        }

        private void Quanly_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) Application.Exit();
        }

        //--------------------------------------------------------------------------



        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbmsv.Text) ||
                    string.IsNullOrWhiteSpace(tbName.Text) ||
                    string.IsNullOrWhiteSpace(tbmalop.Text) ||
                    string.IsNullOrWhiteSpace(tbsdt.Text) ||
                    string.IsNullOrWhiteSpace(tbnganhhoc.Text) ||
                    string.IsNullOrWhiteSpace(cbdiachi.Text))
                {
                    MessageBox.Show("Lỗi: Bạn cần nhập đầy đủ tất cả các trường.");
                    return;
                }

                if (!int.TryParse(tbmsv.Text, out int newId))
                {
                    MessageBox.Show("Lỗi: ID phải là chữ số.");
                    return;
                }

                if (!IsAlphabetic(tbName.Text))
                {
                    MessageBox.Show("Lỗi: Họ tên phải chỉ chứa các ký tự chữ cái.");
                    return;
                }

                if (!IsValidPhoneNumber(tbsdt.Text))
                {
                    MessageBox.Show("Lỗi: Số điện thoại phải bắt đầu bằng 0 và có 10 chữ số.");
                    return;
                }

                if (lstEmp.Any(emp => emp.MaSV == newId))
                {
                    MessageBox.Show("Lỗi: Mã ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                Employee newEmp = new Employee
                {
                    MaSV = newId,
                    TenSV = tbName.Text,
                    GioiTinh = ckGender.Checked,
                    NgaySinh = dateTimePicker1.Value.Date,
                    MaLop = tbmalop.Text,
                    SoDienThoai = tbsdt.Text,
                    NganhHoc = tbnganhhoc.Text,
                    DiaChi = cbdiachi.Text,
                    ImagePath = employeeImagePath

                };

                lstEmp.Add(newEmp);
                bs.ResetBindings(false);
                AddEmployee(newEmp);
                ClearInputFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Nhập số hợp lệ cho ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            int idx = dgvEmployee.CurrentRow.Index;
            Employee em = lstEmp[idx];
            var emp = lstEmp[idx];

            try
            {
                if (string.IsNullOrWhiteSpace(tbmsv.Text) ||
                    string.IsNullOrWhiteSpace(tbName.Text) ||
                    string.IsNullOrWhiteSpace(tbmalop.Text) ||
                    string.IsNullOrWhiteSpace(tbsdt.Text) ||
                    string.IsNullOrWhiteSpace(tbnganhhoc.Text) ||
                    string.IsNullOrWhiteSpace(cbdiachi.Text))
                {
                    MessageBox.Show("Lỗi: Bạn cần nhập đầy đủ tất cả các trường.");
                    return;
                }

                if (!int.TryParse(tbmsv.Text, out int id))
                {
                    MessageBox.Show("Lỗi: ID phải là chữ số.");
                    return;
                }

                if (!IsAlphabetic(tbName.Text))
                {
                    MessageBox.Show("Lỗi: Họ tên phải chỉ chứa các ký tự chữ cái.");
                    return;
                }

                if (!IsValidPhoneNumber(tbsdt.Text))
                {
                    MessageBox.Show("Lỗi: Số điện thoại phải bắt đầu bằng 0 và có 10 chữ số.");
                    return;
                }

                em.MaSV = id;
                em.TenSV = tbName.Text;
                em.GioiTinh = ckGender.Checked;//gioitinh
                em.NgaySinh = dateTimePicker1.Value.Date; // Ngày sinh từ DateTimePicker
                em.MaLop = tbmalop.Text;//malop
                em.SoDienThoai = tbsdt.Text;// sdt
                em.DiaChi = cbdiachi.Text;//diachi
                em.NganhHoc = tbnganhhoc.Text;
                em.ImagePath = employeeImagePath;//anh

                bs.ResetBindings(false);
                ClearInputFields();
                UpdateEmployee(emp);
                ClearInputFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Nhập số hợp lệ cho ID.");
            }
        }

        // Hàm kiểm tra nếu chuỗi chỉ chứa chữ cái
        private bool IsAlphabetic(string text)
        {
            return text.All(char.IsLetter);
        }

        // Hàm kiểm tra số điện thoại hợp lệ
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber) &&
                   phoneNumber.Length == 10 &&
                   phoneNumber.StartsWith("0") &&
                   phoneNumber.All(char.IsDigit);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            int idx = dgvEmployee.CurrentRow.Index;
            var empMaSV = lstEmp[idx].MaSV;
            lstEmp.RemoveAt(idx);
            DeleteEmployee(empMaSV);
            bs.ResetBindings(false);
        }

        //---------------------------------------------------------------------

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= lstEmp.Count) return;

            Employee em = lstEmp[e.RowIndex];

            tbmsv.Text = em.MaSV.ToString();
            tbName.Text = em.TenSV;
            ckGender.Checked = em.GioiTinh;
            tbmalop.Text = em.MaLop;
            tbnganhhoc.Text = em.NganhHoc;
            tbsdt.Text = em.SoDienThoai;
            cbdiachi.Text = em.DiaChi;

            // Đảm bảo BirthDate nằm trong phạm vi của DateTimePicker
            DateTime validDate = em.NgaySinh < dateTimePicker1.MinDate ? dateTimePicker1.MinDate
                               : em.NgaySinh > dateTimePicker1.MaxDate ? dateTimePicker1.MaxDate
                               : em.NgaySinh;

            dateTimePicker1.Value = validDate;

            // Tải ảnh của nhân viên nếu tồn tại
            if (!string.IsNullOrEmpty(em.ImagePath) && System.IO.File.Exists(em.ImagePath))
            {
                pbEmployeeImage.Image = Image.FromFile(em.ImagePath);
            }
            else
            {
                pbEmployeeImage.Image = null; // Xóa ảnh nếu không có
            }
        }

        //---------------------------------------------------------------------

        private void ClearInputFields()
        {
            tbmsv.Text = "";
            tbName.Text = "";
            tbmalop.Text = "";
            tbsdt.Text = "";
            tbnganhhoc.Text = "";
            cbdiachi.Text = "";
            ckGender.Checked = false;
            pbEmployeeImage.Image = null; // Clear image display
            dateTimePicker1.Value = DateTime.Now; // Reset DateTimePicker to current date
        }

        private void SetupImageList()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(24, 24);


            btAddNew.ImageList = imageList;
            btAddNew.ImageIndex = 0;

            btEdit.ImageList = imageList;
            btEdit.ImageIndex = 1;

            btDelete.ImageList = imageList;
            btDelete.ImageIndex = 2;
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    employeeImagePath = ofd.FileName; // Store the image path
                    pbEmployeeImage.Image = Image.FromFile(employeeImagePath); // Show the image
                }
            }
        }

        // Method to set a specific date for the DateTimePicker (if needed)
        private void SetDateForDateTimePicker(DateTime date)
        {
            dateTimePicker1.Value = date;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            this.Text = dateTimePicker1.Value.ToString("dd MMMM yyyy");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {
            // Code xử lý khi nhấp vào label8
        }

        private void tbMaduan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbnganhhoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
