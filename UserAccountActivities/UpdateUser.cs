using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UserAccountActivities
{
    public class UpdateUser
    {
        public void editUser()
        {

            // create an object of class Credentials
            Credentials Cred = new Credentials();

            // create an object for Global variables class
            GlobalVariables GVar = new GlobalVariables();

            Console.WriteLine("Updating user info  ...");

            //Reading input values from console    
            Console.WriteLine("Enter UserName: ");
            GVar.Username = Convert.ToString(Console.ReadLine());       // Required & needs validation

            Console.WriteLine("Enter the new UserName: ");
            GVar.NewPassword = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter User Full Name: ");
            GVar.Fullname = Convert.ToString(Console.ReadLine());       // Not required

            Console.WriteLine("Enter User Description: ");
            GVar.Description = Convert.ToString(Console.ReadLine());    // Not required

            Console.WriteLine("Enter a Department from the below list: \n" +
                "- Admin 5 \n" +
                "- Administrative \n" +
                "- Airframe \n" +
                "- Avionics \n" +
                "- Aircraft Maintenance \n" +
                ": ");
            GVar.Department = Convert.ToString(Console.ReadLine());     // Needs validation

            Console.WriteLine("Enter User Bardge ID: ");
            GVar.UserBadgeID = Convert.ToString(Console.ReadLine());    // Not required

            Console.WriteLine("Enter User Password: ");
            GVar.Password = Convert.ToString(Console.ReadLine());       // Required


            // Not required and needs validation The default value is Empty
            /*
            GVar.AccessCode = string.Empty;
            GVar.ActiveDirectoryName = string.Empty;
            GVar.UserPermissionsProfile = string.Empty;
            */

            Console.WriteLine("\n Enter a Screen name from the list below: \n" +
                    "- Accounting Interface \n" +
                    "- Aircraft \n" +
                    "- Company Database \n" +
                    "- Compliance \n" +
                    "- Contact Profile \n" +
                    "- Employee Schedule \n" +
                    "- Inventory \n" +
                    "- Line Management \n" +
                    "- Purchase Order \n" +
                    "- Receiving :\n");
            GVar.DefaultScreen = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the purchase limit: ");
            GVar.PurchaseLimit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter labor cost: ");
            GVar.LaborCost =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter regular labor cost:");
            GVar.RegularCost =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter overtime labor cost: ");
            GVar.OvertimeCost =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter doubletime labor cost: ");
            GVar.DoubleTimeCost =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter regular time burden labor cost: ");
            GVar.RegularBurdenCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter overtime burden labor cost: ");
            GVar.OvertimeBurdenCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter doubletime burden labor cost: ");
            GVar.DoubleTimeBurdenCost = Convert.ToDouble(Console.ReadLine());

            // UDFs
            GVar.UserDefinedFieldLabel = "Hire Date";
            GVar.UserDefinedFieldData = "08/30/2020";

            GVar.UserDefinedFieldLabel1 = "Phone Number";
            GVar.UserDefinedFieldData1 = "512-885-9966";


            // Labor accounts number, needs validation , Default value is Empty
            /*
            GVar.RegularLaborAccountNumber = Convert.ToString(Console.ReadLine());
            GVar.OvertimeLaborAccountNumber = Convert.ToString(Console.ReadLine());
            GVar.DoubleTimeLaborAccountNumber = Convert.ToString(Console.ReadLine());
            GVar.LaborBurdenAccountNumber = Convert.ToString(Console.ReadLine());
            */


            // I didn't set the boolean variables because they are false by default
            // To set any variable to true it can be set in this class or in the GlobalVariables class
           




            //Calling InvokeService method    
            InvokeServiceUpdateUser(GVar.Username, GVar.Fullname, GVar.Description, GVar.Department, GVar.UserBadgeID, GVar.Password, GVar.AccessCode, GVar.ActiveDirectoryName,
                    GVar.UserPermissionsProfile, GVar.DefaultScreen, GVar.PurchaseLimit, GVar.LaborCost, GVar.RegularCost, GVar.OvertimeCost, GVar.DoubleTimeCost,
                    GVar.RegularBurdenCost, GVar.OvertimeBurdenCost, GVar.DoubleTimeBurdenCost, GVar.RegularLaborAccountNumber, GVar.OvertimeLaborAccountNumber,
                    GVar.DoubleTimeLaborAccountNumber, GVar.LaborBurdenAccountNumber,
                    GVar.MustChangePassword, GVar.MustChangeAccessCode, GVar.CannotChangePassword,
                    GVar.AccountDisabled, GVar.Locator, GVar.SuspendLocator , GVar.CanSelectLocator, GVar.CanSelectToVendorLot,
                    GVar.ReceivingInspector, GVar.TipOfDay, GVar.LargeButtons, GVar.DisablePersistence, GVar.DefaultIncludeFuelActivity,
                    GVar.OnlyIncludeFuelActivity, GVar.DefaultIncludeServiceActivity, GVar.OnlyIncludeServiceActivity,
                    GVar.DefaultIncludePartSaleActivity, GVar.OnlyIncludePartSaleActivity, GVar.DefaultIncludeCateringActivity,
                    GVar.OnlyIncludeCateringActivity, GVar.DefaultIncludeHotelActivity, GVar.OnlyIncludeHotelActivity,
                    GVar.DefaultIncludeTransportationActivity, GVar.OnlyIncludeTransportationActivity, GVar.LaunchLogbookResearch,
                    GVar.CanEnterCompliance, GVar.IncludeAllDefaultLogbookSearchCriteria, GVar.OnlyDisplayAssignedInWOQMgmt,
                    GVar.UserDefinedFieldData, GVar.UserDefinedFieldData1, GVar.NewUsername, Cred.GetAliasName(), Cred.GetLoginID(), Cred.GetLoginPassword());

        }

        public void InvokeServiceUpdateUser(string userName, string Fullname, string Description, string Department, string UserBadgeID, string password,
                                  string AccessCode, string ActiveDirectoryName, string UserPermissionsProfile, string DefaultScreen,
                                  double PurchaseLimit, double LaborCost, double RegularCost, double OvertimeCost, double DoubeTimeCost,
                                  double RegularBurdenCost, double OvertimeBurdenCost, double DoubleTimeBurdenCost, string RegularLaborAccountNumber,
                                  string OvertimeLaborAccountNumber, string DoubleTimeLaborAccountNumber, string LaborBurdenAccountNumber,
                                  
                                  bool MustChangePassword, bool MustChangeAccessCode, bool CannotChangePassword,                                   
                                  bool AccountDisabled,bool Locator, bool SuspendLocator, bool CanSelectLocator, bool CanSelectToVendorLot, 
                                  bool ReceivingInspector,bool TipOfDay, bool LargeButtons, bool DisablePersistence, bool DefaultIncludeFuelActivity, 
                                  bool OnlyIncludeFuelActivity,bool DefaultIncludeServiceActivity, bool OnlyIncludeServiceActivity, 
                                  bool DefaultIncludePartSaleActivity,bool OnlyIncludePartSaleActivity, bool DefaultIncludeCateringActivity, 
                                  bool OnlyIncludeCateringActivity,bool DefaultIncludeHotelActivity, bool OnlyIncludeHotelActivity, 
                                  bool DefaultIncludeTransportationActivity,bool OnlyIncludeTransportationActivity, bool LaunchLogbookResearch,                                
                                  bool CanEnterCompliance,bool IncludeAllDefaultLogbookSearchCriteria, bool OnlyDisplayAssignedInWOQMgmt,
                                  string phoneNum, string date, string newUserName, string schema, string ApiUserName, string ApiUserPwd)

        {
            //Calling CreateSOAPWebRequest method    
            HttpWebRequest request = CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();

            // <?xml version=""1.0"" encoding=""utf-8""?>  

            
            //SOAP Body Request    
            SOAPReqBody.LoadXml(
                @"<?xml version=""1.0"" encoding=""utf-8""?> 
                <soap:Envelope xmlns:xsi = ""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd = ""http://www.w3.org/2001/XMLSchema"" xmlns:soap = ""http://schemas.xmlsoap.org/soap/envelope/"">
                 <soap:Body>
                    <UpdateUser xmlns=""http://corridor.aero/cws/"">    
                        <userData>
                            <AliasName>" + schema + @"</AliasName>
                            <LoginID>" + ApiUserName + @"</LoginID>
                            <LoginPassword>" + ApiUserPwd + @"</LoginPassword>

                            <Username>" + userName+@"</Username>
                            <Fullname>"+Fullname+@"</Fullname>
                            <Description>"+Description+@"</Description>
                            <Department>"+Department+@"</Department>
                            <UserBadgeID>"+UserBadgeID+@"</UserBadgeID>
                            <Password>"+password+@"</Password>
                            <AccessCode>"+AccessCode+@"</AccessCode>
                            <ActiveDirectoryName>"+ActiveDirectoryName+@"</ActiveDirectoryName>
                            <UserPermissionsProfile>"+UserPermissionsProfile+@"</UserPermissionsProfile>
					        <!--<UserDefinedFields>
                               <UserDefinedField>
                                 <Label>Hire Date</Label>
                                 <Data>"+date+@"</Data>
                               </UserDefinedField>
	                          <UserDefinedField>
	                             <Label>Phone Number</Label>
	                             <Data>"+phoneNum+@"</Data>
                               </UserDefinedField>
                            </UserDefinedFields>-->
                            <DefaultScreen>"+DefaultScreen+@"</DefaultScreen>
                            <PurchaseLimit>"+PurchaseLimit+@"</PurchaseLimit>
                            <LaborCost>"+LaborCost+@"</LaborCost>
                            <RegularCost>"+RegularCost+@"</RegularCost>
                            <OvertimeCost>"+OvertimeCost+@"</OvertimeCost>
                            <DoubleTimeCost>"+DoubeTimeCost+@"</DoubleTimeCost>
                            <RegularBurdenCost>"+RegularBurdenCost+@"</RegularBurdenCost>
                            <OvertimeBurdenCost>"+OvertimeBurdenCost+@"</OvertimeBurdenCost>
                            <DoubleTimeBurdenCost>"+DoubleTimeBurdenCost+@"</DoubleTimeBurdenCost>
                            <RegularLaborAccountNumber>"+RegularLaborAccountNumber+@"</RegularLaborAccountNumber>
                            <OvertimeLaborAccountNumber>"+OvertimeLaborAccountNumber+@"</OvertimeLaborAccountNumber>
                            <DoubleTimeLaborAccountNumber>"+DoubleTimeLaborAccountNumber+@"</DoubleTimeLaborAccountNumber>
                            <LaborBurdenAccountNumber>"+LaborBurdenAccountNumber+@"</LaborBurdenAccountNumber>
                            <MustChangePassword>"+ convertedBoolForUpdateUser(MustChangePassword) + @"</MustChangePassword>
                            <MustChangeAccessCode>"+ convertedBoolForUpdateUser(MustChangeAccessCode) +@"</MustChangeAccessCode>
                            <CannotChangePassword>"+ convertedBoolForUpdateUser(CannotChangePassword)+@"</CannotChangePassword>
                            <AccountDisabled>"+ convertedBoolForUpdateUser(AccountDisabled) +@"</AccountDisabled>
                            <Locator>"+ convertedBoolForUpdateUser(Locator) +@"</Locator>
                            <SuspendLocator>"+ convertedBoolForUpdateUser(SuspendLocator) +@"</SuspendLocator>
                            <CanSelectLocator>"+ convertedBoolForUpdateUser(CanSelectLocator) +@"</CanSelectLocator>
                            <CanSelectToVendorLot>"+ convertedBoolForUpdateUser(CanSelectToVendorLot) +@"</CanSelectToVendorLot>
                            <ReceivingInspector>"+ convertedBoolForUpdateUser(ReceivingInspector) +@"</ReceivingInspector>
                            <TipOfDay>"+ convertedBoolForUpdateUser(TipOfDay) +@"</TipOfDay>
                            <LargeButtons>"+ convertedBoolForUpdateUser(LargeButtons) +@"</LargeButtons>
                            <DisablePersistence>"+ convertedBoolForUpdateUser(DisablePersistence) +@"</DisablePersistence>
                            <DefaultIncludeFuelActivity>"+ convertedBoolForUpdateUser(DefaultIncludeFuelActivity) +@"</DefaultIncludeFuelActivity>
                            <OnlyIncludeFuelActivity>"+ convertedBoolForUpdateUser(OnlyIncludeFuelActivity) +@"</OnlyIncludeFuelActivity>
                            <DefaultIncludeServiceActivity>"+ convertedBoolForUpdateUser(DefaultIncludeServiceActivity) +@"</DefaultIncludeServiceActivity>
                            <OnlyIncludeServiceActivity>"+ convertedBoolForUpdateUser(OnlyIncludeServiceActivity) +@"</OnlyIncludeServiceActivity>
                            <DefaultIncludePartSaleActivity>"+ convertedBoolForUpdateUser(DefaultIncludePartSaleActivity) +@"</DefaultIncludePartSaleActivity>
                            <OnlyIncludePartSaleActivity>"+ convertedBoolForUpdateUser(OnlyIncludePartSaleActivity) +@"</OnlyIncludePartSaleActivity>
                            <DefaultIncludeCateringActivity>"+ convertedBoolForUpdateUser(DefaultIncludeCateringActivity) +@"</DefaultIncludeCateringActivity>
                            <OnlyIncludeCateringActivity>"+ convertedBoolForUpdateUser(OnlyIncludeCateringActivity) +@"</OnlyIncludeCateringActivity>
                            <DefaultIncludeHotelActivity>"+ convertedBoolForUpdateUser(DefaultIncludeHotelActivity) +@"</DefaultIncludeHotelActivity>
                            <OnlyIncludeHotelActivity>"+ convertedBoolForUpdateUser(OnlyIncludeHotelActivity) +@"</OnlyIncludeHotelActivity>
                            <DefaultIncludeTransportationActivity>"+ convertedBoolForUpdateUser(DefaultIncludeTransportationActivity) +@"</DefaultIncludeTransportationActivity>
                            <OnlyIncludeTransportationActivity>"+ convertedBoolForUpdateUser(OnlyIncludeTransportationActivity) +@"</OnlyIncludeTransportationActivity>
                            <LaunchLogbookResearch>"+ convertedBoolForUpdateUser(LaunchLogbookResearch) +@"</LaunchLogbookResearch>
                            <CanEnterCompliance>"+ convertedBoolForUpdateUser(CanEnterCompliance)+@"</CanEnterCompliance>
                            <IncludeAllDefaultLogbookSearchCriteria>"+ convertedBoolForUpdateUser(IncludeAllDefaultLogbookSearchCriteria) +@"</IncludeAllDefaultLogbookSearchCriteria>
                            <OnlyDisplayAssignedInWOQMgmt>"+ convertedBoolForUpdateUser(OnlyDisplayAssignedInWOQMgmt) + @"</OnlyDisplayAssignedInWOQMgmt>
                            <NewUsername>" + newUserName+@"</NewUsername>
                        </userData>
                    </UpdateUser>
                   </soap:Body>
                </soap:Envelope>");


            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }

            //Geting response from request    
            using (WebResponse ServicResponse = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(ServicResponse.GetResponseStream()))
                {
                    MemoryStream mStream = new MemoryStream();
                    XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
                    XmlDocument document = new XmlDocument();

                    try
                    {
                        //reading stream    
                        string ServiceResult = rd.ReadToEnd();

                        // load the response into the document
                        document.LoadXml(ServiceResult);

                        // Indent the content of the XML document
                        writer.Formatting = Formatting.Indented;

                        // Write the XML into a formatting XML writer
                        document.WriteContentTo(writer);
                        writer.Flush();
                        mStream.Flush();

                        // Have to rewind the MemoryStream in order to read
                        // its contents.
                        mStream.Position = 0;

                        // Read MemoryStream contents into a StreamReader.
                        StreamReader sReader = new StreamReader(mStream);

                        // Extract the text from the StreamReader.
                        string formattedXml = sReader.ReadToEnd();

                        //writting stream result on console    
                        Console.WriteLine(formattedXml);
                        Console.ReadLine();
                    }
                    catch (XmlException)
                    {
                        // Handle exception
                    }
                    mStream.Close();
                    writer.Close();
                }
            }
        }
        
        // Convert the bool  variable variables if true=1 else 0
        public int convertedBoolForUpdateUser(bool boolVar)
        {
            // Convert bool to int 0 or 1
            int convertedBool = boolVar ? 1 : 0;

            return convertedBool;
        }


        public HttpWebRequest CreateSOAPWebRequest()
        {
            // Instantiate an object of class credentials
            Credentials Obj = new Credentials();

            //Making Web Request    
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@Obj.GetWsdlURL()+"usermanagement.asmx");

            //SOAPAction    
            Req.Headers.Add(@"SOAPAction:"+Obj.GetSoapActionURL()+"UpdateUser");

            //Content_type    
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";

            //HTTP method    
            Req.Method = "POST";

            //return HttpWebRequest    
            return Req;
        }
    }
}
