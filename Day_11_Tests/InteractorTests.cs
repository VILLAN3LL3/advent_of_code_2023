using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_11_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [TestCase(2, 374)]
        [TestCase(10, 1030)]
        [TestCase(100, 8410)]
        public void Test_CalculateSumOfShortestPathsBetweenAllGalaxies(int expansionFactor, int expectedDistance) {
            var result = Interactor.CalculateSumOfShortestPathsBetweenAllGalaxies("TestInputData.txt", expansionFactor);
            result.Should().Be(expectedDistance);
        }
    }
}