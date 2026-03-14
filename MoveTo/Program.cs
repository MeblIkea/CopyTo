namespace MoveTo;

internal static class Program {
    public static int Main(string[] args) {
        if (args.Length < 2) {
            throw new Exception("Not enough arguments. Usage: {DST} [*]{files to cpy}");
        }

        if (!Directory.Exists(args[0])) {
            throw new Exception("Destination is not a directory.");
        }

        string destination = args[0];
        string[] sources = args.Where((s, i) => i > 0).ToArray();

        foreach (string source in sources) {
            if (!File.Exists(source)) {
                throw new Exception(source + " is not a file.");
            }

            string dstPath = Path.Combine(destination, Path.GetFileName(source));
            if (File.Exists(dstPath)) {
                Console.WriteLine($"\e[33m\"{dstPath}\" already exists, Overwriting...\e[0m");
                File.Delete(dstPath);
            }

            File.Copy(source, dstPath);
        }

        return 0;
    }
}