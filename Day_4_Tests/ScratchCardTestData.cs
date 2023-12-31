﻿namespace Day_4_Tests;

public static class ScratchCardTestData
{
    public static string ScratchCardInputLine1 => "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
    public static string ScratchCardInputLine2 => "Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19";
    public static string ScratchCardInputLine3 => "Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1";
    public static string ScratchCardInputLine4 => "Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83";
    public static string ScratchCardInputLine5 => "Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36";
    public static string ScratchCardInputLine6 => "Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11";

    public static string[] TestInputData => [
        ScratchCardInputLine1,
        ScratchCardInputLine2,
        ScratchCardInputLine3,
        ScratchCardInputLine4,
        ScratchCardInputLine5,
        ScratchCardInputLine6,
    ];

    public static List<ScratchCardWithCopies> TestScratchCardsWithCopies => [
        new ScratchCardWithCopies(ScratchCard1, 1),
        new ScratchCardWithCopies(ScratchCard2, 2),
        new ScratchCardWithCopies(ScratchCard3, 4),
        new ScratchCardWithCopies(ScratchCard4, 8),
        new ScratchCardWithCopies(ScratchCard5, 14),
        new ScratchCardWithCopies(ScratchCard6, 1),
    ];

    public static ScratchCard ScratchCard1 => new()
    {
        CardId = 1,
        WinningNumbers = [41, 48, 83, 86, 17],
        UserNumbers = [83, 86, 6, 31, 17, 9, 48, 53],
    };

    public static ScratchCard ScratchCard2 =>  new()
    {
        CardId = 2,
        WinningNumbers = [13, 32, 20, 16, 61],
        UserNumbers = [61, 30, 68, 82, 17, 32, 24, 19],
    };

    public static ScratchCard ScratchCard3 =>  new()
    {
        CardId = 3,
        WinningNumbers = [1, 21, 53, 59, 44],
        UserNumbers = [69, 82, 63, 72, 16, 21, 14, 1],
    };

    public static ScratchCard ScratchCard4 => new()
    {
        CardId = 4,
        WinningNumbers = [41, 92, 73, 84, 69],
        UserNumbers = [59, 84, 76, 51, 58, 5, 54, 83],
    };

    public static ScratchCard ScratchCard5 => new()
    {
        CardId = 5,
        WinningNumbers = [87, 83, 26, 28, 32],
        UserNumbers = [88, 30, 70, 12, 93, 22, 82, 36],
    };

    public static ScratchCard ScratchCard6 => new()
    {
        CardId = 6,
        WinningNumbers = [31, 18, 13, 56, 72],
        UserNumbers = [74, 77, 10, 23, 35, 67, 36, 11],
    };

    public static List<ScratchCard> TestScratchCards => [
        ScratchCard1,
        ScratchCard2,
        ScratchCard3,
        ScratchCard4,
        ScratchCard5,
        ScratchCard6,
    ];
}
