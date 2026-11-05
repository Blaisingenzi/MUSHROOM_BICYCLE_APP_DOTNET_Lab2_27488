using System;
using System.Windows.Forms;

namespace BicycleMushroomApp
{
    public partial class ChooseForm : Form
    {
        private readonly LoginForm? loginForm;
        private bool navigating = false;

        // Needed so the Visual Studio designer can open this form
        public ChooseForm()
        {
            InitializeComponent();
        }

        public ChooseForm(LoginForm login) : this()
        {
            loginForm = login;
        }

        private void btnBicycle_Click(object? sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm(loginForm!);
            bicycle.Show();
            navigating = true;
            this.Close();
        }

        private void btnMushroom_Click(object? sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm(loginForm!);
            mushroom.Show();
            navigating = true;
            this.Close();
        }

        // If the user closes this window with the X button, the whole app ends
        private void ChooseForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!navigating)
            {
                Application.Exit();
            }
        }
    }
}