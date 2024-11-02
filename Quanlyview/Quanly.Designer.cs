namespace Quanlyview
{
    partial class Quanly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanly));
            btThoat = new Button();
            btDangXuat = new Button();
            dgvEmployee = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbmsv = new TextBox();
            tbName = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btEdit = new Button();
            btDelete = new Button();
            label5 = new Label();
            tbmalop = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tbsdt = new TextBox();
            pbEmployeeImage = new PictureBox();
            btSelectImage = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            cbdiachi = new TextBox();
            tbnganhhoc = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.FromArgb(255, 128, 128);
            btThoat.Location = new Point(27, 37);
            btThoat.Margin = new Padding(3, 4, 3, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(97, 32);
            btThoat.TabIndex = 0;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // btDangXuat
            // 
            btDangXuat.BackColor = Color.SpringGreen;
            btDangXuat.Location = new Point(142, 37);
            btDangXuat.Margin = new Padding(3, 4, 3, 4);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(91, 32);
            btDangXuat.TabIndex = 1;
            btDangXuat.Text = "Đăng xuất";
            btDangXuat.UseVisualStyleBackColor = false;
            btDangXuat.Click += btDangXuat_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.GridColor = Color.Black;
            dgvEmployee.Location = new Point(119, 45);
            dgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(1106, 312);
            dgvEmployee.TabIndex = 2;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 81);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 126);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Tuổi";
            // 
            // tbmsv
            // 
            tbmsv.Location = new Point(109, 27);
            tbmsv.Margin = new Padding(3, 4, 3, 4);
            tbmsv.Name = "tbmsv";
            tbmsv.Size = new Size(166, 27);
            tbmsv.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(109, 74);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(166, 27);
            tbName.TabIndex = 8;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Checked;
            ckGender.Location = new Point(109, 163);
            ckGender.Margin = new Padding(3, 4, 3, 4);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(65, 24);
            ckGender.TabIndex = 9;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.BackColor = Color.SpringGreen;
            btAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btAddNew.Location = new Point(118, 380);
            btAddNew.Margin = new Padding(3, 4, 3, 4);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(65, 40);
            btAddNew.TabIndex = 10;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = false;
            btAddNew.Click += btAddNew_Click;
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.Aquamarine;
            btEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btEdit.Location = new Point(118, 437);
            btEdit.Margin = new Padding(3, 4, 3, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(65, 40);
            btEdit.TabIndex = 11;
            btEdit.Text = "Sửa";
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.FromArgb(255, 128, 128);
            btDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btDelete.Location = new Point(118, 497);
            btDelete.Margin = new Padding(3, 4, 3, 4);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(65, 40);
            btDelete.TabIndex = 12;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(551, 6);
            label5.Name = "label5";
            label5.Size = new Size(222, 35);
            label5.TabIndex = 13;
            label5.Text = "Quản Lý Sinh Viên ";
            // 
            // tbmalop
            // 
            tbmalop.Location = new Point(492, 27);
            tbmalop.Margin = new Padding(3, 4, 3, 4);
            tbmalop.Name = "tbmalop";
            tbmalop.Size = new Size(239, 27);
            tbmalop.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 30);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 18;
            label7.Text = "Mã Lớp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 74);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 19;
            label8.Text = "Địa chỉ";
            label8.Click += label8_Click;
            // 
            // tbsdt
            // 
            tbsdt.Location = new Point(492, 119);
            tbsdt.Margin = new Padding(3, 4, 3, 4);
            tbsdt.Name = "tbsdt";
            tbsdt.Size = new Size(239, 27);
            tbsdt.TabIndex = 21;
            // 
            // pbEmployeeImage
            // 
            pbEmployeeImage.Location = new Point(1116, 380);
            pbEmployeeImage.Margin = new Padding(3, 4, 3, 4);
            pbEmployeeImage.Name = "pbEmployeeImage";
            pbEmployeeImage.Size = new Size(108, 143);
            pbEmployeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmployeeImage.TabIndex = 22;
            pbEmployeeImage.TabStop = false;
            // 
            // btSelectImage
            // 
            btSelectImage.BackColor = Color.FromArgb(128, 255, 255);
            btSelectImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btSelectImage.Location = new Point(1116, 531);
            btSelectImage.Margin = new Padding(3, 4, 3, 4);
            btSelectImage.Name = "btSelectImage";
            btSelectImage.Size = new Size(109, 33);
            btSelectImage.TabIndex = 23;
            btSelectImage.Text = "Chọn ảnh";
            btSelectImage.UseVisualStyleBackColor = false;
            btSelectImage.Click += btSelectImage_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 119);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 27);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btDangXuat);
            groupBox1.Controls.Add(btThoat);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(974, 617);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 86);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng Thái";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ckGender);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbdiachi);
            groupBox2.Controls.Add(tbnganhhoc);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbmsv);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbsdt);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbmalop);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(272, 391);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(754, 204);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Sinh Viên";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(378, 160);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 30;
            label6.Text = "Ngành Học ";
            // 
            // cbdiachi
            // 
            cbdiachi.Location = new Point(492, 74);
            cbdiachi.Name = "cbdiachi";
            cbdiachi.Size = new Size(239, 27);
            cbdiachi.TabIndex = 29;
            // 
            // tbnganhhoc
            // 
            tbnganhhoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tbnganhhoc.Location = new Point(492, 160);
            tbnganhhoc.Name = "tbnganhhoc";
            tbnganhhoc.Size = new Size(239, 27);
            tbnganhhoc.TabIndex = 29;
            tbnganhhoc.TextChanged += tbnganhhoc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 119);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 25;
            label4.Text = "Số Điện Thoại";
            label4.Click += label4_Click;
            // 
            // Quanly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1312, 715);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btSelectImage);
            Controls.Add(pbEmployeeImage);
            Controls.Add(label5);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btAddNew);
            Controls.Add(dgvEmployee);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Quanly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quanly";
            FormClosed += Quanly_FormClosed;
            Load += Quanly_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btThoat;
        private Button btDangXuat;
        private DataGridView dgvEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbmsv;
        private TextBox tbName;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btEdit;
        private Button btDelete;
        private Label label5;
        private TextBox tbmalop;
        private Label label7;
        private Label label8;
        private TextBox tbsdt;
        private PictureBox pbEmployeeImage;
        private Button btSelectImage;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox cbdiachi;
        private TextBox tbnganhhoc;
        private Label label6;
    }
}