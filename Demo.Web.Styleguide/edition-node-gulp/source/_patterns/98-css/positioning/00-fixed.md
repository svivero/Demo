Fixed positioning ***fixes*** the position of an element ***relative to the browser window***.  The element always stays fixed in place, even when scrolling.
```
.blueBox {
    position: fixed;
    left: 150px;
}
```
Also, fixed positioning takes an element out of document flow, meaning the browser acts as if the element has no width and height, and the other elements on the page move up as if it was never there
