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
using System.Diagnostics.Tracing;

namespace WindowsFormsApp1.UserControls
{
    public partial class GameMode : UserControl
    {
        public GameMode()
        {
            InitializeComponent();


            // 1. Get all topics 
            List<topic> topics = dbManager.GetAllTopics();

            // 2. Get random 6 of they
            topics = topics.OrderBy(a => Guid.NewGuid()).ToList();

            // 3. Output
            for(int i = 0; i < 6 && i < topics.Count; i++)
            {
                Button but = new Button();
                Controls.Add(but);
                but.Location = new Point(30, (i+1) * 30);
                but.Text = topics[i].topic1;
                but.Click += But_Click;
            }
        }

        private void But_Click(object sender, EventArgs e)
        {
            Button _sender = sender as Button;
            string topic = _sender.Text;
            string raw_words = dbManager.GetTopic(topic).words;
            string[] words = raw_words.Split(new[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show($"{topic} {words.Length}");
        }

        private void GameMode_Load(object sender, EventArgs e)
        {

        }
    }
}
