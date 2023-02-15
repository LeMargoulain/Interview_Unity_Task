# Interview Unity task

This git was created for a unity exercise given for an internship interview at Fraunhofer.

## Content of the project

### Scene

The unity scene of this project contains a plan, a cube and a sphere.<br>
The sphere is orbiting around the cube.<br>
To interact with the scene, you can either click on the cube to change its color to a random one or click anywhere on the plan to change the location of the cube.

### Scripts

This unity project contains the three scripts as follow:

#### *ChangeColor*

On click, change the color of the game object this script was given to and to another object given as parameter.<br>
In this scene, the script was applied to the cube with the sphere as a parameter.

#### *MooveOnClick*

Moove the location of the object this script was given to to the location clicked. In order for it to work, make sure the object is a NavMeshAgent and the location is on a NavMesh.
In this scene, the script was applied to the cube (NavMeshAgent) and it can moove on the plane (NavMesh).

#### *Orbit*

This script permit to an object to become the centre of the orbit of another object put in parameter. You can also change the orbital speed (degrees per second) and the axis.<br>
In this scene, the script was applied to the cube, the center of the orbit and took the sphere as an orbital. By default, the sphere turn around the cube on the y axis at a speed of 30 degres per second.

## Run the project

In order to run this unity project, you can simply launch the .exe ***InterviewTask*** in the ***Executable*** folder if you are on a Windows x64 architecture. If not, you might need to build the scene in unity.

