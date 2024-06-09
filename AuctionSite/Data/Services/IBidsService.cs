using AuctionSite.Models;

namespace AuctionSite.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
    }
}
