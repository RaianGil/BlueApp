using SQLite;


namespace BlueApp.Models
{
    public class CarModel
    {
        [PrimaryKey, AutoIncrement]
        public int CarID { get; set; }
        [Unique]
        public string CarCode { get; set; }
        public string CarBrand { get; set; }
        public string CarMod { get; set; }
        public int CarYear { get; set; }
        public string CarColor { get; set; }
    }
}
