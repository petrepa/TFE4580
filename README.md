<h1 align="center">
  Measuring Quality of Experience  <br>
  using Augmented Reality 
  in Training Systems
</h1>

<h4 align="center">TFE4580<br>Electronic Systems Design and Innovation, Specialization Project</h4>

<p align="center">
  <a href="#description">Description</a> •
  <a href="#installation">Installation</a> •
  <a href="#more-info">More Info</a> •
  <a href="#contributors">Contributors</a>
</p>

This repository contains the specialization project done by Peter Remøy Paulsen, the fall of 2020, as a part of his masters degree in electronical engineering. 

We took a deeper look into realism in AR, and tried to figure out what the level of occlusion has to say for the Quailty of Experience for the user in an augmented reality system. 

[Complete report can be found here.](https://github.com/petrepa/TFE4580/blob/master/TFE4580_peterrp_final_report.pdf)

## Description
To test if occlusion can have anything to say, we built an augemnted reality app using Unity and ARCore.
<p align="center">
   <img src="https://i.imgur.com/OMncFvb.png" width="600"/>
</p>

In the app the participants exposed of either environment 1 or environment 2

| **Environment**      | **Description**           |
|----------------------|---------------------------|
| Environment 1        | Occlusion algorithm component from ARCores API **enabled**, so that the environment is able to capture depth data and occlude virtual objects in the real world |
| Environment 2        | Occlusion algorithm component **disabled**. No dapth data captured. Virtual objects will float above real objects. |


**In action:**

Environemnt 1          |  Environmnet 2
:-------------------------:|:-------------------------:
![](https://github.com/petrepa/TFE4580/blob/master/readmes/media/env_1_compressed.gif)  |  ![](https://github.com/petrepa/TFE4580/blob/master/readmes/media/env_2_compressed.gif)

## Installation
### Pre-compiled APK
The pre-compiled APK can be found in the [releases](https://github.com/petrepa/TFE4580/releases).

### Compile on your own
You can compile the project on you own in Unity. Download the project and import the project to you Unity installation

#### Git Clone
**HTTPS**:
```
git clone https://github.com/petrepa/TFE4580.git
```
or **SSH**:
```
git clone git@github.com:petrepa/TFE4580.git
```


## More info
Can be found in the [Wiki](https://github.com/petrepa/TFE4580/wiki)
## Contributors
* Researcher and Developer: Peter Remøy Paulsen 👨‍🎓
* Supervisor: [Andrew Perkis](https://www.ntnu.edu/employees/andrew.perkis) 👨‍🏫
    * Co-supervisor: [Shafaq Irshad](https://www.ntnu.edu/employees/shafaq.irshad) 👩‍🏫

---
## Further documentation needed for:
* Experimental Application Overview
    * With GIFs demonstrating anything
* TL;DR of report
    * But should link the entire report
* Data analysis
    * The Jupyter Notebook
* Casual notes
    * The wiki
