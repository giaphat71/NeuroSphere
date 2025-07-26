namespace NeuroSphere.Senses;

public abstract class SignalDecoder
{
    /**
        The SignalDecoder is responsible for decoding the encoded signals from the sensory streams.
        It converts the raw data from the streams into a format that can be programmed by developers.
    */
    public abstract EncodedSignal Decode(byte[] rawData);
}