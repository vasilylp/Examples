//----------------------------Лекция 5 Рекурсия--------------------------------
// // Задача составления всех возможных сллов из заданного перечня букв

// int n =1;
// void FindWords(string ejfposjdg, char[] word, int length = 0)
// {
//               if (length == word.Length)
//               {
//                    System.Console.WriteLine($"{n++} {new String(word)}");return;         
//               }
//               for (int i = 0; i < ejfposjdg.Length; i++)
//               {
//                       word[length] = ejfposjdg[i];
//                       FindWords(ejfposjdg, word, length +1);   
//               }
// }


// FindWords("dfgh", new char[5]);
// Задача обход директории------------------------------------------------

//string path = @"C:\Users\HP\Desktop\личные документы\GeekBrains\Курс Знакомство с языками программирования\Урок 1. Знакомство с языком С#";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi =di.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//        System.Console.WriteLine(fi[i].Name);       
// }
//====================================================================
// void CatalogInfo(string path, string indent ="")
// {
//               DirectoryInfo catalog = new DirectoryInfo(path);
//               DirectoryInfo[] catalogs = catalog.GetDirectories();
//               for (int i = 0; i < catalogs.Length; i++)
//               {
//                      System.Console.WriteLine($"{indent}{catalogs[i].Name}");
//                      CatalogInfo(catalogs[i].FullName, indent + "  ");       
//               }
//               FileInfo[] files = catalog.GetFiles();
//               for (int i = 0; i < files.Length; i++)
//               {
//                   System.Console.WriteLine($"{indent}{files[i].Name}");          
//               }
// }
//  string path = @"/Users/HP/Desktop/личные документы";
//  CatalogInfo(path);
//----------------------------------------------------------------------------------------
// // Задача с перестановкой блинов на 3 башни через Рекурсию---------------------------------
// void Towers( string with = "1", string on = "3", string some = "2", int count = 3)
// {
//               if (count > 1) Towers(with, some, on, count -1);
//               System.Console.WriteLine($"{with} >> {on} ");
//               if(count > 1) Towers(some, on, with, count -1);        
// }
//  Towers();
// Задача обход дерева (формулы)-----------------------------------------------------

// string emp = string.Empty;
// string[] tree = {emp, "/","*","10","-","+",emp,emp,"4","2","1","3"};
// //                0    1   2   3    4   5   6   7   8   9   10  11

// void InOrderTreversal(int pos =1)
// {
//               if (pos < tree.Length)
//               {
//                   int left = 2*pos;
//                   int right = 2*pos +1;
//                   if(left < tree.Length && !String.IsNullOrEmpty(tree[left]))InOrderTreversal(left);
//                   System.Console.WriteLine(tree[pos]); 
//                   if(right < tree.Length && !String.IsNullOrEmpty(tree[right]))InOrderTreversal(right);         
//               }
// }

// InOrderTreversal();
//==================================================================
