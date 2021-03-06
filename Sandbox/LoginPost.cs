﻿namespace Sandbox
{
    using System;
    using Models;
    using Simple.Web;
    using Simple.Web.Authentication;
    using Simple.Web.Behaviors;
    using Simple.Web.Helpers;

    [UriTemplate("/login")]
    public class LoginPost : IPost, IInput<Login>, ILogin
    {
        private static readonly Guid MarkGuid = new Guid("B3EDB5DEFECD42779FBE0D7771D13AD2");
        public Status Post()
        {
            string redirectLocation;
            if (Input.UserName == "mark" && Input.Password == "password")
            {
                redirectLocation = Input.ReturnUrl;
                LoggedInUser = new User(MarkGuid, "Mark");
            }
            else
            {
                redirectLocation = UriFromType.Get(() => new LoginForm {ReturnUrl = Input.ReturnUrl}).ToString();
            }

            return Status.SeeOther(redirectLocation);
        }

    	public Login Input { get; set; }

        public IUser LoggedInUser { get; private set; }
    }
}