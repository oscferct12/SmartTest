namespace SmartTest.Response.Response
{
    using System;
    using System.Collections.ObjectModel;
    using System.Net;


    public class ModelResponse<T>
    {
        /// <summary>
        /// Gets or Sets ResponseCode
        /// </summary>
        public HttpStatusCode ResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets Message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets TransactionCode.
        /// </summary>
        public int TransactionCode { get; set; }

        /// <summary>
        /// Gets or Sets Data.
        /// </summary>
        public Collection<T> Data { get; set; } = new Collection<T>();

        /// <summary>
        /// Get Date Response
        /// </summary>
        public DateTime Date { get => DateTime.Now; }
    }
}
