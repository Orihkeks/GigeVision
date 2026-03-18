using System.Threading.Tasks;

namespace GenICam;

/// <summary>
/// Maps to a command button.
/// </summary>
public interface ICommand
{
    /// <summary>
    /// Submits the command.
    /// </summary>
    /// <returns>A task.</returns>
    public Task<IReplyPacket> Execute();
}