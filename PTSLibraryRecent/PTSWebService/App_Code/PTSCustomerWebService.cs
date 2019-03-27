using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using PTSLibraryRecent;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    private CustomerFacade facade;

    public Service()
    {
        //uncomment the following line if using designed components
        //InitializeComponent();
        facade = new CustomerFacade();
    }

    [WebMethod]
    public int Authenticate(string username, string password)
    {
        return facade.Authenticate(username, password);
    }
    [WebMethod]
    public Project[] GetlistOfProjects(int customerId)
    {
        return facade.GetListOfProjects(customerId);
    }
}
