﻿using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Web.Models;
using Web.BOL;
using Web.DTO;

namespace Web.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO usuarioDTO = UsuarioBOL.CrearUsuarioDTO(
                    txtNombre.Text,
                    txtApellido.Text,
                    DateTime.Today, // puse la fecha de hoy, despues se cambia
                    txtUsuario.Text,
                    txtPassword.Text
                    );

                UsuarioBOL.CrearUsuario(usuarioDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
        //var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
        //IdentityResult result = manager.Create(user, Password.Text);
        //if (result.Succeeded)
        //{
        //    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
        //    //string code = manager.GenerateEmailConfirmationToken(user.Id);
        //    //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
        //    //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

        //    signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
        //    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
        //}
        //else 
        //{
        //    ErrorMessage.Text = result.Errors.FirstOrDefault();
        //}
    }
}