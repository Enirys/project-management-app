namespace GestionDeProjets
{
    partial class AddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.panTasksTitle = new System.Windows.Forms.Panel();
            this.PictureBox11 = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.TasksDG = new System.Windows.Forms.DataGridView();
            this.btnEditTask = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteTask = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddTask = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.taskCalendar = new System.Windows.Forms.DateTimePicker();
            this.cmbTaskProgress = new System.Windows.Forms.ComboBox();
            this.panTop.SuspendLayout();
            this.panTasksTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.panTop.Controls.Add(this.panTasksTitle);
            this.panTop.Controls.Add(this.pictureClose);
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(913, 50);
            this.panTop.TabIndex = 17;
            // 
            // panTasksTitle
            // 
            this.panTasksTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.panTasksTitle.Controls.Add(this.PictureBox11);
            this.panTasksTitle.Controls.Add(this.Label6);
            this.panTasksTitle.Location = new System.Drawing.Point(3, 0);
            this.panTasksTitle.Name = "panTasksTitle";
            this.panTasksTitle.Size = new System.Drawing.Size(203, 50);
            this.panTasksTitle.TabIndex = 17;
            // 
            // PictureBox11
            // 
            this.PictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox11.Image")));
            this.PictureBox11.Location = new System.Drawing.Point(9, 11);
            this.PictureBox11.Name = "PictureBox11";
            this.PictureBox11.Size = new System.Drawing.Size(32, 32);
            this.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox11.TabIndex = 2;
            this.PictureBox11.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(47, 9);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(154, 36);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Add Tasks";
            // 
            // pictureClose
            // 
            this.pictureClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(871, 12);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(30, 30);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // TasksDG
            // 
            this.TasksDG.AllowUserToAddRows = false;
            this.TasksDG.AllowUserToDeleteRows = false;
            this.TasksDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TasksDG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TasksDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TasksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(151)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TasksDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.TasksDG.Location = new System.Drawing.Point(423, 65);
            this.TasksDG.Name = "TasksDG";
            this.TasksDG.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TasksDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TasksDG.Size = new System.Drawing.Size(477, 458);
            this.TasksDG.TabIndex = 18;
            this.TasksDG.DoubleClick += new System.EventHandler(this.TasksDG_DoubleClick);
            // 
            // btnEditTask
            // 
            this.btnEditTask.ActiveBorderThickness = 1;
            this.btnEditTask.ActiveCornerRadius = 40;
            this.btnEditTask.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(203)))));
            this.btnEditTask.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditTask.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(203)))));
            this.btnEditTask.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditTask.BackgroundImage")));
            this.btnEditTask.ButtonText = "Edit Task";
            this.btnEditTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTask.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.IdleBorderThickness = 1;
            this.btnEditTask.IdleCornerRadius = 40;
            this.btnEditTask.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(151)))), ((int)(((byte)(219)))));
            this.btnEditTask.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnEditTask.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(151)))), ((int)(((byte)(219)))));
            this.btnEditTask.Location = new System.Drawing.Point(281, 411);
            this.btnEditTask.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(134, 53);
            this.btnEditTask.TabIndex = 22;
            this.btnEditTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.ActiveBorderThickness = 1;
            this.btnDeleteTask.ActiveCornerRadius = 40;
            this.btnDeleteTask.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(203)))));
            this.btnDeleteTask.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteTask.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(203)))));
            this.btnDeleteTask.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTask.BackgroundImage")));
            this.btnDeleteTask.ButtonText = "Delete Task";
            this.btnDeleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTask.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.IdleBorderThickness = 1;
            this.btnDeleteTask.IdleCornerRadius = 40;
            this.btnDeleteTask.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(151)))), ((int)(((byte)(219)))));
            this.btnDeleteTask.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnDeleteTask.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(151)))), ((int)(((byte)(219)))));
            this.btnDeleteTask.Location = new System.Drawing.Point(133, 411);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(142, 53);
            this.btnDeleteTask.TabIndex = 21;
            this.btnDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.ActiveBorderThickness = 1;
            this.btnAddTask.ActiveCornerRadius = 40;
            this.btnAddTask.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(203)))));
            this.btnAddTask.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddTask.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(203)))));
            this.btnAddTask.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTask.BackgroundImage")));
            this.btnAddTask.ButtonText = "Add Task";
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.IdleBorderThickness = 1;
            this.btnAddTask.IdleCornerRadius = 40;
            this.btnAddTask.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(151)))), ((int)(((byte)(219)))));
            this.btnAddTask.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnAddTask.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(151)))), ((int)(((byte)(219)))));
            this.btnAddTask.Location = new System.Drawing.Point(10, 411);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(116, 53);
            this.btnAddTask.TabIndex = 20;
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // BunifuSeparator6
            // 
            this.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.BunifuSeparator6.LineThickness = 1;
            this.BunifuSeparator6.Location = new System.Drawing.Point(23, 128);
            this.BunifuSeparator6.Name = "BunifuSeparator6";
            this.BunifuSeparator6.Size = new System.Drawing.Size(224, 10);
            this.BunifuSeparator6.TabIndex = 24;
            this.BunifuSeparator6.Transparency = 255;
            this.BunifuSeparator6.Vertical = false;
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.SystemColors.Control;
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaskName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.txtTaskName.Location = new System.Drawing.Point(28, 107);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(195, 20);
            this.txtTaskName.TabIndex = 23;
            this.txtTaskName.Text = "Task Name";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 282);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(224, 10);
            this.bunifuSeparator1.TabIndex = 26;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaskDescription.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtTaskDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.txtTaskDescription.Location = new System.Drawing.Point(28, 157);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(195, 119);
            this.txtTaskDescription.TabIndex = 25;
            this.txtTaskDescription.Text = "Add Description";
            // 
            // taskCalendar
            // 
            this.taskCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.taskCalendar.Location = new System.Drawing.Point(28, 299);
            this.taskCalendar.Name = "taskCalendar";
            this.taskCalendar.Size = new System.Drawing.Size(114, 20);
            this.taskCalendar.TabIndex = 27;
            // 
            // cmbTaskProgress
            // 
            this.cmbTaskProgress.FormattingEnabled = true;
            this.cmbTaskProgress.Items.AddRange(new object[] {
            "In Progress",
            "Done",
            "Stopped",
            "Paused",
            "None"});
            this.cmbTaskProgress.Location = new System.Drawing.Point(23, 358);
            this.cmbTaskProgress.Name = "cmbTaskProgress";
            this.cmbTaskProgress.Size = new System.Drawing.Size(121, 21);
            this.cmbTaskProgress.TabIndex = 30;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 534);
            this.ControlBox = false;
            this.Controls.Add(this.cmbTaskProgress);
            this.Controls.Add(this.taskCalendar);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.BunifuSeparator6);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.TasksDG);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTasks";
            this.Load += new System.EventHandler(this.AddTasks_Load);
            this.panTop.ResumeLayout(false);
            this.panTasksTitle.ResumeLayout(false);
            this.panTasksTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panTop;
        internal System.Windows.Forms.Panel panTasksTitle;
        internal System.Windows.Forms.PictureBox PictureBox11;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.DataGridView TasksDG;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnEditTask;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnDeleteTask;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnAddTask;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator6;
        internal System.Windows.Forms.TextBox txtTaskName;
        internal Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        internal System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.DateTimePicker taskCalendar;
        private System.Windows.Forms.ComboBox cmbTaskProgress;
    }
}