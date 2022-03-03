namespace ThreadingDemo
{
    partial class Threading
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
            this.btnProcessI = new System.Windows.Forms.Button();
            this.btnProcessII = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcessI
            // 
            this.btnProcessI.Location = new System.Drawing.Point(79, 37);
            this.btnProcessI.Name = "btnProcessI";
            this.btnProcessI.Size = new System.Drawing.Size(75, 46);
            this.btnProcessI.TabIndex = 0;
            this.btnProcessI.Text = "Process I";
            this.btnProcessI.UseVisualStyleBackColor = true;
            this.btnProcessI.Click += new System.EventHandler(this.btnProcessI_Click);
            // 
            // btnProcessII
            // 
            this.btnProcessII.Location = new System.Drawing.Point(328, 37);
            this.btnProcessII.Name = "btnProcessII";
            this.btnProcessII.Size = new System.Drawing.Size(75, 46);
            this.btnProcessII.TabIndex = 0;
            this.btnProcessII.Text = "Process II";
            this.btnProcessII.UseVisualStyleBackColor = true;
            this.btnProcessII.Click += new System.EventHandler(this.btnProcessII_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 124);
            this.Controls.Add(this.btnProcessII);
            this.Controls.Add(this.btnProcessI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcessI;
        private System.Windows.Forms.Button btnProcessII;
    }
}

