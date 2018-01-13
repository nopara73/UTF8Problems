using System;
using System.Text;
using Xunit;

namespace UTF8Problems
{
    public class UnitTest1
    {
        [Fact]
        public void CanEncode()
        {
            var character = "é";
            var encoded = Encoding.UTF8.GetBytes(character);

            var bytes = new byte[] { 195, 169 };

            Assert.Equal(bytes, encoded);
        }

        [Fact]
        public void CanDecode()
        {
            var character = "é";

            var bytes = new byte[] { 195, 169 };
            var decoded = Encoding.UTF8.GetString(bytes);
            
            Assert.Equal(character, decoded);
        }

        [Fact]
        public void CanEncodeDecode()
        {
            var character = "é";
            var encoded = Encoding.UTF8.GetBytes(character);

            var decoded = Encoding.UTF8.GetString(encoded);

            Assert.Equal(character, decoded);
        }
    }
}
