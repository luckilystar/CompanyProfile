using CompanyProfile.Domain.Users;
using CompanyProfile.EntityFramework;
using CompanyProfile.Repository.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyProfile.Web.Controllers
{
    public class UsersController : Controller
    {
        private CompanyDbContext _entities;
        private UserRepository _userRepository;
        public UsersController()
        {
            _entities = new CompanyDbContext();
            _userRepository = new UserRepository(_entities);
        }
        // GET: Users
        public ActionResult Index()
        {
            var query = _userRepository.GetAll();
            return View(query);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User u)
        {
            try { 
            _userRepository.Create(u);
            _userRepository.Save();
            return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }
    }
}