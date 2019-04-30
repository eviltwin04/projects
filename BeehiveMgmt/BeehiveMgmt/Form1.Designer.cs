namespace BeehiveMgmt
{
    partial class Form1
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
            this.jobAssign = new System.Windows.Forms.Button();
            this.nextShift = new System.Windows.Forms.Button();
            this.workerBeeAssignments = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobAssign
            // 
            this.jobAssign.Location = new System.Drawing.Point(18, 132);
            this.jobAssign.Name = "jobAssign";
            this.jobAssign.Size = new System.Drawing.Size(318, 27);
            this.jobAssign.TabIndex = 0;
            this.jobAssign.Text = "Assign This Job To A Bee";
            this.jobAssign.UseVisualStyleBackColor = true;
            this.jobAssign.Click += new System.EventHandler(this.jobAssign_Click);
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextShift.Location = new System.Drawing.Point(558, 12);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(212, 147);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // workerBeeAssignments
            // 
            this.workerBeeAssignments.AutoSize = true;
            this.workerBeeAssignments.Location = new System.Drawing.Point(15, 16);
            this.workerBeeAssignments.Name = "workerBeeAssignments";
            this.workerBeeAssignments.Size = new System.Drawing.Size(126, 13);
            this.workerBeeAssignments.TabIndex = 2;
            this.workerBeeAssignments.Text = "Worker Bee Assignments";
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Location = new System.Drawing.Point(15, 57);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(24, 13);
            this.job.TabIndex = 3;
            this.job.Text = "Job";
            // 
            // shifts
            // 
            this.shifts.AutoSize = true;
            this.shifts.Location = new System.Drawing.Point(225, 57);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(33, 13);
            this.shifts.TabIndex = 4;
            this.shifts.Text = "Shifts";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(15, 189);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(773, 249);
            this.report.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 84);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar Collector",
            "Honey Manufacturing",
            "Egg Care",
            "Baby Bee Tutoring",
            "Hive Maintenance",
            "Sting Patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(18, 84);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(121, 21);
            this.workerBeeJob.TabIndex = 7;
            this.workerBeeJob.SelectedIndexChanged += new System.EventHandler(this.workerBeeJob_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.job);
            this.groupBox1.Controls.Add(this.workerBeeAssignments);
            this.groupBox1.Controls.Add(this.jobAssign);
            this.groupBox1.Controls.Add(this.nextShift);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.report);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jobAssign;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.Label workerBeeAssignments;
        private System.Windows.Forms.Label job;
        private System.Windows.Forms.Label shifts;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

