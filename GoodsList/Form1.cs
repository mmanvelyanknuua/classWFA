using AddBookForm;
using AddFoodForm;
using GoodsLibrary;

namespace GoodsList
{
    public partial class GoodsListForm : Form
    {
        public GoodsLibrary.GoodsList goodsSet;
        public GoodsListForm()
        {
            goodsSet = new GoodsLibrary.GoodsList();
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            goodsList.Rows.Clear();

            foreach (Good good in goodsSet.Goods)
            {
                if(good is Book)
                {
                    Book book = good as Book;
                    goodsList.Rows.
                        Add(good.Name, good.Price, good.Country, good.DateOfPackaging.ToShortDateString(), good.Describing, 
                        null, 1, "item", book.Authors, book.Publishing, book.PagesCount);
                }
                else
                {
                    Food food = good as Food;
                    goodsList.Rows.
                        Add(good.Name, good.Price, good.Country, good.DateOfPackaging.ToShortDateString(), good.Describing, 
                        food.ExpirationDate.ToShortDateString(), food.Count, food.MeasureUnit, "","","");
                }
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            AddBookForm.AddBookForm addBookForm = new AddBookForm.AddBookForm(goodsSet);
            addBookForm.ShowDialog();
            LoadData();
        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            AddFoodForm.AddFoodForm addFoodForm = new AddFoodForm.AddFoodForm(goodsSet);
            addFoodForm.ShowDialog();
            LoadData();
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow selected in goodsList.SelectedRows)
            {
                goodsSet.Goods.Remove(goodsSet.Goods.ElementAt(selected.Index));
            }
            LoadData();
        }
    }
}