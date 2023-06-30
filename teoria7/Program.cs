/* string archivo = "/Documentos/notas.txt";
Console.WriteLine(Path.GetFullPath(archivo));
Console.WriteLine(Path.GetFileName(archivo));
Console.WriteLine(Path.GetExtension(archivo));
Console.WriteLine(Path.GetDirectoryName(archivo));
Console.WriteLine(Path.ChangeExtension(archivo, "doc"));
Console.WriteLine(Path.GetFileNameWithoutExtension(archivo));
Console.WriteLine(Path.GetTempPath()); */

/* string stDir = Environment.CurrentDirectory;
Console.WriteLine(stDir);   
DirectoryInfo dirInfo = new DirectoryInfo(stDir);
FileInfo[] archivos = dirInfo.GetFiles();
foreach (FileInfo archivo in archivos)
{
string st = $"{archivo.Name} {archivo.Length} bytes";
Console.WriteLine(st);
} */

StreamReader sr = new StreamReader("fuente.txt");
StreamWriter sw = new StreamWriter("destino.txt");


sw.Write(sr.ReadToEnd());

sr.Close(); sw.Close();