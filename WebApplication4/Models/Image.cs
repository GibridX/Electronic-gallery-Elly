namespace WebApplication4.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;// Имя файла на диске
        public byte[] ImageData { get; set; } = null!;// Данные изображения в байтах
        public string ContentType { get; set; } = null!;// Тип содержимого (например, "image/jpeg")
    }
}
