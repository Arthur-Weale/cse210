using System;

class Program
{
    static void Main(string[] args)
    {

        //To exceed requirements: The program also calculates and displays a "level" based on the player's score (one level per 1000 points). This little twist is meant to give users an extra sense of progress and reward making it feel a bit more like a game rather than just a goal tracker
        //Txt file is in Bin.
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}