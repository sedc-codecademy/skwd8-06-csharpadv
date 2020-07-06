using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBrowser
{
    public partial class Browser : Form
    {
        private IEnumerable<Author> authors;
        private Author selectedAuthor;

        public Browser()
        {
            InitializeComponent();
        }

        private void btnLoadAuthors_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Loading Authors ...";
            Thread runner = new Thread(() =>
            {
                authors = new AuthorRepo().GetAuthors();
                Invoke(new Action(() =>
                {
                    lblStatus.Text = $"Loaded {authors.Count()} authors";
                    btnLoadAuthors.Enabled = false;
                    DisplayAuthors(authors);
                }));
            });
            runner.Start();
        }

        private void DisplayAuthors(IEnumerable<Author> authors)
        {
            lbxAuthors.Items.Clear();
            lbxAuthors.Items.AddRange(authors.ToArray());
        }

        private void lbxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAuthor = (Author)lbxAuthors.SelectedItem;
            LoadBooks(selectedAuthor);
        }

        private void LoadBooks(Author selectedAuthor)
        {
            pnlBookImages.Controls.Clear();
            var row = 0;
            var column = 0;
            var booksPerRow = 9;
            foreach (var book in selectedAuthor.Books)
            {
                LoadBookImage(book, row, column);

                column += 1;
                if (column == booksPerRow)
                {
                    row += 1;
                    column = 0;
                }
            }
            lblStatus.Text = $"Loaded {selectedAuthor.Books.Count()} books for {selectedAuthor.Name}";
        }

        private void LoadBookImage(Book book, int row, int column)
        {
            lblStatus.Text = $"Loading image for {book.Title}";
            PictureBox picture = new PictureBox
            {
                Width = 100,
                Height = 160,
                Top = 70 + row * 160 + (row - 1) * 20,
                Left = 50 + column * 100 + (column - 1) * 20
            };

            string imageName = GetImageName(book);
            var request = WebRequest.Create($"http://worldswithoutend.com/covers_md/{imageName}");

            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    picture.Image = Image.FromStream(stream);
                    pnlBookImages.Controls.Add(picture);
                }
            }
        }

        private string GetImageName(Book book)
        {
            if (!string.IsNullOrEmpty(book.ImageName))
            {
                return book.ImageName;
            }
            return book.Type switch
            {
                BookType.ShortStory => "short_story.jpg",
                BookType.Novella => "novella.jpg",
                BookType.Novelette => "novelette.jpg",
                BookType.Novel => "novel.jpg",
                BookType.GraphicNovel => "short_story.jpg",
                _ => string.Empty
            };
        }
    }
}
