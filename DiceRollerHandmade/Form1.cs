using System;
using System.Drawing.Drawing2D;
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
            this.Paint += new PaintEventHandler(MainForm_Paint);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Define the gradient colors and direction
            Color color1 = Color.FromArgb(255, 0, 64); // Red
            Color color2 = Color.FromArgb(0, 0, 0); // Blue
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Vertical);

            // Fill the background with the gradient
            e.Graphics.FillRectangle(brush, this.ClientRectangle);

            // Clean up resources
            brush.Dispose();
        }



        private void CenterLabel()
        {
            labelResult.Left = (this.ClientSize.Width - labelResult.Width) / 2;
            labelResult.Top = this.ClientSize.Height - labelResult.Height - 10; // Adjust 20 to change distance from bottom
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

        private void MainForm_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
