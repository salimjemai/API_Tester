using System;

public class Credentials
{
    public const string WsdlURL = "http://vulcan/CWS/";  
    public string GetWsdlURL()
    {
        return WsdlURL;
    }

    public const string SoapActionURL = "http://SAOPActionURL";
    public string GetSoapActionURL()
    {
        return SoapActionURL;
    }

    private const string AliasName = "Enter_your_schema_here";
    public string GetAliasName()
    {
        return AliasName;
    }

    private const string LoginID = "CorridorAPIUser";
    public string GetLoginID()
    {
        return LoginID;
    }

    private const string LoginPassword = "CorridorAPIPassword"; 
    public string GetLoginPassword()
    {
        return LoginPassword;
    }


}
