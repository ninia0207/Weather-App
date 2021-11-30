using Weather.PCL.Models.Enums;

namespace Weather.PCL.Abstractions
{
    public interface ICultureSettings
    {
        void ChoiceCorF(TempChoice temp);
        void ChoiceMiorKM(MetersOrMiles metersOrMiles);

        bool ConvertTemperatures(out double apparentTemperature, double temperature);

        bool ConvertMilesToMeters(out double meters, double miles);

        bool SetLanguage(string LanguageCode);


        bool SaveChanges();
    }
}
