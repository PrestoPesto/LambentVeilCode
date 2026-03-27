namespace LambentVeilCode;

public class MusicPearl
{
    public static SoundID? DistortionArps;
    public static void RegisterValues()
    {
        DistortionArps = new SoundID("DistortionArps", register: true);
    }
    public static void UnregisterValues()
    {
        if (DistortionArps != null)
        {
            DistortionArps?.Unregister();
            DistortionArps = null;
        }
    }
}