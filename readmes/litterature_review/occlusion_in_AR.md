# Occlusion in Augmented Reality

> Occlusion occurs when an object closer to the viewer obscures the view of objects further away along the line-of-sight

Errors of occlusion ruin the feeling of presence

> The goal of AR is to enhance a user's performance in handling task and increase the perception of the surrounding world with a seamless integraton between the real world and the virtual augmentation. 


## Categorized by what kind of object is hidden by what kind of 'occluder'
Most important issues in resolving occlsuion in AR scene is occlusion between virtual and real objects.

__Occlusion Detection__
Technique used to decide whether some objects overlap or not between the cirtual and real objects. If overlapping is detected, the system need to optimize rendering accordingly by not drawing what is not visible

### 1. Model-based approach
Take a 3D-model of the real objects directly from existing resources or re-model it using software. This approach is used when the actual encironemnt is easy and completely understood where compete 3D models of real objects can be obtained.

[18]'s Ar image guided surgical system occluded based on the assumption that when a real object can be detected in front of a virtual object, then it is in front of all other virtual objects.


[31] used a model-based approach which involves a movable and deformable object. Single main camera for tracking purposes. Using a background subtraction algorithm, the silhouette of the object is then carved into this volume by using an additional camera and its 3D information is used for handling occlusions.
Drawbacks:
- Viewpoint and lighting must remain fixed
- Objects must have color and texture
- Holes in the bounding volume --> Virtual object will be seen through the real one

We can conclude that the model-based approach requires a computer graphic model of real objects obtained in advance. The approach is appropriate for a simple encironment that does not involve complex real objects. The significant error which gives an impact ont he operating results of occlusion can be seen. 

### 2. Depth-based Approach
Tries to resolve occlusion for unknown real objects, so called dynamic occlusion handling.
Nothing is known about the shape, size or position of an occluding object. 

This approach often uses stereo camera technique, where one uses images capture from 2 or more cameras to capture the depth image. Depth images can also be accomplushed with monocular vision using one camera

## Notes
The last table showing considerations regarding occlusion and model- vs depth-based approach is good to look at.
