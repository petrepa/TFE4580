# Occlusion in Augmented Reality

> Occlusion occurs when an object closer to the viewer obscures the view of objects further away along the line-of-sight

Errors of occlusion ruin the feeling of presence

> The goal of AR is to enhance a user's performance in handling task and increase the perception of the surrounding world with a seamless integraton between the real world and the virtual augmentation. 


### Categorized by what kind of object is hidden by what kind of 'occluder'
Most important issues in resolving occlsuion in AR scene is occlusion between virtual and real objects.

__Occlusion Detection__
Technique used to decide whether some objects overlap or not between the cirtual and real objects. If overlapping is detected, the system need to optimize rendering accordingly by not drawing what is not visible

1. Model-based approach
Take a 3D-model of the real objects directly from existing resources or re-model it using software. This approach is used when the actual encironemnt is easy and completely understood where compete 3D models of real objects can be obtained.
__Occlusion Handling__
