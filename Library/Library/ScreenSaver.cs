using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            AllowTransparency = true;       //позволяет сделать фон формы прозрачным
            TransparencyKey = Color.White;   //указывает какой цвет удаляется
        }

        private void tmrShowScreenSaver_Tick(object sender, EventArgs e)
        {
            if (Opacity != 1)
                Opacity += 0.01;
            else
            {
                tmrShowScreenSaver.Enabled = false;
                Hide();
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            }
        }
    }
}
