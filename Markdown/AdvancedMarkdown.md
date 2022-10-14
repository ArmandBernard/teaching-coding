# Purpose

To go over some of the more complex / niche things you can do with Markdown.

Note that not all features here will be supported by every Markdown renderer.

See [this page](https://www.markdownguide.org/extended-syntax/) for more information.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [Using HTML](#using-html)

# Using HTML

Markdown will allow you to write static HTML in your Markdown. Most of the time, there is no need to do this, however, you may want to do this to do some extra formatting markdown does not natively support.

Naturally, scripts in your HTML will most likely not be run, as this is a security issue, and some Markdown renderers may not render the HTML correctly at all.

```html
<div style="display: flex; justify-content: space-between">
    <span style="color: firebrick">Red left</span>
    <span style="color: dodgerblue ">Blue right</span>
</div>
```

<div style="display: flex; justify-content: space-between">
    <span style="color: firebrick">Red left</span>
    <span style="color: dodgerblue ">Blue right</span>
</div>
