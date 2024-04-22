using HomeWork9;

namespace TestLoginManager
{
    public class TestLoginManager
    {
        [Theory(DisplayName = "Test login and password")]
        [InlineData("aaaaaa", "1f", "1f")]
        [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","ssssssssssssssssssssssssssss","ssssssssssssssss")]
        [InlineData(null,"ssssssssssssssssssssssssssss","ssssssssssssssss")]
        [InlineData("sdsdsd",null,"ssssssssssssssss")]
        [InlineData("","ssssssssssssssssssssssssssss","ssssssssssssssss")]
        [InlineData("aaaaaa","ssssssssssssssssssssssssssss","ssssssssssssssss")]
        [InlineData("aaaaaa","12345","12345")]
        [InlineData("aaaaaa","1234","12345")]
        [InlineData("aaaaaa","12341","12345")]
        [InlineData("aaaaaa","1","1")]
        [InlineData("aaaaaa","12","12")]
        [InlineData("aaaaaa","1s","1s")]
        [InlineData("aaaaaa","1ss1","1ss1")]
        
        public void GeneralTest(string login, string password, string confirmPassword)
        {
            var actual = LoginManager.ConfirmerLogin(login, password, confirmPassword);
            Assert.True(actual);
        }

        [Theory(DisplayName = "Test login and password")]
        [InlineData("aaaaaa", "1f", "1f", true)]
        [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "ssssssssssssssssssssssssssss", "ssssssssssssssss", false)]
        [InlineData(null, "ssssssssssssssssssssssssssss", "ssssssssssssssss", false)]
        [InlineData("sdsdsd", null, "ssssssssssssssss", false)]
        [InlineData("", "ssssssssssssssssssssssssssss", "ssssssssssssssss", false)]
        [InlineData("aaaaaa", "ssssssssssssssssssssssssssss", "ssssssssssssssss", false)]
        [InlineData("aaaaaa", "12345", "12345", true)]
        [InlineData("aaaaaa", "1234", "12345", false)]
        [InlineData("aaaaaa", "12341", "12345", false)]
        [InlineData("aaaaaa", "1", "1", true)]
        [InlineData("aaaaaa", "12", "12", true)]
        [InlineData("aaaaaa", "1s", "1s", true)]
        [InlineData("aaaaaa", "1ss1", "1ss1", true)]

        public void TestXpectations(string login, string password, string confirmPassword, bool expected)
        {
            var actual = LoginManager.ConfirmerLogin(login, password, confirmPassword);
            Assert.Equal(expected, actual);
        }

        [Theory(DisplayName = "Test login and password")]
        [InlineData("aaaaaa", "1f", "1f")]
        [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "ssssssssssssssssssssssssssss", "ssssssssssssssss")]
        [InlineData(null, "ssssssssssssssssssssssssssss", "ssssssssssssssss")]
        [InlineData("sdsdsd", null, "ssssssssssssssss")]
        [InlineData("", "ssssssssssssssssssssssssssss", "ssssssssssssssss")]
        [InlineData("aaaaaa", "ssssssssssssssssssssssssssss", "ssssssssssssssss")]
        [InlineData("aaaaaa", "12345", "12345")]
        [InlineData("aaaaaa", "1234", "12345")]
        [InlineData("aaaaaa", "12341", "12345")]
        [InlineData("aaaaaa", "1", "1")]
        [InlineData("aaaaaa", "12", "12")]
        [InlineData("aaaaaa", "1s", "1s")]
        [InlineData("aaaaaa", "1ss1", "1ss1")]

        public void NegativeTest(string login, string password, string confirmPassword)
        {
            var actual = LoginManager.ConfirmerLogin(login, password, confirmPassword);

            Assert.False(actual);
        }
    }
}
