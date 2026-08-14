using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;

public sealed class Class20 : WebClient
{
	[CompilerGenerated]
	internal CookieContainer cookieContainer_0;

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
		Class171.smethod_339(this, webResponse);
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
				Class171.smethod_339(this, webResponse);
				num = (int)(num2 * 1089463280) ^ -1510167112;
			}
		}
	}

	internal static CookieContainer smethod_0()
	{
		return new CookieContainer();
	}

	internal static void smethod_1(HttpWebRequest httpWebRequest_0, string string_0)
	{
		httpWebRequest_0.UserAgent = string_0;
	}

	internal static void smethod_2(HttpWebRequest httpWebRequest_0, string string_0)
	{
		httpWebRequest_0.Accept = string_0;
	}

	internal static WebHeaderCollection smethod_3(WebRequest webRequest_0)
	{
		return webRequest_0.Headers;
	}

	internal static void smethod_4(NameValueCollection nameValueCollection_0, string string_0, string string_1)
	{
		nameValueCollection_0.Add(string_0, string_1);
	}

	internal static void smethod_5(HttpWebRequest httpWebRequest_0, CookieContainer cookieContainer_1)
	{
		httpWebRequest_0.CookieContainer = cookieContainer_1;
	}

	internal static ServicePoint smethod_6(HttpWebRequest httpWebRequest_0)
	{
		return httpWebRequest_0.ServicePoint;
	}

	internal static void smethod_7(ServicePoint servicePoint_0, bool bool_0)
	{
		servicePoint_0.Expect100Continue = bool_0;
	}

	internal static void smethod_8(HttpWebRequest httpWebRequest_0, bool bool_0)
	{
		httpWebRequest_0.AllowAutoRedirect = bool_0;
	}

	internal static void smethod_9(HttpWebRequest httpWebRequest_0, DecompressionMethods decompressionMethods_0)
	{
		httpWebRequest_0.AutomaticDecompression = decompressionMethods_0;
	}
}
