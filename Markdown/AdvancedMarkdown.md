# Purpose

To go over some of the more complex / niche things you can do with Markdown.

Note that not all features here will be supported by every Markdown renderer.

See [this page](https://www.markdownguide.org/extended-syntax/) for more information.

To specifically see what GitHub supports, see [this spec](https://github.github.com/gfm/)

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [Using HTML](#using-html)
- [Tables](#tables)
- [Syntax highlighting](#syntax-highlighting)
    - [Code blocks with syntax highlighting](#code-blocks-with-syntax-highlighting)

# Using HTML

Markdown will allow you to write static HTML in your Markdown. Most of the time, there is no need to do this, however, you may want to do this to do some extra formatting markdown does not natively support.

Naturally, scripts in your HTML will most likely not be run, as this is a security issue, and some Markdown renderers may not render the HTML correctly at all.

```html
<div style="display: flex; justify-content: space-between">
    <span style="color: firebrick">Red left</span>
    <span style="color: dodgerblue">Blue right</span>
</div>
```

<div style="display: flex; justify-content: space-between">
    <span style="color: firebrick">Red left</span>
    <span style="color: dodgerblue">Blue right</span>
</div>

Depending on where you are viewing this, you may see the below intended look or something not quite the same.

![Expected HTML result](images/HtmlExpected.png)

GitHub for example is very restrictive on what it will show for security reasons. It will remove many properties including inline styles.

# Tables

Tables are a bit of a pain to type nicely, but extensions like [Markdown All in One](https://marketplace.visualstudio.com/items?itemName=yzhang.markdown-all-in-one) will automatically clean them up for you.

```
| Student  | Grade |
| -------- | ----- |
| Nicholas | A     |
| Fabien   | C     |
```

| Student  | Grade |
| -------- | ----- |
| Nicholas | A     |
| Fabien   | C     |

# Syntax highlighting

### Code blocks with syntax highlighting

GitHub and some IDE's will allow you to add language information to your code block. This will provide automatic syntax highlighting to the code with minimal effort, making it easier to read.

``````
```js
// code blocks are good for showing multiple lines of code
if (itNeedsDoing) {
    doIt()
}
```
``````

```js
// code blocks are good for showing multiple lines of code
if (itNeedsDoing) {
    doIt()
}
```