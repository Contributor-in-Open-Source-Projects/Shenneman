using System.Threading.Tasks;
using Shenneman.Api.Models.Foundetions.Guests;

namespace Shenneman.Api.Broker.Storages
{
    public partial interface IStorageBroker
    {
        // 1 Curate 
        //2 Read 
        // 3 Update
        // 4 Delete

        ValueTask<Guest> InsertGuestAsync(Guest guest);


    }
}
