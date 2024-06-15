using Auctions.Models;

namespace AuctionSite.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
