using System.Drawing;
namespace ExamSchedule.GUI
{
    partial class frmCreateShedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnLichThi = new System.Windows.Forms.Panel();
            this.dtStuCourseGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPathExport = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnNhapLieu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShedule = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeSlots = new System.Windows.Forms.TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeBreak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxDay = new System.Windows.Forms.TextBox();
            this.txtMaxCourse = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnMain.SuspendLayout();
            this.pnLichThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStuCourseGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnNhapLieu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnLichThi);
            this.pnMain.Controls.Add(this.pnNhapLieu);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(905, 495);
            this.pnMain.TabIndex = 35;
            // 
            // pnLichThi
            // 
            this.pnLichThi.Controls.Add(this.dtStuCourseGridView);
            this.pnLichThi.Controls.Add(this.panel6);
            this.pnLichThi.Controls.Add(this.panel2);
            this.pnLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLichThi.Location = new System.Drawing.Point(0, 163);
            this.pnLichThi.Name = "pnLichThi";
            this.pnLichThi.Size = new System.Drawing.Size(905, 332);
            this.pnLichThi.TabIndex = 30;
            // 
            // dtStuCourseGridView
            // 
            this.dtStuCourseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtStuCourseGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtStuCourseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtStuCourseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStuCourseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CourseName,
            this.Group,
            this.Date,
            this.Exam,
            this.Room});
            this.dtStuCourseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtStuCourseGridView.Location = new System.Drawing.Point(0, 42);
            this.dtStuCourseGridView.Name = "dtStuCourseGridView";
            this.dtStuCourseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtStuCourseGridView.Size = new System.Drawing.Size(905, 229);
            this.dtStuCourseGridView.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã Môn Học";
            this.ID.Name = "ID";
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Tên Môn Học";
            this.CourseName.Name = "CourseName";
            // 
            // Group
            // 
            this.Group.HeaderText = "Nhóm Học";
            this.Group.Name = "Group";
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày Thi";
            this.Date.Name = "Date";
            // 
            // Exam
            // 
            this.Exam.HeaderText = "Ca Thi";
            this.Exam.Name = "Exam";
            // 
            // Room
            // 
            this.Room.HeaderText = "Phòng Thi";
            this.Room.Name = "Room";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightBlue;
            this.panel6.Controls.Add(this.btnSubmit);
            this.panel6.Controls.Add(this.txtPathExport);
            this.panel6.Controls.Add(this.btnChoose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 271);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(905, 61);
            this.panel6.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(745, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 30);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Xuất dữ liệu";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPathExport
            // 
            this.txtPathExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathExport.Location = new System.Drawing.Point(21, 16);
            this.txtPathExport.Name = "txtPathExport";
            this.txtPathExport.Size = new System.Drawing.Size(604, 26);
            this.txtPathExport.TabIndex = 2;
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.Location = new System.Drawing.Point(631, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(108, 30);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Chọn ";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 42);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "LỊCH THI";
            // 
            // pnNhapLieu
            // 
            this.pnNhapLieu.Controls.Add(this.groupBox1);
            this.pnNhapLieu.Controls.Add(this.tableLayoutPanel1);
            this.pnNhapLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNhapLieu.Location = new System.Drawing.Point(0, 0);
            this.pnNhapLieu.Name = "pnNhapLieu";
            this.pnNhapLieu.Size = new System.Drawing.Size(905, 163);
            this.pnNhapLieu.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 163);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo lịch thi";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnShedule, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimeSlots, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimeStart, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimeBreak, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaxDay, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaxCourse, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(899, 140);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // btnShedule
            // 
            this.btnShedule.Location = new System.Drawing.Point(562, 95);
            this.btnShedule.Name = "btnShedule";
            this.btnShedule.Size = new System.Drawing.Size(334, 32);
            this.btnShedule.TabIndex = 18;
            this.btnShedule.Text = "Tạo lịch thi";
            this.btnShedule.UseVisualStyleBackColor = true;
            this.btnShedule.Click += new System.EventHandler(this.btnShedule_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 40);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số môn thi tối đa / ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 40);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // txtTimeSlots
            // 
            this.txtTimeSlots.AllowDrop = true;
            this.txtTimeSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeSlots.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeSlots.Location = new System.Drawing.Point(103, 49);
            this.txtTimeSlots.Name = "txtTimeSlots";
            this.txtTimeSlots.Size = new System.Drawing.Size(333, 29);
            this.txtTimeSlots.TabIndex = 3;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "";
            this.dateTimeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeStart.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(103, 3);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(333, 29);
            this.dateTimeStart.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Số ca thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 46);
            this.label3.TabIndex = 30;
            this.label3.Text = "Khoảng cách giữa 2 ca";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txtTimeBreak
            // 
            this.txtTimeBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeBreak.Location = new System.Drawing.Point(562, 8);
            this.txtTimeBreak.Name = "txtTimeBreak";
            this.txtTimeBreak.Size = new System.Drawing.Size(334, 29);
            this.txtTimeBreak.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "Số ngày thi tối đa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaxDay
            // 
            this.txtMaxDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxDay.Location = new System.Drawing.Point(562, 54);
            this.txtMaxDay.Name = "txtMaxDay";
            this.txtMaxDay.Size = new System.Drawing.Size(334, 29);
            this.txtMaxDay.TabIndex = 4;
            // 
            // txtMaxCourse
            // 
            this.txtMaxCourse.AllowDrop = true;
            this.txtMaxCourse.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxCourse.Location = new System.Drawing.Point(103, 95);
            this.txtMaxCourse.Name = "txtMaxCourse";
            this.txtMaxCourse.Size = new System.Drawing.Size(333, 29);
            this.txtMaxCourse.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 90);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // frmCreateShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "frmCreateShedule";
            this.Size = new System.Drawing.Size(905, 495);
            this.Load += new System.EventHandler(this.frmTaoLichThi_Load);
            this.pnMain.ResumeLayout(false);
            this.pnLichThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtStuCourseGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnNhapLieu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLichThi;
        private System.Windows.Forms.DataGridView dtStuCourseGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnNhapLieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeSlots;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPathExport;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeBreak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxCourse;
    }
}
