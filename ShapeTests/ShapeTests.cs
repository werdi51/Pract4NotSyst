using Xunit;

using GeometryShape;

namespace ShapeTests
{
    public class ShapeTests
    {

        const double width = 5;
        const double height = 5;
        [Theory]
        [InlineData (-11,10)]
        [InlineData(0, 2)]
        [InlineData(-11, -10)]
        [InlineData(18, -22)]
        [InlineData(18, 22)]



        public void CorrectArgumentTestsRectangle(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }


        [Theory]
        [InlineData(-5, 5, 5)]   
        [InlineData(0, 5, 5)]   
        [InlineData(15, 5, 5)]    
        [InlineData(1, 2, 3)]
        public void CorrectArgumentTestsTriangle(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void CalculateTestRectangle_Area()
        {
            double expectedArea = width * height;

            Rectangle rectangle = new(width, height);

            Assert.Equal(expectedArea, rectangle.Area());
        }
        [Fact]
        public void CalculateTestRectangle_Perimeter()
        {
            double expectedPerimeter = (width * 2) + (height * 2);

            Rectangle rectangle = new(width, height);

            Assert.Equal(expectedPerimeter, rectangle.Perimeter());
        }
    }
}
