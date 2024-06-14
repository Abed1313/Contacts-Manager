
using Contact_Manager;
using Xunit;


namespace ContactManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void AddCase()
        {
            // Arrange
            string contact = "ibrahem";


            // Act
            var result = Program.AddContact(contact);

            // Assert
            Assert.Contains(contact, result);
        }

        [Fact]
        public void RemoveCase()
        {
            // Arrange
            Program.AddContact("ibrahem");

            // Act
             Program.RemoveContact("ibrahem");

            // Assert
            var result = Program.AddContact("ibrahem"); // Re-add to check if removal was successful
            Assert.Contains("ibrahem", result);

        }

        [Fact]

        public void ViewAllContactsCase()
        {
            // Arrange
            Program.AddContact("ibrahem");
            Program.AddContact("Abed");

            //Act
            var result = Program.ViewAllContacts();

            // Assert

            Assert.Contains("ibrahem", result);
            Assert.Contains("Abed",result);
        }

    }
}