using System.Runtime.InteropServices;

namespace SampleProject.Platform.Linux;

public class Dir : global::Platform.Definition.Dir
{
    [DllImport("libglib-2.0.so.0", EntryPoint = "g_dir_open")]
    private static extern IntPtr OpenExt([MarshalAs(UnmanagedType.LPUTF8Str)]string path, uint flags, out IntPtr error);
    
    [DllImport("libglib-2.0.so.0", EntryPoint = "g_dir_close")]
    private static extern void CloseExt(IntPtr dir);


    public IntPtr Open(string path, uint flags, out IntPtr error)
        => OpenExt(path, flags, out error);

    public void Close(IntPtr dir)
        => CloseExt(dir);

    public void CloseWindowsOnly(IntPtr dir)
        => throw new PlatformNotSupportedException();
}