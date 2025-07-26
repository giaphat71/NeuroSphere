namespace NeuroSphere.Device;

public class Device
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string DeviceId { get; set; }
    public Device()
    {
        // Try connect to the device
    }
}