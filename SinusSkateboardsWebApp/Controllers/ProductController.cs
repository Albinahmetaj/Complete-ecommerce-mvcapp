using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SinusSkateboardsWebApp.Models;
using SinusSkateboardsWebApp.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SinusSkateboardsWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext  _context;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IColorCategoryRepository _colorCategory;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, AppDbContext  appDbContext, IHostingEnvironment hostingEnvironment, IColorCategoryRepository colorCategory)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _context = appDbContext;
            this.hostingEnvironment = hostingEnvironment;
            _colorCategory = colorCategory;
        }


        public async Task<IActionResult> Edit(int? productId)
        {
            if (productId == null)
            {
                return NotFound();
            }

            var productModel = await _context.Product.FindAsync(productId);
            var ProductsListViewModel = new ProductsListViewModel()
            {
                Id = productModel.ProductId,
                Titel = productModel.Titel,
                
                ShortDescription = productModel.ShortDescription,
                LongDescription = productModel.LongDescription,
                Price = productModel.Price,
                ExistingImage = productModel.Photopath,
                
                IsSaleOfTheWeek = productModel.IsSaleOfTheWeek,
                InStock = productModel.InStock,
                CategoryId = productModel.CategoryId,
                Category = productModel.Category,
                ColorCategoryId = productModel.ColorCategoryId,
                ColorCategory = productModel.ColorCategory,
                ImageCarouselOne = productModel.ImageCarouselOne,
                ImageCarouselTwo = productModel.ImageCarouselTwo
                
            };

            if (productModel == null)
            {
                return NotFound();
            }

            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName", productModel.CategoryId);
            ViewData["ColorCategoryId"] = new SelectList(_context.Set<ColorCategory>(), "ColorCategoryId", "ColorName", productModel.ColorCategoryId);
            return View(ProductsListViewModel);
        }

        // POST: ProductModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int productId, ProductsListViewModel viewModel)
        {


            if (ModelState.IsValid)
            {
                var product = await _context.Product.FindAsync(viewModel.Id);
                product.Titel = viewModel.Titel;
                
                product.ShortDescription = viewModel.ShortDescription;
                product.LongDescription = viewModel.LongDescription;
                product.Price = viewModel.Price;
                
                product.IsSaleOfTheWeek = viewModel.IsSaleOfTheWeek;
                product.InStock = viewModel.InStock;
                product.CategoryId = viewModel.CategoryId;
                product.Category = viewModel.Category;
                product.ColorCategoryId = viewModel.ColorCategoryId;
                product.ColorCategory = viewModel.ColorCategory;
                product.ImageCarouselOne = viewModel.ImageCarouselOne;
                product.ImageCarouselTwo = viewModel.ImageCarouselTwo;

                if (viewModel.ProductPicture != null)
                {
                    if (viewModel.ExistingImage != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, "Images", viewModel.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }
                    product.Photopath = ProcessUploadedFile(viewModel);
                }
                _context.Product.Update(product);
                await _context.SaveChangesAsync();
            }
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName", viewModel.CategoryId);
            ViewData["ColorCategoryId"] = new SelectList(_context.Set<ColorCategory>(), "ColorCategoryId", "ColorName", viewModel.ColorCategoryId);
            return RedirectToAction(nameof(List));
        }

        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName");
            ViewData["ColorCategoryId"] = new SelectList(_context.Set<ColorCategory>(), "ColorCategoryId", "ColorName");
            return View();
        }

        // POST: ProductModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(ProductsListViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);

                ProductModel newProduct = new ProductModel
                {
                    
                    Titel = model.Titel,
                    
                    ShortDescription = model.ShortDescription,
                    LongDescription = model.LongDescription,
                    Price = model.Price,
                    Photopath = uniqueFileName,
                   
                    IsSaleOfTheWeek = model.IsSaleOfTheWeek,
                    InStock = model.InStock,
                    CategoryId = model.CategoryId,
                    Category = model.Category,
                    ColorCategoryId = model.ColorCategoryId,
                    ColorCategory = model.ColorCategory,
                    ImageCarouselOne = model.ImageCarouselOne,
                    ImageCarouselTwo = model.ImageCarouselTwo
                    
                    
                    
                };


                _context.Add(newProduct);
                await _context.SaveChangesAsync();
                
            }
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName", model.CategoryId);
            ViewData["ColorCategoryId"] = new SelectList(_context.Set<ColorCategory>(), "ColorCategoryId", "ColorName", model.ColorCategoryId);
            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> ManageList()
        {
            var product = from p in _context.Product.Include(x => x.Category).Include(x => x.ColorCategory)
                          select p;


            
            return View(await product.ToListAsync());
        }

        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> ColorList(string color)
        {

            var colors = from c in _context.Product.Include(x => x.ColorCategory)
                         
                         select c;

            if (!string.IsNullOrEmpty(color))
            {
                colors = colors.Where(x => x.ColorCategory.ColorName == color);
                
            }

            return View(await colors.ToListAsync());
        }

        

        public async Task<IActionResult>List(string category)
        {
           

            IEnumerable < ProductModel > products;
            
            
            string currentCategory;
          

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                
                currentCategory = "All products";
                
                
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                
                
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
                
            }

            return View(new ProductsListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory,
                
                

            });

          
        }

        public async Task<IActionResult> Delete(int? productId)
        {
            if(productId == null)
            {
                return NotFound();
            }

            var productModel = await _context.Product.FindAsync(productId);

            var model = new ProductsListViewModel()
            {
                Id = productModel.ProductId,
                Titel = productModel.Titel,
                
                ShortDescription = productModel.ShortDescription,
                LongDescription = productModel.LongDescription,
                Price = productModel.Price,
                ExistingImage = productModel.Photopath,
               
                IsSaleOfTheWeek = productModel.IsSaleOfTheWeek,
                InStock = productModel.InStock,
                CategoryId = productModel.CategoryId,
                Category = productModel.Category
            };
            if (productModel == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int productId)
        {
            var productModel = await _context.Product.FindAsync(productId);
            if(productModel != null)
            {
                _context.Product.Remove(productModel);
               
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));


           
        }


        public async Task<IActionResult> Details(int productId)
        {

            var model = new TestViewModel()
            {
                Products = await _context.Product.Include(x => x.Category).Include(x => x.ColorCategory).FirstOrDefaultAsync(x => x.ProductId == productId),
                //Product = _context.Product.Include(x => x.ColorCategory).ToList(),

                //Product = _context.Product.Where(x => x.Category.CategoryName == category).OrderBy(x => x.ProductId).ToList(),
                //Category = _context.Categories.FirstOrDefault(x => x.CategoryName == category)?.CategoryName,
                //Categories = _context.Categories.ToList(),
                //Colors = _context.ColorCategories.ToList()
            };



            //var product = _context.Product.Where(x => x.ProductId == productId).Include(x => x.Category).Include(x => x.ColorCategory).FirstOrDefault();
            if (model == null)
            {
                return NotFound();
                

           }
            
            return View(model);

           
        }

        private string ProcessUploadedFile(ProductsListViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProductPicture != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProductPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProductPicture.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
