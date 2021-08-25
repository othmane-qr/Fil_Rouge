using FoodApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage(int productId)
        {
            InitializeComponent();
            GetProductDetail(productId);
        }

        private  async void GetProductDetail(int productId)
        {
            var apiService = new ApiService();
            var product = await apiService.GetProductByID(productId);
            LblName.Text = product.name;
            LblPrice.Text = product.price.ToString();
            LblDetail.Text = product.detail;
            ImgProduct.Source = product.FullImageUrl;
            LblTotalPrice.Text = LblPrice.Text;

        }
    }
}