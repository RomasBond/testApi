using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testUsersApi.Models;

namespace testUsersApi.Controllers
{
    public class HomeController : Controller
    {
        UsersModel db;
        List<User> users;
        int pageSize = 10;

        public ActionResult Index(string submitButton, int pageNum = 0)
        {
            db = new UsersModel();

            //исключаем -1 страницу
            pageNum = pageNum < 0 ? 0 : pageNum;

            switch (submitButton)
            {
                case "ФИО":
                    users = db.Results.OrderBy(x => x.ID)
                            .Skip(pageSize * pageNum).Take(pageSize)
                            .Select(x => new User
                              {
                                  ID = x.ID,
                                  Title = x.Names.Title,
                                  First = x.Names.First,
                                  Email = x.Email,
                                  Phone = x.Phone,
                                  Last = x.Names.Last,
                                  Date = x.Dobs.Date,
                                  Large = x.Pictures.Large
                              }).OrderBy(x => x.First).ToList();

                    break;
                case "Дата":
                    users = db.Results.OrderBy(x => x.ID)
                           .Skip(pageSize * pageNum).Take(pageSize)
                           .Select(x => new User
                             {
                                 ID = x.ID,
                                 Title = x.Names.Title,
                                 First = x.Names.First,
                                 Email = x.Email,
                                 Phone = x.Phone,
                                 Last = x.Names.Last,
                                 Date = x.Dobs.Date,
                                 Large = x.Pictures.Large
                             }).OrderBy(x => x.Date).ToList();

                    break;

                default:
                    users = db.Results.OrderBy(x => x.ID)
                          .Skip(pageSize * pageNum).Take(pageSize)
                          .Select(x => new User
                          {
                              ID = x.ID,
                              Title = x.Names.Title,
                              First = x.Names.First,
                              Email = x.Email,
                              Phone = x.Phone,
                              Last = x.Names.Last,
                              Date = x.Dobs.Date,
                              Large = x.Pictures.Large
                          }).ToList();
                    break;
            }


            ViewData["pageNum"] = pageNum;

            ViewBag.Title = "Home Page";

            return View(users);
        }


    }
}
