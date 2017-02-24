using System;
using System.Windows.Forms;
using ExamSchedule.BusinessDatabase;
using ExamSchedule.GUI.WindowsWait;
using System.Threading;

namespace ExamSchedule.GUI
{
    public partial class frmCreateShedule : UserControl, IForm
    {
        public frmCreateShedule()
        {
            InitializeComponent();
        }

        public frmCreateShedule(DataProvider db)
        {
            InitializeComponent();
            this.db = db;
            ChangeButton();
            ChangeLabel();
        }

        public void ChangeButton()
        {
            FormServices.ChangeButtonSkin(this);
        }

        public void ChangeLabel()
        {
            FormServices.ChangeLabelSkin(this);
        }

        public void ChangeTextBox()
        {
            throw new NotImplementedException();
        }


        // Lập lịch
        private void btnShedule_Click(object sender, EventArgs e)
        {
            try
            {
                var numExam = int.Parse(txtTimeSlots.Text);
                var maxDay = int.Parse(txtMaxDay.Text);
                var tb = int.Parse(txtTimeBreak.Text);
                var mc = int.Parse(txtMaxCourse.Text);
                
                this.Cursor = Cursors.WaitCursor;

                db.CreateScheduling(dateTimeStart.Value, numExam,maxDay,tb,mc);

                foreach (var item in db.GetScheduling())
                {
                    if (item != null)
                        dtStuCourseGridView.Rows.Add(item.Course.ID, item.Course.Name, item.Course.Group,
                            item.DateExam.ToShortDateString(), item.Exam, item.Room.ID);
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupImportData_Enter(object sender, EventArgs e)
        {
        }

        private void frmTaoLichThi_Load(object sender, EventArgs e)
        {
            FormServices.ChangeLabelSkin(this);
            FormServices.ChangeLabelSkin(this);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            FormServices.SaveFile(txtPathExport, btnSubmit);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FormServices.ExportToExcel(dtStuCourseGridView);
            btnSubmit.Enabled = false;
        }

        #region KhaiBaoBien

        private readonly DataProvider db;
        private SaveFileDialog save;

        #endregion KhaiBaoBien
    }
}