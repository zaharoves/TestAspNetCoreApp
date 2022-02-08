using System;
using System.Linq;
using TestAspNetCoreApp.Domain.Entities;

namespace TestAspNetCoreApp.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
