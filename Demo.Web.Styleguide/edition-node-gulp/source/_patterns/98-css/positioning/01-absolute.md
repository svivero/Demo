Absolute positioning takes an element out of document flow, meaning the browser acts as if the element has no width and height, and the other elements on the page move up as if it was never there (similar to fixed positioning). The difference is the position of the element is then fixed relative to the top level container, or ***the closest parent with a set positioning***.
```
.absolute-blueBox {
    position: absolute;
    left: 20px;
}
.absolute-container {    
    position: absolute;
    left: 50px;    
}
```
If ***position: absolute*** is removed from the container, then blueBox would position relative to the body.
Also, unlike fixed positioning the blueBox will not move during scroll.
