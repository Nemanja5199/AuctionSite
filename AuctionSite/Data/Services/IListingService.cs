using AuctionSite.Models;

namespace AuctionSite.Data.Services
{
    public interface IListingService
    {

        IQueryable<Listing> GetAll();
    }
}
