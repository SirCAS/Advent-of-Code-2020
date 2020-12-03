using NUnit.Framework;

namespace Day03.Test
{
    public class RoutePlannerTests
    {
        private readonly string[] _input = {
            "..##.......",
            "#...#...#..",
            ".#....#..#.",
            "..#.#...#.#",
            ".#...##..#.",
            "..#.##.....",
            ".#.#.#....#",
            ".#........#",
            "#.##...#...",
            "#...##....#",
            ".#..#...#.#"
        };
        
        [TestCase(1, 1, 2)]
        [TestCase(3, 1, 7)]
        [TestCase(5, 1, 3)]
        [TestCase(7, 1, 4)]
        [TestCase(1, 2, 2)]
        public void CountTreesTest(int right, int down, int expectedTreeCount)
        {
            // Arrange
            var screenBuffer = new ScreenBuffer(_input);
            var routePlanner = new RoutePlanner(screenBuffer);

            // Act
            var treeCount = routePlanner.CountTrees(new SlopeModel { Right = right, Down = down });
            
            // Assert
            Assert.That(treeCount, Is.EqualTo(expectedTreeCount));
        }

        [Test]
        public void MultiplyTreeCountsTest()
        {
            // Arrange
            var screenBuffer = new ScreenBuffer(_input);
            var routePlanner = new RoutePlanner(screenBuffer);

            var slopes = new[]
            {
                new SlopeModel {Right = 1, Down = 1},
                new SlopeModel {Right = 3, Down = 1},
                new SlopeModel {Right = 5, Down = 1},
                new SlopeModel {Right = 7, Down = 1},
                new SlopeModel {Right = 1, Down = 2},
            };
            
            // Act
            var treeCount = routePlanner.MultiplyTreeCounts(slopes);
            
            // Assert
            Assert.That(treeCount, Is.EqualTo(336));
        }
    }
}