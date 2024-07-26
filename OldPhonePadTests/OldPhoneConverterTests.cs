using OldPhonePad;
namespace OldPhonePadTests
{
    [TestClass]
    public class OldPhoneConverterTests
    {
        [TestMethod]
        public void TestIsValidInput()
        {
            string input1 = "222 22 2";
            string input2 = "227*#";
            OldPhoneConverter phoneObj = new OldPhoneConverter();
            phoneObj.isValidInput(input2);
            Assert.IsFalse(phoneObj.isValidInput(input1));
            Assert.IsTrue(phoneObj.isValidInput(input2));

        }
    }
}

