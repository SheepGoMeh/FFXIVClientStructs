using Thread = FFXIVClientStructs.FFXIV.Client.System.Threading.Thread;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

// Client::Graphics::Kernel::Device::RenderThread
//   Client::System::Threading::Thread
//     Client::System::Common::NonCopyable
/// <summary>
/// Processes the commands of a frame when <see cref="Device.UseRenderThread"/> is set. Pointed to by <see cref="Device.RenderThread"/>.
/// </summary>
[GenerateInterop]
[Inherits<Thread>]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe partial struct RenderThread {
    /// <summary> Auto-reset event, set to start processing a frame. </summary>
    [FieldOffset(0x28)] public nint StartEvent; // HANDLE

    /// <summary> Auto-reset event, set when a frame is processed. </summary>
    [FieldOffset(0x30)] public nint DoneEvent; // HANDLE
}
