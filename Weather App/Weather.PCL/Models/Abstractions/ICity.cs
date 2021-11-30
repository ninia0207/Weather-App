namespace Weather.PCL.Models.Abstractions
{
    public interface ICity
    {
        string CityName { get; set; }
        double Lng { get; set; }
        double Lat { get; set; }
    }
}
