using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparePDF
{
    /// <summary>
    /// Структура содержащая в себе имя и путь файла
    /// </summary>
    public partial struct CopyFileInfo
    {
        
        public CopyFileInfo(string Name, string Patch)
        {
            name = Name;
            patch = Patch;
        }

        string name;
        string patch;
        public string Names
        {
            get { return name; }
            set { name = value; }
        }
        public string Patchs
        {
            get { return patch; }
            set { patch = value; }
        }
    }

    class FindPDF
        {
            ObservableCollection<CopyFileInfo> list;

            //поиск только по буквам и цифрамб без учета пробелов и символов
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            /// <summary>
            /// Производит поиск копий файлов с определенным разрешением в вбранных директориях ПК,
            /// поиск производится двумя спопобами: 1. поиск фалов с одинаковым расширением
            /// 2.поиск фалов одного расширения файлов в одной папке и все вхождения копий имени файла в искомой папке
            /// </summary>
            /// <param name="findFolder">Путь к папке из которой производим поиск</param>
            /// <param name="outputFolder">Путь к папке в которой ищем</param>
            /// <param name="typeFile1">Тип файла по которому производится поиск в исходной папке</param>
            /// <param name="typeFile2">Тип файла по которому производится поиск в искомой папке</param>
            /// <returns></returns>
            public ObservableCollection<CopyFileInfo> Search(string findFolder,
                string outputFolder,
                string typeFile1,
                string typeFile2)
            {
                list = new ObservableCollection<CopyFileInfo>();
                //помещение в переменную всех файлов определенного расширения из выбранной папки
                var result = Directory.EnumerateFiles(findFolder, $"*{typeFile1}",
                    SearchOption.AllDirectories);
                var res = Directory.EnumerateFiles(outputFolder, $"*{typeFile2}",
                    SearchOption.AllDirectories);
                //сравнение имен файлов из переменных result и res и добавление в коллекцию
                foreach (var m in result)
                foreach (var i in res)
                {
                    if (rgx.Replace(Path.GetFileNameWithoutExtension(m), "")
                        ==
                        rgx.Replace(Path.GetFileNameWithoutExtension(i), ""))
                    {
                        list.Add(new CopyFileInfo(Path.GetFileNameWithoutExtension(i), i.ToString()));
                    }
                }

                return list;
            }

            public ObservableCollection<CopyFileInfo> Result
            {
                get { return list; }
                set { list = value; }
            }

        }
    }

