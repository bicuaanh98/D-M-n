namespace Do_Min_v._2._0
{
    partial class ScoreBoard
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreDataDataSet2 = new Do_Min_v._2._0.ScoreDataDataSet2();
            this.bangDiemTableAdapter = new Do_Min_v._2._0.ScoreDataDataSet2TableAdapters.BangDiemTableAdapter();
            this.scoreDataDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreDataDataSet3 = new Do_Min_v._2._0.ScoreDataDataSet3();
            this.bangDiemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemTableAdapter1 = new Do_Min_v._2._0.ScoreDataDataSet3TableAdapters.BangDiemTableAdapter();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.thoigianDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bangDiemBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(616, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // bangDiemBindingSource
            // 
            this.bangDiemBindingSource.DataMember = "BangDiem";
            this.bangDiemBindingSource.DataSource = this.scoreDataDataSet2;
            // 
            // scoreDataDataSet2
            // 
            this.scoreDataDataSet2.DataSetName = "ScoreDataDataSet2";
            this.scoreDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiemTableAdapter
            // 
            this.bangDiemTableAdapter.ClearBeforeFill = true;
            // 
            // scoreDataDataSet2BindingSource
            // 
            this.scoreDataDataSet2BindingSource.DataSource = this.scoreDataDataSet2;
            this.scoreDataDataSet2BindingSource.Position = 0;
            // 
            // scoreDataDataSet3
            // 
            this.scoreDataDataSet3.DataSetName = "ScoreDataDataSet3";
            this.scoreDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiemBindingSource1
            // 
            this.bangDiemBindingSource1.DataMember = "BangDiem";
            this.bangDiemBindingSource1.DataSource = this.scoreDataDataSet3;
            // 
            // bangDiemTableAdapter1
            // 
            this.bangDiemTableAdapter1.ClearBeforeFill = true;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // thoigianDataGridViewTextBoxColumn
            // 
            this.thoigianDataGridViewTextBoxColumn.DataPropertyName = "Thoigian";
            this.thoigianDataGridViewTextBoxColumn.HeaderText = "Thoigian";
            this.thoigianDataGridViewTextBoxColumn.Name = "thoigianDataGridViewTextBoxColumn";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 340);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScoreBoard";
            this.Text = "ScoreBoard";
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ScoreDataDataSet2 scoreDataDataSet2;
        private System.Windows.Forms.BindingSource bangDiemBindingSource;
        private ScoreDataDataSet2TableAdapters.BangDiemTableAdapter bangDiemTableAdapter;
        private System.Windows.Forms.BindingSource scoreDataDataSet2BindingSource;
        private ScoreDataDataSet3 scoreDataDataSet3;
        private System.Windows.Forms.BindingSource bangDiemBindingSource1;
        private ScoreDataDataSet3TableAdapters.BangDiemTableAdapter bangDiemTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianDataGridViewTextBoxColumn;
    }
}