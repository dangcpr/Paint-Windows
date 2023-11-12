# Paint-Windows
 Knowledge base

> The core concept of the processing is to draw graphic objects
> 

## Technical details

- Design patterns: Singleton, Factory, Abstract factory, prototype
- Plugin architecture
- Delegate & event

## Core requirements (5 points)

- [x]  Dynamically load all graphic objects that can be drawn from external DLL files
- [x]  The user can choose which object to draw
- [x]  The user can see the preview of the object they want to draw
- [x]  The user can finish the drawing preview and their change becomes permanent with previously drawn objects
- [ ]  The list of drawn objects can be saved and loaded again for continuing later
    
    You must save in your own defined binary format
    
- [x]  Save and load all drawn objects as an image in bmp/png/jpg format (rasterization). Just one format is fine. No need to save in all three formats.

## Basic graphic objects

- [x]  Line: controlled by two points, the starting point, and the endpoint
- [x]  Rectangle: controlled by two points, the left top point, and the right bottom point
- [x]  Ellipse: controlled by two points, the left top point, and the right bottom point

## Improvements (Choose and propose as you wish)

- [ ]  Allow the user to change the color, pen width, stroke type (dash, dot, dash dot dot..._
- [ ]  Adding text to the list of drawable objects
- [x]  Adding image to the canvas
- [ ]  Reduce flickering when drawing preview by using buffer to redraw all the canvas
    
    Upgrade: Only redraw the needed region, no fullscreen redraw
    
- [ ]  Adding Layers support
- [ ]  Select a single element for editing again
    
    Transforming horizontally and vertically
    
    Rotate the image
    
    Drag & Drop
    
- [x]  Zooming
- [ ]  Cut / Copy / Paste
- [x]  Undo, Redo
- [ ]  Fill color by boundaries
- [ ]  Anything that you think is suitable
