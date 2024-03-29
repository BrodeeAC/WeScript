﻿using System;
namespace DeadByDaylight
{
    public class Offsets

    {

        public static Int64 GObjects = 0x9D37A20;
        public static Int64 GNames = 0x9CEBC40;
        public static Int64 UWorld = 0x9EBB210;

        public class UE
        {
            public class UWorld
            {
                public static Int64 PersistentLevel = 0x38; // class ULevel*
                public static Int64 NetworkManager = 0x60; // class AGameNetworkManager*
                public static Int64 OwningGameInstance = 0x198; // class UGameInstance*
            }

            public class ULevel
            {
                public static Int64 AActors = 0xA0;
                public static Int64 AActorsCount = 0xA8;
            }

            public class UdbdPlayer
            {
                public static Int64 _interactionHandler = 0x08E8;

            }

            public class UGameInstance
            {
                public static Int64 LocalPlayers = 0x40;
            }

            public class UPlayer
            {
                public static Int64 PlayerController = 0x38;
                public static Int64 CurrentNetSpeed = 0x40;
            }

            public class APlayerController
            {
                public static Int64 AcknowledgedPawn = 0x2B8;
                public static Int64 PlayerCameraManager = 0x2D0;
            }

            public class AController
            {
                public static Int64 PlayerState = 0x238;
                public static Int64 Pawn = 0x268;
                public static Int64 Character = 0x278;
                public static Int64 TransformComponent = 0x280;
                public static Int64 ControlRotation = 0x2A0;
            }

            public class APawn
            {
                public static Int64 PlayerState = 0x250;
                public static Int64 Controller = 0x268;
                public static Int64 Health = 0x830;
                public static Int64 MaxHealth = 0x850;
            }

            public class AGCharacter
            {
                public static Int64 SpectatorCount = 0x1CE0;
            }

            public class APlayerState
            {
                public static Int64 PlayerId = 0x234;
                public static Int64 Ping = 0x238;
                public static Int64 UniqueId = 0x260;
                public static Int64 PlayerNamePrivate = 0x318;
                public static Int64 Team = 0x372;
                public static float Score = 0x230;
            }

            public class AKSTeamState
            {
                public static Int64 r_TeamNum = 0x220;
            }

            public class AActor
            {
                public static Int64 Instigator = 0x0128;
                public static Int64 RootComponent = 0x140;
                public static Int64 _outlineComponent = 0x240;
            }

            public class ACharacter
            {
                public static Int64 Mesh = 0x290;
                public static Int64 CharacterMovement = 0x298;
            }

            // from ACharacter to here
            public class UCharacterMovementComponent
            {
                public static Int64 GravityScale = 0x160;
                public static Int64 JumpZVelocity = 0x168;
                public static Int64 MaxWalkSpeed = 0x19C;
                public static Int64 MaxWalkSpeedCrouched = 0x1A0;
                public static Int64 MaxSwimSpeed = 0x1A4;
                public static Int64 MaxFlySpeed = 0x1A8;
                public static Int64 MaxAcceleration = 0x1B0;
            }

            public class USceneComponent
            {
                public static Int64 BoundsOrigin = 0x100; // vec3
                public static Int64 BoundsExtended = 0x10C; // vec3
                public static Int64 BoundsRadius = 0x118; // float
                public static Int64 RelativeLocation = 0x134; //0x118 for some reason // struct FVector
                public static Int64 RelativeRotation = 0x140; // struct FRotator
                public static Int64 ComponentVelocity = 0x158; // struct FVector
            }

            public class UStaticMeshComponent
            {
                public static Int64 ComponentToWorld = 0x1E0; //Bone Array
                public static Int64 StaticMesh = 0x490; // class UStaticMesh*
            }

            public class USkinnedMeshComponent
            {
                public static Int64 SkeletalMesh = 0x478; // class USkeletalMesh*
                public static Int64 bDisplayBones = 0x61E; // Bool
                public static Int64 bRecentlyRendered = 0x61F; // Bool
                public static Int64 CachedWorldSpaceBounds = 0x4A0; // FTransform 450 / 470 (0x00F8) MISSED OFFSET
            }

            public class USkeletalMesh
            {
                public static Int64 Skeleton = 0x68; // class USkeleton*
            }

            public class USkeleton
            {
                public static Int64 BoneTree = 0x40; // TArray<struct FBoneNode>
                public static Int64 VirtualBoneGuid = 0x178; // struct FGuid
                public static Int64 VirtualBones = 0x188; //TArray<struct FVirtualBone>
            }

            public class APlayerCameraManager
            {
                public static Int64 TransformComponent = 0x238; // class USceneComponent*
                public static Int64 CameraCachePrivate = 0x1A70; // struct FCameraCacheEntry
                public static Int64 CurrentFov = 0x1A98; // float
                public static Int64 AnimCameraActor = 0x2698; // class ACameraActor*
            }

            public class UPlayerInteractionHandler
            {
                public static Int64 _skillCheck = 0x02D8; // class UPlayerInteractionHandler / class USkillCheck* 
            }
        }
    }

    public class Managers
    {
        public static Int64 EntityList = 0;
        public static Int32 EntityListSize = 0;
        public static Int64 LocalPlayer = 0;

        public class Base
        {
            public static Int64 GWorld = 0;
            public static Int64 PersistentLevel = 0;
            public static Int64 OwningGameInstance = 0;
            public static Int64 LocalPlayers = 0;
            public static Int64 PlayerController = 0;
            public static Int32 PlayerID = 0;
        }

        public class DBD
        {
            public static bool IsDisplayed = false;
            public static float currentProgress = 0;
            public static float startSuccessZone = 0;
        }
    }

}
