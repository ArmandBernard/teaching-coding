import express = require("express");

// port to host on
const port = process.env.PORT || 3000;
const app = express();

app.use(express.static("public"));

// create a page endpoint for the index.html file
app.get("/", async (_, res) => {
  // send the index.html file to the client
  res.sendFile("../public/index.html");
});

// get express to listen on the port, and tell the user what port we're using
app.listen(port, () =>
  console.log(`Go to http://localhost:${port} to see the webpage!`)
);
