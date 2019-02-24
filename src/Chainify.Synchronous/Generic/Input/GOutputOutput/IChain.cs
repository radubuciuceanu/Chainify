using Chainify.Core;
using Chainify.Core.Generic;
using IGVoidVoid = Chainify.Synchronous.Generic.Input.GVoidVoid.IChain;
using IGInputInputGIoIo = Chainify.Synchronous.Generic.Input.GInputInputGIoIo.IChain;

namespace Chainify.Synchronous.Generic.Input.GOutputOutput
{
    public interface IChain : IGVoidVoid
    {
        IGInputInputGIoIo Chain(IGenericOutput other);

        IGInputInputGIoIo Chain<TOtherOutput>(IOutput<TOtherOutput> other);
    }
}
