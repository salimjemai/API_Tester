using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountActivities
{
    class GlobalVariables
    {

        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string UserBadgeID { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }

        public string AccessCode { get; set; } = String.Empty;
        public string ActiveDirectoryName { get; set; } = String.Empty;
        public string UserPermissionsProfile { get; set; } = String.Empty;

        public string UserDefinedFieldLabel { get; set; } = String.Empty;
        public string UserDefinedFieldLabel1 { get; set; } = String.Empty;
        public string UserDefinedFieldLabel2 { get; set; } = String.Empty;

        public string UserDefinedFieldData { get; set; } = String.Empty;
        public string UserDefinedFieldData1 { get; set; } = String.Empty;
        public string UserDefinedFieldData2 { get; set; } = String.Empty;

        public string DefaultScreen { get; set; } = "Aircraft";

        public double PurchaseLimit { get; set; }
        public double LaborCost { get; set; }
        public double RegularCost { get; set; }
        public double OvertimeCost { get; set; }
        public double DoubleTimeCost { get; set; }
        public double RegularBurdenCost { get; set; }
        public double OvertimeBurdenCost { get; set; }
        public double DoubleTimeBurdenCost { get; set; }

        public string RegularLaborAccountNumber { get; set; } = String.Empty;
        public string OvertimeLaborAccountNumber { get; set; } = String.Empty;
        public string DoubleTimeLaborAccountNumber { get; set; } = String.Empty;
        public string LaborBurdenAccountNumber { get; set; } = String.Empty;

        // Bool variables
        public bool MustChangePassword { get; set; } = false;
        public bool MustChangeAccessCode { get; set; } = false;
        public bool CannotChangePassword { get; set; } = false;
        public bool AccountDisabled { get; set; } = false;
        public bool Locator { get; set; } = false;
        public bool SuspendLocator { get; set; } = false;
        public bool CanSelectLocator { get; set; } = false;
        public bool CanSelectToVendorLot { get; set; } = false;
        public bool ReceivingInspector { get; set; } = false;
        public bool TipOfDay { get; set; } = false;
        public bool LargeButtons { get; set; } = false;
        public bool DisablePersistence { get; set; } = false;
        public bool DefaultIncludeFuelActivity { get; set; } = false;
        public bool OnlyIncludeFuelActivity { get; set; } = false;
        public bool DefaultIncludeServiceActivity { get; set; } = false;
        public bool OnlyIncludeServiceActivity { get; set; } = false;
        public bool DefaultIncludePartSaleActivity { get; set; } = false;
        public bool OnlyIncludePartSaleActivity { get; set; } = false;
        public bool DefaultIncludeCateringActivity { get; set; } = false;
        public bool OnlyIncludeCateringActivity { get; set; } = false;
        public bool DefaultIncludeHotelActivity { get; set; } = false;
        public bool OnlyIncludeHotelActivity { get; set; } = false;
        public bool DefaultIncludeTransportationActivity { get; set; } = false;
        public bool OnlyIncludeTransportationActivity { get; set; } = false;
        public bool LaunchLogbookResearch { get; set; } = false;
        public bool CanEnterCompliance { get; set; } = false;
        public bool IncludeAllDefaultLogbookSearchCriteria { get; set; } = false;
        public bool OnlyDisplayAssignedInWOQMgmt { get; set; } = false;

        // New user for Edit User API
        public string NewUsername { get; set; } = String.Empty;

    }
}
