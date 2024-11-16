using Plaxground;

namespace PlaygroundTests;

public class ClassUnderTestTests
{
    [Test]
    public void AddTest()
    {
        var result = new ClassUnderTest().Add(1,1);
        Assert.That(result, Is.EqualTo(2));
    }
}
