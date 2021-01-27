using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Models.Cart
{
    public class MyCart
    {
        static private Dictionary<int, Cartİtem> sepet = new Dictionary<int, Cartİtem>();
        public List<Cartİtem> GetAllCartItem => sepet.Values.ToList();
        public void AddCart(Cartİtem cartİtem)
        {
            if (sepet.ContainsKey(cartİtem.ID))
            {
                sepet[cartİtem.ID].Amount += cartİtem.Amount;
                return;
            }

            sepet.Add(cartİtem.ID, cartİtem);
        }
        public void Update(int id,short amount)
        {
            if (sepet.ContainsKey(id))
            {
                sepet[id].Amount = amount;
            }
        }
        public void Delete(int id)
        {
            if (sepet.ContainsKey(id))
            {
                sepet.Remove(id);
            }
        }
        public int TotalAmount => sepet.Values.Sum(a => a.Amount);
        public int GetCount => sepet.Count;
    }
}
