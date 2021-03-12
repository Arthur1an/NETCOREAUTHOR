using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GrpcGreeter;
using Soit.Authentication.Protos;
using Grpc.Core;

namespace NETCOREAUTHOR.Controllers
{
    public class ModuleController : Controller
    {
        public  IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetTreeAsync(string Token) {

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var clien_num = new ModuleService.ModuleServiceClient(channel);
            Metadata headers = new Metadata();
            headers.Add("token", Token);
            var result = await clien_num.GetTreeAsync(new Google.Protobuf.WellKnownTypes.Empty(), headers);

            return Json(result);
        }
    }
}
