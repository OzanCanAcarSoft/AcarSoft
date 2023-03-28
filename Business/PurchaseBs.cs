using DAL.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business
{
    public class PurchaseBs
    {
        PurchaseRepository _repo = new PurchaseRepository();
        
        public List<Purchase> GetAll()
        {
            return _repo.GetAll();
        }
        public void Insert(Purchase ps)
        {
            _repo.Add(ps);
        }
    }
}
