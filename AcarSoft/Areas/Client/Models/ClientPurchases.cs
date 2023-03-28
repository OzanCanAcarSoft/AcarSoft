using System.Collections.Generic;

namespace AcarSoft.Areas.Client.Models
{
    public class ClientPurchases
    {
        public List<Model.Entities.Product> products { get; set; }
        public List<Model.Entities.Purchase> purchases { get; set; }
    }
}
