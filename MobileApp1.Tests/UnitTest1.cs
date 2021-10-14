using FluentAssertions;
using FluentAssertions.Execution;
using MobileApp1.ViewModels;
using NUnit.Framework;

namespace MobileApp1.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void AboutPageCtorWorks()
        {
            var aboutViewModel = new AboutViewModel();
            //fluent assertion
            using (new AssertionScope())
            {
                aboutViewModel.Title.Should().Be("About");
                aboutViewModel.Title.Length.Should().Be(5);
                aboutViewModel.Title.Should().BeEquivalentTo("about");

            }

        }
    }
}