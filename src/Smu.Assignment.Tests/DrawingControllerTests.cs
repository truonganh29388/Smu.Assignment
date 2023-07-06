using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Smu.Assignment.Controllers;
using Smu.Assignment.Manager;
using Smu.Assignment.Models.Requests;

namespace Smu.Assignment.Tests
{
    public class DrawingControllerTests
    {
        [Fact]
        public async Task DrawSquare_Should_Return_BadRequest_If_Validation_Failed()
        {
            //Arrange
            var request = new SquareDrawingRequest();
            var mockShapeDrawer = new Mock<IShapeDrawer>();
            var errorMsg = Guid.NewGuid().ToString();

            var validationResult = new ValidationResult();
            validationResult.Errors.Add(new ValidationFailure("error", errorMsg));

            var mockValidator = new Mock<IValidator<SquareDrawingRequest>>();
            mockValidator.Setup(x => x.ValidateAsync(request, default)).ReturnsAsync(validationResult);

            var controller = new DrawingController(mockShapeDrawer.Object);

            //Act
            var result = await controller.DrawSquare(request, mockValidator.Object);

            //Assert
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Contains(errorMsg, (result as BadRequestObjectResult).Value as IEnumerable<string>);
            mockShapeDrawer.Verify(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>()), Times.Never());
        }

        [Fact]
        public async Task DrawSquare_Should_Return_Ok_If_Validation_Passed()
        {
            //Arrange
            var request = new SquareDrawingRequest();
            var expectedResult = Guid.NewGuid().ToString();

            var mockShapeDrawer = new Mock<IShapeDrawer>();
            mockShapeDrawer.Setup(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>())).Returns(expectedResult);

            var mockValidator = new Mock<IValidator<SquareDrawingRequest>>();
            mockValidator.Setup(x => x.ValidateAsync(request, default)).ReturnsAsync(new ValidationResult());

            var controller = new DrawingController(mockShapeDrawer.Object);

            //Act
            var result = await controller.DrawSquare(request, mockValidator.Object);

            //Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(expectedResult, (result as OkObjectResult).Value as string);
            mockShapeDrawer.Verify(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>()), Times.Once());
        }

        [Fact]
        public async Task DrawShapes_Should_Return_BadRequest_If_Validation_Failed()
        {
            //Arrange
            var request = new ShapeDrawingRequest();
            var mockShapeDrawer = new Mock<IShapeDrawer>();
            var errorMsg = Guid.NewGuid().ToString();

            var validationResult = new ValidationResult();
            validationResult.Errors.Add(new ValidationFailure("error", errorMsg));

            var mockValidator = new Mock<IValidator<ShapeDrawingRequest>>();
            mockValidator.Setup(x => x.ValidateAsync(request, default)).ReturnsAsync(validationResult);

            var controller = new DrawingController(mockShapeDrawer.Object);

            //Act
            var result = await controller.DrawShapes(request, mockValidator.Object);

            //Assert
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Contains(errorMsg, (result as BadRequestObjectResult).Value as IEnumerable<string>);
            mockShapeDrawer.Verify(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>()), Times.Never());
        }

        [Fact]
        public async Task DrawShapes_Should_Return_Ok_If_Validation_Passed()
        {
            //Arrange
            var request = new ShapeDrawingRequest();
            var expectedResult = Guid.NewGuid().ToString();

            var mockShapeDrawer = new Mock<IShapeDrawer>();
            mockShapeDrawer.Setup(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>())).Returns(expectedResult);

            var mockValidator = new Mock<IValidator<ShapeDrawingRequest>>();
            mockValidator.Setup(x => x.ValidateAsync(request, default)).ReturnsAsync(new ValidationResult());

            var controller = new DrawingController(mockShapeDrawer.Object);

            //Act
            var result = await controller.DrawShapes(request, mockValidator.Object);

            //Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(expectedResult, (result as OkObjectResult).Value as string);
            mockShapeDrawer.Verify(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>()), Times.Once());
        }

        [Fact]
        public async Task AdvancedDrawShapes_Should_Return_BadRequest_If_Validation_Failed()
        {
            //Arrange
            var request = new AdvancedShapeDrawingRequest();
            var mockShapeDrawer = new Mock<IShapeDrawer>();
            var errorMsg = Guid.NewGuid().ToString();

            var validationResult = new ValidationResult();
            validationResult.Errors.Add(new ValidationFailure("error", errorMsg));

            var mockValidator = new Mock<IValidator<AdvancedShapeDrawingRequest>>();
            mockValidator.Setup(x => x.ValidateAsync(request, default)).ReturnsAsync(validationResult);

            var controller = new DrawingController(mockShapeDrawer.Object);

            //Act
            var result = await controller.AdvancedDrawShapes(request, mockValidator.Object);

            //Assert
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Contains(errorMsg, (result as BadRequestObjectResult).Value as IEnumerable<string>);
            mockShapeDrawer.Verify(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>()), Times.Never());
        }

        [Fact]
        public async Task AdvancedDrawShapes_Should_Return_Ok_If_Validation_Passed()
        {
            //Arrange
            var request = new AdvancedShapeDrawingRequest();
            var expectedResult = Guid.NewGuid().ToString();

            var mockShapeDrawer = new Mock<IShapeDrawer>();
            mockShapeDrawer.Setup(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>())).Returns(expectedResult);

            var mockValidator = new Mock<IValidator<AdvancedShapeDrawingRequest>>();
            mockValidator.Setup(x => x.ValidateAsync(request, default)).ReturnsAsync(new ValidationResult());

            var controller = new DrawingController(mockShapeDrawer.Object);

            //Act
            var result = await controller.AdvancedDrawShapes(request, mockValidator.Object);

            //Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(expectedResult, (result as OkObjectResult).Value as string);
            mockShapeDrawer.Verify(x => x.Draw(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<char>()), Times.Once());
        }
    }
}