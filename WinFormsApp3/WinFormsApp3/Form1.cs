using System;
using System.Drawing;
using System.Windows.Forms;

namespace PigLatinConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConvertToPigLatin()
        {
            string word = textBoxWord.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(word))
            {
                string pigLatinWord = word.Substring(1) + word[0] + "ay";
                labelResult.Text = pigLatinWord;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load background image (assuming the image file is named pig.jpg and located in the project directory)
            pictureBoxBackground.Image = Image.FromFile(@"C:\Users\imdri\Desktop\pig.jpg");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            ConvertToPigLatin();
        }
    }
}
