using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class StorageHandler
    {
        public enum StorageComponentTypes
        {
            ApacerMicroSDHC = 1,
            KingstonMicroSDHC = 2,
            SanDiskMicroSDXC = 3,
            SiliconPowerMicroSD = 4
        }

        IOutput Output;

        public StorageHandler(IOutput output)
        {
            this.Output = output;
        }

        public StorageComponentTypes GetStorageType(string enteredStorageTypeIndex)
        {
            int storageTypeIndex = 0;

            if (string.IsNullOrWhiteSpace(enteredStorageTypeIndex)) throw new ArgumentException("Index must be entered.");
            if (!int.TryParse(enteredStorageTypeIndex, out storageTypeIndex)) throw new ArgumentException("Index must be numeric.");


            int numberOfAvailableStorageTypes = Enum.GetValues(typeof(StorageComponentTypes)).Length;
            if ((storageTypeIndex < 1) || (storageTypeIndex > numberOfAvailableStorageTypes))
            {
                throw new ArgumentOutOfRangeException(paramName: "storageTypeIndex", message: "Entered index is out of the available range.");
            }

            return (StorageComponentTypes)storageTypeIndex;
        }
    

        public IStorage GetStorage(StorageComponentTypes StorageType)
        {
            IStorage storageComponent = null;

            switch (StorageType)
            {
                case StorageComponentTypes.ApacerMicroSDHC:
                    storageComponent = new ApacerMicroSDHC(Output);
                    Output.WriteLine($"{nameof(ApacerMicroSDHC)} selected");
                    break;
                case StorageComponentTypes.KingstonMicroSDHC:
                    storageComponent = new KingstonMicroSDHC(Output);
                    Output.WriteLine($"{nameof(KingstonMicroSDHC)} selected");
                    break;
                case StorageComponentTypes.SanDiskMicroSDXC:
                    storageComponent = new SanDiskMicroSDXC(Output);
                    Output.WriteLine($"{nameof(SanDiskMicroSDXC)} selected");
                    break;
                case StorageComponentTypes.SiliconPowerMicroSD:
                    storageComponent = new SiliconPowerMicroSD(Output);
                    Output.WriteLine($"{nameof(SiliconPowerMicroSD)} selected");
                    break;
            }

            return storageComponent;
        }

        public void SetAndRunStorage(SimCorpMobile simCorpMobile, IStorage storageComponent)
        {
            simCorpMobile.RemovableStorage = storageComponent;
            simCorpMobile.StoreToRemovableStorage(new Object());
        }

        public void ShowMenuOfStorages()
        {
            var menuBuilder = new StringBuilder();

            menuBuilder.AppendLine("Select storage component by specifying its index:");

            string[] storageTypes = Enum.GetNames(typeof(StorageComponentTypes));
            for (int i = 0; i < storageTypes.Count(); i++)
            {
                menuBuilder.AppendLine($"{i + 1} - {storageTypes[i]}");
            }

            Output.Write(menuBuilder.ToString());
        }
    }
}
