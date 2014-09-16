namespace BubbleLogic
{
    partial class BubbleControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BubbleControl));
            this.flowLayoutPanel = new System.Windows.Forms.Panel();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSimpleRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompositeRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topTableLayoutPanel.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flowLayoutPanel.Size = new System.Drawing.Size(637, 325);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.AutoSize = true;
            this.topTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topTableLayoutPanel.ColumnCount = 4;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTableLayoutPanel.Controls.Add(this.comboBox, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.addButton, 2, 0);
            this.topTableLayoutPanel.Controls.Add(this.deleteButton, 3, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(637, 34);
            this.topTableLayoutPanel.TabIndex = 4;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "If All",
            "If Any"});
            this.comboBox.Location = new System.Drawing.Point(3, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(294, 28);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(584, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(22, 22);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(612, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(22, 22);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSimpleRuleToolStripMenuItem,
            this.addCompositeRuleToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(171, 48);
            // 
            // addSimpleRuleToolStripMenuItem
            // 
            this.addSimpleRuleToolStripMenuItem.Name = "addSimpleRuleToolStripMenuItem";
            this.addSimpleRuleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addSimpleRuleToolStripMenuItem.Text = "Add Simple Rule";
            this.addSimpleRuleToolStripMenuItem.Click += new System.EventHandler(this.addSimpleRuleToolStripMenuItem_Click);
            // 
            // addCompositeRuleToolStripMenuItem
            // 
            this.addCompositeRuleToolStripMenuItem.Name = "addCompositeRuleToolStripMenuItem";
            this.addCompositeRuleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addCompositeRuleToolStripMenuItem.Text = "Add Composite Rule";
            this.addCompositeRuleToolStripMenuItem.Click += new System.EventHandler(this.addCompositeRuleToolStripMenuItem_Click);
            // 
            // BubbleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.topTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(200, 0);
            this.Name = "BubbleControl";
            this.Size = new System.Drawing.Size(637, 359);
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addSimpleRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompositeRuleToolStripMenuItem;
        private System.Windows.Forms.Panel flowLayoutPanel;
    }
}
