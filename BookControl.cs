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
    public partial class BookControl : UserControl
    {
        Book currentBook;

        public BookControl()
        {
            InitializeComponent();
        }

        public BookControl(Book book) : this()
        {
            currentBook = book;
            LoadBookDataToControls();
        }

        private void LoadBookDataToControls()
        {
            if (currentBook != null)
            {
                TitleLabel.Text = $"{currentBook.Author}/{currentBook.Title} ({currentBook.Year})";
                DescriptionLabel.Text = currentBook.Description;
                CoverPictureBox.BackgroundImage = currentBook.Cover;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            BookForm editBookForm = new BookForm(currentBook);

            if (editBookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBookDataToControls();
            }
        }
    }
}
