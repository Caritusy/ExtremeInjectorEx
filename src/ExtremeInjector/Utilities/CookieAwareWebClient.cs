using System;
using System.Collections.Specialized;
using System.Net;

public sealed class CookieAwareWebClient : WebClient
{
	public CookieContainer Cookies { get; }

	public CookieAwareWebClient()
	{
		Cookies = new CookieContainer();
	}

	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		if (webRequest is HttpWebRequest httpWebRequest)
		{
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:27.0) Gecko/20100101 Firefox/27.0";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
			httpWebRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
			httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.5");
			httpWebRequest.CookieContainer = Cookies;
			httpWebRequest.ServicePoint.Expect100Continue = false;
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		}
		return webRequest;
	}

	protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
	{
		WebResponse webResponse = base.GetWebResponse(request, result);
		RecoveredRuntime.CaptureResponseCookies(this, webResponse);
		return webResponse;
	}

	protected override WebResponse GetWebResponse(WebRequest request)
	{
		WebResponse webResponse = base.GetWebResponse(request);
		RecoveredRuntime.CaptureResponseCookies(this, webResponse);
		return webResponse;
	}
}
