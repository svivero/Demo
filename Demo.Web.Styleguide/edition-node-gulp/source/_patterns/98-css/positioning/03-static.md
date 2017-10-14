---
title: Static
---
**Static** positioning is the default behavior of elements.
```
.static-blueBox {
    position: static;
    top: 100px;
}
```
Note:
- blueBox does not move 100px because top is ignored when position is static.

===============================

**Inherited** positioning tells an element to inherit its positioning from its parent element.

===============================

**Z-index** controls the vertical stacking order of elements. Elements must have a set positioning for z-index to work.
```
.static-blueBox {
    position: static;
    z-index: -1;    
}
```
Note:
- The blue box is now behind green because of z-index -1
