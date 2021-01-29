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
}