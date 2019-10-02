using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Assignment9.Repository;


namespace Assignment9.BLL
{
    class ItemManagement
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool InsertCustomer(string item, int price)
        {
            return _itemRepository.InsertCustomer(item,price);
        }
        public bool UniqueItemName(string name)
        {
            return _itemRepository.UniqueItemName(name);
        }
        public bool UpdateItem(string item, int price, int id)
        {
            return _itemRepository.UpdateItem(item,price,id);
        }
        public bool DeleteItem(int id)
        {
            return _itemRepository.DeleteItem(id);
        }
        public DataTable SearchItem(string item)
        {
            return _itemRepository.SearchItem(item);
        }
        public DataTable ShowItemInfo()
        {
            return _itemRepository.ShowItemInfo();
        }


    }
}
