//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;


//namespace SinusSkateboardsWebApp.Models
//{
//    public class ProductModelsController : Controller
//    {
//        private readonly AppDbContext _context;

//        public ProductModelsController(AppDbContext context)
//        {
//            _context = context;
//        }

//        // GET: ProductModels
//        public async Task<IActionResult> Index(string searchString)
//        {
//            var product = from p in _context.Product
//                          select p;

//            if (!String.IsNullOrEmpty(searchString))
//            {
//                product = product.Where(x => x.Titel.Contains(searchString));
//            }
//            //var SinusSkateboardsWebAppContext = _context.Product.Include(p => p.Category);
//            return View(await product.ToListAsync());
//        }

//        //        // GET: ProductModels/Details/5
//        //        public async Task<IActionResult> Details(int? id)
//        //        {
//        //            if (id == null)
//        //            {
//        //                return NotFound();
//        //            }

//        //            var productModel = await _context.Product
//        //                .Include(p => p.Category)
//        //                .FirstOrDefaultAsync(m => m.ProductId == id);
//        //            if (productModel == null)
//        //            {
//        //                return NotFound();
//        //            }

//        //            return View(productModel);
//        //        }

//        //        // GET: ProductModels/Create
//        //        public IActionResult Create()
//        //        {
//        //            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryName", "CategoryName");
//        //            return View();
//        //        }

//        //        // POST: ProductModels/Create
//        //        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        //        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //        [HttpPost]
//        //        [ValidateAntiForgeryToken]
//        //        public async Task<IActionResult> Create([Bind("ProductId,Titel,Color,ShortDescription,LongDescription,Price,Photopath,ImageThumbnailUrl,IsSaleOfTheWeek,InStock,CategoryId")] ProductModel productModel)
//        //        {
//        //            if (ModelState.IsValid)
//        //            {
//        //                _context.Add(productModel);
//        //                await _context.SaveChangesAsync();
//        //                return RedirectToAction(nameof(Index));
//        //            }
//        //            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryId", productModel.CategoryId);
//        //            return View(productModel);
//        //        }

//        //GET: ProductModels/Edit/5
//public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var productModel = await _context.Product.FindAsync(id);
//            if (productModel == null)
//            {
//                return NotFound();
//            }
//            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryId", productModel.CategoryId);
//            return View(productModel);
//        }

//        // POST: ProductModels/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]


//        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Titel,Color,ShortDescription,LongDescription,Price,Photopath,ImageThumbnailUrl,IsSaleOfTheWeek,InStock,CategoryId")] ProductModel productModel)
//        {
//            if (id != productModel.ProductId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(productModel);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ProductModelExists(productModel.ProductId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryId", productModel.CategoryId);
//            return View(productModel);
//        }

//        // GET: ProductModels/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var productModel = await _context.Product
//                .Include(p => p.Category)
//                .FirstOrDefaultAsync(m => m.ProductId == id);
//            if (productModel == null)
//            {
//                return NotFound();
//            }

//            return View(productModel);
//        }

//        // POST: ProductModels/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var productModel = await _context.Product.FindAsync(id);
//            _context.Product.Remove(productModel);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ProductModelExists(int id)
//        {
//            return _context.Product.Any(e => e.ProductId == id);
//        }
//    }
//}
