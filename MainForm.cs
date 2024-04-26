﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Book[] books =
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

    }
}
