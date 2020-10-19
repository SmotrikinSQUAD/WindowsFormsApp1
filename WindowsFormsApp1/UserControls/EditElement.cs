using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Tracing;
using WindowsFormsApp1.dbhandler;

namespace WindowsFormsApp1.UserControls
{

    public partial class EditElement : UserControl
    {
        private string topic_name;

        public EditElement(string topic_name, string word)
        {
            InitializeComponent();

            word_name.Text = word;
            this.topic_name = topic_name;
        }

        public event Action<EditElement> OnDelete;

        private void Edit_but_Click(object sender, EventArgs e)
        {
            string NewValue = Microsoft.VisualBasic.Interaction.InputBox("Введите новое значение:");
            if (NewValue == "") return;

            string old_value = word_name.Text;

            //1. Get Topic From DB
            topic topic1 = dbhandler.dbManager.GetTopic(topic_name);
            //2. Get Words From Topic
            string words = topic1.words;
            //3. Replace Word
            topic1.words = words.Replace(old_value, NewValue);

            dbhandler.dbManager.EditTopic(topic1);
            word_name.Text = NewValue;
        }

        private void Delete_but_Click(object sender, EventArgs e)
        {

        }

        private void EditElement_Load(object sender, EventArgs e)
        {

        }
    }
}
