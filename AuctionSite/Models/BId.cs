using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionSite.Models
{
    public class BId
    {

        public int Id { get; set; }
        public double Price { get; set; }

        public string IdentityUserID { get; set; }

        [ForeignKey("IdentityUser")]
        public IdentityUser User { get; set; }

        public int? ListingId { get; set; }

        [ForeignKey("ListingId")]
        public Listing? Listing { get; set; }
    }
}
