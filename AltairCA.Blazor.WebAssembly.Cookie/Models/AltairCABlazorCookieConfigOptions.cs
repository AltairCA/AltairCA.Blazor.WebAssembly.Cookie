namespace AltairCA.Blazor.WebAssembly.Cookie.Models;

public class AltairCABlazorCookieConfigOptions
{
    public TimeSpan DefaultExpire { get; set; } = TimeSpan.Zero;
    public string Path { get; set; } = "/";
    public string Domain { get; set; } = string.Empty;
    public bool IsSecure { get; set; } = false;
}