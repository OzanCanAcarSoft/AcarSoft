using DAL.ManagerRepository;
using DAL.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ClientBs
    {
        private ClientRepository _repo;
        public ClientBs()
        {
            _repo = new ClientRepository();
        }

        public Client LogIn(string email, string password, params string[] includeList)
        {
            return _repo.LogIn(email, password, includeList);
        }
        public void Insert(Client client)
        {
            _repo.Add(client);
        }
        public Client GetByEmail(string email)
        {
            return _repo.Get(x => x.Email == email);
        }
        public List<Client> GetAll(params string[] includeList)
        {
            return _repo.GetAll(filter: null, includeList: includeList);
        }
        public void Update(Client client) 
        {
            _repo.Update(client);
        }
    }
}
