using System;
using CSharpCourse.AddDictionary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMobile {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            // Arrange/Act
            FakeIOutput output = new FakeIOutput();
            FakeITranslate dict = new FakeITranslate(output);
            dict.Translate(output);

            var expectingString = $"{nameof(ABBYYDict)} is translating";

            //Assert
            Assert.AreEqual(expectingString,output.fakeString);
        }
    }
}
