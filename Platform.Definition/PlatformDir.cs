namespace Platform.Definition;

public interface Dir
{
    IntPtr Open(string path, uint flags, out IntPtr error);
    void Close(IntPtr dir);

    void CloseWindowsOnly(IntPtr dir);
}