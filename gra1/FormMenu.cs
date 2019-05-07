using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }


        private void buttonPlayGame_Click(object sender, EventArgs e) // zamykanie okna menu i otwieranie okna gry
        {
            this.Hide();
            FormGame formGame = new FormGame();
            formGame.Closed += (s, args) => this.Close();
            formGame.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e) // zamykanie programu
        {
            Close();
        }

        private void labelGameName_Click(object sender, EventArgs e) //nazwa gry
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
