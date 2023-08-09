using RegexOperations;
using RegexOperations.UserRegistrationSystem;

namespace UserRegistrationTest
{
    public class Tests
    {

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
    }
}