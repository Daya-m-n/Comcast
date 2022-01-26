using Comcast.GenericUtility;
using Comcast.ObjectRepository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.Tests.Organizations
{
    public class CreateOrganizationTest : BaseClass
    {
        [Test]
        public void CreateOrganization()
        {
            CSharpUtility csu = new CSharpUtility();
            
            HomePage hp=new HomePage(driver);
            hp.GetOrganizationsLink.Click();

            OrganizationsPage op=new OrganizationsPage(driver);
            op.GetCreateOrgImg.Click();

            CreateNewOrganizationsPage cnop=new CreateNewOrganizationsPage(driver);
            cnop.CreateOrganization("TYSS" + csu.GetRandomNumber());
            driver.Navigate().Refresh();
        }
    }
}
