using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using WarriorProject;

namespace WarriorProject.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void TestPositionKonstrktor()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Position position = new Position(2, -1);
                expected = "(2,-1)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                position.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Position osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A Position->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Position->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestWarriorKonstrktor()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Position position = new Position(2, -1);
                Warrior warrior = new Warrior("Peter the Iron Man", position);
                expected = "Peter the Iron Man, position (2,-1)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                warrior.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Warrior osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A Warrior->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Warrior->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestWarriorMoveHorizontal()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Position position = new Position(2, -1);
                Warrior warrior = new Warrior("Peter the Iron Man", position);
                warrior.MoveHorizontal(5);
                expected = "Peter the Iron Man, position (7,-1)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                warrior.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Warrior osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A Warrior->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Warrior->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestWarriorMoveHorizontalNegativ()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Position position = new Position(2, -1);
                Warrior warrior = new Warrior("Peter the Iron Man", position);
                warrior.MoveHorizontal(-5);
                expected = "Peter the Iron Man, position (-3,-1)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                warrior.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Warrior osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A Warrior->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Warrior->ToConsole nem megfelően működik.");
        }


        [TestMethod()]
        public void TestWarriorMoveVertical()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Position position = new Position(2, -1);
                Warrior warrior = new Warrior("Peter the Iron Man", position);
                warrior.MoveVertical(5);
                expected = "Peter the Iron Man, position (2,4)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                warrior.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Warrior osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A Warrior->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Warrior->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestWarriorMoveVerticalNegativ()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Position position = new Position(2, -1);
                Warrior warrior = new Warrior("Peter the Iron Man", position);
                warrior.MoveVertical(-5);
                expected = "Peter the Iron Man, position (2,-6)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                warrior.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Warrior osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A Warrior->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Warrior->ToConsole nem megfelően működik.");
        }

    }
}