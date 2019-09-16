using System;
using NUnit.Framework;
using restApi_Project.BasicLogic;
using TechTalk.SpecFlow;

namespace restApi_Project.RestFeatureSteps
{
    [Binding]
    public class BasicLogic
    {
        Logic obj = new Logic();


        [When(@"I register a new User with '(.*)' Username and '(.*)' Password")]
        public void WhenIRegisterANewUserWithUsernameAndPassword(string p0, string p1)
        {

            obj.Register(p0, p1);
        }
        
       [When(@"I register again new User with '(.*)' Username and '(.*)' Password")]
        public void WhenIRegisterAgainNewUserWithUsernameAndPassword(string p0, string p1)
        {
            obj.Register(p0, p1);
        }
        
        [When(@"user sends a request on Users")]
        public void WhenUserSendsARequestOnUsers()
        {
            obj.call();
            obj.Get_request();

        }

        [Then(@"registration is successful")]
        public void ThenRegistrationIsSuccessful()
        {
            Assert.IsTrue(obj.Valid());

        }

        [Then(@"token is generated")]
        public void ThenTokenIsGenerated()
        {
            Assert.IsTrue(obj.Valid());

        }

        [Then(@"registration is not successful")]
        public void ThenRegistrationIsNotSuccessful()
        {
            Assert.IsFalse(obj.Valid());

        }

        [Then(@"user will get list of users")]
        public void ThenUserWillGetListOfUsers()
        {
            Assert.IsTrue(obj.UserList());
        }
    }
}
