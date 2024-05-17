using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsL1
{
    internal class Penjualan
    {
        private List<Item> ListItem = new List<Item>();

        public void TambahItem(Item item)
        {
            ListItem.Add(item);
        }
        public void HapusItem(Item item)
        {
            ListItem.Remove(item);
        }
        public void ClearItem()
        {
            ListItem.Clear();
        }

        public int GetTotalItem()
        {
            return ListItem.Count;
        }

        public int GetTotalBelanja()
        {
            int totalBelanja = 0;
            foreach (Item item in ListItem)
            {
                totalBelanja += item.HitungTotalHarga();
            }
            return totalBelanja;
        }

        public List<Item> GetItems()
        {
            return ListItem;
        }
    }
}
