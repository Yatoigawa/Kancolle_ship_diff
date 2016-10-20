namespace Kancolle_ship_diff
{
    partial class Form2
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
            "",
            "戦艦"}, -1);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortableListView1 = new CSortableListViewLib.SortableListView();
            this.CheckBoxes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShipTypes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(115, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(196, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sortableListView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 288);
            this.panel1.TabIndex = 3;
            // 
            // sortableListView1
            // 
            this.sortableListView1.CheckBoxes = true;
            this.sortableListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CheckBoxes,
            this.ShipTypes});
            listViewItem1.StateImageIndex = 0;
            this.sortableListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.sortableListView1.Location = new System.Drawing.Point(0, 0);
            this.sortableListView1.Name = "sortableListView1";
            this.sortableListView1.Size = new System.Drawing.Size(126, 288);
            this.sortableListView1.SortStyle = CSortableListViewLib.SortableListView.SortStyles.SortSelectedColumn;
            this.sortableListView1.TabIndex = 0;
            this.sortableListView1.UseCompatibleStateImageBehavior = false;
            this.sortableListView1.View = System.Windows.Forms.View.Details;
            // 
            // CheckBoxes
            // 
            this.CheckBoxes.Text = "○";
            this.CheckBoxes.Width = 23;
            // 
            // ShipTypes
            // 
            this.ShipTypes.Text = "艦種";
            this.ShipTypes.Width = 96;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "艦種設定";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader CheckBoxes;
        private System.Windows.Forms.ColumnHeader ShipTypes;
        public CSortableListViewLib.SortableListView sortableListView1;
    }
}