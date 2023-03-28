using DAL.ManagerRepository;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ManagerBs
    {
        private ManagerRepository _repo;
        public ManagerBs()
        {
            _repo = new ManagerRepository();
        }

        public Manager LogIn(string email, string password)
        {
            return _repo.LogIn(email, password);
        }
        public void Insert(Manager manager)
        {
            _repo.Add(manager);
        }
        public Manager GetByEmail(string email)
        {
            return _repo.Get(x => x.Email == email);
        }
        public List<Manager> GetAll(params string[] includeList)
        {
            return _repo.GetAll(filter: null, includeList: includeList);
        }
        public Manager GetById(int id)
        {
            return _repo.GetById(id);
        }
        public Manager GetByName(string name) 
        {
            return _repo.Get(x=>x.FullName == name);
        }
        public void Update(Manager manager)
        {
            _repo.Update(manager);
        }
    }
}
