using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Review> GetAll() => _context.Reviews;

        public Review GetById(int id) => _context.Reviews.Find(id);

        public void Add(Review review) => _context.Reviews.Add(review);

        public void Update(Review review) => _context.Reviews.Update(review);

        public void Delete(int id)
        {
            var review = GetById(id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
            }
        }
    }
}
