namespace MultithreadMailCourier
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.buttonListMailTasks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ısStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextRunningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnStopTask = new System.Windows.Forms.Button();
            this.btnRunTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogs
            // 
            this.lbLogs.BackColor = System.Drawing.Color.Silver;
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLogs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 18;
            this.lbLogs.Location = new System.Drawing.Point(0, 478);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(845, 238);
            this.lbLogs.TabIndex = 0;
            // 
            // buttonListMailTasks
            // 
            this.buttonListMailTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListMailTasks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListMailTasks.Location = new System.Drawing.Point(0, 12);
            this.buttonListMailTasks.Name = "buttonListMailTasks";
            this.buttonListMailTasks.Size = new System.Drawing.Size(845, 58);
            this.buttonListMailTasks.TabIndex = 1;
            this.buttonListMailTasks.Text = "List Mail Tasks";
            this.buttonListMailTasks.UseVisualStyleBackColor = true;
            this.buttonListMailTasks.Click += new System.EventHandler(this.buttonListMailTasks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIdDataGridViewTextBoxColumn,
            this.ProviderType,
            this.ısRunningDataGridViewCheckBoxColumn,
            this.ısStartedDataGridViewCheckBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.nextRunningDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mailTaskBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(845, 185);
            this.dataGridView1.TabIndex = 2;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            this.taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProviderType
            // 
            this.ProviderType.DataPropertyName = "ProviderType";
            this.ProviderType.HeaderText = "ProviderType";
            this.ProviderType.Name = "ProviderType";
            // 
            // ısRunningDataGridViewCheckBoxColumn
            // 
            this.ısRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            this.ısRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            this.ısRunningDataGridViewCheckBoxColumn.Name = "ısRunningDataGridViewCheckBoxColumn";
            this.ısRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ısStartedDataGridViewCheckBoxColumn
            // 
            this.ısStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            this.ısStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            this.ısStartedDataGridViewCheckBoxColumn.Name = "ısStartedDataGridViewCheckBoxColumn";
            this.ısStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            this.secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            this.secondDataGridViewTextBoxColumn.HeaderText = "Second";
            this.secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            this.secondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextRunningDataGridViewTextBoxColumn
            // 
            this.nextRunningDataGridViewTextBoxColumn.DataPropertyName = "NextRunning";
            this.nextRunningDataGridViewTextBoxColumn.HeaderText = "NextRunning";
            this.nextRunningDataGridViewTextBoxColumn.Name = "nextRunningDataGridViewTextBoxColumn";
            this.nextRunningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailTaskBindingSource
            // 
            this.mailTaskBindingSource.AllowNew = false;
            this.mailTaskBindingSource.DataSource = typeof(MultithreadMailCourier.MailTask);
            this.mailTaskBindingSource.CurrentItemChanged += new System.EventHandler(this.mailTaskBindingSource_CurrentItemChanged);
            // 
            // btnStartTask
            // 
            this.btnStartTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartTask.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartTask.Location = new System.Drawing.Point(6, 22);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(122, 72);
            this.btnStartTask.TabIndex = 3;
            this.btnStartTask.Text = "Start";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnStopTask
            // 
            this.btnStopTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopTask.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStopTask.Location = new System.Drawing.Point(134, 22);
            this.btnStopTask.Name = "btnStopTask";
            this.btnStopTask.Size = new System.Drawing.Size(122, 72);
            this.btnStopTask.TabIndex = 4;
            this.btnStopTask.Text = "Stop";
            this.btnStopTask.UseVisualStyleBackColor = true;
            this.btnStopTask.Click += new System.EventHandler(this.btnStopTask_Click);
            // 
            // btnRunTask
            // 
            this.btnRunTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunTask.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRunTask.Location = new System.Drawing.Point(630, 22);
            this.btnRunTask.Name = "btnRunTask";
            this.btnRunTask.Size = new System.Drawing.Size(209, 72);
            this.btnRunTask.TabIndex = 5;
            this.btnRunTask.Text = "Run";
            this.btnRunTask.UseVisualStyleBackColor = true;
            this.btnRunTask.Click += new System.EventHandler(this.btnRunTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStopTask);
            this.groupBox1.Controls.Add(this.btnRunTask);
            this.groupBox1.Controls.Add(this.btnStartTask);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 716);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonListMailTasks);
            this.Controls.Add(this.lbLogs);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbLogs;
        private Button buttonListMailTasks;
        private DataGridView dataGridView1;
        private BindingSource mailTaskBindingSource;
        private Button btnStartTask;
        private Button btnStopTask;
        private Button btnRunTask;
        private DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProviderType;
        private DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
        private GroupBox groupBox1;
    }
}