using System.Net;
using System.Net.Http.Headers;

namespace RestTemplateCore
{
    /// <summary>
    /// Result
    /// </summary>
    public class RestResponse
    {
        /// <summary>
        /// 响应状态码
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// 响应的报文头
        /// </summary>
        public HttpResponseHeaders Headers { get; set; }
    }
}
