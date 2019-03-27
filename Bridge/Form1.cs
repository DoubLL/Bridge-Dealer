using System;
using System.Windows.Forms;

namespace Bridge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var desc = !string.IsNullOrEmpty(descriptionInput.Text) ? descriptionInput.Text : "Description";
            var count = (countInput.Value > 0) ? countInput.Value : 1;
            var output = FormatProvider.Start(desc);
            for (uint i = 0; i < count; i++)
            {
                var game = GameProvider.createGame(i);
                output += FormatProvider.Format(game);
            }
            FileSystemProvider.Save(output);
        }
    }
}
