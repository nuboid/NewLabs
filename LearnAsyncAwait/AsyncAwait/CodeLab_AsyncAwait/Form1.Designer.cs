namespace CodeLab_AsyncAwait
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDownload1 = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btDownload2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDownload1
            // 
            this.btDownload1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDownload1.Location = new System.Drawing.Point(48, 52);
            this.btDownload1.Name = "btDownload1";
            this.btDownload1.Size = new System.Drawing.Size(170, 50);
            this.btDownload1.TabIndex = 0;
            this.btDownload1.Text = "Exercise 1";
            this.btDownload1.UseVisualStyleBackColor = true;
            this.btDownload1.Click += new System.EventHandler(this.btDownload1_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(298, 66);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(63, 25);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(298, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(324, 65);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Click me (if you can...)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btDownload2
            // 
            this.btDownload2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDownload2.Location = new System.Drawing.Point(48, 145);
            this.btDownload2.Name = "btDownload2";
            this.btDownload2.Size = new System.Drawing.Size(170, 50);
            this.btDownload2.TabIndex = 3;
            this.btDownload2.Text = "Exercise 2";
            this.btDownload2.UseVisualStyleBackColor = true;
            this.btDownload2.Click += new System.EventHandler(this.btDownload2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 268);
            this.Controls.Add(this.btDownload2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btDownload1);
            this.Name = "Form1";
            this.Text = "CodeLab Async/Await";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btDownload1;
        private Label lbInfo;
        private CheckBox checkBox1;
        private Button btDownload2;
    }
}