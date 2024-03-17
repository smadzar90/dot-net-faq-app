using dot_net_faq_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dot_net_faq_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly FaqContext _context;

        public HomeController(FaqContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var faqs = await _context.FAQs.Include(m => m.Topic).Include(m => m.Category).ToListAsync();
            return View(faqs);
        }

        [HttpGet("/Home/Index/Topic/{TopicId}")]
        public async Task<IActionResult> AllFaqsByTopic(string TopicId)
        {
            var faqs = await _context.FAQs.Include(m => m.Topic).Include(m => m.Category)
                      .Where(m => m.Topic.TopicId == TopicId).ToListAsync();
            return View("Index", faqs);
        }

        [HttpGet("/Home/Index/Category/{CategoryId}")]
        public async Task<IActionResult> AllFaqsByCategory(string CategoryId)
        {
            var faqs = await _context.FAQs.Include(m => m.Topic).Include(m => m.Category)
                      .Where(m => m.Category.CategoryId == CategoryId).ToListAsync();
            return View("Index", faqs);
        }

        [HttpGet("/Home/Index/Category/{CategoryId}/Topic/{TopicId}")]
        public async Task<IActionResult> FaqsByCategoryAndTopic(string CategoryId, string TopicId)
        {
            var faqs = await _context.FAQs.Include(m => m.Topic).Include(m => m.Category)
                      .Where(m => m.Category.CategoryId == CategoryId && m.Topic.TopicId == TopicId).ToListAsync();
            return View("Index", faqs);
        }

        [HttpGet("/Home/Index/Topic/{TopicId}/Category/{CategoryId}")]
        public async Task<IActionResult> FaqsByCategoryAndTopicReversed(string TopicId, string CategoryId)
        {
            var faqs = await _context.FAQs.Include(m => m.Topic).Include(m => m.Category)
                      .Where(m => m.Category.CategoryId == CategoryId && m.Topic.TopicId == TopicId).ToListAsync();
            return View("Index", faqs);
        }

    }
}
