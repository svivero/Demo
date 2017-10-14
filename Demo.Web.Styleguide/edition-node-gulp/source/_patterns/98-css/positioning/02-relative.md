Relative positioning sets the position of an element relative to its original position.  The element's original width and height is **retained in document flow** and other elements behave as if it was in its original position.
```
.relative-blueBox {
    position: relative;
    top: 50px;
}
```
Note:
* The blue box moved 50px from the top of its ***original position*** ie of its container, instead of the body - like fixed would.
* The green box **does not** ignore its width and height - like fixed would.
