using System;
using System.Windows.Forms;

namespace DiceRollerGUI
{
    public partial class MainForm : Form
    {
        private Random random;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            CenterLabel();
        }

        private void CenterLabel()
        {
            labelResult.Left = (this.ClientSize.Width - labelResult.Width) / 2;
            labelResult.Top = this.ClientSize.Height - labelResult.Height - 20; // Adjust 20 to change distance from bottom
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            int numberOfSides;
            if (int.TryParse(textBoxSides.Text, out numberOfSides) && numberOfSides > 0)
            {
                int diceRoll = random.Next(1, numberOfSides + 1);
                labelResult.Text = "You rolled a: " + diceRoll;
                CenterLabel(); // Re-center after updating text
            }
            else
            {
                MessageBox.Show("Please enter a valid side count.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterLabel();
        }

        private void textBoxSides_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
