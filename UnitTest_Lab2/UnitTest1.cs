using Lab2_Test;

namespace UnitTest_Lab2;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Lab2_Test.LabTask task = new LabTask();
        Assert.AreEqual(1, task.Euclid(56, 15));
        Assert.AreNotEqual(2, task.Euclid(56, 15));
    }
}