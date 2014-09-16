namespace BubbleLogic
{
    partial class GroupRuleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.atomicRuleControl1 = new BubbleLogic.AtomicRuleControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.atomicRuleControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // atomicRuleControl1
            // 
            this.atomicRuleControl1.AutoSize = true;
            this.atomicRuleControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.atomicRuleControl1.Location = new System.Drawing.Point(3, 3);
            this.atomicRuleControl1.Name = "atomicRuleControl1";
            this.atomicRuleControl1.Size = new System.Drawing.Size(360, 27);
            this.atomicRuleControl1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(369, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "OR...";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 33);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(39, 13);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "AND...";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(407, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(42, 13);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "DELTE";
            // 
            // GroupRuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GroupRuleControl";
            this.Size = new System.Drawing.Size(739, 270);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AtomicRuleControl atomicRuleControl1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}
