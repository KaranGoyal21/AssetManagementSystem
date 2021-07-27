using AssetManagementSystem.Library;
using System;

namespace AssetManagementSystem.ConsoleUI
{
    class Program
    {
        static AssetManagementServices services = new AssetManagementServices();
        static void Main(string[] args)
        {
            services.GetAssetName("C300");
            services.GetMachineName("Blade safety cover");
        }
    }
}
