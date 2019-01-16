using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparePDF
{
    public partial class Form1 : Form, IView
    {
        //путь папки из которой ищем
        public string FindFolder
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        //путь папки в которой нужно искать
        public string OutputFolder
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        //свойство выводящее коллекцию совпадающих файлов в listView
        //и разблокировки кнопок после работы поиска
        public ObservableCollection<CopyFileInfo> Result
        {
            set
            {
             int count = 1;
                //если коллекция поиска пуста, то очищаем форму
                //и добавляем резултаты нового поиска
                if(value.Count==0)
                    listView1.Items.Clear();
                foreach (var e in value)
                {
                    listView1.Items.Add(count++ +") Название файла: "+e.Names);
                    listView1.Items.Add(e.Patchs);
                }
                btnSearch.Enabled = true;
                btnAddFolder1.Enabled = true;
                btnAddFolder2.Enabled = true;
                btnReset.Enabled = true;
                btnSave.Enabled = true;
                progressBar1.Maximum = 0;
            }
        }
        //свойство для отображения прогрессбара
        public bool Progress
        {
            set
            {
                if (value == true)
                    progressBar1.Maximum = 100;
            }
        }
        //свойство блокировки кнопок на форме
        public bool BlockButton
        {
            set
            {
                if (value == true)
                {
                    btnSearch.Enabled = false;
                    btnAddFolder1.Enabled= false;
                    btnAddFolder2.Enabled= false;
                    btnReset.Enabled= false;
                    btnSave.Enabled= false;
                }
            }
        }
        //свойство передачи типа искомого файла
        public string TypeFile
        {
            get { return lbInfoCheck.Text; }
            set { lbInfoCheck.Text = value; }
        }
        //поиск по всем названиям файлов без расширения 
        public bool CheckAllFolder
        {
            get { return cbAllFiles.Checked; }
            set { cbAllFiles.Checked = value; }
        }
        //вывод найденных элементов
        public int CountCoincidence
        {
            get { return Convert.ToInt32(lbCount.Text); }
            set { lbCount.Text = value.ToString(); }
        }

        Presenter p;
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            p = new Presenter(this);
            btnAddFolder1.Click += (s, e) => p.OpenFile();
            btnAddFolder2.Click += (s, e) => p.OpenFilTo();
            btnSearch.Click += (s, e) => p.Searchs();
            PDF.Click += (s, e)=> p.TypeFiles(nameof(PDF));
            DOC.Click += (s, e) => p.TypeFiles(nameof(DOC));
            DOCX.Click += (s, e) => p.TypeFiles(nameof(DOCX));
            XLSX.Click += (s, e) => p.TypeFiles(nameof(XLSX));
            btnSave.Click += (s, e) => p.Save();
            btnReset.Click += (s, e) => p.Clear();
            btnStop.Click += (s, e) => p.StopSearch();
        }
    }
}
