# Purpose

To explain what markdown is and what it can be used for.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [What is Markdown?](#what-is-markdown)
- [Basic Syntax](#basic-syntax)
  - [Headers](#headers)

# What is Markdown?

According to https://daringfireball.net/projects/markdown/:

_Markdown is a text-to-HTML conversion tool for web writers_

What this means in practice is that it allows you to format text for the web in a way that is more human-readable than HTML.

It is great for writing rich documentation for things like wiki pages without a fancy editor like Microsoft Word and without having to switch between keyboard and mouse, making it very efficient for writers.

It has become a popular standard amongst software developers, and its syntax is supported on many platforms. 

Much of its basic syntax is supported on messaging apps like Discord and Slack, and GitHub supports all of its native features plus extra.

Almost all of the documentation you see in this project is written in Markdown!

You can recognize a Markdown file by its `.md` extension.

# Basic Syntax

Here I will highlight the most common pieces of syntax you will likely want to use with Markdown.

## Headers

Headers can be done by adding a `#` (hash) at the start of a line, with the number of hashes indicating the header level. More hashes means a lower heading level.

Input:
```
# Heading 1
## Heading 2
### Heading 3
```

Output:

(I have used an image here because otherwise it would mess with my table of contents)

![Headings](images/Headings.png)
