using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using CallbackTest.Model;

namespace CallbackTest.Services
{
	public class CallbackService:ICallbackService
	{
		private readonly Dictionary<CallbackServiceModel, DateTime> _callBackStorage = new Dictionary<CallbackServiceModel, DateTime>();
		public Dictionary<CallbackServiceModel,DateTime> GetCallbacksFromStorage()
		{
			return _callBackStorage;
		}

		public void AddCallbackToStorage(CallbackServiceModel model)
		{
			_callBackStorage.Add(model, DateTime.Now);
		}

		public void RemoveAllCallbacksFromStorage()
		{
			_callBackStorage.Clear();
		}
	}

}
