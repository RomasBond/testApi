using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testUsersApi.Models;

namespace testUsersApi.Controllers
{
    public class ValuesController : ApiController
    {
        UsersModel db;
        // GET api/values/
        // тут возвращаем 1000 записей
        public string Get()
        {
            db = new UsersModel();

            return JsonConvert.SerializeObject(
                    db.Results.Where(x => x.ID < 1000)
                              .Select(x => new { x.Names.Title, x.Names.First, x.Names.Last, x.Dobs.Date, x.Pictures.Large }).ToList()
                   );
        }

        // GET api/values/5
        // возвращаем конкретную запись по ID
        public string Get(int id)
        {
            db = new UsersModel();

            return JsonConvert.SerializeObject(
                    db.Results.Where(x => x.ID == id)
                              .Select(x => new { x.Names.Title, x.Names.First, x.Names.Last, x.Dobs.Date, x.Pictures.Large }).FirstOrDefault()
                   );
        }

    }
}
