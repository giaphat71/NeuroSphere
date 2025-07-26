namespace NeuroSphere.Senses;

using NeuroSphere;

public enum SignalType
{
    Vision,
    Hearing,
    Touch,
    Smell,
    Taste
}

public enum DesiredControl
{
    Contract,
    Relax,
    None // No specific control desired
}

public class EncodedSignal
{
    public SignalType Type { get; set; }
    public HumanPart HumanPart { get; set; } = HumanPart.None; // The human part that the signal is related to, such as Eye, Ear, Skin, Nose, Tongue
    public Point3D InitialOffset { get; set; } = new Point3D(0, 0, 0);
    public byte[] Data { get; set; } // The encoded data representing the signal

    public DesiredControl DesiredControl { get; set; } = DesiredControl.None; // The decoded signal create by the brain, to control a muscle.

    public Point3D IntendedMovement { get; set; } = new Point3D(0, 0, 0); // The intended movement of the human part, when decoded with many control signals coming together.

    public EncodedSignal(SignalType type, byte[] data)
    {
        Type = type;
        Data = data;
    }
    public EncodedSignal(SignalType type, HumanPart humanPart, byte[] data)
    {
        Type = type;
        HumanPart = humanPart;
        Data = data;
    }
    public EncodedSignal(SignalType type, HumanPart humanPart, byte[] data, Point3D initialOffset)
    {
        Type = type;
        HumanPart = humanPart;
        Data = data;
        InitialOffset = initialOffset;
    }

    /**
        Only for decoded signals, which are created by the brain.
    */
    public EncodedSignal(SignalType type, HumanPart humanPart, byte[] data, Point3D initialOffset, DesiredControl desiredControl)
    {
        Type = type;
        HumanPart = humanPart;
        Data = data;
        InitialOffset = initialOffset;
        DesiredControl = desiredControl;
    }
    public override string ToString()
    {
        return $"EncodedSignal(Type: {Type}, HumanPart: {HumanPart}, InitialOffset: {InitialOffset}, DesiredControl: {DesiredControl})";
    }
}