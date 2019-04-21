namespace QLHS_Form_Lop
{
    partial class Form_RpDiem
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
            this.crystalReportViewer_BDiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_BDiem
            // 
            this.crystalReportViewer_BDiem.ActiveViewIndex = -1;
            this.crystalReportViewer_BDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer_BDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_BDiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_BDiem.Location = new System.Drawing.Point(12, 12);
            this.crystalReportViewer_BDiem.Name = "crystalReportViewer_BDiem";
            this.crystalReportViewer_BDiem.Size = new System.Drawing.Size(1416, 577);
            this.crystalReportViewer_BDiem.TabIndex = 0;
            // 
            // Form_RpDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 658);
            this.Controls.Add(this.crystalReportViewer_BDiem);
            this.Name = "Form_RpDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điểm học sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_RpDiem_FormClosing);
            this.Load += new System.EventHandler(this.Form_RpDiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_BDiem;
    }
}