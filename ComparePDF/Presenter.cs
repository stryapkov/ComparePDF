using System;
using System.Threading;
using System.Windows.Forms;

namespace ComparePDF
{
    class Presenter
    {
        private IView view;
        private Model  model;
        bool checkThread = false;
        private Thread thread;
        private static object lockObject = new object();
        public Presenter(IView View)
        {
            view = View;
            model = new Model();
        }
        public void OpenFile()
        {
            model.FindIs();
            view.FindFolder = model.FindFolder;
        }
        public void OpenFilTo()
        {
            model.FindTo();
            view.OutputFolder = model.OutputFolder;
        }
        
        /// <summary>
        /// Метод запускающий метод поиска файлов в отдельном потоке
        /// и передающий данные на форму
        /// </summary>
        public void Searchs()
        {
            view.BlockButton = true;
            view.Progress = true;
            thread = new Thread(Search);
            thread.Name = "MyPotok";
            thread.Start();
           // thread.Join();
            while (checkThread == false)        // Цикл не дающий выполняться коду дальше пока
            {                                            //  сигнал checkThread не будет true
                Application.DoEvents();
            }
            checkThread = false;
            view.Result = model.Find.Result;
            view.CountCoincidence = model.Find.Result.Count;
        }
        /// <summary>
        /// Поиск копий файлов
        /// </summary>
        public void Search()
        {
                lock (lockObject)
                {
                    if (model.Find.Result != null)
                    {
                        model.Find.Result.Clear();
                        view.Result = model.Find.Result;
                    }
                try
                    {
                       model
                            .Find
                            .Search(view.FindFolder,
                                view.OutputFolder,
                                view.TypeFile,
                                model.Check());
                    }
                    catch (Exception)
                    {
                        if (checkThread)
                            MessageBox.Show("Поиск остановлен");
                        else
                        MessageBox.Show("Проверьте правильность пути\n по которому расположены папки");
                    }
                }
            checkThread = true;
        }
        /// <summary>
        /// Передача выбранного типа файла из формы в модель
        /// </summary>
        /// <param name="T"></param>
        public void TypeFiles(string T)
        {
            view.TypeFile = T;
            model.TypeFile = "."+T;
        }
        /// <summary>
        /// Сохранение в текстовый документ
        /// </summary>
        public void Save()
        {
            model.SaveTXT();
        }

        /// <summary>
        /// Очистка формы bool данных
        /// </summary>
        public void Clear()
        {
            model.FindFolder = "";
            view.FindFolder = "";
            model.OutputFolder = "";
            view.OutputFolder = "";
            model.TypeFile = ".PDF";
            view.TypeFile = "PDF";
            view.CountCoincidence = 0;
            // view.Result.Clear();
            if (model.Find.Result != null)
            {
                model.Find.Result.Clear();
                view.Result = model.Find.Result;
            }
        }
        /// <summary>
        /// Метод для остановки поиска
        /// </summary>
        public void StopSearch()
        {
            checkThread = true;
            thread.Abort();
            Thread.Sleep(500);
        }
    }
}
