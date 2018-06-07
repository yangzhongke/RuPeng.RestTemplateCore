namespace RestTemplateCore
{
    /// <summary>
    /// 带响应报文的Rest响应结果，而且json报文会被自动反序列化
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RestResponseWithBody<T>: RestResponse
    {
        /// <summary>
        /// 响应报文体json反序列化的内容
        /// </summary>
        public T Body { get; set; }
    }
}