# Purpose

To explain how files can be interacted with in Node.js

# How to read

Files can be interacted with in synchronous and asynchronous ways using the fs module in Node.js.

```

import { promises as fsp } from "fs";
import { readFileSync } from "fs";

// synchronous
const txt = readFileSync("./hello.txt", "utf8");

// asynchronous
txt = await fsp.readFile("./hello.txt", "utf8");

```

Note that readFile exists on fs directly, but its a callback version.
