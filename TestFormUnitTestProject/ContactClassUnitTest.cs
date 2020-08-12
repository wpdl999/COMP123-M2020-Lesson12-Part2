using NUnit.Framework;
using COMP123_M2020_Lesson12_Part2;

namespace TestFormUnitTestProject
{
    public class ContactClassUnitTest
    {
        [SetUp]
        public void Setup()
        {
            // Arrange
        }

        [Test]
        public void TestContactClassExists()
        {
            // Act 
            Contact contact = new Contact();

            // Assert
            Assert.IsInstanceOf(typeof(Contact), contact);
        }

        [Test]
        public void TestContactClassFirstNameIsString()
        {
            // Act
            Contact contact = new Contact();
            contact.FirstName = "Tom";

            // Assert
            Assert.IsInstanceOf(typeof(string), contact.FirstName);
        }

        [Test]
        public void TestContactClassLastNameIsString()
        {
            // Act
            Contact contact = new Contact();
            contact.LasttName = "Smith";

            // Assert
            Assert.IsInstanceOf(typeof(string), contact.LasttName);
        }

        [Test]
        public void TestContactClassEmailAddressIsString()
        {
            // Act
            Contact contact = new Contact();
            contact.EmailAddress = "tom@example.com";

            // Assert
            Assert.IsInstanceOf(typeof(string), contact.EmailAddress);
        }

        [Test]
        public void TestContactClassContactNumberIsString()
        {
            // Act
            Contact contact = new Contact();
            contact.ContactNumber = "4165555555";

            // Assert
            Assert.IsInstanceOf(typeof(string), contact.ContactNumber);
        }

        [Test]
        public void TestSaysHelloMethodReturnsAppropriateString()
        {
            // Act
            Contact contact = new Contact();
            contact.FirstName = "Tom";
            contact.LasttName = "Smith";
            contact.EmailAddress = "tom@example.com";
            contact.ContactNumber = "4165555555";

            // Assert
            Assert.AreEqual($"{contact.FirstName} says Hello!", contact.saysHello());
        }
    }
}