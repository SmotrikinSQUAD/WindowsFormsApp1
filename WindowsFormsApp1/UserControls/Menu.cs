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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }


        public event Action OnStartGameAction;

        public event Action<string, string> OnEnterAction;


        private void StartGame_Button_Click(object sender, EventArgs e)
        {
            OnStartGameAction.Invoke();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            OnEnterAction.Invoke(textBox1.Text, textBox2.Text);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "");
        }
    }
}
