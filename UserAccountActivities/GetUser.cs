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
    public class GetUser
    {

        public void getUser()
        {
            // create an object of class Credentials
            Credentials Cred = new Credentials();

            // create an object for Global variables class
            GlobalVariables GVar = new GlobalVariables();

            Console.WriteLine(" Getting user info ... \n");

            //Reading input values from console    
            Console.WriteLine("Enter UserName: ");
            GVar.Username = Convert.ToString(Console.ReadLine());       // Required

            //Calling InvokeService method    
            InvokeServiceGetUser(GVar.Username, Cred.GetAliasName(),Cred.GetLoginID(),Cred.GetLoginPassword());
        }
        
        public void InvokeServiceGetUser(string userName, string schema, string ApiUserName, string ApiUserPwd)
        {
            //Calling CreateSOAPWebRequest method    
            HttpWebRequest request = CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();

            // <?xml version=""1.0"" encoding=""utf-8""?>  

            //SOAP Body Request    
            SOAPReqBody.LoadXml(
                @"<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"" >
                    <soap:Body>
                      <GetUser xmlns=""http://corridor.aero/cws/"">
                            <userReference>
                                <AliasName>"+ schema + @"</AliasName>
                                <LoginID>"+ ApiUserName + @"</LoginID>
                                <LoginPassword>"+ ApiUserPwd + @"</LoginPassword>

                                <Username>" + userName + @"</Username>
                            </userReference>
                      </GetUser>
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


        public HttpWebRequest CreateSOAPWebRequest()
        {
            // Instantiate an object of class credentials
            Credentials Obj = new Credentials();

            //Making Web Request    
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"http://extdev6win10/CWS/usermanagement.asmx");

            //SOAPAction    
            Req.Headers.Add(@"SOAPAction:http://corridor.aero/cws/GetUser");

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
