# Purpose

To explain the Program and/or Startup files of a WebAPI project.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [Simplified vs Program.Main style](#simplified-vs-programmain-style)
- [Steps to building the application](#steps-to-building-the-application)

# Simplified vs Program.Main style

Since .NET 6, this will be in the simplified style.

```c#
var builder = WebApplication.CreateBuilder(args);

...

app.Run();
```

The typical `Program.Main` style would instead look like this:

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ...

        app.Run();
    }
}
```

These will run identically.

# Steps to building the application

Services, configuration and middle-wares are added to the program using builders.

The following steps are completed in

1. The web application builder is created

```c#
var builder = WebApplication.CreateBuilder(args);
```

2. Any services are added

```c#
builder.Services.AddControllers();
...
```

3. The app is built

```c#
var app = builder.Build();
```

Then the app is configured

```c#

app.UseHttpsRedirection();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        "default",
        "{controller=Home}/{action=Index}");
});
...

```

4. The app is run

```c#
app.Run();
```
