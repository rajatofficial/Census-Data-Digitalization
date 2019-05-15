using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CloudinaryDotNet.Actions;
using BAL;
using AutoMapper;
using Shared.DTO;
using System.Web.Http;
using CloudinaryDotNet;

namespace Census_Data_Digitalization.Controllers
{
    public class UserController : ApiController
    {
        IUserService serviceCall;
        // GET api/<controller>

        public UserController(IUserService userService)
        {
            serviceCall = userService;
        }

        // GET api/<controller>
        public List<UserDTO> Get()
        {
            return serviceCall.ServiceGetUserList();
        }

        // GET api/<controller>/5
        public List<UserDTO> Get(int id)
        {
            if(id==1)
            {
                return serviceCall.serviceApprovedUsers(id);
            }
            if(id==3)
            {
                return serviceCall.servicePendingUsers(id);
            }
            else
            {
                return serviceCall.serviceRejectedUsers(id);
            }
        }

        
        // POST api/<controller>
        public string Post([FromBody] UserDTO user)
        {
             //           Account account = new Account(
             //"dmxrlqiij",
             //"536862683394679",
             //"GAo3FcR_C7D6lj_Q_isWwyosCDc");

            //Cloudinary cloudinary = new Cloudinary(account);
            //var uploadParams = new ImageUploadParams()
            //{
            //    File = new FileDescription(@user.image)
            //};
            //var uploadResult = cloudinary.Upload(uploadParams);
            //var x=uploadResult.SecureUri;
            //user.image = x.ToString();
            if (ModelState.IsValid)
            {
                return serviceCall.ServiceCreateUser(user);
            }
            else
                return "valid";
            
        }
        
        // PATCH api/<controller>/5
        public void Put(int id,[FromBody]UserDTO user)
        {
            int status = (int)(user.Status);
            serviceCall.EditStatus(id, status);
        }

        [HttpPost]
        [Route("Login")]
        public UserDTO login([FromBody] UserDTO user)
        {
            return serviceCall.LoginService(user);
        }

    }
}