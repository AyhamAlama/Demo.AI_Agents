namespace Demo.AI_Agents.Utilities;

public class AppConfiguration
{
    private static IConfiguration Configuration =>
     new ConfigurationBuilder().AddUserSecrets<AppConfiguration>().Build();

    private static string GetSecret(string key) => Configuration[key] ?? throw new Exception("Key not found");

    public static string GitHubToken => GetSecret("GITHUB_TOKEN");

    public static string GitHubEndpoint => GetSecret("GIT_HUB_END_POINT");
}