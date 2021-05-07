using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Exceptions;
using Application.Wrappers;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace BackendAPI.ValidateFilter
{
    public class ValidateModelAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var responseModel = new BadRequestResponse<Dictionary<string, List<string>>>();
            if (!context.ModelState.IsValid)
            {

                var Errors = new Dictionary<string, List<string>>();

                foreach (var modelState in context.ModelState)
                {
                    Errors.Add(modelState.Key, modelState.Value.Errors.Select(a => a.ErrorMessage).ToList());
                }
                responseModel.Code = 400;
                responseModel.Msg = "Validation failed";
                responseModel.Data = Errors;
                //context.Result = new BadRequestObjectResult(context.ModelState);
                context.Result = new BadRequestObjectResult(responseModel);
            }
            base.OnActionExecuting(context);
        }
    }
}
