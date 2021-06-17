
namespace DataGridViewDemo
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.jobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minlvlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxlvlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDs = new DataGridViewDemo.myDs();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtJobDesc = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.pubsDataSet = new DataGridViewDemo.pubsDataSet();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsTableAdapter = new DataGridViewDemo.pubsDataSetTableAdapters.jobsTableAdapter();
            this.jobsTableAdapter1 = new DataGridViewDemo.myDsTableAdapters.jobsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDs)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgv1);
            this.panel1.Location = new System.Drawing.Point(-1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 676);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "JOB";
            // 
            // dtgv1
            // 
            this.dtgv1.AutoGenerateColumns = false;
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobidDataGridViewTextBoxColumn,
            this.jobdescDataGridViewTextBoxColumn,
            this.minlvlDataGridViewTextBoxColumn,
            this.maxlvlDataGridViewTextBoxColumn});
            this.dtgv1.DataSource = this.jobsBindingSource1;
            this.dtgv1.Location = new System.Drawing.Point(0, 53);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.RowHeadersWidth = 51;
            this.dtgv1.RowTemplate.Height = 24;
            this.dtgv1.Size = new System.Drawing.Size(694, 604);
            this.dtgv1.TabIndex = 0;
            this.dtgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellContentClick);
            this.dtgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv1_CellMouseClick);
            // 
            // jobidDataGridViewTextBoxColumn
            // 
            this.jobidDataGridViewTextBoxColumn.DataPropertyName = "job_id";
            this.jobidDataGridViewTextBoxColumn.HeaderText = "job_id";
            this.jobidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobidDataGridViewTextBoxColumn.Name = "jobidDataGridViewTextBoxColumn";
            this.jobidDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobdescDataGridViewTextBoxColumn
            // 
            this.jobdescDataGridViewTextBoxColumn.DataPropertyName = "job_desc";
            this.jobdescDataGridViewTextBoxColumn.HeaderText = "job_desc";
            this.jobdescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobdescDataGridViewTextBoxColumn.Name = "jobdescDataGridViewTextBoxColumn";
            this.jobdescDataGridViewTextBoxColumn.Width = 125;
            // 
            // minlvlDataGridViewTextBoxColumn
            // 
            this.minlvlDataGridViewTextBoxColumn.DataPropertyName = "min_lvl";
            this.minlvlDataGridViewTextBoxColumn.HeaderText = "min_lvl";
            this.minlvlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minlvlDataGridViewTextBoxColumn.Name = "minlvlDataGridViewTextBoxColumn";
            this.minlvlDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxlvlDataGridViewTextBoxColumn
            // 
            this.maxlvlDataGridViewTextBoxColumn.DataPropertyName = "max_lvl";
            this.maxlvlDataGridViewTextBoxColumn.HeaderText = "max_lvl";
            this.maxlvlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxlvlDataGridViewTextBoxColumn.Name = "maxlvlDataGridViewTextBoxColumn";
            this.maxlvlDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobsBindingSource1
            // 
            this.jobsBindingSource1.DataMember = "jobs";
            this.jobsBindingSource1.DataSource = this.myDs;
            // 
            // myDs
            // 
            this.myDs.DataSetName = "myDs";
            this.myDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtJobDesc);
            this.panel2.Controls.Add(this.txtmin);
            this.panel2.Controls.Add(this.txtmax);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtJobID);
            this.panel2.Location = new System.Drawing.Point(718, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 676);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(148, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.Location = new System.Drawing.Point(115, 137);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.Size = new System.Drawing.Size(210, 22);
            this.txtJobDesc.TabIndex = 1;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(115, 195);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(210, 22);
            this.txtmin.TabIndex = 2;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(115, 246);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(210, 22);
            this.txtmax.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "maxlvl: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "minlvl: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "JobDesc: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "JobID: ";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(115, 90);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(210, 22);
            this.txtJobID.TabIndex = 0;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "jobs";
            this.jobsBindingSource.DataSource = this.pubsDataSet;
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // jobsTableAdapter1
            // 
            this.jobsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJobID;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private pubsDataSetTableAdapters.jobsTableAdapter jobsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minlvlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxlvlDataGridViewTextBoxColumn;
        private myDs myDs;
        private System.Windows.Forms.BindingSource jobsBindingSource1;
        private myDsTableAdapters.jobsTableAdapter jobsTableAdapter1;
    }
}

