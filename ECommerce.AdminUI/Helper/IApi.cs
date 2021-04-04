using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.AdminUI.Helper
{
    public interface IApi
    {
        public HttpClient Initial();
    }
}
