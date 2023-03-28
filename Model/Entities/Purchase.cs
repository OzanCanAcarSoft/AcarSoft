using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Model.Entities
{
    public class Purchase: BaseEntity
    {
        public int ClientId { get; set; }

        public int ProductId { get; set; }

        public DateTime PurchaseDate { get; set; }
        public int PurchaseDuration { get; set; }
        public Product Product { get; set; }
    }
}
