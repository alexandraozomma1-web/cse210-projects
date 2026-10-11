using System;


// CREATIVITY & EXCEEDING REQUIREMENTS:
// To exceed core requirements for 100%, I included to this program  a dynamic 
// "Rank / Leveling System" in the GoalManager interface. As the user accumulates 
// points from completing goals, their adventurer title automatically upgrades 
// (e.g., Novice Adventurer -> Journeyman -> Master Quest Champion) to keep 
// them motivated and engaged on their eternal quest!


class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the GoalManager controller and start the program loop
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}