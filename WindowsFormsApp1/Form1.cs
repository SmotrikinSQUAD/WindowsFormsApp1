using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1.dbhandler;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    using Menu = UserControls.Menu;

    public partial class Form1 : Form
    {

        Menu menu;
        AdminPanel adminPanel;

        public Form1()
        {

            InitializeComponent();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            Controls.Add(menu = new Menu());
            adminPanel = new AdminPanel();
            adminPanel.OnBackToMenu += OnBackToMenu;

            adminPanel.OnTopicClick += (topic, words) =>
            {
                Controls.Clear();
                Controls.Add(new Edit(topic, words));
            };

            menu.OnEnterAction += (login, password) =>
            {
                if (login == "admin" && password == "111")
                {
                    Controls.Clear();
                    Controls.Add(adminPanel);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            };

            menu.OnStartGameAction += () =>
            {
                Controls.Clear();
                Controls.Add(new UserControls.GameMode());
            };
        }

        private void OnBackToMenu()
        {
            Controls.Clear();
            Controls.Add(menu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = dbManager.GetAllTopics();

            foreach (var item in list)
            {
                MessageBox.Show($"Текущий topic = {item.Id}; {item.topic1}; {item.words}");

            }

            



            // On topic selected

            // 1. Get rounds amount

            // 2. Start round

            // 3. Get word

            // 4. Shuffle word letters

        }
    }
}
