namespace DiceRollerGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxSides;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBoxSides = new TextBox();
            buttonRoll = new Button();
            labelResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxSides
            // 
            textBoxSides.BackColor = SystemColors.Window;
            textBoxSides.Font = new Font("Unispace", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxSides.Location = new Point(73, 66);
            textBoxSides.Margin = new Padding(4, 3, 4, 3);
            textBoxSides.Name = "textBoxSides";
            textBoxSides.Size = new Size(179, 30);
            textBoxSides.TabIndex = 0;
            textBoxSides.TextAlign = HorizontalAlignment.Center;
            textBoxSides.TextChanged += textBoxSides_TextChanged;
            // 
            // buttonRoll
            // 
            buttonRoll.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRoll.Location = new Point(73, 112);
            buttonRoll.Margin = new Padding(4, 3, 4, 3);
            buttonRoll.Name = "buttonRoll";
            buttonRoll.Size = new Size(179, 56);
            buttonRoll.TabIndex = 1;
            buttonRoll.Text = "Roll";
            buttonRoll.UseVisualStyleBackColor = true;
            buttonRoll.Click += buttonRoll_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Unispace", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(101, 217);
            labelResult.Margin = new Padding(5, 0, 5, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(142, 23);
            labelResult.TabIndex = 2;
            labelResult.Text = "Result Here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 25);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 3;
            label1.Text = "Sides Below";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(325, 267);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(buttonRoll);
            Controls.Add(textBoxSides);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Dice Roller!";
            Resize += MainForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
