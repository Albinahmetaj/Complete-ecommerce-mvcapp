using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public class MockProductRepository: IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        private readonly IColorCategoryRepository _colorRepository = new MockColorRepository();

        public IEnumerable<ProductModel> AllProducts =>
            new List<ProductModel>
            {
                new ProductModel {ProductId = 1, Titel="Hoodie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer congue convallis ligula vel ullamcorper. Donec congue gravida nulla sed sodales. Pellentesque ullamcorper eros non dolor laoreet ultrices. Maecenas et varius ex. Integer tempor eu quam a imperdiet. Integer ut euismod lacus, malesuada fringilla diam. Quisque maximus est a nisi tempus, et semper enim elementum. Cras at convallis massa. Fusce id ex sed ligula luctus elementum.", Category = _categoryRepository.AllCategories.ToList()[0], ColorCategory = _colorRepository.AllColors.ToList()[0], Photopath="hoodie-fire.png", InStock=true, IsSaleOfTheWeek=true, ImageCarouselOne="hoodie-fire1.jpg", ImageCarouselTwo="hoodie-fire2.jpg"},
                new ProductModel {ProductId = 2, Titel="Cap", Price=18.95M , ShortDescription="Lorem Ipsum", LongDescription="Fusce in dictum enim. Curabitur non congue turpis. Praesent congue enim quis bibendum ultrices. Vestibulum ac libero iaculis, pharetra leo vitae, efficitur nulla. Sed cursus mauris enim, et aliquet ipsum dictum id. Sed luctus sodales hendrerit. Mauris placerat volutpat velit, eu venenatis leo. Morbi finibus lobortis laoreet. Sed erat metus, rutrum nec lectus vel, tincidunt blandit odio.", Category = _categoryRepository.AllCategories.ToList()[1],ColorCategory = _colorRepository.AllColors.ToList()[1],Photopath="sinus-cap-purple.png", InStock=true, IsSaleOfTheWeek=false, ImageCarouselOne="purple-cap1.jpg", ImageCarouselTwo="purple-cap2.jpg"},
                new ProductModel {ProductId = 3, Titel="Skateboard", Price=15.95M,ShortDescription="Lorem Ipsum", LongDescription="Maecenas vel sodales eros. Ut elementum et odio ac auctor. Etiam dapibus ipsum quis ipsum tincidunt blandit. Cras porta tempor est in rhoncus. Aenean suscipit enim vel mollis iaculis. Etiam ornare bibendum orci, finibus suscipit lorem dignissim quis. Sed et lorem dui. Ut eleifend, ante in eleifend vehicula, nunc sem egestas metus, luctus ultricies sem eros et nisi. Maecenas pharetra id urna a tincidunt. Donec auctor lectus at nulla ultricies ullamcorper. Quisque semper dignissim porta. Aliquam sit amet eros id diam varius dapibus.", Category = _categoryRepository.AllCategories.ToList()[2],ColorCategory = _colorRepository.AllColors.ToList()[2],Photopath="sinus-skateboard-logo.png", InStock=true, IsSaleOfTheWeek=true, ImageCarouselOne="skateboard-logo1.jpg", ImageCarouselTwo="skateboard-logo2.jpg"},
                new ProductModel {ProductId = 4, Titel="Tshirt", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Integer posuere, purus ac dapibus egestas, nisl mi finibus arcu, quis ullamcorper turpis quam in ligula. Etiam nec tellus ante. Morbi quis enim ut turpis ornare elementum. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed congue, nulla et auctor pulvinar, tortor diam interdum arcu, at volutpat risus velit at diam. Donec ut molestie ligula. Fusce ex ante, posuere nec varius feugiat, tincidunt tincidunt quam. Curabitur at magna ac justo pretium porta sit amet ut eros. Donec euismod purus nulla, rhoncus luctus erat aliquet quis.", Category = _categoryRepository.AllCategories.ToList()[3],ColorCategory = _colorRepository.AllColors.ToList()[3],Photopath="sinus-tshirt-grey.png", InStock=true, IsSaleOfTheWeek=true, ImageCarouselOne="tshirt-grey1.jpg", ImageCarouselTwo="tshirt-grey2.jpg"},
                new ProductModel {ProductId = 5, Titel="Tshirt", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Quisque nisl turpis, mattis feugiat efficitur et, mattis vitae risus. Nam ac ultricies mauris. Vestibulum dignissim egestas magna, eu dignissim orci vulputate id. Nam vehicula feugiat justo. Pellentesque neque lacus, elementum tempor blandit vel, imperdiet quis dui. Sed tempor orci lectus, et lobortis orci tempus vitae. Aenean volutpat vel tellus a commodo. Quisque convallis, diam id commodo dictum, massa mauris vehicula lacus, a dapibus ligula turpis tempus sem. Duis id ipsum scelerisque, consequat felis id, aliquam justo. Morbi elementum egestas orci, non tristique magna efficitur sit amet. Pellentesque tempor diam vel mauris consequat eleifend. In eget nunc nibh. Maecenas a augue id purus pharetra lacinia.", Category = _categoryRepository.AllCategories.ToList()[3],ColorCategory = _colorRepository.AllColors.ToList()[4],Photopath="tshirt-white.png", InStock=true, IsSaleOfTheWeek=false, ImageCarouselOne="tshirt-white1.jpg", ImageCarouselTwo="tshirt-white2.jpg"}
            };

        public IEnumerable<ProductModel> SaleOfTheWeek { get; }

        public ProductModel GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
