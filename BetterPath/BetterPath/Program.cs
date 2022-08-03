using BetterPath;

Files files = new Files();
Bussiness bussiness = new Bussiness();


string fileName = "1000x1000.txt";
string pathDir = Directory.GetCurrentDirectory();
string path = pathDir.Replace("/bin/Debug/net6.0", "/Resources/" + fileName);


int[,] Mountain = files.GetData(path); // Get Matriz
bussiness.FindPath(Mountain); 