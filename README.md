# AltairCA.Blazor.WebAssembly.Cookie

AltairCA.Blazor.WebAssembly.Cookie is a Cookie manager for blazor webassembly.


## setup

### NuGet install:

`Install-Package AltairCA.Blazor.WebAssembly.Cookie`

### Program.cs

```c#
builder.Services.AddAltairCACookieService(options =>
{
    options.DefaultExpire = TimeSpan.FromMinutes(15);
});
```

### Example of use

#### Inject Service
```c#
@inject IAltairCABlazorCookieUtil _cookieUtil;
```
#### Basic Usage Example 1
```c#
await _cookieUtil.SetValueAsync("cookieName", "value");
```

#### Basic Usage Example 2
```c#
await _cookieUtil.SetValueAsync("a", "a",path:"/",domain:"localhost",secure:true);
```

#### Basic Usage Example 3
```c#
await _cookieUtil.SetValueAsync(key: "b", value: "a",span:TimeSpan.Zero);
```