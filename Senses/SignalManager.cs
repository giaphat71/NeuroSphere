namespace NeuroSphere.Senses;
using System.Text.Json;

public class SignalManager
{
    const string SignalDirectory = "./Senses/Signals/";
    private Dictionary<string, EncodedSignal> signals;
    private void LoadEncodedSignal()
    {
        signals = new Dictionary<string, EncodedSignal>();
        foreach (var file in Directory.GetFiles(SignalDirectory, "*.signal"))
        {
            var signalName = Path.GetFileNameWithoutExtension(file);
            var rawData = File.ReadAllBytes(file);
            var signal = JsonSerializer.Deserialize<EncodedSignal>(rawData);
            if (signal == null)
            {
                throw new Exception($"Failed to decode signal from file: {file}");
            }
            signals[signalName] = signal;
        }
    }
    public EncodedSignal GetDefaultSignal(string signalName)
    {
        if (signals == null)
        {
            LoadEncodedSignal();
        }
        if (signals.TryGetValue(signalName, out var signal))
        {
            return signal;
        }
        throw new KeyNotFoundException($"Signal '{signalName}' not found.");
    }
}