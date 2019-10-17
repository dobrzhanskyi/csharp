using System;
using System.Collections.Generic;
using CallbackTest.Model;

namespace CallbackTest.Services
{
	public interface ICallbackService
	{
		Dictionary<CallbackServiceModel, DateTime> GetCallbacksFromStorage();

		void AddCallbackToStorage(CallbackServiceModel model);

		void RemoveAllCallbacksFromStorage();
	}
}