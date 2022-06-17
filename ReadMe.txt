/****************************************************************************************
Summary: This is a console app that will prompt the user to select what method/Action to 
perform such as Add a user, Edit user info, Change User passwor and Get user info.

****************************************************************************************/

Before starting the App, few steps needs to be performed.

1- Navigate to the Credentials class
2- Update the WSDL URL like this format "http://ServerName/CWS/"
	Note: No need to include the "usermanagement.asmx" at the end of the WSDL URL, 
	because it is appended in the code
3- Update the Soap Action URL can be found in the SOAP sample request
	a. Open a web browser
	b. Enter the your WSDL URL in the address bar (i.e http://ServerName/CWS/usermanagement.asmx)
	c. You will be presented with a list of method used by the API
	d. Click on one of them (i.e AddUser)
	e. You will be presented with a sample SOAP request and response
	f. Look at the first 5 lines in the header of the sample
	   The SOAPAction should look like this: "http://corridor.aero/cws/AddUser"
	Note: Your SOAP Action URL should exlude the method "AddUser", because it is appended at every class
4- Update the schema Alias (must be valid)
5- Update user name (must be a valid corridor user)
6- Update the user password (this password must be encrypted), the password will be provided by DevOps

Note: Most of the unused variables are defaulted for false(bool)/Empty(string), they can be updated
in the GlobalVariables class or call the variable's setter methor to set a new value.