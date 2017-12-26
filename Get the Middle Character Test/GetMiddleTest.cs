using Get_the_Middle_Character;
using NUnit.Framework;
using System;

[TestFixture]
public class GetMiddleTest
{
    [Test]
    public void GenericTests()
    {
        Assert.AreEqual("es", Kata.GetMiddle("test"));
        Assert.AreEqual("t", Kata.GetMiddle("testing"));
        Assert.AreEqual("dd", Kata.GetMiddle("middle"));
        Assert.AreEqual("A", Kata.GetMiddle("A"));
    }
}