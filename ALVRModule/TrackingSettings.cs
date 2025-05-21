using VRCFaceTracking.Core.Params.Data;

namespace ALVRModule
{
    using static Setting;

    public enum Setting
    {
        UpperFaceTracking = 0,
        LowerFaceTracking = 1,
    }

    public class TrackingSettings
    {
        public static bool EnableUpperFaceTracking = true;
        public static bool EnableLowerFaceTracking = false;

        public static void SetModuleSettings(FloatParams p, FloatWeightParams w, UnifiedEyeData eye)
        {
            EnableUpperFaceTracking = p[UpperFaceTracking] != 0f;
            EnableLowerFaceTracking = p[LowerFaceTracking] != 0f;
        }
    }
}
