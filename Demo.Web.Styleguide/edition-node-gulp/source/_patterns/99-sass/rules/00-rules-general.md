---
title: Rules
---
**Parent selector (&)**
```
a {
  text-decoration: none;
  &:hover {
    text-decoration: underline;
  }
}
// Results in
a { text-decoration: none; }
a:hover { text-decoration: underline; }
```

**Nested properties**
```
font: {
  family: Verdana, Helvetica, sans-serif;
  size: 14px;
}
// Results in
font-family: Verdana, Helvetica, sans-serif;
font-size: 14px;
```
