namespace SampleWinApp
{
    partial class frmCalcForm
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(8, 7);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(321, 94);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstValue.Location = new System.Drawing.Point(8, 116);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(320, 48);
            this.txtFirstValue.TabIndex = 1;
            this.txtFirstValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstValue_Validating);
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "X",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(120, 182);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(54, 30);
            this.cmbOperator.TabIndex = 2;
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondValue.Location = new System.Drawing.Point(8, 233);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(320, 48);
            this.txtSecondValue.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(96, 303);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(125, 47);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Get Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(334, 578);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtSecondValue);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtFirstValue);
            this.Controls.Add(this.lblDisplay);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalcForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.Button btnResult;
    }
}

