using MasterpieceStore.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterpieceStore.WebUI.Controllers
{
    public class AuthorController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
      
        // GET: /Author/
        public ActionResult Index()
        {
            var authors = unitOfWork.AuthorRepository.Get();
            return View(authors.ToList());
        }
    }
}