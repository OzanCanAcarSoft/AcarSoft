using DAL.DBContext;
using Infrastructure.RepositoryBase;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ClientRepository:RepositoryBase<Client, AcarSoftContext>
    {
        public Client LogIn(string Email, string Password, params string[] includeList)
        {
            return Get(x => x.Email == Email && x.Password == Password, includeList);
        }
    }
}
