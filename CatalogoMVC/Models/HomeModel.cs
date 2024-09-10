namespace CatalogoMVC.Models
{
    public class HomeModel
    {
        public int Id { get; set; } 
        public required String Username { get; set; }
        public required String Email { get; set; }
        public required String Name { get; set; }
        public required String Gender { get; set; }
        public required String Zip { get; set; }
        public required String Password { get; set; }


    }
}
