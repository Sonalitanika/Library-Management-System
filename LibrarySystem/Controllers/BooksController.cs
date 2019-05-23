using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Models;
using static LibrarySystem.Controllers.BooksController;
using LibrarySystem.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LibrarySystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibrarySystemIdentityDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BooksController(LibrarySystemIdentityDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }



        // GET: Books
        public async Task<IActionResult> Index(SearchType searchType, string searchString)
        {
            var books = from m in _context.Books select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                if (searchType == SearchType.Author)
                {
                    books = books.Where(s => s.Author.Contains(searchString));
                }
                else
                {
                    books = books.Where(s => s.Title.Contains(searchString));
                }
            }
            return View(await books.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var books = await _context.Books
                .SingleOrDefaultAsync(m => m.ID == id);
            if (books == null)
            {
                return NotFound();
            }

            return View(books);
        }

        [Authorize(Policy = "Librarian")]
        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Author,Title,Copies")] Books books)
        {
            if (ModelState.IsValid)
            {
                books.ID = Guid.NewGuid();
                _context.Add(books);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(books);
        }

        [Authorize(Policy = "Librarian")]
        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var books = await _context.Books.SingleOrDefaultAsync(m => m.ID == id);
            if (books == null)
            {
                return NotFound();
            }
            return View(books);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Author,Title,Copies")] Books books)
        {
            if (id != books.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(books);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BooksExists(books.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(books);
        }

        [Authorize(Policy = "Librarian")]
        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var books = await _context.Books
                .SingleOrDefaultAsync(m => m.ID == id);
            if (books == null)
            {
                return NotFound();
            }

            return View(books);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var books = await _context.Books.SingleOrDefaultAsync(m => m.ID == id);
            _context.Books.Remove(books);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BooksExists(Guid id)
        {
            return _context.Books.Any(e => e.ID == id);
        }

        private async Task<IActionResult> AddtoCart(Guid id)
        {
            CartItem item = new CartItem()
            {
                ItemId = Guid.NewGuid(),
                CartId = _context.Carts.Where(c => c.UserID == _userManager.GetUserId(User)).FirstOrDefault().ID,
                Quatity = 1,
                DateCreated = DateTime.Now,
                BooksID = id
            };
            _context.Add(item);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        [HttpGet]
        private async Task<IActionResult> Confim()
        {
            var items=_context.ShoppingCartItems.Where(i=>i.CartId==_context.Carts.Where(c=>c.UserID==_userManager.GetUserId(User)).FirstOrDefault().ID);
            return View(items);
        }

        [HttpPost]
        private async Task<IActionResult> Confim(string ids)
        {
            string[] Ids = ids.Split(";");
            foreach (var Id in Ids)
            {
                var item = _context.ShoppingCartItems.Where(i => i.ItemId == Guid.Parse(Id)).FirstOrDefault();
                item.Borrowed = true;
                _context.Update(item);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
