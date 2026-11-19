using System;
using System.Threading;
using System.Threading.Tasks;

namespace SharpBrick.PoweredUp.Bluetooth;

public interface IPoweredUpBluetoothAdapter
{
    void Discover(Func<IPoweredUpBluetoothDeviceInfo, Task> discoveryHandler, CancellationToken cancellationToken = default);

    Task<IPoweredUpBluetoothDevice> GetDeviceAsync(IPoweredUpBluetoothDeviceInfo bluetoothDeviceInfo, Func<Task> onDisconnect);

    Task<IPoweredUpBluetoothDeviceInfo> CreateDeviceInfoByKnownStateAsync(object state);
}
