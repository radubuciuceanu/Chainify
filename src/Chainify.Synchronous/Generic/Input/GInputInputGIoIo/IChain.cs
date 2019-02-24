using Chainify.Core;
using Chainify.Core.Generic;
using IGVoidVoid = Chainify.Synchronous.Generic.Input.GVoidVoid.IChain;
using IGOutputOutput = Chainify.Synchronous.Generic.Input.GOutputOutput.IChain;

namespace Chainify.Synchronous.Generic.Input.GInputInputGIoIo
{
    public interface IChain : IGVoidVoid
    {
        IGOutputOutput Chain<TOtherInput>(IInput<TOtherInput> other);

        IChain Chain(IGenericInputOutput other);

        IChain Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
    }
}