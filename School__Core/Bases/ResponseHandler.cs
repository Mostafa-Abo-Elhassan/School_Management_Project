﻿using School__Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Bases
{
    public class ResponseHandler
    {
       
        public ResponseHandler()
        {
            
        }
        public Response<T> Deleted<T>(string Message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Deleted Successfully",
            };
        }
        public Response<T> Success<T>(T entity, object Meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Added Successfully",
                Meta = Meta
            };
        }
        public Response<T> Unauthorized<T>(string Message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = true,
                Message = Message == null ? "Bad Request" : Message

            };
        }
        public Response<T> BadRequest<T>(string Message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = Message == null ? "Bad Request": Message
            };
        }

        //public Response<T> UnprocessableEntity<T>(string Message = null)
        //{
        //    return new Response<T>()
        //    {
        //        StatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
        //        Succeeded = false,
        //        Message = Message == null ? _stringLocalizer[SharedResourcesKeys.UnprocessableEntity] : Message
        //    };
        //}


        public Response<T> NotFound<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false,
                Message = message == null ? "Not Found": message

            };
        }

        public Response<T> Created<T>(T entity, object Meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Succeeded = true,
                Message = "Not Data",
                Meta = Meta
            };
        }
    }


}