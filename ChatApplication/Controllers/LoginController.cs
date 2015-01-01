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


namespace ChatApplication.Controllers
{
   
    public class LoginController : Controller
    {
       public LoginController()
            : this(new UserManager<ChatContext>(new UserStore<ChatContext>(new ChatContext())))
        {
        }

        public AccountController(UserManager<ChatContext> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<ChatDbContext> UserManager { get; private set; }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }


        #region Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(ChatApplication.Models.AccountModel.LoginModel model)
        {
            var user = await UserManager.FindAsync(model.UserName, model.Password);
            if (user!=null)
            {
                await SignInAsync(user,model.RememberMe);
            }
            else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }


           return View(model);
        }

            private Task SignInAsync(ChatDbContext user,bool p)
            {
                	throw new NotImplementedException();
            }
        #endregion

        #region UserDeatils
         [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(ChatApplication.Models.AccountModel.RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ChatDbContext() { UserName = model.UserName };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    AddErrors(result);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
        #endregion

        #region ChangePassword
        [Route("ChangePassword")]
        public async Task<IHttpActionResult> ChangePassword(ChangePasswordBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }
            return Ok();
        }

        #endregion

        #region SetPassword
        [Route("SetPassword")]
        public async Task<IHttpActionResult> SetPassword(SetPasswordBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);
            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();

        }
        #endregion

        #region LogOut
        [Route("LogOut")]
        public IHttpActionResult Logout()
        {
            Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            return Ok();

        }
        #endregion

        #region Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                UserManager.Dispose();
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Helper
        private IAuthenticationManager Authentication
        {
            get { return Request.GetOwinContext().Authentication; }
        }



        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {

                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

        #endregion


    }
}
