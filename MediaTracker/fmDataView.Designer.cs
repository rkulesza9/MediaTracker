namespace MediaTracker
{
    partial class fmDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDataView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvSeriesTypes = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddSeriesType = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRmvSeriesType = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvSeries = new System.Windows.Forms.ListView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddSeries = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRmvSeries = new System.Windows.Forms.ToolStripButton();
            this.lvIssues = new System.Windows.Forms.ListView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddIssue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRmvIssue = new System.Windows.Forms.ToolStripButton();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvSeriesTypes);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 1;
            // 
            // lvSeriesTypes
            // 
            this.lvSeriesTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1});
            this.lvSeriesTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSeriesTypes.FullRowSelect = true;
            this.lvSeriesTypes.GridLines = true;
            this.lvSeriesTypes.HideSelection = false;
            this.lvSeriesTypes.Location = new System.Drawing.Point(0, 25);
            this.lvSeriesTypes.Name = "lvSeriesTypes";
            this.lvSeriesTypes.Size = new System.Drawing.Size(272, 425);
            this.lvSeriesTypes.TabIndex = 1;
            this.lvSeriesTypes.UseCompatibleStateImageBehavior = false;
            this.lvSeriesTypes.View = System.Windows.Forms.View.Details;
            this.lvSeriesTypes.SelectedIndexChanged += new System.EventHandler(this.lvSeriesTypes_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnAddSeriesType,
            this.toolStripSeparator1,
            this.btnRmvSeriesType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(272, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "[Types]";
            // 
            // btnAddSeriesType
            // 
            this.btnAddSeriesType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSeriesType.Image = global::MediaTracker.Properties.Resources.add;
            this.btnAddSeriesType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSeriesType.Name = "btnAddSeriesType";
            this.btnAddSeriesType.Size = new System.Drawing.Size(23, 22);
            this.btnAddSeriesType.Click += new System.EventHandler(this.btnAddSeriesType_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRmvSeriesType
            // 
            this.btnRmvSeriesType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRmvSeriesType.Image = global::MediaTracker.Properties.Resources.remove;
            this.btnRmvSeriesType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRmvSeriesType.Name = "btnRmvSeriesType";
            this.btnRmvSeriesType.Size = new System.Drawing.Size(23, 22);
            this.btnRmvSeriesType.Text = "toolStripButton2";
            this.btnRmvSeriesType.Click += new System.EventHandler(this.btnRmvSeriesType_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvSeries);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvIssues);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer2.Size = new System.Drawing.Size(524, 450);
            this.splitContainer2.SplitterDistance = 241;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvSeries
            // 
            this.lvSeries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSeries.FullRowSelect = true;
            this.lvSeries.GridLines = true;
            this.lvSeries.HideSelection = false;
            this.lvSeries.Location = new System.Drawing.Point(0, 25);
            this.lvSeries.Name = "lvSeries";
            this.lvSeries.Size = new System.Drawing.Size(524, 216);
            this.lvSeries.TabIndex = 1;
            this.lvSeries.UseCompatibleStateImageBehavior = false;
            this.lvSeries.View = System.Windows.Forms.View.Details;
            this.lvSeries.SelectedIndexChanged += new System.EventHandler(this.lvSeries_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnAddSeries,
            this.toolStripSeparator2,
            this.btnRmvSeries});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(524, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel2.Text = "[Series]";
            // 
            // btnAddSeries
            // 
            this.btnAddSeries.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSeries.Image = global::MediaTracker.Properties.Resources.add;
            this.btnAddSeries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSeries.Name = "btnAddSeries";
            this.btnAddSeries.Size = new System.Drawing.Size(23, 22);
            this.btnAddSeries.Text = "toolStripButton3";
            this.btnAddSeries.Click += new System.EventHandler(this.btnAddSeries_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRmvSeries
            // 
            this.btnRmvSeries.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRmvSeries.Image = global::MediaTracker.Properties.Resources.remove;
            this.btnRmvSeries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRmvSeries.Name = "btnRmvSeries";
            this.btnRmvSeries.Size = new System.Drawing.Size(23, 22);
            this.btnRmvSeries.Text = "toolStripButton4";
            this.btnRmvSeries.Click += new System.EventHandler(this.btnRmvSeries_Click);
            // 
            // lvIssues
            // 
            this.lvIssues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIssues.FullRowSelect = true;
            this.lvIssues.GridLines = true;
            this.lvIssues.HideSelection = false;
            this.lvIssues.Location = new System.Drawing.Point(0, 25);
            this.lvIssues.Name = "lvIssues";
            this.lvIssues.Size = new System.Drawing.Size(524, 180);
            this.lvIssues.TabIndex = 1;
            this.lvIssues.UseCompatibleStateImageBehavior = false;
            this.lvIssues.View = System.Windows.Forms.View.Details;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnAddIssue,
            this.toolStripSeparator3,
            this.btnRmvIssue});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(524, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel3.Text = "[Issues]";
            // 
            // btnAddIssue
            // 
            this.btnAddIssue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddIssue.Image = global::MediaTracker.Properties.Resources.add;
            this.btnAddIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddIssue.Name = "btnAddIssue";
            this.btnAddIssue.Size = new System.Drawing.Size(23, 22);
            this.btnAddIssue.Text = "toolStripButton5";
            this.btnAddIssue.Click += new System.EventHandler(this.btnAddIssue_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRmvIssue
            // 
            this.btnRmvIssue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRmvIssue.Image = global::MediaTracker.Properties.Resources.remove;
            this.btnRmvIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRmvIssue.Name = "btnRmvIssue";
            this.btnRmvIssue.Size = new System.Drawing.Size(23, 22);
            this.btnRmvIssue.Text = "toolStripButton6";
            this.btnRmvIssue.Click += new System.EventHandler(this.btnRmvIssue_Click);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Series Type";
            this.ColumnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Series Title";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Issue Title";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Issue #";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Viewed";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Viewed";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Continuing";
            // 
            // fmDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmDataView";
            this.Text = "File Name";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvSeriesTypes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnAddSeriesType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRmvSeriesType;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvSeries;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnAddSeries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRmvSeries;
        private System.Windows.Forms.ListView lvIssues;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnAddIssue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRmvIssue;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}