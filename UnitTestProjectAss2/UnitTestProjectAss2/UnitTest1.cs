using AuthenticationLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace UnitTestProjectAss2
{
    [TestFixture]
    public class UserAuthenticatorTests
    {
        private UserAuthenticator _userAuthenticator;

        [SetUp]
        public void Setup()
        {
            _userAuthenticator = new UserAuthenticator();
        }

        [Test]
        public void RegisterUser_ValidCredentials_ReturnsTrue()
        {

            string username = "Rojashree";
            string password = "password123";
            bool result = _userAuthenticator.RegisterUser(username, password);


            Assert.IsTrue(result);
        }

        [Test]
        public void LoginUser_ValidCredentials_ReturnsTrue()
        {

            string username = "Rojashree";
            string password = "password123";
            _userAuthenticator.RegisterUser(username, password);
            bool result = _userAuthenticator.LoginUser(username, password);

            Assert.IsTrue(result);
        }
    }
}