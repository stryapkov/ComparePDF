using System.IO;
using System.Windows.Forms;

namespace ComparePDF
{
    class Model
    {
        #region variables
        private FolderBrowserDialog dialog;
        private FindPDF find=new FindPDF();
        private string outputFolder;
        private string findFolder;
        private string typeFile=".pdf";
        private bool checkAllFolder;
        #endregion


       
       //метод определяющий нажатие чекбокс
       //возвражает расширение для файла
        public string Check()
        {
            if (checkAllFolder == true)
                return "";
            else return typeFile;
        }
        //установка пути поиска из папки
        public void FindIs()
        {
            dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            findFolder = dialog.SelectedPath;
        }
        //установка пути поиска в папке
        public void FindTo()
        {
            dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            outputFolder = dialog.SelectedPath;
        }
        //сохранение результатов поиска копий файлов в текстовый документ
        public void SaveTXT()
        {
            //проверка списка
            if (Find.Result == null)
            {
                MessageBox.Show("Список пуст");
                return;
            }
                
            dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            //заапись в файл
            using (StreamWriter sw = new StreamWriter(dialog.SelectedPath + "\\spisok.txt", false, System.Text.Encoding.Default))
            {
                int count = 1;
                sw.WriteLine($"Поиск копий содержимого папки {findFolder} в папке {outputFolder}\n");
                foreach (var i in Find.Result)
                {
                    sw.WriteLine(count++ + ") Название файла:" + i.Names);
                    //sw.WriteLine(count++ + ") Имя Файла: " + Path.GetFileNameWithoutExtension(i) + "---" );
                    sw.WriteLine("Расположение: "+i.Patchs);
                }
            }
        }
        #region property data
        public FindPDF Find => this.find;
        public string FindFolder { get { return findFolder; } set { findFolder = value; } }
        public string OutputFolder { get { return outputFolder; } set { outputFolder = value; } }
        public string TypeFile { get { return typeFile; } set { typeFile = value; } }
        bool CheckAllFolder { get { return checkAllFolder; } set { checkAllFolder = value; } }
        #endregion

    }
}
