using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        WindowsPrincipal winPrin = new WindowsPrincipal(WindowsIdentity.GetCurrent());
        return "" +
            "User.Identity.Name =                  " + Context.User.Identity.Name + "\r\n" +
            "User.Identity.AuthenticationType =    " + Context.User.Identity.AuthenticationType + "\r\n" +
            "User.Identity.IsAuthenticated =       " + Context.User.Identity.IsAuthenticated.ToString() + "\r\n" +
            "WindowsPrincipal.Identity.name =      " + winPrin.Identity.Name + "\r\n" +
            "WindowsPrincipal.AuthenticationType = " + winPrin.Identity.AuthenticationType + "\n\n";
    }
    
}