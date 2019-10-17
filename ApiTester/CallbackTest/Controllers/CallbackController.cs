using System.Collections.Generic;
using CallbackTest.Model;
using CallbackTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace CallbackTest.Controllers
{
	[Route("callback")]
	[ApiController]
	public class CallbackController : Controller
	{
		private readonly ICallbackService _requestService;

		public CallbackController(ICallbackService requestService)
		{
			_requestService = requestService;
		}

		[HttpPost]
		public IActionResult Post([FromBody] CallbackServiceModel model)
		{
			_requestService.AddCallbackToStorage(model);
			return Ok();
		}

		[HttpGet]
		public List<CallbackServiceModel> Get()
		{
			List<CallbackServiceModel> list = new List<CallbackServiceModel>();
			var result = _requestService.GetCallbacksFromStorage();
			foreach (var item in result)
			{
				list.Add(item.Key);
				item.Key.Date = item.Value;
			}
			return list;
		}

		[HttpDelete]
		public IActionResult Delete()
		{
			_requestService.RemoveAllCallbacksFromStorage();
			return Ok();
		}
	}
}