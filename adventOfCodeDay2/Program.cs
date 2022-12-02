string[] lines = System.IO.File.ReadAllLines(@"C:\Users\chris\source\repos\advent1\advent1\TextFile2.txt");
int total = 0;
static int calculateScore(char opp, char you)
{
    var score = 0;
    score += checkSymbol(you);
    score += checkWin(opp, you);
    if (opp == you) { score += 3; }
    return score;
}
static int checkWin(char opp, char you)
{
    if (opp == 'A' && you == 'Y' || opp == 'B' && you == 'Z' || opp == 'C' && you == 'X')
    {
        return 6;
    }
    return 0;
}
static int checkSymbol(char input)
{
    if (input == 'X' || input == 'A')
    {
        return 1;
    }
    if (input == 'Y' || input == 'B')
    {
        return 2;
    }
    return 3;
}
//// part 2 ////
static int makeDraw(char opp)
{
    return 3 + checkSymbol(opp);
}
static int makeLoss(char opp)
{
    if (opp == 'A')
    {
        return 3;
    }
    if (opp == 'B')
    {
        return 1;
    }
    return 2;
}
static int makeWin(char opp)
{
    if (opp == 'A')
    {
        return 8;
    }
    if (opp == 'B')
    {
        return 9;
    }
    return 7;
}
foreach (var line in lines)
{
    char opp = Convert.ToChar(line.Substring(0, 1));
    char you = Convert.ToChar(line.Substring(2, 1));

    if (you == 'X')
    {
        total += makeLoss(opp);
    }
    else if (you == 'Y')
    {
        total += makeDraw(opp);
    }
    else
    {
        total += makeWin(opp);
    }
    //total += calculateScore(opp, you);
}
Console.WriteLine(total);