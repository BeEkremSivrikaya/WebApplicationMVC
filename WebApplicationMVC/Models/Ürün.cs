namespace WebApplicationMVC.Models
{
    public class Ürün
    {
        public int Id { get; set; }
        public string? İsim { get; set; }
        public string? Açıklama { get; set; }
        public int? Fiyat { get; set; }

        public int Stok { get; set; }


    }
}
