using System;
using System.Threading;
using System.Threading.Tasks;
using NClap.Metadata;

namespace SmartGlass.Cli
{
    internal class PowerOffCommand : Command
    {
        [PositionalArgument(ArgumentFlags.Required, Position = 0)]
        public string Hostname { get; set; }

        public override async Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            ConnectCommand conn = new ConnectCommand { Hostname = Hostname };

            var connResult = await conn.ExecuteAsync(cancel, async () => {
                Console.WriteLine($"Powering off {Hostname}...");
                var powerOffCommand = new Session.PowerOffCommand();
                await powerOffCommand.ExecuteAsync(cancel);
                
                Console.WriteLine($"Disconnecting from {Hostname}...");
                var exitCommand = new ExitCommand();
                await exitCommand.ExecuteAsync(cancel);
            });

            return CommandResult.Success;
        }
    }
}