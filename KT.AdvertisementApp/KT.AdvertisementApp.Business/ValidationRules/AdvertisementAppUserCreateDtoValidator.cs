using FluentValidation;
using KT.AdvertisementApp.Common.Enums;
using KT.AdvertisementApp.Dtos.AdvertisementAppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.ValidationRules
{
    public class AdvertisementAppUserCreateDtoValidator : AbstractValidator<AdvertisementAppUserCreateDto>
    {
        public AdvertisementAppUserCreateDtoValidator()
        {
            this.RuleFor(x => x.AdvertisementAppUserStatusId).NotEmpty();
            this.RuleFor(x => x.AdvertisementId).NotEmpty();
            this.RuleFor(x => x.AppUserId).NotEmpty();
            this.RuleFor(x => x.CvPath).NotEmpty();
            this.RuleFor(x => x.EndDate).NotEmpty().When(x=>x.MilitaryStatusId == (int)MilitaryStatusType.Tecilli);
        
        }
    }
}
    