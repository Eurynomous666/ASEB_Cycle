namespace WindowsFormsApplication4
{
    partial class Home
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
            this.btn_L1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_L1
            // 
            this.btn_L1.Location = new System.Drawing.Point(28, 33);
            this.btn_L1.Name = "btn_L1";
            this.btn_L1.Size = new System.Drawing.Size(146, 40);
            this.btn_L1.TabIndex = 0;
            this.btn_L1.Text = "Welcome !";
            this.btn_L1.UseVisualStyleBackColor = true;
            this.btn_L1.Click += new System.EventHandler(this.btn_L1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_L1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_L1;
    }
}