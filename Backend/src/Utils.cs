namespace WebApp;
public static class Utils
{
    // Read all mock users from file
    private static readonly Arr mockUsers = JSON.Parse(
        File.ReadAllText(FilePath("json", "mock-users.json"))
    );

    // Read all bad words from file and sort from longest to shortest
    // if we didn't sort we would often get "---ing" instead of "---" etc.
    // (Comment out the sort - run the unit tests and see for yourself...)
    private static readonly Arr badWords = ((Arr)JSON.Parse(
        File.ReadAllText(FilePath("json", "bad-words.json"))
    )).Sort((a, b) => ((string)b).Length - ((string)a).Length);

    // public static bool IsPasswordGoodEnough(string password)
    // {
    //     return password.Length >= 8
    //         && password.Any(Char.IsDigit)
    //         && password.Any(Char.IsLower)
    //         && password.Any(Char.IsUpper)
    //         && password.Any(x => !Char.IsLetterOrDigit(x));
    // }

    // public static bool IsPasswordGoodEnoughRegexVersion(string password)
    // {
    //     // See: https://dev.to/rasaf_ibrahim/write-regex-password-validation-like-a-pro-5175
    //     var pattern = @"^(?=.*[0-9])(?=.*[a-zåäö])(?=.*[A-ZÅÄÖ])(?=.*\W).{8,}$";
    //     return Regex.IsMatch(password, pattern);
    // }

    // public static string RemoveBadWords(string comment, string replaceWith = "---")
    // {
    //     comment = " " + comment;
    //     replaceWith = " " + replaceWith + "$1";
    //     badWords.ForEach(bad =>
    //     {
    //         var pattern = @$" {bad}([\,\.\!\?\:\; ])";
    //         comment = Regex.Replace(
    //             comment, pattern, replaceWith, RegexOptions.IgnoreCase);
    //     });
    //     return comment[1..];
    // }

    // public static Arr CreateMockUsers()
    // {
    //     Arr successFullyWrittenUsers = Arr();
    //     foreach (var user in mockUsers)
    //     {
    //         // user.password = "12345678";
    //         var result = SQLQueryOne(
    //             @"INSERT INTO users(firstName,lastName,email,password)
    //             VALUES($firstName, $lastName, $email, $password)
    //         ", user);
    //         // If we get an error from the DB then we haven't added
    //         // the mock users, if not we have so add to the successful list
    //         if (!result.HasKey("error"))
    //         {
    //             // The specification says return the user list without password
    //             user.Delete("password");
    //             successFullyWrittenUsers.Push(user);
    //         }
    //     }
    //     return successFullyWrittenUsers;
    // }

     // public static Arr RemoveMockUsers()
    // {
    //     Arr usersInDb = SQLQuery("SELECT email FROM users");
    //     Arr emailsInDb = usersInDb.Map(user => user.email);
    //     Arr mockUsersInDb = mockUsers.Filter(mockUser => emailsInDb.Contains(mockUser.email));
    //     Arr deletedMockUsers = Arr();


    //     foreach (var user in mockUsersInDb)
    //     {
    //         SQLQueryOne("DELETE FROM users WHERE email = $email", user);
    //         deletedMockUsers.Push(user);
    //     }
    //     return deletedMockUsers;
    // }

    public static Obj CountDomainsFromUseremails()
    {
        Arr domains = SQLQuery("SELECT SUBSTRING(email, INSTR(email, '@') + 1) AS domain, COUNT(*) AS count FROM users GROUP BY SUBSTRING(email, INSTR(email, '@') + 1); ");
        Obj countedDomains = Obj();

        foreach (var domain in domains)
        {
            countedDomains[domain.domain] = domain.count;
        }
        return countedDomains;
    }

    // Now write the two last ones yourself!
    // See: https://sys23m-jensen.lms.nodehill.se/uploads/videos/2021-05-18T15-38-54/sysa-23-presentation-2024-05-02-updated.html#8
}