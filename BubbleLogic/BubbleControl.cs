using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleLogic
{
    public partial class BubbleControl : UserControl
    {
        public BubbleControl()
        {
            InitializeComponent();
            this.comboBox.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip.Show(this, this.addButton.Location + this.addButton.Size, ToolStripDropDownDirection.BelowLeft);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
                this.Parent.Controls.Remove(this);
        }

        private void addSimpleRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel.Controls.Add(new AtomicRuleControl
            {
                Dock = DockStyle.Top
            });
        }

        private void addCompositeRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel.Controls.Add(new BubbleControl {
                AutoSize = true,
                Dock = DockStyle.Top
            });
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox.SelectedItem == "If All") {
                this.BackColor = Color.PaleGreen;
                this.comboBox.BackColor = Color.PaleGreen;
            }
            if (this.comboBox.SelectedItem == "If Any") {
                this.BackColor = Color.PowderBlue;
                this.comboBox.BackColor = Color.PowderBlue;
            }
        }
    }
}
