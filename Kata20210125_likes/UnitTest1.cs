using System;
using NUnit.Framework;

namespace Kata20210125_likes
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //var nama = "dustin";
        }

        [Test]
        public void NoLikes()
        {
            var actual = new Kata().Likes( new string[0]);

            Assert.AreEqual("no one likes this", actual);
        }

        [Test]
        public void LikesOnePerson()
        {
            var actual = new Kata().Likes(new string[] {"Peter"});

            Assert.AreEqual("Peter likes this", actual);
        }

        [Test]
        public void LikesTwoPersons()
        {
            var actual = new Kata().Likes(new string[] { "Jacob", "Alex" });

            Assert.AreEqual("Jacob and Alex like this", actual);
        }

        [Test]
        public void LikesThreePersons()
        {
            var actual = new Kata().Likes(new string[] { "Max", "John", "Mark" });

            Assert.AreEqual("Max, John and Mark like this", actual);
        }

        [Test]
        public void LikesMoreThanFourPersons()
        {
            var actual = new Kata().Likes(new string[] { "Alex", "Jacob", "Mark", "Max" });

            Assert.AreEqual("Alex, Jacob and 2 others like this", actual);
        }
    }

    public class Kata
    {
        public string Likes(string[] person)
        {
            int personNum = person.Length;
            string likePerson = "";
            
            //根據數量選擇對應結果
            switch (personNum)
            {
                case 0:
                    likePerson = "no one likes this";
                    break;
                case 1:
                    likePerson = person[0] + " likes this";
                    break;
                case 2:
                    likePerson = person[0] + " and " + person[1] + " like this";
                    break;
                case 3:
                    likePerson = person[0] +", " + person[1] + " and " + person[2] + " like this";
                    break;
                default:
                    likePerson = person[0] + ", " + person[1] + " and " + (personNum-2) + " others like this";
                    break;
            }

            return likePerson;
        }
    }
}