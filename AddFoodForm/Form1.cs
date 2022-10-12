using GoodsLibrary;

namespace AddFoodForm
{
    public partial class AddFoodForm : Form
    {
        GoodsList goodsList;
        public AddFoodForm()
        {
            InitializeComponent();
        }
        public AddFoodForm(GoodsList _goodsList)
        {
            goodsList = _goodsList;
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            double price = 0;
            DateTime dateOfPackaging = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            int count = 0;
            if (nameTb.Text == "" || !Double.TryParse(priceTb.Text, out price) || !DateTime.TryParse(expirationDateTb.Text, out expirationDate) ||
                !DateTime.TryParse(dateOfPackagingTb.Text, out dateOfPackaging) || !Int32.TryParse(countTb.Text, out count) || measureUnitTb.Text == "")
            {
                MessageBox.Show("Incorrect data");
            }
            else
            {
                Food newItem = new Food();
                newItem.Name = nameTb.Text;
                newItem.Price = price;
                newItem.Country = countryTb.Text;
                newItem.DateOfPackaging = dateOfPackaging;
                newItem.Describing = describingRichTb.Text;
                newItem.ExpirationDate = expirationDate;
                newItem.Count = count;
                newItem.MeasureUnit = measureUnitTb.Text;
                goodsList.Goods.Add(newItem);
                Close();
            }
        }
    }
}