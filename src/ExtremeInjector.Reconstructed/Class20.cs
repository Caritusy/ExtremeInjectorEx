using System;
using System.Net;
using System.Runtime.CompilerServices;

public sealed class Class20 : WebClient
{
	[CompilerGenerated]
	private CookieContainer cookieContainer_0;

	public Class20()
	{
		method_1(new CookieContainer());
	}

	[SpecialName]
	[CompilerGenerated]
	public CookieContainer method_0()
	{
		return cookieContainer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(CookieContainer cookieContainer_1)
	{
		cookieContainer_0 = cookieContainer_1;
	}

	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		if (webRequest is HttpWebRequest httpWebRequest)
		{
			httpWebRequest.UserAgent = Class178.smethod_0(128);
			httpWebRequest.Accept = Class178.smethod_0(225);
			httpWebRequest.Headers.Add(Class178.smethod_0(310), Class178.smethod_0(331));
			httpWebRequest.Headers.Add(Class178.smethod_0(352), Class178.smethod_0(373));
			httpWebRequest.CookieContainer = method_0();
			httpWebRequest.ServicePoint.Expect100Continue = false;
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		}
		return webRequest;
	}

	protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
	{
		WebResponse webResponse = base.GetWebResponse(request, result);
		Class171.smethod_333(this, webResponse);
		return webResponse;
	}

	protected override WebResponse GetWebResponse(WebRequest request)
	{
		WebResponse webResponse = base.GetWebResponse(request);
		while (true)
		{
			int num = -1361806636;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -598079579)) % 3)
				{
				case 2u:
					goto IL_000a;
				case 0u:
					break;
				default:
					return webResponse;
				}
				break;
				IL_000a:
				Class171.smethod_333(this, webResponse);
				num = (int)(num2 * 1089463280) ^ -1510167112;
			}
		}
	}
}
