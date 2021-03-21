﻿using Application.Exceptions;
using Application.Wrappers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace BackendAPI.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new Response<string>() { Data =null };

                switch (error)
                {

                    case Application.Exceptions.NotFoundException e:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        responseModel.Msg = e.Message;
                        break;
                    case Application.Exceptions.CreateRequestException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        responseModel.Msg = e.Message;
                        break;
                    case Application.Exceptions.UpdateRequestException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        responseModel.Msg = e.Message;
                        break;
                    case Application.Exceptions.DeleteRequestException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        responseModel.Msg = e.Message;
                        break;
                    case Application.Exceptions.BadRequestException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        responseModel.Msg = e.Message;
                        break;
                    case Application.Exceptions.AuthFailedException e:
                        response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        responseModel.Msg = e.Message;
                        break;
                    case Application.Exceptions.UnauthorizeException e:
                        response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        responseModel.Msg = "You have not permission to change this resource";
                        break;
                    //case ValidationException e:
                    //    // custom application error
                    //    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    //    responseModel.Errors = e.Errors;
                    //    break;
                    case KeyNotFoundException e:
                        // not found error
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    case Exception e:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        responseModel.Msg = "Server Toang";
                        responseModel.Data = e.Message;
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }
                responseModel.Code = response.StatusCode;
                var result = JsonSerializer.Serialize(responseModel);

                await response.WriteAsync(result);
            }
        }
    }
}
