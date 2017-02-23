using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DreamVault.Model;

namespace DreamVaultTest
{
    [TestClass]
    public class ModelTests
    {
        #region ' Tag Tests '

        [TestMethod]
        public void TagToFullString_NoSubTags()
        {
            var tag = new Tag("Foo");
            var result = tag.ToFullString();
            Assert.AreEqual("Foo", result);
        }

        [TestMethod]
        public void TagToFullString_OneSubtag()
        {
            var tag = new Tag("Foo");
            tag.AddSubtag("Bar");
            var result = tag.ToFullString();
            Assert.AreEqual("Foo (Bar)", result);
        }

        [TestMethod]
        public void TagToFullString_ThreeSubtags()
        {
            var tag = new Tag("Foo");
            tag.AddSubtag("Bar");
            tag.AddSubtag("Echo");
            tag.AddSubtag("Bravo");
            var result = tag.ToFullString();
            Assert.AreEqual("Foo (Bar, Echo, Bravo)", result);
        }

        [TestMethod]
        public void TagHasSubtag_NoSubtags()
        {
            var tag = new Tag("Foo");
            var result = tag.HasSubtag("bar");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TagHasSubtag_OneSubtag()
        {
            var tag = new Tag("Foo");
            tag.AddSubtag("Bar");
            var result = tag.HasSubtag("bar");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TagHasSubtag_ThreeSubtags_True()
        {
            var tag = new Tag("Foo");
            tag.AddSubtag("Bar");
            tag.AddSubtag("Echo");
            tag.AddSubtag("Bravo");
            var result = tag.HasSubtag("ECHO");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TagHasSubtag_ThreeSubtags_False()
        {
            var tag = new Tag("Foo");
            tag.AddSubtag("Bar");
            tag.AddSubtag("Echo");
            tag.AddSubtag("Bravo");
            var result = tag.HasSubtag("Bars");
            Assert.IsFalse(result);
        }

        #endregion
    }
}
