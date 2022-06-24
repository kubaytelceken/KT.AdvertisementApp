using FluentValidation;
using KT.AdvertisementApp.Dtos.GenderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.ValidationRules
{
    public class GenderCreateDtoValidator : AbstractValidator<GenderCreateDto>
    {
        public GenderCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
        }
    }
}
