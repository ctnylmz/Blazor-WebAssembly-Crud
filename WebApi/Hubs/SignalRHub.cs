using DataAccess.Concrete.Context;
using Microsoft.AspNetCore.SignalR;

namespace WebApi.Hubs
{
    public class SignalRHub:Hub
    {
        QrKitchenContext Context = new QrKitchenContext();

        public async Task SendCategoryCount()
        {
            var value = Context.Categorys.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount",value);
        }
    }
}
