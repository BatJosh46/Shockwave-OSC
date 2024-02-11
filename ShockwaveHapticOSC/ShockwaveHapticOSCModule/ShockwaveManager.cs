#region Assembly ShockwaveManager, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// G:\avatar\avatars\pinkydaduck\haptics test\Assets\ShockwaveSDK\Plugins\ShockwaveManager.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class ShockwaveManager
{
    public enum ERROR_ENUM
    {
        NO_ERROR = 0,
        NATIVE_INIT_ERROR = 1,
        STEAMVR_INIT_ERROR = 2,
        STEAMVR_32BIT_ERROR = 4,
        SUIT_MISSING_ERROR = 8,
        SUIT_MISSING_WAIT_TIMEOUT = 0x10
    }

    public enum HapticGroup
    {
        ALL,
        HIP,
        WAIST,
        SPINE,
        CHEST,
        SHOULDERS,
        LEFT_ARM,
        LEFT_BICEP,
        LEFT_FOREARM,
        RIGHT_ARM,
        RIGHT_BICEP,
        RIGHT_FOREARM,
        LEFT_LEG,
        LEFT_THIGH,
        LEFT_LOWER_LEG,
        RIGHT_LEG,
        RIGHT_THIGH,
        RIGHT_LOWER_LEG,
        FRONT,
        HIP_FRONT,
        LEFT_HIP_FRONT,
        RIGHT_HIP_FRONT,
        WAIST_FRONT,
        LEFT_WAIST_FRONT,
        RIGHT_WAIST_FRONT,
        SPINE_FRONT,
        LEFT_SPINE_FRONT,
        RIGHT_SPINE_FRONT,
        CHEST_FRONT,
        LEFT_CHEST_FRONT,
        RIGHT_CHEST_FRONT,
        SHOULDERS_FRONT,
        LEFT_SHOULDER_FRONT,
        RIGHT_SHOULDER_FRONT,
        LEFT_ARM_FRONT,
        LEFT_BICEP_FRONT,
        LEFT_FOREARM_FRONT,
        RIGHT_ARM_FRONT,
        RIGHT_BICEP_FRONT,
        RIGHT_FOREARM_FRONT,
        LEFT_LEG_FRONT,
        LEFT_THIGH_FRONT,
        LEFT_SHIN,
        RIGHT_LEG_FRONT,
        RIGHT_THIGH_FRONT,
        RIGHT_SHIN,
        BACK,
        HIP_BACK,
        LEFT_HIP_BACK,
        RIGHT_HIP_BACK,
        WAIST_BACK,
        LEFT_WAIST_BACK,
        RIGHT_WAIST_BACK,
        SPINE_BACK,
        LEFT_SPINE_BACK,
        RIGHT_SPINE_BACK,
        CHEST_BACK,
        LEFT_CHEST_BACK,
        RIGHT_CHEST_BACK,
        SHOULDERS_BACK,
        LEFT_SHOULDER_BACK,
        RIGHT_SHOULDER_BACK,
        LEFT_ARM_BACK,
        LEFT_BICEP_BACK,
        LEFT_FOREARM_BACK,
        RIGHT_ARM_BACK,
        RIGHT_BICEP_BACK,
        RIGHT_FOREARM_BACK,
        LEFT_LEG_BACK,
        LEFT_THIGH_BACK,
        LEFT_CALF,
        RIGHT_LEG_BACK,
        RIGHT_THIGH_BACK,
        RIGHT_CALF,
        LEFT_ELBOW,
        RIGHT_ELBOW,
        LEFT_KNEE,
        RIGHT_KNEE,
        LEFT_HIP,
        RIGHT_HIP,
        LEFT_WAIST,
        RIGHT_WAIST,
        LEFT_SPINE,
        RIGHT_SPINE,
        LEFT_CHEST,
        RIGHT_CHEST,
        LEFT_SHOULDER,
        RIGHT_SHOULDER,
        LEFT_SIDE,
        RIGHT_SIDE,
        PELVIS,
        PELVIS_SPINE,
        SPINE_CHEST,
        CHEST_SHOULDERS,
        SPINE_CHEST_SHOULDERS,
        TORSO,
        NUM_GROUPS
    }

    public enum HapticRegion
    {
        TORSO,
        LEFTUPPERARM,
        LEFTLOWERARM,
        RIGHTUPPERARM,
        RIGHTLOWERARM,
        LEFTUPPERLEG,
        LEFTLOWERLEG,
        RIGHTUPPERLEG,
        RIGHTLOWERLEG
    }

    private bool useSteamVR = false;

    private static ShockwaveManager _instance;

    public bool enableBodyTracking = true;

    private bool PositionComputation = false;

    public float MaximumIntensity = 3f;

    public int IntensityDropOff = 4;

    public int error = 0;

    private bool initialized = false;

    private static readonly int[] allHaptics = new int[72]
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
        10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
        20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
        30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
        40, 41, 42, 43, 44, 45, 46, 47, 48, 49,
        50, 51, 52, 53, 54, 55, 56, 57, 58, 59,
        60, 61, 62, 63, 64, 65, 66, 67, 68, 69,
        70, 71
    };

    private static readonly int[] front = new int[36]
    {
        0, 1, 6, 7, 8, 9, 14, 15, 16, 17,
        22, 23, 24, 25, 30, 31, 32, 33, 36, 37,
        40, 42, 44, 46, 48, 50, 52, 54, 56, 58,
        60, 62, 64, 66, 68, 70
    };

    private static readonly int[] hips_front = new int[4] { 0, 1, 6, 7 };

    private static readonly int[] left_hip_front = new int[2] { 0, 1 };

    private static readonly int[] right_hip_front = new int[2] { 6, 7 };

    private static readonly int[] waist_front = new int[4] { 8, 9, 14, 15 };

    private static readonly int[] left_waist_front = new int[2] { 8, 9 };

    private static readonly int[] right_waist_front = new int[2] { 14, 15 };

    private static readonly int[] spine_front = new int[4] { 16, 17, 22, 23 };

    private static readonly int[] left_spine_front = new int[2] { 22, 23 };

    private static readonly int[] right_spine_front = new int[2] { 16, 17 };

    private static readonly int[] chest_front = new int[4] { 24, 25, 30, 31 };

    private static readonly int[] left_chest_front = new int[2] { 24, 25 };

    private static readonly int[] right_chest_front = new int[2] { 30, 31 };

    private static readonly int[] shoulders_front = new int[4] { 32, 33, 36, 37 };

    private static readonly int[] left_shoulder_front = new int[2] { 32, 33 };

    private static readonly int[] right_shoulder_front = new int[2] { 36, 37 };

    private static readonly int[] left_arm_front = new int[4] { 40, 42, 44, 46 };

    private static readonly int[] left_bicep_front = new int[2] { 40, 42 };

    private static readonly int[] left_forearm_front = new int[2] { 44, 46 };

    private static readonly int[] right_arm_front = new int[4] { 48, 50, 52, 54 };

    private static readonly int[] right_bicep_front = new int[2] { 48, 50 };

    private static readonly int[] right_forearm_front = new int[2] { 52, 54 };

    private static readonly int[] left_leg_front = new int[4] { 56, 58, 60, 62 };

    private static readonly int[] left_thigh_front = new int[2] { 56, 58 };

    private static readonly int[] left_shin = new int[2] { 60, 62 };

    private static readonly int[] right_leg_front = new int[4] { 64, 66, 68, 70 };

    private static readonly int[] right_thigh_front = new int[2] { 64, 66 };

    private static readonly int[] right_shin = new int[2] { 68, 70 };

    private static readonly int[] back = new int[36]
    {
        2, 3, 4, 5, 10, 11, 12, 13, 18, 19,
        20, 21, 26, 27, 28, 29, 34, 35, 38, 39,
        41, 43, 45, 47, 49, 51, 53, 55, 57, 59,
        61, 63, 65, 67, 69, 71
    };

    private static readonly int[] hip_back = new int[4] { 2, 3, 4, 5 };

    private static readonly int[] left_hip_back = new int[2] { 2, 3 };

    private static readonly int[] right_hip_back = new int[2] { 4, 5 };

    private static readonly int[] waist_back = new int[4] { 10, 11, 12, 13 };

    private static readonly int[] left_waist_back = new int[2] { 10, 11 };

    private static readonly int[] right_waist_back = new int[2] { 12, 13 };

    private static readonly int[] spine_back = new int[4] { 18, 19, 20, 21 };

    private static readonly int[] left_spine_back = new int[2] { 18, 19 };

    private static readonly int[] right_spine_back = new int[2] { 20, 21 };

    private static readonly int[] chest_back = new int[4] { 26, 27, 28, 29 };

    private static readonly int[] left_chest_back = new int[2] { 26, 27 };

    private static readonly int[] right_chest_back = new int[2] { 28, 29 };

    private static readonly int[] shoulders_back = new int[4] { 34, 35, 38, 39 };

    private static readonly int[] left_shoulder_back = new int[2] { 34, 35 };

    private static readonly int[] right_shoulder_back = new int[2] { 38, 39 };

    private static readonly int[] left_arm_back = new int[4] { 41, 43, 45, 47 };

    private static readonly int[] left_bicep_back = new int[2] { 41, 43 };

    private static readonly int[] left_forearm_back = new int[2] { 45, 47 };

    private static readonly int[] right_arm_back = new int[4] { 49, 51, 53, 55 };

    private static readonly int[] right_bicep_back = new int[2] { 49, 51 };

    private static readonly int[] right_forearm_back = new int[2] { 53, 55 };

    private static readonly int[] left_leg_back = new int[4] { 57, 59, 61, 63 };

    private static readonly int[] left_thigh_back = new int[2] { 57, 59 };

    private static readonly int[] left_calf = new int[2] { 61, 63 };

    private static readonly int[] right_leg_back = new int[4] { 65, 67, 69, 71 };

    private static readonly int[] right_thigh_back = new int[2] { 65, 67 };

    private static readonly int[] right_calf = new int[2] { 69, 71 };

    private static readonly int[] torso = new int[40]
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
        10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
        20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
        30, 31, 32, 33, 34, 35, 36, 37, 38, 39
    };

    private static readonly int[] hip = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };

    private static readonly int[] waist = new int[8] { 8, 9, 10, 11, 12, 13, 14, 15 };

    private static readonly int[] spine = new int[8] { 16, 17, 18, 19, 20, 21, 22, 23 };

    private static readonly int[] chest = new int[8] { 24, 25, 26, 27, 28, 29, 30, 31 };

    private static readonly int[] pelvis = new int[16]
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
        10, 11, 12, 13, 14, 15
    };

    private static readonly int[] pelvis_spine = new int[24]
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
        10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
        20, 21, 22, 23
    };

    private static readonly int[] spine_chest = new int[16]
    {
        16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
        26, 27, 28, 29, 30, 31
    };

    private static readonly int[] chest_shoulders = new int[16]
    {
        24, 25, 26, 27, 28, 29, 30, 31, 32, 33,
        34, 35, 36, 37, 38, 39
    };

    private static readonly int[] spine_chest_shoulders = new int[24]
    {
        16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
        26, 27, 28, 29, 30, 31, 32, 33, 34, 35,
        36, 37, 38, 39
    };

    private static readonly int[] shoulders = new int[8] { 32, 33, 34, 35, 36, 37, 38, 39 };

    private static readonly int[] left_arm = new int[8] { 40, 41, 42, 43, 44, 45, 46, 47 };

    private static readonly int[] left_bicep = new int[4] { 40, 41, 42, 43 };

    private static readonly int[] left_forearm = new int[4] { 44, 45, 46, 47 };

    private static readonly int[] right_arm = new int[8] { 48, 49, 50, 51, 52, 53, 54, 55 };

    private static readonly int[] right_bicep = new int[4] { 48, 49, 50, 51 };

    private static readonly int[] right_forearm = new int[4] { 52, 53, 54, 55 };

    private static readonly int[] left_leg = new int[8] { 56, 57, 58, 59, 60, 61, 62, 63 };

    private static readonly int[] left_thigh = new int[4] { 56, 57, 58, 59 };

    private static readonly int[] left_lower_leg = new int[4] { 60, 61, 62, 63 };

    private static readonly int[] right_leg = new int[8] { 64, 65, 66, 67, 68, 69, 70, 71 };

    private static readonly int[] right_thigh = new int[4] { 64, 65, 66, 67 };

    private static readonly int[] right_lower_leg = new int[4] { 68, 69, 70, 71 };

    private static readonly int[] left_elbow = new int[2] { 43, 45 };

    private static readonly int[] right_elbow = new int[2] { 51, 53 };

    private static readonly int[] left_knee = new int[2] { 56, 60 };

    private static readonly int[] right_knee = new int[2] { 68, 64 };

    private static readonly int[] left_hip = new int[4] { 0, 1, 2, 3 };

    private static readonly int[] right_hip = new int[4] { 4, 5, 6, 7 };

    private static readonly int[] left_waist = new int[4] { 8, 9, 10, 11 };

    private static readonly int[] right_waist = new int[4] { 12, 13, 14, 15 };

    private static readonly int[] left_spine = new int[4] { 18, 19, 22, 23 };

    private static readonly int[] right_spine = new int[4] { 16, 17, 20, 21 };

    private static readonly int[] left_chest = new int[4] { 24, 25, 26, 27 };

    private static readonly int[] right_chest = new int[4] { 28, 29, 30, 31 };

    private static readonly int[] left_shoulder = new int[4] { 32, 33, 34, 35 };

    private static readonly int[] right_shoulder = new int[4] { 36, 37, 38, 39 };

    private static readonly int[] left_side = new int[36]
    {
        0, 1, 2, 3, 8, 9, 10, 11, 18, 19,
        22, 23, 24, 25, 26, 27, 32, 33, 34, 35,
        40, 41, 42, 43, 44, 45, 46, 47, 56, 57,
        58, 59, 60, 61, 62, 63
    };

    private static readonly int[] right_side = new int[36]
    {
        4, 5, 6, 7, 12, 13, 14, 15, 16, 17,
        20, 21, 28, 29, 30, 31, 36, 37, 38, 39,
        48, 49, 50, 51, 52, 53, 54, 55, 64, 65,
        66, 67, 68, 69, 70, 71
    };

    private bool testing = false;

    private uint hipIndex = uint.MaxValue;

    private ushort hap = 0;

    public bool isUsingSteamVR => useSteamVR;

    public bool Ready => _instance != null && _instance.initialized;

    public static ShockwaveManager Instance => (_instance != null) ? _instance : (_instance = new ShockwaveManager());

    public static string GetErrorString(ERROR_ENUM err)
    {
        string text = "";
        if (err != 0)
        {
            if ((err & ERROR_ENUM.NATIVE_INIT_ERROR) > ERROR_ENUM.NO_ERROR)
            {
                text += "Native Initialization Error\n";
            }

            if ((err & ERROR_ENUM.SUIT_MISSING_ERROR) > ERROR_ENUM.NO_ERROR)
            {
                text += "Shockwave is not connected to the Native Shockwave Driver\n";
            }

            if ((err & ERROR_ENUM.STEAMVR_INIT_ERROR) > ERROR_ENUM.NO_ERROR)
            {
                text += "Shockwave can not connect to SteamVR\n";
            }

            if ((err & ERROR_ENUM.SUIT_MISSING_ERROR) > ERROR_ENUM.NO_ERROR)
            {
                text += "Shockwave not found, check Native Shockwave Driver and SteamVR Driver\n";
            }

            if ((err & ERROR_ENUM.SUIT_MISSING_WAIT_TIMEOUT) > ERROR_ENUM.NO_ERROR)
            {
                text += "Shockwave is not connected\n";
            }

            if ((err & ERROR_ENUM.NATIVE_INIT_ERROR) > ERROR_ENUM.NO_ERROR)
            {
                text += "Shockwave is not connected to the Native Shockwave Driver\n";
            }

            if ((err & ERROR_ENUM.STEAMVR_32BIT_ERROR) > ERROR_ENUM.NO_ERROR)
            {
                text += "Shockwave can only connect to SteamVR from a 64bit host application";
            }
        }

        return text;
    }

    private ShockwaveManager()
    {
        _instance = this;
    }

    ~ShockwaveManager()
    {
        if (initialized)
        {
            DisconnectSuit();
        }

        if (_instance == this)
        {
            _instance = null;
        }
    }

    public void InitializeSuit()
    {
        try
        {
            ShockwaveInterop.StartShockwaveDevice();
            if (enableBodyTracking)
            {
                ShockwaveInterop.EnableBodyTracking();
            }

            initialized = true;
        }
        catch (Exception ex)
        {
            error |= 1;
            Console.WriteLine(ex.Message);
        }
    }

    public static int[] ShockGroup(HapticGroup group)
    {
        return group switch
        {
            HapticGroup.HIP => hip,
            HapticGroup.WAIST => waist,
            HapticGroup.SPINE => spine,
            HapticGroup.CHEST => chest,
            HapticGroup.SHOULDERS => shoulders,
            HapticGroup.LEFT_ARM => left_arm,
            HapticGroup.LEFT_BICEP => left_bicep,
            HapticGroup.LEFT_FOREARM => left_forearm,
            HapticGroup.RIGHT_ARM => right_arm,
            HapticGroup.RIGHT_BICEP => right_bicep,
            HapticGroup.RIGHT_FOREARM => right_forearm,
            HapticGroup.LEFT_LEG => left_leg,
            HapticGroup.LEFT_THIGH => left_thigh,
            HapticGroup.LEFT_LOWER_LEG => left_lower_leg,
            HapticGroup.RIGHT_LEG => right_leg,
            HapticGroup.RIGHT_THIGH => right_thigh,
            HapticGroup.RIGHT_LOWER_LEG => right_lower_leg,
            HapticGroup.FRONT => front,
            HapticGroup.HIP_FRONT => hips_front,
            HapticGroup.LEFT_HIP_FRONT => left_hip_front,
            HapticGroup.RIGHT_HIP_FRONT => right_hip_front,
            HapticGroup.WAIST_FRONT => waist_front,
            HapticGroup.LEFT_WAIST_FRONT => left_waist_front,
            HapticGroup.RIGHT_WAIST_FRONT => right_waist_front,
            HapticGroup.SPINE_FRONT => spine_front,
            HapticGroup.LEFT_SPINE_FRONT => left_spine_front,
            HapticGroup.RIGHT_SPINE_FRONT => right_spine_front,
            HapticGroup.CHEST_FRONT => chest_front,
            HapticGroup.LEFT_CHEST_FRONT => left_chest_front,
            HapticGroup.RIGHT_CHEST_FRONT => right_chest_front,
            HapticGroup.SHOULDERS_FRONT => shoulders_front,
            HapticGroup.LEFT_SHOULDER_FRONT => left_shoulder_front,
            HapticGroup.RIGHT_SHOULDER_FRONT => right_shoulder_front,
            HapticGroup.LEFT_ARM_FRONT => left_arm_front,
            HapticGroup.LEFT_BICEP_FRONT => left_bicep_front,
            HapticGroup.LEFT_FOREARM_FRONT => left_forearm_front,
            HapticGroup.RIGHT_ARM_FRONT => right_arm_front,
            HapticGroup.RIGHT_BICEP_FRONT => right_bicep_front,
            HapticGroup.RIGHT_FOREARM_FRONT => right_forearm_front,
            HapticGroup.LEFT_LEG_FRONT => left_leg_front,
            HapticGroup.LEFT_THIGH_FRONT => left_thigh_front,
            HapticGroup.LEFT_SHIN => left_shin,
            HapticGroup.RIGHT_LEG_FRONT => right_leg_front,
            HapticGroup.RIGHT_THIGH_FRONT => right_thigh_front,
            HapticGroup.RIGHT_SHIN => right_shin,
            HapticGroup.BACK => back,
            HapticGroup.HIP_BACK => hip_back,
            HapticGroup.LEFT_HIP_BACK => left_hip_back,
            HapticGroup.RIGHT_HIP_BACK => right_hip_back,
            HapticGroup.WAIST_BACK => waist_back,
            HapticGroup.LEFT_WAIST_BACK => left_waist_back,
            HapticGroup.RIGHT_WAIST_BACK => right_waist_back,
            HapticGroup.SPINE_BACK => spine_back,
            HapticGroup.LEFT_SPINE_BACK => left_spine_back,
            HapticGroup.RIGHT_SPINE_BACK => right_spine_back,
            HapticGroup.CHEST_BACK => chest_back,
            HapticGroup.LEFT_CHEST_BACK => left_chest_back,
            HapticGroup.RIGHT_CHEST_BACK => right_chest_back,
            HapticGroup.SHOULDERS_BACK => shoulders_back,
            HapticGroup.LEFT_SHOULDER_BACK => left_shoulder_back,
            HapticGroup.RIGHT_SHOULDER_BACK => right_shoulder_back,
            HapticGroup.LEFT_ARM_BACK => left_arm_back,
            HapticGroup.LEFT_BICEP_BACK => left_bicep_back,
            HapticGroup.LEFT_FOREARM_BACK => left_forearm_back,
            HapticGroup.RIGHT_ARM_BACK => right_arm_back,
            HapticGroup.RIGHT_BICEP_BACK => right_bicep_back,
            HapticGroup.RIGHT_FOREARM_BACK => right_forearm_back,
            HapticGroup.LEFT_LEG_BACK => left_leg_back,
            HapticGroup.LEFT_THIGH_BACK => left_thigh_back,
            HapticGroup.LEFT_CALF => left_calf,
            HapticGroup.RIGHT_LEG_BACK => right_leg_back,
            HapticGroup.RIGHT_THIGH_BACK => right_thigh_back,
            HapticGroup.RIGHT_CALF => right_calf,
            HapticGroup.LEFT_ELBOW => left_elbow,
            HapticGroup.RIGHT_ELBOW => right_elbow,
            HapticGroup.LEFT_KNEE => left_knee,
            HapticGroup.RIGHT_KNEE => right_knee,
            HapticGroup.LEFT_HIP => left_hip,
            HapticGroup.RIGHT_HIP => right_hip,
            HapticGroup.LEFT_WAIST => left_waist,
            HapticGroup.RIGHT_WAIST => right_waist,
            HapticGroup.LEFT_SPINE => left_spine,
            HapticGroup.RIGHT_SPINE => right_spine,
            HapticGroup.LEFT_CHEST => left_chest,
            HapticGroup.RIGHT_CHEST => right_chest,
            HapticGroup.LEFT_SHOULDER => left_shoulder,
            HapticGroup.RIGHT_SHOULDER => right_shoulder,
            HapticGroup.LEFT_SIDE => left_side,
            HapticGroup.RIGHT_SIDE => right_side,
            HapticGroup.PELVIS => pelvis,
            HapticGroup.PELVIS_SPINE => pelvis_spine,
            HapticGroup.SPINE_CHEST => spine_chest,
            HapticGroup.CHEST_SHOULDERS => chest_shoulders,
            HapticGroup.SPINE_CHEST_SHOULDERS => spine_chest_shoulders,
            HapticGroup.TORSO => torso,
            _ => allHaptics,
        };
    }

    public bool suitConnected()
    {
        return ShockwaveInterop.suitConnected();
    }

    private async Task HapticsTest(int msTestDuration, float strength)
    {
        if (!testing)
        {
            testing = true;
            int TestNum = 1;
            while (TestNum < 18)
            {
                TestNum++;
                SendHapticGroupTest((HapticGroup)TestNum, strength, msTestDuration);
                await Task.Delay(200);
            }

            testing = false;
        }
    }

    private void SendHapticGroupTest(HapticGroup group, float strength, int msDuration)
    {
        if (testing)
        {
            int[] array = ShockGroup(group);
            float[] array2 = new float[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = strength;
                ShockwaveInterop.HapticsPulse(array[i], array2[i], msDuration);
            }
        }
    }

    public void SendHapticGroup(HapticGroup group, float strength, int msDuration)
    {
        if (!testing)
        {
            int[] array = ShockGroup(group);
            float[] array2 = new float[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = strength;
                ShockwaveInterop.HapticsPulse(array[i], array2[i], msDuration);
            }
        }
    }

    public void InitSequence()
    {
        if (!testing)
        {
            Task.Run(() => HapticsTest(100, 1f));
        }
    }

    public void StartPositionComputation(float customHeight)
    {
        if (!PositionComputation)
        {
            PositionComputation = true;
            ShockwaveInterop.StartPositionComputation(customHeight);
        }
    }

    public void StopPositionComputation()
    {
        if (PositionComputation)
        {
            PositionComputation = false;
            ShockwaveInterop.StopPositionComputation();
        }
    }

    public void SendHeadsetPositionQuaternion(float[] headsetPos, float[] headsetQuaternion)
    {
        ShockwaveInterop.SendHeadsetPositionQuaternion(headsetPos, headsetQuaternion);
    }

    public void DisconnectSuit()
    {
        initialized = false;
        if (!useSteamVR)
        {
            StopPositionComputation();
            ShockwaveInterop.Quit();
        }
    }

    public float[] GetRotations(int index)
    {
        float[] array = new float[4] { 0f, 0f, 0f, 1f };
        ShockwaveInterop.SensorRotationInfo(index, ref array[0], ref array[1], ref array[2], ref array[3]);
        return array;
    }

    public float[] GetTrackerPosition(int index)
    {
        float[] array = new float[3];
        ShockwaveInterop.GetPositionofTracker(index, ref array[0], ref array[1], ref array[2]);
        return array;
    }

    public float GetBodyHeight()
    {
        float height = 1.7f;
        float[] boneLengths = new float[8];
        ShockwaveInterop.BodySizeData(ref height, boneLengths);
        return height;
    }

    public float[] GetBoneLengths()
    {
        float height = 1.7f;
        float[] array = new float[8];
        ShockwaveInterop.BodySizeData(ref height, array);
        return array;
    }

    public void EnableBodyTracking(bool enabled = true)
    {
        if (enabled && !enableBodyTracking)
        {
            ShockwaveInterop.EnableBodyTracking();
            enableBodyTracking = true;
        }
        else if (!enabled && enableBodyTracking)
        {
            ShockwaveInterop.DisableBodyTracking();
            enableBodyTracking = false;
        }
    }

    public bool isBoneTracked(int index)
    {
        return ShockwaveInterop.isBoneTracked(index);
    }

    public void sendHapticsUpdate(int[] hapticIndices, float[] hapticStrengths, int numberActuated)
    {
        ShockwaveInterop.HapticsUpdate(hapticIndices, hapticStrengths, numberActuated);
    }

    public void sendHapticsPulse(int hapticIndices, float hapticStrengths, float milliseconds)
    {
        ShockwaveInterop.HapticsPulse(hapticIndices, hapticStrengths, milliseconds);
    }

    public void sendHapticsPulse(int[] hapticIndices, float[] hapticStrengths, float milliseconds)
    {
        for (int i = 0; i < Math.Min(hapticIndices.Length, hapticStrengths.Length); i++)
        {
            ShockwaveInterop.HapticsPulse(hapticIndices[i], hapticStrengths[i], milliseconds);
        }
    }

    public void sendHapticsPulsewithPositionInfo(HapticRegion region, float value, float angYaw, float longitudinalPosition, float regionHeight, float milliseconds)
    {
        ShockwaveInterop.HapticsPulseWithPosition((int)region, value, angYaw, longitudinalPosition, regionHeight, milliseconds);
    }

    public void sendLEDUpdate(int[] ledIndices, float[] ledStrengths, int numberActuated)
    {
        ShockwaveInterop.LEDUpdate(ledIndices, ledStrengths, numberActuated);
    }

    public void sendHapticsWithPosition(int hapticIndex, float hapticStrength, float relativeDistance)
    {
        ShockwaveInterop.HapticsPositionUpdate(hapticIndex, hapticStrength, relativeDistance);
    }

    public void sendLEDUpdate(float[] color, bool leftSide)
    {
        int[] array = new int[3];
        float[] strengths = new float[3]
        {
            color[1],
            color[0],
            color[2]
        };
        for (int i = 0; i < 3; i++)
        {
            array[i] = (leftSide ? i : (i + 3));
        }

        ShockwaveInterop.LEDUpdate(array, strengths, 3);
    }

    public void SetMaximumIntensity(float maximumIntensity)
    {
        MaximumIntensity = maximumIntensity;
        ShockwaveInterop.SetMaxCollisionIntensity(maximumIntensity);
    }
}
#if false // Decompilation log
'242' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'G:\unity editor\2022.3.6f1\Editor\Data\UnityReferenceAssemblies\unity-4.8-api\mscorlib.dll'
#endif



#region Assembly ShockwaveManager, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// G:\avatar\avatars\pinkydaduck\haptics test\Assets\ShockwaveSDK\Plugins\ShockwaveManager.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion



public static class ShockwaveInterop
{
    [DllImport("ShockWaveIMU")]
    public static extern void StartShockwaveDevice();

    [DllImport("ShockWaveIMU")]
    public static extern void EnableBodyTracking();

    [DllImport("ShockWaveIMU")]
    public static extern void DisableBodyTracking();

    [DllImport("ShockWaveIMU")]
    public static extern void SetMaxCollisionIntensity(float maxIntensity);

    [DllImport("ShockWaveIMU")]
    public static extern void LEDUpdate(int[] index, float[] strengths, int len);

    [DllImport("ShockWaveIMU")]
    public static extern void HapticsUpdate(int[] index, float[] strengths, int len);

    [DllImport("ShockWaveIMU")]
    public static extern void HapticsPositionUpdate(int index, float strength, float pos);

    [DllImport("ShockWaveIMU")]
    public static extern void HapticsPulseWithPosition(int regionIndex, float value, float angYaw, float longitudinalPosition, float regionHeight, float milliseconds);

    [DllImport("ShockWaveIMU")]
    internal static extern void Quit();

    [DllImport("ShockWaveIMU")]
    internal static extern void SensorRotationInfo(int ind, ref float w, ref float x, ref float y, ref float z);

    [DllImport("ShockWaveIMU")]
    internal static extern void SensorRotationInfoRaw(int ind, ref float w, ref float x, ref float y, ref float z);

    [DllImport("ShockWaveIMU")]
    internal static extern void SendHeadsetPositionQuaternion(float[] headsetPos, float[] headsetQuaternion);

    [DllImport("ShockWaveIMU")]
    internal static extern void SendHeadsetPositionMatrix34(float[,] Matrix34);

    [DllImport("ShockWaveIMU")]
    internal static extern void StartPositionComputation(float customHeight);

    [DllImport("ShockWaveIMU")]
    internal static extern void StopPositionComputation();

    [DllImport("ShockWaveIMU")]
    internal static extern void GetPositionofTracker(int m_TrackerIndex, ref float posX, ref float posY, ref float posZ);

    [DllImport("ShockWaveIMU")]
    internal static extern bool isBoneTracked(int i);

    [DllImport("ShockWaveIMU")]
    internal static extern bool ConnectionStatus();

    [DllImport("ShockWaveIMU")]
    internal static extern void BodySizeData(ref float height, float[] boneLengths);

    [DllImport("ShockWaveIMU")]
    internal static extern void HapticsPulse(int ind, float value, float milliseconds);

    [DllImport("ShockWaveIMU")]
    internal static extern bool suitConnected();

    [DllImport("ShockWaveIMU")]
    internal static extern void EnableAdditionalYaw(bool en);
}
#if false // Decompilation log
'241' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'G:\unity editor\2022.3.6f1\Editor\Data\UnityReferenceAssemblies\unity-4.8-api\mscorlib.dll'
#endif
