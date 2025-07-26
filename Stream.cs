namespace NeuroSphere;
using NeuroSphere.Senses;

public abstract class Stream
{
    /**
        The Stream is an human sensory input stream, such as Vision, Hearing, Touch, Smell, Taste.
        Pushing data to the stream will automatically convert to desired brain signals, then send to the brain.
        The Stream is a base class for all sensory streams, such as VisionStream, HearingStream, TouchStream, SmellStream, TasteStream.
    */
    public abstract void Write(EncodedSignal data);
    public abstract EncodedSignal Read();
}
