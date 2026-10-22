namespace FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

// Client::Graphics::Kernel::SwapChain
//   Client::Graphics::Kernel::Resource
//     Client::Graphics::DelayedReleaseClassBase
//       Client::Graphics::ReferencedClassBase
//   Client::Graphics::Kernel::Notifier
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x78)]
public unsafe partial struct SwapChain {
    [FieldOffset(0x38)] public uint Width;
    [FieldOffset(0x3C)] public uint Height;
    [FieldOffset(0x58)] public Texture* BackBuffer;
    [FieldOffset(0x60)] public Texture* DepthStencil;
    [FieldOffset(0x68)] public void* DXGISwapChain; // IDXGISwapChain

    /// <summary> QueryPerformanceCounter in microseconds when <c>IDXGISwapChain::Present</c> last returned. </summary>
    [FieldOffset(0x70)] public ulong LastPresentTime;

    [MemberFunction("E8 ?? ?? ?? ?? C6 46 79 00 EB 40")]
    public partial void Present();
}
