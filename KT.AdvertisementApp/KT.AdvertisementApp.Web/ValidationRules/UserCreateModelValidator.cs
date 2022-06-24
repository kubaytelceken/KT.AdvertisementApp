using FluentValidation;
using KT.AdvertisementApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Web.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        
        public UserCreateModelValidator()
        {
            //CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(3);
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Password not match");
            RuleFor(x => x.Username).MinimumLength(3);
            RuleFor(x => new { x.Username,x.FirstName }).Must(x=> CanNotFirstname(x.Username,x.FirstName)).WithMessage("Username cannot contain firstname!").When(x=>x.Username != null && x.FirstName != null);

            RuleFor(x => x.GenderId).NotEmpty();
   
            RuleFor(x => x.LastName).NotEmpty();
            
        }

        private bool CanNotFirstname(string username,string firstname)
        {
            return !username.Contains(firstname);
        }
    }
}
