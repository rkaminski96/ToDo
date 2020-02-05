namespace ToDoAzure
{
    partial class ToDoForm
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
            this.gradientPanel1 = new ToDoAzure.Design.GradientPanel();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.SteelBlue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.DarkViolet;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(167, 450);
            this.gradientPanel1.TabIndex = 0;
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Design.GradientPanel gradientPanel1;
    }
}