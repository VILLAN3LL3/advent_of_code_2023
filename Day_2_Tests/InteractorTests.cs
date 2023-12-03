﻿namespace Day_2_Tests;

[TestFixture]
public class InteractorTests
{
    [Test]
    public void Test_CalculateIdSumOfPossibleGamesForGivenBag() {
        var bag = new Bag(12, 14, 13);
        var result = Interactor.CalculateIdSumOfPossibleGamesForGivenBag(bag, "TestInputData.txt");
        result.Should().Be(8);
    }
}
