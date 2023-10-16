namespace ExceptionHandling
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

    }

    public interface IProductRepositoey
    {

    }

    public class ProductService
    {

        private readonly IProductRepositoey productRepository;

        public ProductService()
        {
            //this.productRepository = productRepositoey ?? throw new ArgumentNullException(nameof(productRepositoey));
        }

        public void AddNewProduct(Product product)
        {


            ArgumentNullException.ThrowIfNull(product, nameof(product));

            checkPrice(product);

        }

        private void checkPrice(Product product)
        {
            if (product.Price <= 0)
            {
                throw new ArgumentException("ürün fiyatı negatif veya 0 olamaz!");
            }
        }

        /// <summary>
        /// Bir ürünün stok bilgisini güncelleyen fonksiyon
        /// </summary>
        /// <param name="productId">Hangi ürünü güncelleyecek iseniz o ürünün id'sini girin</param>
        /// <param name="productStock">Yeni stock bilgisi</param>
        /// <exception cref="ProductServiceException">0'ın altında ise exception fırlar.</exception>
        public void ChangeProductStock(int productId, int productStock)
        {
            if (productStock <= 0)
            {
                throw new ProductServiceException("stock <= 0", $"stock, 0'dan büyük olmalı! Hata modeli: {typeof(Product).FullName}");


            }
        }

        public byte AddTwoBytes(byte x, byte y)
        {
            try
            {
                checked
                {
                    return (byte)(x + y);
                }
            }
            catch (Exception)
            {

                throw new Exception("İki değerin toplamı byte sınırlarını aştı");
            }


        }
    }
}
