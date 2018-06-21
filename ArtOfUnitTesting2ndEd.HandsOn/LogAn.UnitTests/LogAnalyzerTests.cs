using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer
                .IsValidLogFileName("filewithbadextension.foo");
            Assert.False(result);
        }

        [TestCase("filewithgoodextension.slf")]
        [TestCase("filewithgoodextension.SLF")]
        public void IsValidLogFileName_ValidExtension_ReturnsTrue(string filename)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer
                .IsValidLogFileName(filename);
            Assert.True(result);
        }
    }
}
