﻿using Newtonsoft.Json;
using Submail.AppConfig;
using Submail.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Submail.Lib
{
	public class Mail : ISender
	{
		private const string API_SEND = "http://api.mysubmail.com/mail/send.json";
		private const string API_XSEND = "http://api.mysubmail.com/mail/xsend.json";
		private const string API_SUBSCRIBE = "http://api.mysubmail.com/addressbook/mail/subscribe.json";
		private const string API_UNSUBSCRIBE = "http://api.mysubmail.com/addressbook/mail/unsubscribe.json";
		private const string API_Balance = "http://api.mysubmail.com/balance/mail.json";

		private IAppConfig _appConfig;
		private HttpWebHelper _httpWebHelper;

		public Mail(IAppConfig appConfig)
		{
			this._appConfig = appConfig;
			this._httpWebHelper = new HttpWebHelper(_appConfig);
		}

		public string Send(Dictionary<string, object> data, out string returnMessage)
		{
			string retrunJsonResult = _httpWebHelper.HttpPost(API_SEND, data);
			returnMessage = retrunJsonResult;
			return retrunJsonResult;
		}

		public string XSend(Dictionary<string, object> data, out string returnMessage)
		{
			string retrunJsonResult = _httpWebHelper.HttpPost(API_XSEND, data);
			returnMessage = retrunJsonResult;
			return retrunJsonResult;
		}

		public string Subscribe(Dictionary<string, object> data, out string returnMessage)
		{
			string retrunJsonResult = _httpWebHelper.HttpPost(API_SUBSCRIBE, data);
			returnMessage = retrunJsonResult;
			return retrunJsonResult;
		}

		public string UnSubscribe(Dictionary<string, object> data, out string returnMessage)
		{
			string retrunJsonResult = _httpWebHelper.HttpPost(API_UNSUBSCRIBE, data);
			returnMessage = retrunJsonResult;
			return retrunJsonResult;
		}

		public string MultiXSend(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}


		public string MultiSend(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Balance(Dictionary<string, object> data, out string returnMessage)
		{
			string retrunJsonResult = _httpWebHelper.HttpPost(API_Balance, data);
			returnMessage = retrunJsonResult;
			return retrunJsonResult;
		}



		public string VoiceVerify(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Log(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Get(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Put(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Delete(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Post(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

	}
}
