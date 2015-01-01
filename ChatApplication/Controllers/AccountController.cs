using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using ChatApplication.Models;
using System.Web.Security;
using ChatApplication.Repository;

namespace ChatApplication.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        public AccountController() : this(new UserManager<AccountModelBind>(new UserStore<AccountModelBind>(new ChatContext())))
        {
           
        }

        public AccountController(UserManager<AccountModelBind> userManager)
        {           
            UserManager = userManager;
        }

        
        public UserManager<AccountModelBind> UserManager { get; private set; }

       


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            //ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>Login(LoginModel logmodel)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindAsync(logmodel.UserName, logmodel.Password);
                if (user != null)
                {
                    Session["FullUserName"] = logmodel.UserName.ToString();
                    //return RedirectToAction("Index", "LogHome");
                    //return Redirect("http://localhost:9198/HomePage.html");

                   
                    return Redirect("~/HomePage.html");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }


            return View(logmodel);
        }

       
       
        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult UserDetail()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>UserDetail(RegisterModel model)
        {
            if (ModelState.IsValid)
            {            
                var user = new AccountModelBind() { UserName = model.UserName,Email =model.Email,PhoneNumber=model.Phoneno };
                var result = await UserManager.CreateAsync(user, model.Password);
             
                if (result.Succeeded)
                {
                   
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("","Error");
                }
            }  
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index","Home");
        }

        #region Helper

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        #endregion
    }
}
