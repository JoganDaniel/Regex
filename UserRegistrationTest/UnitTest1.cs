using RegexOperations;
using RegexOperations.UserRegistrationSystem;

namespace UserRegistrationTest
{
    public class Tests
    {
        static string[] emails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };


        [Test]
        public void TestFirstName()
        {
            UserRegistration userReg = new UserRegistration();
            bool valid = userReg.ValidateName("Name");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidateName("yuvuy878");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestLastName()
        {
            UserRegistration userReg = new UserRegistration();
            bool valid = userReg.ValidateName("Name");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidateName("yuvuy878");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestMobile()
        {
            UserRegistration userReg = new UserRegistration();
            bool valid = userReg.ValidateMobile("91 8789653465");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidateMobile("76 876877");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestEmail()
        {
            UserRegistration userReg = new UserRegistration();
            bool valid = userReg.ValidateEmail("abc.uh@huasd.com.in");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidateEmail("abc@.uyagd.col");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestPassword()
        {
            UserRegistration userReg = new UserRegistration();
            bool valid = userReg.ValidatePassword("vvdcA876@fsd");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidatePassword("vuvcuy0SDc");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestSampleEmails()
        {
            UserRegistration userReg = new UserRegistration();
            foreach (string s in emails)
            {
                bool valid = userReg.ValidateEmail(s);
                Assert.IsTrue(valid);
            }
        }
    }
}