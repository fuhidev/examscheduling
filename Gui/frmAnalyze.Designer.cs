namespace ExamSchedule.GUI
{
    partial class frmAnalyze
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
            this.pnbBtnAnalize = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.pnGridView = new System.Windows.Forms.Panel();
            this.dataGridViewCourseConflided = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnbBtnAnalize.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseConflided)).BeginInit();
            this.SuspendLayout();
            // 
            // pnbBtnAnalize
            // 
            this.pnbBtnAnalize.Controls.Add(this.tableLayoutPanel1);
            this.pnbBtnAnalize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnbBtnAnalize.Location = new System.Drawing.Point(0, 369);
            this.pnbBtnAnalize.Name = "pnbBtnAnalize";
            this.pnbBtnAnalize.Size = new System.Drawing.Size(1020, 126);
            this.pnbBtnAnalize.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.btnResolve, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAnalyze, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 126);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnResolve
            // 
            this.btnResolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResolve.Location = new System.Drawing.Point(870, 47);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(147, 30);
            this.btnResolve.TabIndex = 1;
            this.btnResolve.Text = "Giải quyết";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Location = new System.Drawing.Point(717, 47);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(147, 30);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Phân tích";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // pnGridView
            // 
            this.pnGridView.Controls.Add(this.dataGridViewCourseConflided);
            this.pnGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGridView.Location = new System.Drawing.Point(0, 0);
            this.pnGridView.Name = "pnGridView";
            this.pnGridView.Size = new System.Drawing.Size(1020, 369);
            this.pnGridView.TabIndex = 0;
            // 
            // dataGridViewCourseConflided
            // 
            this.dataGridViewCourseConflided.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourseConflided.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCourseConflided.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseConflided.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Group,
            this.Block,
            this.Status});
            this.dataGridViewCourseConflided.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCourseConflided.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCourseConflided.MultiSelect = false;
            this.dataGridViewCourseConflided.Name = "dataGridViewCourseConflided";
            this.dataGridViewCourseConflided.ReadOnly = true;
            this.dataGridViewCourseConflided.Size = new System.Drawing.Size(1020, 369);
            this.dataGridViewCourseConflided.TabIndex = 0;
            this.dataGridViewCourseConflided.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourseConflided_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã Môn";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên Môn";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Nhóm";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Block
            // 
            this.Block.HeaderText = "Tổ";
            this.Block.Name = "Block";
            this.Block.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Tình trạng";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.ToolTipText = "Vấn đề của môn ( Cần tách nhóm, tổ,..)";
            // 
            // frmAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnGridView);
            this.Controls.Add(this.pnbBtnAnalize);
            //this.Name = "frmAnalyzing";
            this.Size = new System.Drawing.Size(1020, 495);
            this.pnbBtnAnalize.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseConflided)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnbBtnAnalize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Panel pnGridView;
        private System.Windows.Forms.DataGridView dataGridViewCourseConflided;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnResolve;
    }
}
