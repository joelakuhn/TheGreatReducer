using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheGreatReducer
{
    public partial class AreaSelector : Form
    {
        public AreaSelector()
        {
            InitializeComponent();
            var dragger = new WindowDragEffect(this);
            dragger.ApplyDragging(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
        }
    }
}
