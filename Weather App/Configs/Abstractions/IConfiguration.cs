using Configs.Models.Abstractions;
namespace Configs.Abstractions
{
    public interface IConfiguration
    {
        bool IsConfigExsists();

        bool SetConfigs(IConfig config);
        bool SetCityConfigs(IConfig[] config);
        string GetConfigs();

        bool DeleteConfig(string path);

        void SetConfigFileName(string name);
    }
}
