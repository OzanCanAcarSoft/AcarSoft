using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace AcarSoft.Areas.Manager.Extension
{
    public static class SessionExtension
    {
        //Bu sayfa serialize ve deserialize işlemleri için oluşturulan bir ExtensionMethod sayfasıdır
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObject<T>(this ISession session, string key) where T : class
        { 
           return JsonConvert.DeserializeObject<T>(session.GetString(key));
        }
          

    }
}
