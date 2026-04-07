using Xunit;
using Moq;
using studManagementAPI.Services;
using studManagementAPI.Repository;
using studManagementAPI.Models;



namespace studManagementAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetAllStudents_ReturnsList()
        {
            // Arrange
            var mockRepo = new Mock<IStudentRepository>();

            mockRepo.Setup(repo => repo.GetAll())
                    .ReturnsAsync(new List<Student>());

            var service = new StudentService(mockRepo.Object);

            // Act
            var result = await service.GetAll();

            // Assert
            Assert.NotNull(result);
        }
    }
}