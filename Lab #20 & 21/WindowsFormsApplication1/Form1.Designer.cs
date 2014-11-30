namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inTxtBox = new System.Windows.Forms.TextBox();
            this.outTxtBox = new System.Windows.Forms.TextBox();
            this.inputLbl = new System.Windows.Forms.Label();
            this.ouputLbl = new System.Windows.Forms.Label();
            this.computeBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // inTxtBox
            // 
            this.inTxtBox.Location = new System.Drawing.Point(127, 78);
            this.inTxtBox.Name = "inTxtBox";
            this.inTxtBox.Size = new System.Drawing.Size(100, 20);
            this.inTxtBox.TabIndex = 1;
            // 
            // outTxtBox
            // 
            this.outTxtBox.Location = new System.Drawing.Point(127, 138);
            this.outTxtBox.Name = "outTxtBox";
            this.outTxtBox.Size = new System.Drawing.Size(100, 20);
            this.outTxtBox.TabIndex = 2;
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Location = new System.Drawing.Point(83, 85);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(34, 13);
            this.inputLbl.TabIndex = 3;
            this.inputLbl.Text = "Input:";
            this.inputLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ouputLbl
            // 
            this.ouputLbl.AutoSize = true;
            this.ouputLbl.Location = new System.Drawing.Point(75, 145);
            this.ouputLbl.Name = "ouputLbl";
            this.ouputLbl.Size = new System.Drawing.Size(42, 13);
            this.ouputLbl.TabIndex = 4;
            this.ouputLbl.Text = "Output:";
            this.ouputLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(96, 190);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(75, 23);
            this.computeBtn.TabIndex = 5;
            this.computeBtn.Text = "Process";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.ouputLbl);
            this.Controls.Add(this.inputLbl);
            this.Controls.Add(this.outTxtBox);
            this.Controls.Add(this.inTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox inTxtBox;
        private System.Windows.Forms.TextBox outTxtBox;
        private System.Windows.Forms.Label inputLbl;
        private System.Windows.Forms.Label ouputLbl;
        private System.Windows.Forms.Button computeBtn;
    }
}

