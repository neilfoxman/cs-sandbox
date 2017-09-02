namespace sandbox
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
            this.btnSleepTest = new System.Windows.Forms.Button();
            this.btnPrintTest = new System.Windows.Forms.Button();
            this.btnUseBackgroundWorker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSleepTest
            // 
            this.btnSleepTest.Location = new System.Drawing.Point(21, 27);
            this.btnSleepTest.Name = "btnSleepTest";
            this.btnSleepTest.Size = new System.Drawing.Size(75, 23);
            this.btnSleepTest.TabIndex = 0;
            this.btnSleepTest.Text = "Sleep Test";
            this.btnSleepTest.UseVisualStyleBackColor = true;
            this.btnSleepTest.Click += new System.EventHandler(this.btnSleepTest_Click);
            // 
            // btnPrintTest
            // 
            this.btnPrintTest.Location = new System.Drawing.Point(21, 57);
            this.btnPrintTest.Name = "btnPrintTest";
            this.btnPrintTest.Size = new System.Drawing.Size(75, 23);
            this.btnPrintTest.TabIndex = 1;
            this.btnPrintTest.Text = "Print Test";
            this.btnPrintTest.UseVisualStyleBackColor = true;
            this.btnPrintTest.Click += new System.EventHandler(this.btnPrintTest_Click);
            // 
            // btnUseBackgroundWorker
            // 
            this.btnUseBackgroundWorker.Location = new System.Drawing.Point(21, 87);
            this.btnUseBackgroundWorker.Name = "btnUseBackgroundWorker";
            this.btnUseBackgroundWorker.Size = new System.Drawing.Size(75, 54);
            this.btnUseBackgroundWorker.TabIndex = 2;
            this.btnUseBackgroundWorker.Text = "Use BackgroundWorker";
            this.btnUseBackgroundWorker.UseVisualStyleBackColor = true;
            this.btnUseBackgroundWorker.Click += new System.EventHandler(this.btnUseBackgroundWorker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUseBackgroundWorker);
            this.Controls.Add(this.btnPrintTest);
            this.Controls.Add(this.btnSleepTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSleepTest;
        private System.Windows.Forms.Button btnPrintTest;
        private System.Windows.Forms.Button btnUseBackgroundWorker;
    }
}

