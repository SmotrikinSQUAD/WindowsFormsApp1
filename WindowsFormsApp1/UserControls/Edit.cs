using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class Edit : UserControl
    {
        public Edit(string topic, string[] words)
        {
            InitializeComponent();

            label1.Text = topic;
            for (int i = 0; i < words.Length; i++)
            {
                EditElement ee = new EditElement(topic, words[i]);
                ee.Location = new Point(15, (i + 1) * 50);
                Controls.Add(ee);
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
