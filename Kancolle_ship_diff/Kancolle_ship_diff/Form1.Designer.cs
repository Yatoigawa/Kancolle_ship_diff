namespace Kancolle_ship_diff
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortableListView1 = new CSortableListViewLib.SortableListView();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.艦種ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // sortableListView1
            // 
            this.sortableListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortableListView1.Location = new System.Drawing.Point(0, 24);
            this.sortableListView1.Name = "sortableListView1";
            this.sortableListView1.Size = new System.Drawing.Size(403, 259);
            this.sortableListView1.SortStyle = CSortableListViewLib.SortableListView.SortStyles.SortDefault;
            this.sortableListView1.TabIndex = 1;
            this.sortableListView1.UseCompatibleStateImageBehavior = false;
            this.sortableListView1.SelectedIndexChanged += new System.EventHandler(this.sortableListView1_SelectedIndexChanged);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.艦種ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "表示";
            // 
            // 艦種ToolStripMenuItem
            // 
            this.艦種ToolStripMenuItem.Name = "艦種ToolStripMenuItem";
            this.艦種ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.艦種ToolStripMenuItem.Text = "艦種";
            this.艦種ToolStripMenuItem.Click += new System.EventHandler(this.艦種ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 283);
            this.Controls.Add(this.sortableListView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private CSortableListViewLib.SortableListView sortableListView1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 艦種ToolStripMenuItem;
    }
}