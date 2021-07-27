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

        List<string> _allAssetForSameMachineType = new List<string>();

        public AssetManagementServices()
        {
            GetAssetData();
        }

        public void GetAssetData()
        {
            Asset a1 = new Asset("C300", "Cutter head", "S6");
            Asset a2 = new Asset("C40", "Cutter head", "S7");
            Asset a3 = new Asset("C300", "Blade safety cover", "S10");
            Asset a4 = new Asset("C60", "Blade safety cover", "S11");
            Asset a5 = new Asset("C300", "Deburring blades", "S6");
            Asset a6 = new Asset("C60", "Cutter head", "S8");
            Asset a7 = new Asset("C60", "Clamping fixture", "S2");
            Asset a8 = new Asset("C40", "Blade safety cover", "S11");
            Asset a9 = new Asset("C40", "Shutter gripper", "S3");

            _listOfAssets = new List<Asset>() { a1, a2, a3, a4, a5, a6, a7, a8, a9 };
        }


        public string use = "C300";

        public List<string> GetSortedAssetData()
        {
            foreach (var asset in _listOfAssets)
            {
                if (use == asset.MachineName)
                {
                    _allAssetForSameMachineType.Add(asset.AssetName);
                }
            }
            return _allAssetForSameMachineType;
        }

        public void GetAssetName(string machineName)
        {
            int count = default;
            foreach (var asset in _listOfAssets)
            {
                if (machineName == asset.MachineName)
                {
                    count++;
                    Console.WriteLine($"{machineName} Machine contains Asset {count}: {asset.AssetName} with Series Number: {asset.SeriesNumber}");
                }
            }
        }

        public void GetMachineName(string assetName)
        {
            foreach (var asset in _listOfAssets)
            {
                if (assetName == asset.AssetName)
                {
                    Console.WriteLine($"{assetName} Asset with Series Number: {asset.SeriesNumber} is used on : {asset.MachineName} Machine");
                }
            }
        }

        /*public void GetMachineTypesUsingLatestAssets()
        {
            foreach (var asset in _listOfAssets)
            {
                if (asset.MachineName)
            }
        }*/
    }
}
