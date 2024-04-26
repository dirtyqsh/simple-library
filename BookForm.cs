using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice3
{
    public partial class BookForm : Form
    {
        private Book currentBook;

        public BookForm(Book book)
        {
            InitializeComponent();

            currentBook = book;

            AuthorTextBox.Text = currentBook.Author;
            TitleTextBox.Text = currentBook.Title;
            YearTextBox.Text = currentBook.Year.ToString();
            DescriptionTextBox.Text = currentBook.Description;
            CoverPictureBox.BackgroundImage = currentBook.Cover;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            currentBook.Author = AuthorTextBox.Text;
            currentBook.Title = TitleTextBox.Text;
            currentBook.Year = Convert.ToInt32(YearTextBox.Text);
            currentBook.Description = DescriptionTextBox.Text;
            currentBook.Cover = CoverPictureBox.BackgroundImage;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CoverPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Изображение | *.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CoverPictureBox.BackgroundImage = Image.FromFile(dialog.FileName);
            }
        }
    }
}
