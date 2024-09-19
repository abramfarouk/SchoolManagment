namespace SchoolManagment.Core.Bases
{


    public class ResponseHandler
    {

        public ResponseHandler()
        {

        }
        public Responses<T> Deleted<T>(string mess)
        {
            return new Responses<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = mess == null ? "Deleted Successfully" : mess
            };
        }
        public Responses<T> Success<T>(T entity, object Meta = null)
        {
            return new Responses<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Added Successfully",
                Meta = Meta
            };
        }
        public Responses<T> Unauthorized<T>()
        {
            return new Responses<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = true,
                Message = "UnAuthorized"
            };
        }
        public Responses<T> BadRequest<T>(string Message = null)
        {
            return new Responses<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = Message == null ? "Bad Request" : Message
            };
        }

        public Responses<List<T>> BadRequestT<T>(string Message = null)
        {
            return new Responses<List<T>>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = Message ?? "Bad Request"
            };
        }

        public Responses<T> NotFound<T>(string message = null)
        {
            return new Responses<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false,
                Message = message == null ? "Not Found" : message
            };
        }
        public Responses<T> UnprocessableEntity<T>(string message = null)
        {
            return new Responses<T>()
            {
                StatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
                Succeeded = false,
                Message = message == null ? "There Is Problem" : message
            };
        }

        public Responses<T> Created<T>(T entity, object Meta = null)
        {
            return new Responses<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Succeeded = true,
                Message = "Created Successful",
                Meta = Meta
            };
        }
    }
}
