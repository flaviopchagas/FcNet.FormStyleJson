namespace FcNet.FormStyleJson.Sample
{
    partial class FormMain
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
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Location = new System.Drawing.Point(76, 32);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(205, 83);
            this.pnlTitle.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnOk);
            this.pnlContent.Location = new System.Drawing.Point(299, 158);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(205, 83);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Location = new System.Drawing.Point(46, 158);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(205, 83);
            this.pnlLeft.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(97, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 401);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTitle);
            this.Name = "FormMain";
            this.Text = "FcNet.FormStyleJson Sample";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnCancel;
    }
}

