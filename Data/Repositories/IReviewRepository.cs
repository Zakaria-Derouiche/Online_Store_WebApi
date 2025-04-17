using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAll();
        Review GetById(int id);
        void Add(Review review);
        void Update(Review review);
        void Delete(int id);
    }
}
