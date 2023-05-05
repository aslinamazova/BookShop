using System;
namespace BookShop.Services.Interfaces.BaseInterface
{
    public interface IBaseInterface<T>
    {
        public void Create(int id);
        public void Delete(int id);
        public T Get(int id);
    }
}

