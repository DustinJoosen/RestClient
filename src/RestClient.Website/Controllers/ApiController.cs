
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestClient.Infra.Dtos;
using RestClient.Orm;

namespace RestClient.Website.Controllers
{
    public class ApiController : Controller
    {
        private DataProvider _provider;
        public ApiController(DataProvider provider)
        {
            _provider = provider;
        }
        public async Task<IActionResult> Index()
        {
            var apis = await _provider.ApiService.GetAll();
            return View(apis);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ApiDto api)
        {
            //validation
            await _provider.ApiService.Create(api);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var api = await _provider.ApiService.GetById(id);
            var endpoints = await _provider.EndpointService.GetAll();

            if (api == null)
            {
                return NotFound();
            }

            ViewData["Endpoints"] = new SelectList(endpoints, "Id", "Name");
            return View(api);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ApiDto api)
        {
            //validation
            await _provider.ApiService.Update(api.Id, api);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RemoveEndpoint(Guid apiid, Guid endpointid)
        {
            await _provider.EndpointService.Delete(endpointid);
            return RedirectToAction(nameof(Edit), new { id = apiid });
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var api = await _provider.ApiService.GetById(id);
            if (api == null)
            {
                return NotFound();
            }
            
            return View(api);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var api = await _provider.ApiService.GetById(id);
            if (api == null)
            {
                return NotFound();
            }

            await _provider.ApiService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
