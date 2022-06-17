using System;

public class Credentials
{
    // This is the CWS application URL
    public const string WsdlURL = "http://extdev6win10/CWS/";  
    public string GetWsdlURL()
    {
        return WsdlURL;
    }


    public const string SoapActionURL = "http://corridor.aero/cws/";
    public string GetSoapActionURL()
    {
        return SoapActionURL;
    }

    private const string AliasName = "QA12c_V11_UC_1";
    public string GetAliasName()
    {
        return AliasName;
    }

    // Please provide the API username to login
    private const string LoginID = "cati";
    public string GetLoginID()
    {
        return LoginID;
    }

    // Please provide the API user password
    private const string LoginPassword = "PgacdE"; 
    public string GetLoginPassword()
    {
        return LoginPassword;
    }


}
