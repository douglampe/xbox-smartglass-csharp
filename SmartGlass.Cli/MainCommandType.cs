using NClap.Metadata;

namespace SmartGlass.Cli
{
    internal enum MainCommandType
    {
        [Command(
            typeof(AuthenticateCommand),
            Description = "Authenticate to Xbox Live via Microsoft Account.")]
        Authenticate,

        [Command(
            typeof(ConnectCommand),
            Description = "Opens a connection to an Xbox One console.")]
        Connect,

        [Command(
            typeof(BroadcastCommand),
            Description = "Connect and start a broadcast session.")]
        Broadcast,

        [Command(
            typeof(DiscoverCommand),
            Description = "Discover and list Xbox One consoles on the local network.")]
        Discover,

        [Command(
            typeof(PcapCommand),
            Description = "Decrypt captured messages.")]
        Pcap,

        [Command(
            typeof(PingCommand),
            Description = "Ping and output details of an Xbox One console.")]
        Ping,

        [Command(
            typeof(PowerOnCommand),
            Description = "Power on Xbox One console.")]
        PowerOn,

        [Command(
            typeof(PowerOffCommand),
            Description = "Power off Xbox One console.")]
        PowerOff
    }
}