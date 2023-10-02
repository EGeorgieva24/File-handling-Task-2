class Test
{
    public static void Main()
    {
        string path = @"D:\Programming guysss\File_Handling";
        DirectoryInfo Directory = new DirectoryInfo(path);
        Directory.Create();

        var file = $@"{path}\Steve.txt";
        
        File.AppendAllText(file,"hello");

   
    }
}