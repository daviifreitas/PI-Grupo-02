using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PI.Application.Intefaces;
using PI.Application.ViewModel.Enterprise;

namespace PI.Web.Controllers
{
    public class EnterpriseController : Controller
    {
        private IEnterpriseService _enterpriseService;

        public EnterpriseController(IEnterpriseService enterpriseService)
        {
            _enterpriseService = enterpriseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(CreateEnterpriseViewModel model)
        {
            bool v = await _enterpriseService.SignUp(model);

            return v ? RedirectToAction("Index", "Home") : View() ;
        }

        [HttpPost]
        public IActionResult Tester(string data)
        {
            var item = data ;

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> TesterAdd(string dado)
        {
            CreateEnterpriseViewModel create = JsonConvert.DeserializeObject<CreateEnterpriseViewModel>(dado);
            var item = dado;
            bool v = await _enterpriseService.SignUp(create);

            return Ok();
        }
    }
}
