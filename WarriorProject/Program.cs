/*
 * A feladat a github-on olvasható!
 */

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace WarriorProject
{
    public class Position
    {
        private int _x;
        private int _y;

        public int X { get => _x; set { _x = value; } }
        public int Y { get => _y; set { _y = value; } }

        public Position(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        public void ToConsole()
        {
            Console.WriteLine($"({X},{Y})");
        }
    }
    public class Warrior
    {
        private Position p;
        private string _name;
        
        public Warrior(string name, Position position) 
        {
            this._name = name;
            this.p = position;
        }
        public void ToConsole()
        {
            Console.WriteLine($"{_name}, position ({p.X},{p.Y})");
        }
        public void MoveHorizontal(int distance)
        {
            p.X += distance;
        }
        
        public void MoveVertical(int distance)
        {
            p.Y += distance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}
