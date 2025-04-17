using Data.Models;
using Data.Repositories;


namespace Business.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public IEnumerable<Review> GetAllReviews() => _reviewRepository.GetAll();

        public Review GetReviewById(int id) => _reviewRepository.GetById(id);

        public void CreateReview(Review review)
        {

            _reviewRepository.Add(review);
        }

        public void UpdateReview(Review product)
        {

            _reviewRepository.Update(product);
        }

        public void DeleteReview(int id) => _reviewRepository.Delete(id);
    }
}
