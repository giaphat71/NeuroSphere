namespace NeuroSphere.Senses;

public class SignalEncoder
{
    /**
        Allow developers to encode signals into a format that can be sent to the sensory streams, by using a pretrained machine learning model.
    */
    public EncodedSignal EncodeVisual(byte[] data, int eye)
    {
        throw new NotImplementedException("Encoding logic is not implemented yet.");
    }

    public EncodedSignal EncodeSound(byte[] data, int ear, Point3D? initialOffset = default, double level = 1.0)
    {
        throw new NotImplementedException("Encoding logic is not implemented yet.");
    }

    public EncodedSignal EncodeFeel(EncodedSignal defaultSignal, HumanPart humanPart, Point3D? initialOffset = default, double radius = 1.0)
    {
        throw new NotImplementedException("Encoding logic is not implemented yet.");
    }

    public EncodedSignal EncodeSmell(EncodedSignal defaultSignal, double intensity = 1.0)
    {
        throw new NotImplementedException("Encoding logic is not implemented yet.");
    }

    public EncodedSignal EncodeTaste(EncodedSignal defaultSignal, Point3D? initialOffset = default, double intensity = 1.0)
    {
        throw new NotImplementedException("Encoding logic is not implemented yet.");
    }

}