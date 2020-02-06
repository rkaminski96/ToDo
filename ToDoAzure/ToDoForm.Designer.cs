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
            this.listViewCompleted = new System.Windows.Forms.ListView();
            this.ToDoTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToDoStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradientPanel1 = new ToDoAzure.Design.GradientPanel();
            this.gradientPanel2 = new ToDoAzure.Design.GradientPanel();
            this.allTodosButton = new System.Windows.Forms.Button();
            this.completedTodosButton = new System.Windows.Forms.Button();
            this.activeTodosButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewActive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAll = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markAsDoneButton = new System.Windows.Forms.PictureBox();
            this.addToDoButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toDoStatusLabel = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markAsDoneButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToDoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCompleted
            // 
            this.listViewCompleted.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ToDoTitle,
            this.ToDoStatus});
            this.listViewCompleted.HideSelection = false;
            this.listViewCompleted.Location = new System.Drawing.Point(182, 48);
            this.listViewCompleted.Name = "listViewCompleted";
            this.listViewCompleted.Size = new System.Drawing.Size(521, 362);
            this.listViewCompleted.TabIndex = 2;
            this.listViewCompleted.UseCompatibleStateImageBehavior = false;
            this.listViewCompleted.View = System.Windows.Forms.View.Details;
            // 
            // ToDoTitle
            // 
            this.ToDoTitle.Text = "Todo Title";
            this.ToDoTitle.Width = 381;
            // 
            // ToDoStatus
            // 
            this.ToDoStatus.Text = "Todo Status";
            this.ToDoStatus.Width = 136;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.DarkOrchid;
            this.gradientPanel1.ColorTop = System.Drawing.Color.SteelBlue;
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(167, 527);
            this.gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.DarkOrchid;
            this.gradientPanel2.ColorTop = System.Drawing.Color.SteelBlue;
            this.gradientPanel2.Controls.Add(this.allTodosButton);
            this.gradientPanel2.Controls.Add(this.completedTodosButton);
            this.gradientPanel2.Controls.Add(this.activeTodosButton);
            this.gradientPanel2.Controls.Add(this.panel4);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(167, 527);
            this.gradientPanel2.TabIndex = 4;
            // 
            // allTodosButton
            // 
            this.allTodosButton.BackColor = System.Drawing.Color.Transparent;
            this.allTodosButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allTodosButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allTodosButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.allTodosButton.Location = new System.Drawing.Point(0, 212);
            this.allTodosButton.Margin = new System.Windows.Forms.Padding(0);
            this.allTodosButton.Name = "allTodosButton";
            this.allTodosButton.Size = new System.Drawing.Size(167, 51);
            this.allTodosButton.TabIndex = 7;
            this.allTodosButton.Text = "ALL";
            this.allTodosButton.UseVisualStyleBackColor = false;
            this.allTodosButton.Click += new System.EventHandler(this.allTodosButton_Click);
            // 
            // completedTodosButton
            // 
            this.completedTodosButton.BackColor = System.Drawing.Color.Transparent;
            this.completedTodosButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.completedTodosButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.completedTodosButton.Location = new System.Drawing.Point(-2, 314);
            this.completedTodosButton.Margin = new System.Windows.Forms.Padding(0);
            this.completedTodosButton.Name = "completedTodosButton";
            this.completedTodosButton.Size = new System.Drawing.Size(167, 51);
            this.completedTodosButton.TabIndex = 6;
            this.completedTodosButton.Text = "COMPLETED";
            this.completedTodosButton.UseVisualStyleBackColor = false;
            this.completedTodosButton.Click += new System.EventHandler(this.completedTodosButton_Click);
            // 
            // activeTodosButton
            // 
            this.activeTodosButton.BackColor = System.Drawing.Color.Transparent;
            this.activeTodosButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.activeTodosButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activeTodosButton.Location = new System.Drawing.Point(0, 263);
            this.activeTodosButton.Margin = new System.Windows.Forms.Padding(0);
            this.activeTodosButton.Name = "activeTodosButton";
            this.activeTodosButton.Size = new System.Drawing.Size(167, 51);
            this.activeTodosButton.TabIndex = 5;
            this.activeTodosButton.Text = "ACTIVE";
            this.activeTodosButton.UseVisualStyleBackColor = false;
            this.activeTodosButton.Click += new System.EventHandler(this.activeTodosButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 152);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(42, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Todo App";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 120);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(51, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 152);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 1;
            // 
            // listViewActive
            // 
            this.listViewActive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewActive.HideSelection = false;
            this.listViewActive.Location = new System.Drawing.Point(182, 48);
            this.listViewActive.Name = "listViewActive";
            this.listViewActive.Size = new System.Drawing.Size(521, 362);
            this.listViewActive.TabIndex = 3;
            this.listViewActive.UseCompatibleStateImageBehavior = false;
            this.listViewActive.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Todo Title";
            this.columnHeader1.Width = 381;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Todo Status";
            this.columnHeader2.Width = 134;
            // 
            // listViewAll
            // 
            this.listViewAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewAll.HideSelection = false;
            this.listViewAll.Location = new System.Drawing.Point(182, 48);
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(521, 362);
            this.listViewAll.TabIndex = 4;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            this.listViewAll.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Todo Title";
            this.columnHeader3.Width = 381;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Todo Status";
            this.columnHeader4.Width = 135;
            // 
            // markAsDoneButton
            // 
            this.markAsDoneButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.markAsDoneButton.Image = global::ToDoAzure.Properties.Resources.tick;
            this.markAsDoneButton.Location = new System.Drawing.Point(182, 450);
            this.markAsDoneButton.Name = "markAsDoneButton";
            this.markAsDoneButton.Size = new System.Drawing.Size(60, 60);
            this.markAsDoneButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.markAsDoneButton.TabIndex = 6;
            this.markAsDoneButton.TabStop = false;
            this.markAsDoneButton.Click += new System.EventHandler(this.markAsDoneButton_Click);
            // 
            // addToDoButton
            // 
            this.addToDoButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addToDoButton.Image = global::ToDoAzure.Properties.Resources.radio;
            this.addToDoButton.Location = new System.Drawing.Point(643, 450);
            this.addToDoButton.Name = "addToDoButton";
            this.addToDoButton.Size = new System.Drawing.Size(60, 60);
            this.addToDoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addToDoButton.TabIndex = 5;
            this.addToDoButton.TabStop = false;
            this.addToDoButton.Click += new System.EventHandler(this.addToDoButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::ToDoAzure.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(689, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ToDoAzure.Properties.Resources.todo;
            this.pictureBox6.Location = new System.Drawing.Point(36, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(94, 74);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 202);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 62);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ToDoAzure.Properties.Resources.microphone;
            this.pictureBox2.Location = new System.Drawing.Point(64, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToDoAzure.Properties.Resources.todo;
            this.pictureBox1.Location = new System.Drawing.Point(36, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(179, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mark as done";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(640, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Add Todo";
            // 
            // toDoStatusLabel
            // 
            this.toDoStatusLabel.AutoSize = true;
            this.toDoStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toDoStatusLabel.Location = new System.Drawing.Point(178, 21);
            this.toDoStatusLabel.Name = "toDoStatusLabel";
            this.toDoStatusLabel.Size = new System.Drawing.Size(130, 21);
            this.toDoStatusLabel.TabIndex = 9;
            this.toDoStatusLabel.Text = "Todo App | All ";
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 527);
            this.Controls.Add(this.toDoStatusLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.markAsDoneButton);
            this.Controls.Add(this.addToDoButton);
            this.Controls.Add(this.listViewAll);
            this.Controls.Add(this.listViewActive);
            this.Controls.Add(this.listViewCompleted);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "ToDoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoForm";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markAsDoneButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToDoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closeButton;
        private Design.GradientPanel gradientPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button activeTodosButton;
        private System.Windows.Forms.Button completedTodosButton;
        private System.Windows.Forms.ListView listViewCompleted;
        private System.Windows.Forms.ColumnHeader ToDoStatus;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ColumnHeader ToDoTitle;
        private System.Windows.Forms.ListView listViewActive;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewAll;
        internal System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button allTodosButton;
        private System.Windows.Forms.PictureBox addToDoButton;
        private System.Windows.Forms.PictureBox markAsDoneButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label toDoStatusLabel;
    }
}