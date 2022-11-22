namespace ClassLibrary1Mindbox.TestProject1
{
    public class TriangleUnitTest1
    {
        [Fact]
        public void isFigureRealTest1()
        {
            double[] sides = { 0, 0, 0 }; 
            Figure figure = new Triangle(sides);

            Assert.False(figure.isFigureReal());
        }
    }
    public class DiskUnitTest1
    {
        [Fact]
        public void isFigureRealTest1()
        {
            Figure figure = new Disk(0);

            Assert.False(figure.isFigureReal());
        }
    }
}