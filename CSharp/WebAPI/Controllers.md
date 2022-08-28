# Purpose

To explain how a controller works and how it is structured.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [Controller Basics](#controller-basics)
  - [Controller Structure](#controller-structure)
- [Routing](#routing)
- [Action running steps](#action-running-steps)

# Controller Basics

Controllers are collections of endpoints that serve a distinct purpose.

A Controller has several **Actions**, these usually represent actions a user of the API will want to do.

For example, a `UserController` may have a `Create` action to create a new user.

Users will be able to navigate to an action using the route. See [Routing](#routing) for more information.

It may look something like this:

`https://localhost:3000/api/v1/ControllerName/ActionName`

When making a HTTPRequest to the above url, the action's code will be run.

## Controller Structure

A controller will look something like this:

```c#
// Controller
[ApiController]
[Route("api/[controller]")] // Route to controller
public class UsersController : ControllerBase
{
    // Constructor
    public WeatherForecastController(...)
    {
        ...
    }

    // GET: api/Users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserAndBasicStatsDto>>> GetUsers()
    {
        ...
    }

    // GET: api/Users/5
    [HttpGet("{id:int}")]
    public async Task<ActionResult<UserDto>> GetUser(int id) // parsed url params
    {
        ...
    }

    // DELETE: api/Users/Delete/5
    [HttpDelete("Delete/{id:int}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        ...
    }

    // POST: api/Users/Create
    [HttpPost("Create")]
    public async Task<IActionResult> PostUser([FromBody] UserDto userDto) // object pulled from body
    {
        ...
    }
}
```

Every public method in the controller apart from the constructor will (usually) be an Action.

# Routing

Routing to controller actions can be configured in many ways, but a typical example is:

`https://localhost:3000/api/v1/ControllerName/ActionName`

Usually, the "Controller" part of the controller name (e.g. WeatherForecast**Controller**) will be removed from the route.

The route to the controller can be customised in the Route attribute

```c#
[Route("api/[controller]")]
```

and the Action route and route parameters can be customised in the Http attributes

```c#
[HttpDelete("Delete/{id:int}")]
```

# Action running steps

When a HTTP request comes in, the following will happen.

1. If any authentication is necessary, this will happen first.
2. The request will be routed down to the appropriate action.
3. Any valid url parameters specified in the request url are parsed, and the valid ones are passed through the method arguments.
4. If there is a specified `[FromBody]` parameter, the body will be parsed to a JSON object of the specified type.
5. The code in the action will run. Available within the action code will be:
   - the above url parameters, if any
   - The request information, including HTTP headers
6. The code will return a HTTP response. This may include a serialized copy of an object.
7. The user receives this response and the transaction is over.
