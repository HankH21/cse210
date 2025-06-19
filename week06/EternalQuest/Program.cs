//I added a mehthod to show player's title. They will get differnt title when they reach a specific score. 
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalmanager = new GoalManager();
        goalmanager.start();
    }
}