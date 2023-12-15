using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_11_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_CalculateSumOfShortestPathsBetweenAllGalaxies() {
            var result = Interactor.CalculateSumOfShortestPathsBetweenAllGalaxies("TestInputData.txt");
            result.Should().Be(374);
        }
    }
}