namespace SampleProject;

public class Dir
{
    private readonly Platform.Definition.Dir platformDir;

    private readonly IntPtr handle;
    
    public static Dir Open(string path)
    {
        return new Dir(path, null!); //TODO: How to get the platform definition?
    }

    private Dir(string path, Platform.Definition.Dir platformDir)
    {
        this.platformDir = platformDir;
        handle = platformDir.Open(path, 0, out _);
    }

    public void Close()
    {
        platformDir.Close(handle);
    }
}