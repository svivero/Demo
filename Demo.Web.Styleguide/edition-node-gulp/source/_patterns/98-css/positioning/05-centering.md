Floating positions an element according to document flow, and then moves it to the far left or right as possible. Elements following a floated element will move up as far as possible.
```
Horizontal
.center-blueBox {
  margin: 0 auto;
}
```
```
Vertical
.center-greenBox {
  background: #5b8054;
  position: absolute;
  top: 50%;
  margin-top: -50px;
}
```
```
Vertical and Horizontal
.center-container{
  position: absolute;
  top: 50%;
  margin-top: -10px;
  width: 100%;
}
.center-blackBox {
  margin: 0 auto;
}
```
