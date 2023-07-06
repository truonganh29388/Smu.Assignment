namespace Smu.Assignment.Manager.Tests
{
    public class ShapeDrawerTests
    {
        [Theory]
        [InlineData("square")]
        [InlineData("Square")]
        [InlineData("SQUARE")]
        [InlineData("triangle")]
        [InlineData("Triangle")]
        [InlineData("TRIANGLE")]
        public void Draw_Should_Return_Not_Null_Value(string shape)
        {
            //Arrange
            var drawer = new ShapeDrawer();
            var size = new Random().Next(0, 100);

            //Act
            var result = drawer.Draw(shape, size);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Draw_Should_Return_Null()
        {
            //Arrange
            var shape = RandomString(new Random().Next(1, 10));
            while (shape.Equals("square", StringComparison.OrdinalIgnoreCase) || shape.Equals("triangle", StringComparison.OrdinalIgnoreCase))
            {
                shape = RandomString(new Random().Next(1, 10));
            }
            var drawer = new ShapeDrawer();
            var size = new Random().Next(0, 100);

            //Act
            var result = drawer.Draw(shape, size);

            //Assert
            Assert.Null(result);
        }

        private string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}