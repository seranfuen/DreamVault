using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DreamVault.Helper;

namespace DreamVaultTest
{
    [TestClass]
    public class HelperTests
    {
        #region ' CollectionExtension Tests '

        [TestMethod]
        public void CollectionIsNullOrEmpty_Null()
        {
            List<string> testValue = null;
            var result = testValue.IsNullOrEmpty();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollectionIsNullOrEmpty_NoElements()
        {
            List<string> testValue = new List<string>();
            var result = testValue.IsNullOrEmpty();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollectionIsNullOrEmpty_HasElements()
        {
            List<string> testValue = new List<string>()
            {
                "One",
                ""
            };
            var result = testValue.IsNullOrEmpty();
            Assert.IsFalse(result);
        }

        #endregion
    }
}
