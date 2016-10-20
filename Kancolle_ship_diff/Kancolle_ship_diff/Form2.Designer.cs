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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shipTypeListView = new CSortableListViewLib.SortableListView();
            this.shipClassListView = new CSortableListViewLib.SortableListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(184, 277);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(265, 277);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shipTypeListView);
            this.panel1.Controls.Add(this.shipClassListView);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 258);
            this.panel1.TabIndex = 3;
            // 
            // shipTypeListView
            // 
            this.shipTypeListView.Location = new System.Drawing.Point(161, 0);
            this.shipTypeListView.Name = "shipTypeListView";
            this.shipTypeListView.Size = new System.Drawing.Size(163, 258);
            this.shipTypeListView.SortStyle = CSortableListViewLib.SortableListView.SortStyles.SortDefault;
            this.shipTypeListView.TabIndex = 2;
            this.shipTypeListView.UseCompatibleStateImageBehavior = false;
            this.shipTypeListView.View = System.Windows.Forms.View.Details;
            // 
            // shipClassListView
            // 
            this.shipClassListView.CheckBoxes = true;
            this.shipClassListView.Location = new System.Drawing.Point(3, 0);
            this.shipClassListView.Name = "shipClassListView";
            this.shipClassListView.Size = new System.Drawing.Size(152, 258);
            this.shipClassListView.SortStyle = CSortableListViewLib.SortableListView.SortStyles.SortDefault;
            this.shipClassListView.TabIndex = 1;
            this.shipClassListView.UseCompatibleStateImageBehavior = false;
            this.shipClassListView.View = System.Windows.Forms.View.Details;
            this.shipClassListView.SelectedIndexChanged += new System.EventHandler(this.shipTypeClassView_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(352, 308);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private CSortableListViewLib.SortableListView shipClassListView;
        private CSortableListViewLib.SortableListView shipTypeListView;
    }
}