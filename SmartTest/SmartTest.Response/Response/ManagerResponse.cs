namespace SmartTest.Response.Response
{
    using System.Collections.ObjectModel;
    using System.Net;


    public class ManagerResponse<T>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected ManagerResponse() { }

        /// <summary>
        ///  Logica para respuesta de la petición.
        /// </summary>
        /// <typeparam name="T">Objeto Generico</typeparam>
        /// <param name="message">Mensaje de error</param>
        /// <returns></returns>
        public static ModelResponse<T> ResponseError(string message)
        {
            return new ModelResponse<T>
            {
                ResponseCode = HttpStatusCode.BadRequest,
                TransactionCode = 0,
                Message = message,
                Data = null
            };
        }

        /// <summary>
        ///  Logica para respuesta de la petición.
        /// </summary>
        /// <typeparam name="T">Objeto Generico</typeparam>
        /// <param name="message">Mensaje de error</param>
        /// <returns></returns>
        public static ModelResponse<T> ResponseUnauthorized(string message)
        {
            return new ModelResponse<T>
            {
                ResponseCode = HttpStatusCode.Unauthorized,
                TransactionCode = 0,
                Message = message,
                Data = null
            };
        }

        /// <summary>
        ///  Logica para respuesta de la petición.
        /// </summary>
        /// <typeparam name="T">Objeto Generico</typeparam>
        /// <param name="message">Mensaje de operación exitosa</param>
        /// <returns></returns>
        public static ModelResponse<T> ResponseOk(int rowsAffected, Collection<T> resultData)
        {
            return new ModelResponse<T>
            {
                ResponseCode = HttpStatusCode.OK,
                TransactionCode = rowsAffected,
                Message = "Ok",
                Data = resultData
            };
        }

        /// <summary>
        ///  Logica para respuesta de la petición.
        /// </summary>
        /// <typeparam name="T">Objeto Generico</typeparam>
        /// <param name="message">Mensaje de operación exitosa</param>
        /// <returns></returns>
        public static ModelResponse<T> ResponseOk(int idTransactionCode)
        {
            return new ModelResponse<T>
            {
                ResponseCode = HttpStatusCode.OK,
                TransactionCode = 0,
                Message = "Ok",
                Data = null
            };
        }


        /// <summary>
        ///  Logica para respuesta de la petición.
        /// </summary>
        /// <typeparam name="T">Objeto Generico</typeparam>
        /// <param name="message">Mensaje de operación exitosa</param>
        /// <returns></returns>
        public static ModelResponse<T> ResponseOk(string message)
        {
            return new ModelResponse<T>
            {
                ResponseCode = HttpStatusCode.OK,
                TransactionCode = 0,
                Message = message,
                Data = null
            };
        }

        /// <summary>
        ///  Logica para respuesta de la petición.
        /// </summary>
        /// <typeparam name="T">Objeto Generico</typeparam>
        /// <param name="message">Mensaje de error interno en el servicio</param>
        public static ModelResponse<T> ResponseInternalServerError(string message)
        {
            return new ModelResponse<T>
            {
                ResponseCode = HttpStatusCode.InternalServerError,
                TransactionCode = 0,
                Message = message,
                Data = null
            };
        }

        /// <summary>
        ///  Indica que la operación se ejecuto correctamente, pero no hay datapara retornar.
        /// </summary>
        /// <typeparam name="T">Objeto Generico</typeparam>
        /// <param name="message">Mensaje de error interno en el servicio</param>
        public static ModelResponse<T> ResponseNoContent(string message)
        {
            return new ModelResponse<T>
            {
                ResponseCode = HttpStatusCode.NoContent,
                TransactionCode = 0,
                Message = message,
                Data = null
            };
        }

        /// <summary>
        ///  Indica que se ha generado un conflicto en validaciones de negocio.
        /// </summary>
        /// <typeparam name="T">Objeto Generico</typeparam>
        /// <param name="message">Mensaje de error interno en el servicio</param>
        public static ModelResponse<T> ResponseConflict(string message)
        {
            return new ModelResponse<T>
            {
                ResponseCode = HttpStatusCode.Conflict,
                TransactionCode = 0,
                Message = message,
                Data = null
            };
        }
    }
}
