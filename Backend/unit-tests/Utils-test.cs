namespace WebApp;
public class UtilsTest(Xlog Console)
{
    // [Fact]
    // // A simple initial example
    // public void TestSumInt()
    // {
    //     Assert.Equal(12, Utils.SumInts(7, 5));
    //     Assert.Equal(-3, Utils.SumInts(6, -9));
    // }

    // [Fact]
    // public void TestCreateMockUsers()
    // {
    //     // Read all mock users from the JSON file
    //     var read = File.ReadAllText(FilePath("json", "mock-users.json"));
    //     Arr mockUsers = JSON.Parse(read);
    //     // Get all users from the database
    //     Arr usersInDb = SQLQuery("SELECT email FROM users");
    //     Arr emailsInDb = usersInDb.Map(user => user.email);
    //     // Only keep the mock users not already in db
    //     Arr mockUsersNotInDb = mockUsers.Filter(
    //         mockUser => !emailsInDb.Contains(mockUser.email)
    //     );
    //     // Get the result of running the method in our code
    //     var result = Utils.CreateMockUsers();
    //     // Assert that the CreateMockUsers only return
    //     // newly created users in the db
    //     output.WriteLine($"The test expected that {mockUsersNotInDb.Length} users should be added.");
    //     output.WriteLine($"And {result.Length} users were added.");
    //     output.WriteLine("The test also asserts that the users added " +
    //         "are equivalent (the same) to the expected users!");
    //     Assert.Equivalent(mockUsersNotInDb, result);
    //     output.WriteLine("The test passed!");
    // }

    [Theory]
    [InlineData ("abcD9!12", true)]
    [InlineData ("abcD#9!12", true)]
    [InlineData ("abc9!122", false)]
    [InlineData ("abc9!12", false)]
    [InlineData ("ABCD9!12", false)]
    public void TestIsPasswordGoodEnough(string password, bool excpeted)
    {
        Assert.Equal(excpeted, Utils.IsPasswordGoodEnough(password));
    }

    // [Theory]
    // [InlineData("hello", "[****]", "[****]o")]
    // [InlineData("hello", "[****]", "hello")]
    // [InlineData("Hi you are an ass hole", "[****]", "Hi you are an [****] hole")]
    // [InlineData("Hi, how are you?", "[****]", "Hi, how are you?")]
    // public void RemoveBadWordsAlt(string text, string censor, string expected)
    // {
    //     var result = Utils.RemoveBadWordsAlt(text, censor);
    //     Assert.Equal(expected, result);
    // }

}