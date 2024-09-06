# VR
 Frogger VR exergame_Jump-activated button version
## Description

This VR exergame is designed based on the Unity game engine and VR device Meta Quest 3, which is used to train players' upper and lower limbs and increase players' physical activity. The focus of the game is to gamify the form of exercise, engaging the player in physical activity. The approach is to map the player's body movement to the movement in the game, combining gameplay with player ability.

## Features

- Buttons control movements.
- Interactive environment.
- Multiple levels of difficulty.

## Installation

To run this project, you need to have Unity installed on your system.

1. Clone the repository or download the source code.
2. Open Unity Hub and add the project.
3. Select the project from Unity Hub to open it in Unity Editor.
4. In the Building Setiting, transfrom Windows to Andrioid environment.
5. In the Window-> Packager Manager->Unity Registry, find and download XR Plugin Management and Oculus XR Plugin.
6. In the Window->Asset Store, find and download Meta XR All-in-One SDK.
7. From https://github.com/oculus-samples/Unity-Movement, download Movement SDK
8. Once configue the environment in Unity and then connect Quest device, you can run the game by pressing the Play button in the editor.

## Usage

Instructions

[TODO: Instructions on game rules in the start scene, access different levels within limited time, etc.]

## Key Scripts

- `KeyboardController`: Button and Movements manager.
- 'GameManager': Update the game state.
- 'RemainingLife': LoseLife(), every time player loses one life, decrease lives and restart the current scene.

## Environment

Unity: 2022.3.25f1



