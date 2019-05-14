namespace SampleWinApp
{
    partial class DatabaseProgram
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
            this.grdDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDetails
            // 
            this.grdDetails.AllowUserToAddRows = false;
            this.grdDetails.AllowUserToDeleteRows = false;
            this.grdDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDetails.Location = new System.Drawing.Point(12, 181);
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.Size = new System.Drawing.Size(1074, 413);
            this.grdDetails.TabIndex = 0;
            // 
            // DatabaseProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 689);
            this.Controls.Add(this.grdDetails);
            this.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DatabaseProgram";
            this.Text = "DatabaseProgram";
            this.Load += new System.EventHandler(this.DatabaseProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDetails;
    }
}