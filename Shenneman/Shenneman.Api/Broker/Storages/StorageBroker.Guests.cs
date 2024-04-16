using Microsoft.EntityFrameworkCore;
using Shenneman.Api.Models.Foundetions.Guests;

namespace Shenneman.Api.Broker.Storages
{
    public partial class StorageBroker
    {
        public  DbSet<Guest> Guests { get; set; }
    }
}
