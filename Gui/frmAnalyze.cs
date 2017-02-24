using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSchedule.GUI
{
    public partial class frmAnalyze : UserControl
    {
        private BusinessDatabase.DataProvider db;

        public frmAnalyze()
        {
            InitializeComponent();
        }

        public frmAnalyze(BusinessDatabase.DataProvider db)
        {
            // TODO: Complete member initialization 
            InitializeComponent();
            this.db = db;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            var check = db.Analyze();
            if(check == null){
                MessageBox.Show("Đã phân tích", "Thông báo");
            }else{
                dataGridViewCourseConflided.Rows.Clear();
                 foreach(var item in check)
                dataGridViewCourseConflided.Rows.Add(item.ID, item.Name, item.Group, item.Block, item.Status);
                
            }
           
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            var check = db.Resolve();
            if (check == null)
            {
                MessageBox.Show("Đã giải quyết", "Thông báo");
            }
            else
            {
                dataGridViewCourseConflided.Rows.Clear();
                foreach (var item in check)
                    dataGridViewCourseConflided.Rows.Add(item.ID, item.Name, item.Group, item.Block, item.Status);
            }
            
        }

        private void dataGridViewCourseConflided_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
