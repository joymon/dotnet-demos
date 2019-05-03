using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CurrentUserTests
{
    class HttpResponseCacheHeaderHandler
    {
        internal static async Task SetHttpCacheHeaders(HttpResponseMessage responseMessage, ResponseCacheMode mode)
        {
            responseMessage.Headers.Add("joy-mode-identified", mode.ToString());
            if ((mode & ResponseCacheMode.CacheControl) == ResponseCacheMode.CacheControl)
            {
                //http://codeconcerns.com/web-api-response-http-cache/
                responseMessage.Headers.CacheControl = new CacheControlHeaderValue() { MaxAge = TimeSpan.FromSeconds(60) };
                //responseMessage.Headers.Add("Cache-Control", "max-age=60");
            }
            if ((mode & ResponseCacheMode.Expires) == ResponseCacheMode.Expires)
            {
                // https://stackoverflow.com/questions/15256785/how-to-add-an-expires-response-header-to-a-webapi-action-response
                responseMessage.Content.Headers.Expires = DateTimeOffset.UtcNow.AddSeconds(30);
                //responseMessage.Headers.Add("Expires", "max-age=60");
                responseMessage.Headers.CacheControl = new CacheControlHeaderValue() { Public = true };
                //responseMessage.Headers.Remove("Pragma");
                //responseMessage.Headers.Pragma.Clear();
                //responseMessage.Content.Headers.Remove("Pragma");
            }
            if ((mode & ResponseCacheMode.ETag) == ResponseCacheMode.ETag)
            {
                //responseMessage.Headers.ETag = new EntityTagHeaderValue() { Tag }
                //responseMessage.Headers.Add("joys", "dodod");
                string eTagInRequest = GetETagFromRequest(responseMessage.RequestMessage);
                string eTagOfResponse = await GetETagFromContent(responseMessage.Content);
                if (string.Equals(eTagInRequest, eTagOfResponse))
                {
                    responseMessage.StatusCode = HttpStatusCode.NotModified;
                }
                else
                {
                    responseMessage.Headers.ETag = new EntityTagHeaderValue(eTagOfResponse);
                }

            }
        }
        static private async Task<string> GetETagFromContent(HttpContent content)
        {
            return MD5BasedETagCalculator.ComputeHash(await content.ReadAsStringAsync());
        }
        private static string GetETagFromRequest(HttpRequestMessage request)
        {
            IEnumerable<string> values = null;
            if (request.Headers.TryGetValues("If-None-Match", out values))
                return new EntityTagHeaderValue(values.FirstOrDefault()).Tag;

            return null;
        }
    }
}