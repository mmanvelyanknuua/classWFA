using GoodsLibrary;
namespace AddBookForm
{
    public partial class AddBookForm : Form
    {
        GoodsList goodsList;
        public AddBookForm()
        {
            InitializeComponent();
        }

        public AddBookForm(GoodsList _goodsList)
        {
            goodsList = _goodsList;
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            double price = 0;
            DateTime dateOfPublishing = DateTime.Now;
            int pagesCount = 0;
            if (bookNameTb.Text == "" || !Double.TryParse(priceTb.Text, out price) ||
                !DateTime.TryParse(dateOfPublishTb.Text, out dateOfPublishing) || !Int32.TryParse(pagesCountTb.Text, out pagesCount))
            {
                MessageBox.Show("Incorrect data");
            }
            else
            {
                Book newBook = new Book();
                newBook.Name = bookNameTb.Text;
                newBook.Price = price;
                newBook.Country = countryTb.Text;
                newBook.DateOfPackaging = dateOfPublishing;
                newBook.Describing = describingRichTb.Text;
                newBook.Authors = authorsTb.Text;
                newBook.Publishing = publishingTb.Text;
                newBook.PagesCount = pagesCount;
                goodsList.Goods.Add(newBook);
                Close();
            }
        }
    }
}