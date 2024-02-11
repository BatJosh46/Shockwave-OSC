
using System.Windows;
using VRCOSC.Game.Modules;
using VRCOSC.Game.Modules.Avatar;

namespace VRCOSC.Modules.ShockwaveHapticOSCModule
{
    [ModuleTitle("ShockwaveHaptic")]
    [ModuleDescription("This is a plugin to hopefully streamline the use of the shockwave haptic suit for vrchat!")]
    [ModuleAuthor("BatJosh")]
    [ModuleGroup(ModuleType.General)]
    public partial class ShockwaveHapticOSCModule : AvatarModule
    {


        ShockwaveManager manager;
        protected override void CreateAttributes()
        {
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_0, ParameterMode.Read, "Shockwave_0", "Shockwave_0", "Shockwav_0");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_1, ParameterMode.Read, "Shockwave_1", "Shockwave_1", "Shockwave_1");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_2, ParameterMode.Read, "Shockwave_2", "Shockwave_2", "Shockwave_2");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_3, ParameterMode.Read, "Shockwave_3", "Shockwave_3", "Shockwave_3");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_4, ParameterMode.Read, "Shockwave_4", "Shockwave_4", "Shockwave_4");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_5, ParameterMode.Read, "Shockwave_5", "Shockwave_5", "Shockwave_5");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_6, ParameterMode.Read  , "Shockwave_6", "Shockwave_6", "Shockwave_6");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_7, ParameterMode.Read, "Shockwave_7", "Shockwave_7", "Shockwave_7");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_8, ParameterMode.Read, "Shockwave_8", "Shockwave_8", "Shockwave_3");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_9, ParameterMode.Read, "Shockwave_9", "Shockwave_9", "Shockwave_3");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_10, ParameterMode.Read, "Shockwave_10", "Shockwave_10", "Shockwave_10");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_11, ParameterMode.Read, "Shockwave_11", "Shockwave_11", "Shockwave_11");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_12, ParameterMode.Read, "Shockwave_12", "Shockwave_12", "Shockwave_12");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_13, ParameterMode.Read, "Shockwave_13", "Shockwave_13", "Shockwave_13");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_14, ParameterMode.Read, "Shockwave_14", "Shockwave_14", "Shockwave_14");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_15, ParameterMode.Read, "Shockwave_15", "Shockwave_15", "Shockwave_15");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_16, ParameterMode.Read, "Shockwave_16", "Shockwave_16", "Shockwave_16");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_17, ParameterMode.Read, "Shockwave_17", "Shockwave_17", "Shockwave_17");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_18, ParameterMode.Read, "Shockwave_18", "Shockwave_18", "Shockwave_18");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_19, ParameterMode.Read, "Shockwave_19", "Shockwave_19", "Shockwave_19");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_20, ParameterMode.Read, "Shockwave_20", "Shockwave_20", "Shockwave_20");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_21, ParameterMode.Read, "Shockwave_21", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_22, ParameterMode.Read, "Shockwave_22", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_23, ParameterMode.Read, "Shockwave_23", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_24, ParameterMode.Read, "Shockwave_24", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_25, ParameterMode.Read, "Shockwave_25", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_26, ParameterMode.Read, "Shockwave_26", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_27, ParameterMode.Read, "Shockwave_27", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_28, ParameterMode.Read, "Shockwave_28", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_29, ParameterMode.Read, "Shockwave_29", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_30, ParameterMode.Read, "Shockwave_30", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_31, ParameterMode.Read, "Shockwave_31", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_32, ParameterMode.Read, "Shockwave_32", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_33, ParameterMode.Read, "Shockwave_33", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_34, ParameterMode.Read, "Shockwave_34", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_35, ParameterMode.Read, "Shockwave_35", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_36, ParameterMode.Read, "Shockwave_36", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_37, ParameterMode.Read, "Shockwave_37", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_38, ParameterMode.Read, "Shockwave_38", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_39, ParameterMode.Read, "Shockwave_39", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_40, ParameterMode.Read, "Shockwave_40", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_41, ParameterMode.Read, "Shockwave_41", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_42, ParameterMode.Read, "Shockwave_42", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_43, ParameterMode.Read, "Shockwave_43", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_44, ParameterMode.Read, "Shockwave_44", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_45, ParameterMode.Read, "Shockwave_45", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_46, ParameterMode.Read, "Shockwave_46", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_47, ParameterMode.Read, "Shockwave_47", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_48, ParameterMode.Read, "Shockwave_48", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_49, ParameterMode.Read, "Shockwave_49", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_50, ParameterMode.Read, "Shockwave_50", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_51, ParameterMode.Read, "Shockwave_51", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_52, ParameterMode.Read, "Shockwave_52", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_53, ParameterMode.Read, "Shockwave_53", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_54, ParameterMode.Read, "Shockwave_54", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_55, ParameterMode.Read, "Shockwave_55", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_56, ParameterMode.Read, "Shockwave_56", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_57, ParameterMode.Read, "Shockwave_57", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_58, ParameterMode.Read, "Shockwave_58", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_59, ParameterMode.Read, "Shockwave_59", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_60, ParameterMode.Read, "Shockwave_60", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_61, ParameterMode.Read, "Shockwave_61", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_62, ParameterMode.Read, "Shockwave_62", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_63, ParameterMode.Read, "Shockwave_63", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_64, ParameterMode.Read, "Shockwave_64", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_65, ParameterMode.Read, "Shockwave_65", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_66, ParameterMode.Read, "Shockwave_66", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_67, ParameterMode.Read, "Shockwave_67", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_68, ParameterMode.Read, "Shockwave_68", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_69, ParameterMode.Read, "Shockwave_69", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_70, ParameterMode.Read, "Shockwave_70", "Shockwave_", "Shockwave_");
            CreateParameter<bool>(ShockwaveHapticParameter.Shockwave_71, ParameterMode.Read, "Shockwave_71", "Shockwave_", "Shockwave_");
            CreateSetting(VRChatConfig.AFK, "AFK setting", "Whether the suit should react while user is AFK", bool.TrueString);
            CreateSetting(VRChatConfig.InStation, "In Station setting", "Whether the suit should react while user is in station", bool.TrueString);
            CreateSetting(VRChatConfig.Seated, "Seated setting", "Whether the suit should react while user is seated", bool.TrueString);
            CreateSetting(DevicesConfig.Enabled, "Enabled Devices", "Whether the suits devices are enabled or not", bool.TrueString);
            CreateSetting(DevicesConfig.IntensityMinimum, "Device Minimum Intensity", "The minimum intensity of which the devices actuate (0)", int.MinValue);
            CreateSetting(DevicesConfig.IntensityMaximum, "Devices Maximum Intensity", "The Maximum intensity of which the devices actuate (500)", int.MaxValue);
            CreateSetting(DevicesConfig.Duration, "Duration", "The duration of which the devices actuate (500)", int.MaxValue);
        }

        protected override void OnModuleStart()
        {
            manager = ShockwaveManager.Instance;
            manager.InitializeSuit();
        }

        private void ProcessExit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        [ModuleUpdate(ModuleUpdateMode.Custom)]
        private void moduleUpdate()
        {
            
        }




        protected override void OnModuleStop()
        {
        }

        private enum ShockwaveHapticParameter
        {
            Shockwave_0,
            Shockwave_1,
            Shockwave_2,
            Shockwave_3,
            Shockwave_4,
            Shockwave_5,
            Shockwave_6,
            Shockwave_7,
            Shockwave_8,
            Shockwave_9,
            Shockwave_10,
            Shockwave_11,
            Shockwave_12,
            Shockwave_13,
            Shockwave_14,
            Shockwave_15,
            Shockwave_16,
            Shockwave_17,
            Shockwave_18,
            Shockwave_19,
            Shockwave_20,
            Shockwave_21,
            Shockwave_22,
            Shockwave_23,
            Shockwave_24,
            Shockwave_25,
            Shockwave_26,
            Shockwave_27,
            Shockwave_28,
            Shockwave_29,
            Shockwave_30,
            Shockwave_31,
            Shockwave_32,
            Shockwave_33,
            Shockwave_34,
            Shockwave_35,
            Shockwave_36,
            Shockwave_37,
            Shockwave_38,
            Shockwave_39,
            Shockwave_40,
            Shockwave_41,
            Shockwave_42,
            Shockwave_43,
            Shockwave_44,
            Shockwave_45,
            Shockwave_46,
            Shockwave_47,
            Shockwave_48,
            Shockwave_49,
            Shockwave_50,
            Shockwave_51,
            Shockwave_52,
            Shockwave_53,
            Shockwave_54,
            Shockwave_55,
            Shockwave_56,
            Shockwave_57,
            Shockwave_58,
            Shockwave_59,
            Shockwave_60,
            Shockwave_61,
            Shockwave_62,
            Shockwave_63,
            Shockwave_64,
            Shockwave_65,
            Shockwave_66,
            Shockwave_67,
            Shockwave_68,
            Shockwave_69,
            Shockwave_70,
            Shockwave_71,

        }

        private enum VRChatConfig
        {
            AFK,
            InStation,
            Seated
        }

        private enum DevicesConfig
        {
            Enabled,
            IntensityMinimum,
            IntensityMaximum,
            Duration
        }

        private enum DevicesConfigBase
        {
            Vest,
            UpperArmLeft,
            UpperArmRight,
            LowerArmLeft,
            LowerArmRight,
            perLegLeft,
            UpperLegRight,
            LowerLegLeft,
            LowerLegRight
        }

        protected override void OnAnyParameterReceived(ReceivedParameter Parameter)
        {

            var manager = ShockwaveManager.Instance;

            // Define the intensity and duration based on your configuration
            float intensity = (float)DevicesConfig.IntensityMaximum;
            float duration = (float)DevicesConfig.Duration;


            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_0))
            {
                ShockwaveManager.Instance.sendHapticsPulse(0, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_1))
            {
                ShockwaveManager.Instance.sendHapticsPulse(1, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_2))
            {
                ShockwaveManager.Instance.sendHapticsPulse(2, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_3))
            {
                ShockwaveManager.Instance.sendHapticsPulse(3, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_4))
            {
                ShockwaveManager.Instance.sendHapticsPulse(4, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_5))
            {
                ShockwaveManager.Instance.sendHapticsPulse(5, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_6))
            {
                ShockwaveManager.Instance.sendHapticsPulse(6, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_7))
            {
                ShockwaveManager.Instance.sendHapticsPulse(7, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_8))
            {
                ShockwaveManager.Instance.sendHapticsPulse(8, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_9))
            {
                ShockwaveManager.Instance.sendHapticsPulse(9, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_10))
            {
                ShockwaveManager.Instance.sendHapticsPulse(10, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_11))
            {
                ShockwaveManager.Instance.sendHapticsPulse(11, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_12))
            {
                ShockwaveManager.Instance.sendHapticsPulse(12, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_13))
            {
                ShockwaveManager.Instance.sendHapticsPulse(13, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_14))
            {
                ShockwaveManager.Instance.sendHapticsPulse(14, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_15))
            {
                ShockwaveManager.Instance.sendHapticsPulse(15, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_16))
            {
                ShockwaveManager.Instance.sendHapticsPulse(16, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_17))
            {
                ShockwaveManager.Instance.sendHapticsPulse(17, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_18))
            {
                ShockwaveManager.Instance.sendHapticsPulse(18, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_19))
            {
                ShockwaveManager.Instance.sendHapticsPulse(19, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_20))
            {
                ShockwaveManager.Instance.sendHapticsPulse(20, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_21))
            {
                ShockwaveManager.Instance.sendHapticsPulse(21, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_22))
            {
                ShockwaveManager.Instance.sendHapticsPulse(22, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_23))
            {
                ShockwaveManager.Instance.sendHapticsPulse(23, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_24))
            {
                ShockwaveManager.Instance.sendHapticsPulse(24, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_25))
            {
                ShockwaveManager.Instance.sendHapticsPulse(25, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_26))
            {
                ShockwaveManager.Instance.sendHapticsPulse(26, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_27))
            {
                ShockwaveManager.Instance.sendHapticsPulse(27, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_28))
            {
                ShockwaveManager.Instance.sendHapticsPulse(28, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_29))
            {
                ShockwaveManager.Instance.sendHapticsPulse(29, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_30))
            {
                ShockwaveManager.Instance.sendHapticsPulse(30, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_31))
            {
                ShockwaveManager.Instance.sendHapticsPulse(31, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_32))
            {
                ShockwaveManager.Instance.sendHapticsPulse(32, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_33))
            {
                ShockwaveManager.Instance.sendHapticsPulse(33, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_34))
            {
                ShockwaveManager.Instance.sendHapticsPulse(34, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_35))
            {
                ShockwaveManager.Instance.sendHapticsPulse(35, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_36))
            {
                ShockwaveManager.Instance.sendHapticsPulse(36, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_37))
            {
                ShockwaveManager.Instance.sendHapticsPulse(37, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_38))
            {
                ShockwaveManager.Instance.sendHapticsPulse(38, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_39))
            {
                ShockwaveManager.Instance.sendHapticsPulse(39, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_40))
            {
                ShockwaveManager.Instance.sendHapticsPulse(40, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_41))
            {
                ShockwaveManager.Instance.sendHapticsPulse(41, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_42))
            {
                ShockwaveManager.Instance.sendHapticsPulse(42, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_43))
            {
                ShockwaveManager.Instance.sendHapticsPulse(43, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_44))
            {
                ShockwaveManager.Instance.sendHapticsPulse(44, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_45))
            {
                ShockwaveManager.Instance.sendHapticsPulse(45, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_46))
            {
                ShockwaveManager.Instance.sendHapticsPulse(46, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_47))
            {
                ShockwaveManager.Instance.sendHapticsPulse(47, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_48))
            {
                ShockwaveManager.Instance.sendHapticsPulse(48, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_49))
            {
                ShockwaveManager.Instance.sendHapticsPulse(49, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_50))
            {
                ShockwaveManager.Instance.sendHapticsPulse(50, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_51))
            {
                ShockwaveManager.Instance.sendHapticsPulse(51, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_52))
            {
                ShockwaveManager.Instance.sendHapticsPulse(52, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_53))
            {
                ShockwaveManager.Instance.sendHapticsPulse(53, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_54))
            {
                ShockwaveManager.Instance.sendHapticsPulse(54, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_55))
            {
                ShockwaveManager.Instance.sendHapticsPulse(55, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_56))
            {
                ShockwaveManager.Instance.sendHapticsPulse(56, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_57))
            {
                ShockwaveManager.Instance.sendHapticsPulse(57, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_58))
            {
                ShockwaveManager.Instance.sendHapticsPulse(58, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_59))
            {
                ShockwaveManager.Instance.sendHapticsPulse(59, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_60))
            {
                ShockwaveManager.Instance.sendHapticsPulse(60, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_61))
            {
                ShockwaveManager.Instance.sendHapticsPulse(61, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_62))
            {
                ShockwaveManager.Instance.sendHapticsPulse(62, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_63))
            {
                ShockwaveManager.Instance.sendHapticsPulse(63, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_64))
            {
                ShockwaveManager.Instance.sendHapticsPulse(64, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_65))
            {
                ShockwaveManager.Instance.sendHapticsPulse(65, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_66))
            {
                ShockwaveManager.Instance.sendHapticsPulse(66, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_67))
            {
                ShockwaveManager.Instance.sendHapticsPulse(67, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_68))
            {
                ShockwaveManager.Instance.sendHapticsPulse(68, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_69))
            {
                ShockwaveManager.Instance.sendHapticsPulse(69, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_70))
            {
                ShockwaveManager.Instance.sendHapticsPulse(70, intensity, duration);
            }

            if (Parameter.Name == nameof(ShockwaveHapticParameter.Shockwave_71))
            {
                ShockwaveManager.Instance.sendHapticsPulse(71, intensity, duration);
            }
        }

    }
}




