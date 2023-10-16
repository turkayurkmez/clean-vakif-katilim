namespace ExceptionHandling
{
    public class BusinessException<T> : Exception
    {
        public string LayerPosition { get; set; }
        public string Reason { get; set; }

        public T? Model { get; set; }

        public BusinessException(string? message) : base(message)
        {

        }
    }

    public class ProductServiceException : BusinessException<Product>
    {


        public ProductServiceException() : base("ProductService sınıfından kaynaklanan bir hata meydana geldi")
        {
        }

        public ProductServiceException(string? message) : base(message)
        {

        }

        public ProductServiceException(string reason, string? message) : base(message)
        {
            Reason = reason;
            LayerPosition = "Application";

        }



    }


}
