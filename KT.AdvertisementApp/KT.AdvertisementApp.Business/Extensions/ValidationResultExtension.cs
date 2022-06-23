using FluentValidation.Results;
using KT.AdvertisementApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Extensions
{
    public static class ValidationResultExtension
    {
        public static List<CustomValidationError> ConvertToCustomValidationError(this ValidationResult validationResult)
        {
            List<CustomValidationError> customValidationErrors = new List<CustomValidationError>();
            foreach (var item in validationResult.Errors)
            {
                customValidationErrors.Add(new CustomValidationError()
                {
                    ErrorMessage = item.ErrorMessage,
                    PropertyName = item.PropertyName
                });
            }
            return customValidationErrors;
        }
    }
}
