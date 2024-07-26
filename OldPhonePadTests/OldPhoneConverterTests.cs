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
        [TestMethod]
        public void TestConvertOldPhoneNumbers()
        {
            string input1 = "222 22 2#";
            string input2 = "8 88777444666*664#";
            string input3 = "";
            OldPhoneConverter phoneObj = new OldPhoneConverter();
            Assert.AreEqual(phoneObj.ConvertOldPhoneNumbers(input1), "CBA");
            Assert.AreEqual(phoneObj.ConvertOldPhoneNumbers(input2), "TURING");
            Assert.AreEqual(phoneObj.ConvertOldPhoneNumbers(input3), "");

        }
    }
}

