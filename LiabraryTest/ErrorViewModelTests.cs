using NUnit.Framework;
using BookShopAsp.Models;

namespace BookShopAsp.Tests.Models
{
    [TestFixture]
    public class ErrorViewModelTests
    {
        [Test]
        public void ErrorViewModel_ShowRequestId_ShouldReturnTrue_WhenRequestIdIsNotEmpty()
        {
            // Arrange
            var errorViewModel = new ErrorViewModell
            {
                RequestId = "123"
            };

            // Act
            var showRequestId = errorViewModel.ShowRequestId;

            // Assert
            Assert.That(showRequestId, Is.True);
        }

        [Test]
        public void ErrorViewModel_ShowRequestId_ShouldReturnFalse_WhenRequestIdIsNull()
        {
            // Arrange
            var errorViewModel = new ErrorViewModell
            {
                RequestId = null
            };

            // Act
            var showRequestId = errorViewModel.ShowRequestId;

            // Assert
            Assert.That(showRequestId, Is.False);
        }

        [Test]
        public void ErrorViewModel_ShowRequestId_ShouldReturnFalse_WhenRequestIdIsEmpty()
        {
            // Arrange
            var errorViewModel = new ErrorViewModell
            {
                RequestId = string.Empty
            };

            // Act
            var showRequestId = errorViewModel.ShowRequestId;

            // Assert
            Assert.That(showRequestId, Is.False);
        }
    }
}