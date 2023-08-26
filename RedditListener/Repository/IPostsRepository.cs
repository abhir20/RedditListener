using RedditListener.Model;

namespace RedditListener.Repository
{
    public interface IPostsRepository
    {
        IList<LiveThreads> GetLiveThreads();

        IList<LiveThreads> GetUsersWithHighPosts();

        IList<LiveThreads> GetLiveThreadsWithHighUpvotes();
    }
}
