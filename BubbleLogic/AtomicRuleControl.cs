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
    public partial class AtomicRuleControl : UserControl
    {
        public AtomicRuleControl()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox3.SelectedItem == "NOT")
                this.BackColor = Color.Yellow;
            else
                this.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
                this.Parent.Controls.Remove(this);
        }
    }
}
