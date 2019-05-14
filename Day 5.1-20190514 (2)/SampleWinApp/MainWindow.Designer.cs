namespace SampleWinApp
{
    partial class MainWindow
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllRecordsToolStripMenuItem,
            this.addNewRecordToolStripMenuItem,
            this.updateRecordToolStripMenuItem,
            this.deleteRecordToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitWindowToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // viewAllRecordsToolStripMenuItem
            // 
            this.viewAllRecordsToolStripMenuItem.Name = "viewAllRecordsToolStripMenuItem";
            this.viewAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAllRecordsToolStripMenuItem.Text = "View All Records";
            this.viewAllRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewAllRecordsToolStripMenuItem_Click);
            // 
            // addNewRecordToolStripMenuItem
            // 
            this.addNewRecordToolStripMenuItem.Name = "addNewRecordToolStripMenuItem";
            this.addNewRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewRecordToolStripMenuItem.Text = "Add New Record";
            this.addNewRecordToolStripMenuItem.Click += new System.EventHandler(this.addNewRecordToolStripMenuItem_Click);
            // 
            // updateRecordToolStripMenuItem
            // 
            this.updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            this.updateRecordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateRecordToolStripMenuItem.Text = "Update Record";
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // exitWindowToolStripMenuItem
            // 
            this.exitWindowToolStripMenuItem.Name = "exitWindowToolStripMenuItem";
            this.exitWindowToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitWindowToolStripMenuItem.Text = "Exit Window";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitWindowToolStripMenuItem;
    }
}



