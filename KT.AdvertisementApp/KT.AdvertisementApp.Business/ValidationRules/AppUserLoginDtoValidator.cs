using FluentValidation;
using KT.AdvertisementApp.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.ValidationRules
{
    public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
