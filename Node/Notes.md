Install node

check node version with node -v

global variables can be assigned to `global` e.g. `global.port`

`process.platform` can be used to check the OS

`process.env` can be used to access environment variables like `PATH`

`process.on(eventName,callback)` will allow you to add callbacks on events for example `process.on("exit",callback)` will allow you to run code when the program is about to close.

## Creating Events

Custom events can be created using `EventEmitter` like so:

```
import { EventEmitter } from "events";
// or const { EventEmitter } = require("events");

const eventEmitter = new EventEmitter();

eventEmitter.on("lunch", () => {
    console.log("It's food time.")
})

eventEmitter.emit("lunch")

```
