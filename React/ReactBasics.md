# Purpose

To explain what React is, and how to get started with it.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [What is React?](#what-is-react)
- [JSX (or TSX)](#jsx-or-tsx)
- [Components](#components)
- [State](#state)
  - [Explanation](#explanation)
  - [Using the `useState` hook](#using-the-usestate-hook)
  - [Caveats to using state](#caveats-to-using-state)

# What is React?

React is what is colloquially known as a front=end framework. It is used to make the process of making a responsive web-based application easier.

React detects changes in values in variables you set and rerenders only the parts of the interface that need changing.

# JSX (or TSX)

`JSX` is JavaScript code that intentionally looks like `HTML`.

You can mix code into `JSX` to have the content be dynamically calculated.

```jsx
...
<div>
  <h1>Hello and welcome to my webpage</h1>
  <p>This is page tells you the current local date and time.</p>
  Today's date is {new Date().toLocaleString()}
</div>
...
```

The date above is calculated on page load.

# Components

Components are pieces of a React webpage with integrated logic. A component's concerns are only to **render** itself and its **children** based on the changing **state** of the page.

A component is structured thus:

```jsx
// component is a function that can be passed data in the form of props and
// returns "HTML"-like JSX
function DateSentence(props) {
  // some logic to calculate the state of the component
  const todaysDate = new Date().toLocaleString();

  // return jsx which will be rendered
  return <div>Today's date is {todaysDate}</div>;
}
```

Essentially, a component:

1. Takes some `properties` (optional)
2. Does whatever calculations it needs to to figure out what to render in the page
3. Returns the page `JSX`

# State

State allows you to store the state of a component in a way that will cause the component to rerender efficiently when the state changes.

## Explanation

Say that you want a component to keep track of some data related to itself.

The first thought would be to store it in a variable. e.g.

```jsx
function Counter() {
  const counterValue = 0;

  return (
    <div>
      <div>Counter is at {counterValue}</div>
      <button
        onclick={() => {
          // will not work
          counterValue = counterValue + 1;
        }}
      >
        Add 1
      </button>
    </div>
  );
}
```

However because components are functions, after each render the value is lost.

You could store it in a constant outside the function:

```jsx
let counterValue = 0;

function Counter() {
  return (
    <div>
      <div>Counter is at {counterValue}</div>
      <button
        onClick={() => {
          // will not work
          counterValue = counterValue + 1;
        }}
      >
        Add 1
      </button>
      <button onClick={() => alert(counterValue)}>print counter value</button>
    </div>
  );
}
```

However, although the value of `counterValue` will change (you can check this by pressing the second print button), the value shown in the page will not.

That is because React does not know it needs to rerender the page. This is the wrong way to do it.

Instead, you should use the `state` feature of components to store data that will affect what is shown in the component.

## Using the `useState` hook

The `useState` hook allows you to create a new piece of `state` unique to the component that will trigger a (partial) rerender of the component when the value is updated.

A **hook** is a React function with some special rules around it. Lets leave that aside for now though.

The anatomy of a `useState` hook call is:

```js
const [myState, setMyState] = useState(initialValue);
```

The `myState` here is the current value of your piece of state. When you want to change the value, you need to use the **setter** function `setMyState` with the new value as its sole argument.

Usually, the nomenclature is more like this:

```jsx
setterFunction(newValue);
```

A rerender of the component will then be triggered and the component content will be updated.

Going back to the Counter example explored in [Explanation](#explanation), you could use state like this:

```jsx
function Counter() {
  // create a new piece of state with initial value of 0
  const [counterValue, setCounterValue] = useState(0);

  return (
    <div>
      <div>Counter is at {counterValue}</div>
      <button
        onClick={() => {
          // increment state value
          setCounterValue(counterValue + 1);
        }}
      >
        Add 1
      </button>
    </div>
  );
}
```

## Caveats to using state

When calling the setter, you should bear in mind that the new value **will take affect on next render**. Do not try to use value immediately after setting it, as it will not have been updated yet.

For example:

```jsx
function Counter() {
  // create a new piece of state with initial value of 0
  const [counterValue, setCounterValue] = useState(0);

  return (
    <div>
      <div>Counter is at {counterValue}</div>
      <button
        onClick={() => {
          // this will print the current value
          console.log(counterValue);

          // increment state value
          setCounterValue(counterValue + 1);

          // this will still give the old value!
          console.log(counterValue);
        }}
      >
        Add 1
      </button>
    </div>
  );
}
```
