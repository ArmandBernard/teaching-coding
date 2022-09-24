# Purpose

To explain how a webpage can be changed with scripts.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [Foreword](#foreword)
- [Some key concepts](#some-key-concepts)
  - [The document object](#the-document-object)
- [Finding Elements](#finding-elements)
  - [By id](#by-id)
  - [Advanced selectors](#advanced-selectors)
    - [Selector examples](#selector-examples)
- [Navigating the DOM](#navigating-the-dom)
- [Element attributes](#element-attributes)
  - [Getting attributes](#getting-attributes)
  - [Setting attributes](#setting-attributes)

# Foreword

While there are better ways to change a webpage's content than using pure JavaScript (i.e. no extra libraries or frameworks), this is the original and most rudimentary way to do this.

If you are going to be creating complex, dynamic pages that have to hold information client-side, you're better of using a JavaScript framework like React or Angular.

# Some key concepts

When you are using pure JavaScript to modify the DOM, there are a few things you need to be familiar with.

## The document object

the [`document`](https://developer.mozilla.org/en-US/docs/Web/API/Document) object is available to you in javascript.

It represents the page, and allows you to find, modify and create elements.

It also allows you to find out stuff that is currently happening in the page and add event listeners.

# Finding Elements

To be able to change an element, you first have to find it.

The document object provides functions to query the page for elements with specific property values.

## By id

A common way to find an element is be looking for its id.

An example part of a webpage may look like this:

```html
<body>
  ...
  <div id="username">(replace with the user's name!)</div>
  ...
</body>
```

The above `div` can be easily selected by using

```js
document.getElementById("username");
```

as it has an id.

Similar functions exist for selecting by className or tag (e.g. `<body>`).

## Advanced selectors

When id's are not feasible or you need to restrict the found elements further, you can use the `querySelector`s.

The `document`'s `querySelector()` or `querySelectorAll()` functions allow you to find one or more elements matching specific criteria.

The syntax is the same as for [CSS selectors](https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_Selectors).

### Selector examples

All buttons in the page

```js
const elements = document.querySelectorAll("button");
```

The first element with class "my-class"

```js
const element = document.querySelector(".my-class");
```

The first input element with a `class` of `password-field` inside another element which has a `class` of `login-form`.

```js
const element = document.querySelector(".login-form input.password-field");
```

# Navigating the DOM

You can also get its parent and children, allowing you to navigate the DOM.

As the DOM is a tree structure, there is only ever one parent to a given element, if any, but there it can have several children.

```html
<body>
  <div name="parent">
    <div name="me">
      <div name="child 1"></div>
      <div name="child 2"></div>
    </div>
    <div name="sibling"></div>
  </div>
</body>
```

The parent will be the element in the DOM that contains the selected one. It can be accessed with `element.parentElement`.

if there are any children, they can be gotten with `element.children`.

The next element after ours can be gotten with `element.nextSibling`.

# Element attributes

Once an element has been found, you can access its attributes.

## Getting attributes

For example, you can get its `id` with `element.id`, see if its hidden with `element.hidden` etc.

Less common or custom attributes (such as `data-bind`) can be gotten with

```js
element.getAttribute("data-bind");
```

For style related attributes, such as colour, use the style property.

e.g.

```js
const elementColor = element.style.color;
```

## Setting attributes

You can also set the same attributes you get.

Most can be set using the `=` setting syntax e.g.

```js
element.hidden = true;
```

but for more custom named attributes you can use

```js
element.setAttribute("data-bind");
```
