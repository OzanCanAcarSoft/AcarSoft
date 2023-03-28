using DAL.DBContext;
using Infrastructure.RepositoryBase;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DAL.ManagerRepository
{
    public class ManagerRepository:RepositoryBase<Manager, AcarSoftContext>
    {
        public Manager LogIn(string Email, string Password)
        {
            return Get(x => x.Email == Email && x.Password == Password);
        }
    }
}
