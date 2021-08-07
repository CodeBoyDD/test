namespace SpeedTool
{
    partial class Frm_Clean
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "清空回收站",
            "系统回收站清空"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "清空IE缓冲区",
            "彻底删除系统中IE缓存文件"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "清空IE Cookice",
            "清除在系统中保存的IE Cookies文件"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "清空Windows临时文件",
            "清空Windows临时文件"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "清空打开文件的记录",
            "删除【开始】/【文档】中的打开记录"}, -1);
            this.Clean_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ConfrimClean = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Clean_listView
            // 
            this.Clean_listView.CheckBoxes = true;
            this.Clean_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Clean_listView.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Clean_listView.GridLines = true;
            this.Clean_listView.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            this.Clean_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.Clean_listView.Location = new System.Drawing.Point(12, 11);
            this.Clean_listView.Name = "Clean_listView";
            this.Clean_listView.Size = new System.Drawing.Size(370, 150);
            this.Clean_listView.TabIndex = 0;
            this.Clean_listView.UseCompatibleStateImageBehavior = false;
            this.Clean_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "清理项目";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "项目说明";
            this.columnHeader2.Width = 246;
            // 
            // btn_ConfrimClean
            // 
            this.btn_ConfrimClean.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ConfrimClean.Location = new System.Drawing.Point(299, 167);
            this.btn_ConfrimClean.Name = "btn_ConfrimClean";
            this.btn_ConfrimClean.Size = new System.Drawing.Size(85, 30);
            this.btn_ConfrimClean.TabIndex = 1;
            this.btn_ConfrimClean.Text = "清理";
            this.btn_ConfrimClean.UseVisualStyleBackColor = true;
            this.btn_ConfrimClean.Click += new System.EventHandler(this.btn_ConfrimClean_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 169);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(281, 26);
            this.progressBar1.TabIndex = 2;
            // 
            // Frm_Clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 201);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_ConfrimClean);
            this.Controls.Add(this.Clean_listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Clean";
            this.Text = "电脑清理";
            this.Load += new System.EventHandler(this.Frm_Clean_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Clean_listView;
        private System.Windows.Forms.Button btn_ConfrimClean;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}