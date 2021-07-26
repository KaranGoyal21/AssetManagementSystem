using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementSystem.Library
{
    public class AssetManagementServices
    {
        List<Asset> _listOfAssets;

        public AssetManagementServices()
        {
            GetAssetData();
        }

        public void GetAssetData()
        {
            Asset a1 = new Asset("C300", "Cutterhead", "S6");
            Asset a2 = new Asset("C40", "Cutter head", "S7");
            Asset a3 = new Asset("C300", "Blade safety cover", "S10");
            Asset a4 = new Asset("C60", "Blade safety cover", "S11");
            Asset a5 = new Asset("C300", "Deburring blades", "S6");
            Asset a6 = new Asset("C60", "Cutter head", "S8");
            Asset a7 = new Asset("C60", "Clamping fixture", "S2");
            Asset a8 = new Asset("C40", "Blade safety cover", "S11");
            Asset a9 = new Asset("C40", "Shutter gripper", "S3");
        }


    }
}
