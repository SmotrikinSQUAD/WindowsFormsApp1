using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.dbhandler;

namespace WindowsFormsApp1.UserControls
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();

            List<topic> topics = dbManager.GetAllTopics();

            int count = 0;

            for (int i = 0; i < topics.Count; i++)
            {
                Button but = new Button();
                Controls.Add(but);
                but.Location = new Point(30, (i + 1) * 30);
                but.Text = topics[i].topic1;
                but.Click += But_Click;
                count++;
            }
             
            if (count == topics.Count)
            {
                Button butback = new Button();
                Controls.Add(butback);
                butback.Location = new Point(130, (count + 1) * 30);
                butback.AutoSize = true;
                butback.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                butback.Text = "Вернуться в главное меню";
                butback.Click += Butback_Click;
            }
        }

        private void But_Click(object sender, EventArgs e)
        {
            Button _sender = sender as Button;
            string topic = _sender.Text;
            string raw_words = dbManager.GetTopic(topic).words;
            string[] words = raw_words.Split(new[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show($"{topic} {words.Length}");
            Controls.Clear();
            

        }

        private void Butback_Click(object sender, EventArgs e)
        {
            Controls.Clear();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
