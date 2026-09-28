# VelocityRush — Code Showcase

This guide highlights the parts of the repository that are most useful for a technical/recruiter review.

## 1. Vehicle Gameplay

### `CarController.cs`
Core vehicle gameplay code. This is one of the primary files to review for the implementation of vehicle movement and race controls using Unity's vehicle physics systems.

Related supporting scripts include camera following and engine/audio behaviour.

## 2. Race Progression

### `LapController.cs`
Handles race/lap progression and contributes to the overall racing state.

### `CheckpointSingle.cs`
Represents individual checkpoints used by the race progression system.

### `CheckpointRespawnPointController.cs`
Supports checkpoint-based vehicle recovery/respawning so the player can return to a valid point on the track.

Together these scripts demonstrate a multi-component race progression system rather than a single monolithic controller.

## 3. Multiplayer Architecture

VelocityRush uses Photon PUN for its multiplayer layer. The networking flow covers:

```text
Photon Connection
      ↓
Room Creation / Joining
      ↓
Lobby & Ready State
      ↓
Player Setup
      ↓
Network Vehicle Spawning
      ↓
Multiplayer Race State
```

The multiplayer/player-setup code is particularly relevant because local and remote vehicles require different control behaviour: the local player receives gameplay control while opponent vehicles remain network-driven.

## 4. Vehicle Combat & Power-Ups

### `EmpController.cs`
Implements EMP-related vehicle effects.

### `EmpPowerup.cs`
Handles collection/activation state associated with the EMP gameplay mechanic.

### `HealthPowerup.cs`
Provides vehicle health recovery through the collectible/power-up system.

### `HealthBar.cs`
Provides health-state feedback for the vehicle combat system.

Additional nitro and shield scripts extend the same gameplay architecture with acceleration and defensive mechanics.

## 5. Supporting Vehicle Systems

### `CameraFollow.cs`
Supports the racing camera behaviour.

### `CarEngineSoundController.cs`
Connects vehicle behaviour to engine audio feedback.

These are supporting systems rather than the main architectural focus, but they show integration between gameplay state and player feedback.

## Recommended Review Order

For a quick technical review:

1. `CarController.cs`
2. Multiplayer/network manager and player-setup scripts
3. `LapController.cs`
4. `CheckpointRespawnPointController.cs`
5. `EmpController.cs` / `EmpPowerup.cs`
6. Health, nitro, and shield gameplay scripts

## What This Project Demonstrates

- Unity C# gameplay programming
- Photon PUN multiplayer integration
- Local vs. remote player control separation
- Vehicle physics and Wheel Collider usage
- Race/checkpoint progression
- Respawn and recovery systems
- Power-up and combat mechanics
- Multi-script gameplay architecture
