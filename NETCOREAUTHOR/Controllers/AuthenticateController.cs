using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soit.Authentication.Protos;
using Grpc.Net.Client;
using Grpc.Core;

namespace NETCOREAUTHOR.Controllers
{
    public class AuthenticateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public  async Task<string>  LoginAsync(string Cipher,string UserName = "1")
        {
            //int rtn = 0;
            string Token = "";
            try
            {
                using var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var clien_num = new AuthenticateService.AuthenticateServiceClient(channel);// new GrpcGreeter.Greeter.GreeterClient(channel);
                if (Cipher=="1")
                    Cipher = @"FvY6RlVZ9luQN7J/GOGYr0kar2myC5rZ2TFVz6x/k9eMIVQ2+VkYT5pfACOHymTPUKGrlw/WI6P3/Ri2h2V3A9zBWcv6J8AeY4mbqpNm9AZ/Uq/bOGInt9MbZibaSThuJABX1crFuPF0bOIjsmZSuHGueAL1/sWpSSJv/MrT31U=";
                Metadata metadata = new Metadata();
                metadata.Add("token", Token);
                var result = await clien_num.LoginAsync(new LoginRequest { UserName = UserName, Cipher = Cipher }, metadata);//.SayHelloAsync(new HelloRequest { Name = name });

                //ViewBag.UserId = result.UserId;
                //ViewBag.LegalName = result.LegalName;
                //ViewBag.ExpireAt = result.ExpireAt;
                //ViewBag.Token = result.Token;
                //var rtn = Json(result);
                //return Json(result);
                if (!string.IsNullOrWhiteSpace(result.Token))
                {
                    Token = result.Token;
                }
            }
            catch (Exception)
            {

            }
           
            return Token;
        }
    }
}
