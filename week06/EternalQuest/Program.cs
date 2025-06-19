//I added a mehthod to show player's title. They will get differnt titles when they reach specific scores. 
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalmanager = new GoalManager();
        goalmanager.start();
    }
}