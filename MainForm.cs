using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice3
{
    public partial class MainForm : Form
    {
        private Book[] books;
        public MainForm()
        {
            InitializeComponent();

            books = new Book[]
            {
                new Book()
                {
                    Author = "Стив Макконнелл",
                    Title = "Совершенный код 2-е издание",
                    Year = 2004,
                    Description = "Книга о методах программирования, позволяющих сократить количество ошибок в программном обеспечении, уменьшить сложность их исправления и внесения изменений, облегчить последующую поддержку.",
                },
                new Book()
                {
                    Author = "Александр Сергеевич Пушкин",
                    Title = "Капитанская дочка",
                    Year = 1837,
                    Description = "Исторический роман Александра Пушкина, действие которого происходит во время восстания Емельяна Пугачёва.",
                },
                new Book()
                {
                    Author = "Даниэль Канеман",
                    Title = "Думай медленно… решай быстро",
                    Year = 2011,
                    Description = "Там, где надо подумать и разобраться, мозг решает все впопыхах как попало, а когда нужно среагировать быстро, человек почему-то начинает тормозить. И в результате таких сбоев мы можем принимать неправильные решения, неправильно действовать и получать в итоге не то, что хотели.",
                }
            };

            String jsonString = File.ReadAllText("bookList.txt");
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            books = JsonSerializer.Deserialize<Book[]>(jsonString, options);

            for (int i = 0; i < books.Length; i++)
            {
                Control control = new BookControl(books[i]);
                control.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                BooksListTableLayout.Controls.Add(control);
                BooksListTableLayout.SetRow(control, i);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(books, options);
            File.WriteAllText("bookList.txt", jsonString);
        }

    }
}
