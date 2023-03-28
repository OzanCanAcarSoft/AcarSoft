using DAL.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ProductBs
    {
        ProductRepository _repo = new ProductRepository();

        public Product GetById(int id)
        {
            return _repo.GetById(id); 
        }
        public List<Product> GetAll() 
        {
            return _repo.GetAll();
        }
    }
}

