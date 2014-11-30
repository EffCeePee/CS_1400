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
            this.firstNumberLbl = new System.Windows.Forms.Label();
            this.secondNumberLbl = new System.Windows.Forms.Label();
            this.sumLbl = new System.Windows.Forms.Label();
            this.firstNumberTxtBox = new System.Windows.Forms.TextBox();
            this.secondNumberTxtBox = new System.Windows.Forms.TextBox();
            this.sumTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
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
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // firstNumberLbl
            // 
            this.firstNumberLbl.AutoSize = true;
            this.firstNumberLbl.Location = new System.Drawing.Point(58, 52);
            this.firstNumberLbl.Name = "firstNumberLbl";
            this.firstNumberLbl.Size = new System.Drawing.Size(56, 13);
            this.firstNumberLbl.TabIndex = 1;
            this.firstNumberLbl.Text = "Number 1:";
            this.firstNumberLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // secondNumberLbl
            // 
            this.secondNumberLbl.AutoSize = true;
            this.secondNumberLbl.Location = new System.Drawing.Point(58, 99);
            this.secondNumberLbl.Name = "secondNumberLbl";
            this.secondNumberLbl.Size = new System.Drawing.Size(56, 13);
            this.secondNumberLbl.TabIndex = 2;
            this.secondNumberLbl.Text = "Number 2:";
            this.secondNumberLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Location = new System.Drawing.Point(80, 154);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(34, 13);
            this.sumLbl.TabIndex = 3;
            this.sumLbl.Text = "Sum :";
            this.sumLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // firstNumberTxtBox
            // 
            this.firstNumberTxtBox.Location = new System.Drawing.Point(120, 49);
            this.firstNumberTxtBox.Name = "firstNumberTxtBox";
            this.firstNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumberTxtBox.TabIndex = 4;
            // 
            // secondNumberTxtBox
            // 
            this.secondNumberTxtBox.Location = new System.Drawing.Point(120, 99);
            this.secondNumberTxtBox.Name = "secondNumberTxtBox";
            this.secondNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.secondNumberTxtBox.TabIndex = 5;
            // 
            // sumTxtBox
            // 
            this.sumTxtBox.Location = new System.Drawing.Point(120, 147);
            this.sumTxtBox.Name = "sumTxtBox";
            this.sumTxtBox.ReadOnly = true;
            this.sumTxtBox.Size = new System.Drawing.Size(100, 20);
            this.sumTxtBox.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(131, 193);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(131, 237);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 288);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.sumTxtBox);
            this.Controls.Add(this.secondNumberTxtBox);
            this.Controls.Add(this.firstNumberTxtBox);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.secondNumberLbl);
            this.Controls.Add(this.firstNumberLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project #9";
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
        private System.Windows.Forms.Label firstNumberLbl;
        private System.Windows.Forms.Label secondNumberLbl;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.TextBox firstNumberTxtBox;
        private System.Windows.Forms.TextBox secondNumberTxtBox;
        private System.Windows.Forms.TextBox sumTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

