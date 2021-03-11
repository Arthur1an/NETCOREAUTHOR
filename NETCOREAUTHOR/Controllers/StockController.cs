using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using StockServices.Protos;
using leaveDemo;
using GrpcGreeter;
using Soit.Authentication.Protos;

namespace NETCOREAUTHOR.Controllers
{
    public class StockController : Controller
    {
        public async Task<IActionResult> IndexAsync(string name = "1")
        {
            //using var channel = GrpcChannel.ForAddress("https://localhost:5003");
            //var clien_num = new leave.leaveClient(channel);// new GrpcGreeter.Greeter.GreeterClient(channel);
            //var result = await clien_num.GetUserInfoListAsync(new GetUserInfoRequest { Name=name });//.SayHelloAsync(new HelloRequest { Name = name });

            //ViewData["result"] = result;

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var clien_num = new AuthenticateService.AuthenticateServiceClient(channel);// new GrpcGreeter.Greeter.GreeterClient(channel);
            var result = await clien_num.LoginAsync(new LoginRequest { UserName = name,Cipher= @"FvY6RlVZ9luQN7J/GOGYr0kar2myC5rZ2TFVz6x/k9eMIVQ2+VkYT5pfACOHymTPUKGrlw/WI6P3/Ri2h2V3A9zBWcv6J8AeY4mbqpNm9AZ/Uq/bOGInt9MbZibaSThuJABX1crFuPF0bOIjsmZSuHGueAL1/sWpSSJv/MrT31U=" });//.SayHelloAsync(new HelloRequest { Name = name });
        
            ViewData["result"] = result;
            ViewBag.UserId = result.UserId;
            ViewBag.LegalName = result.LegalName;
            ViewBag.ExpireAt = result.ExpireAt;
            ViewBag.Token = result.Token;
            var rtn = Json(result);
            return Json(result);
        }

    }
}
