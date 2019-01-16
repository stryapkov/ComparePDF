using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparePDF
{
    interface IView
    {
        string OutputFolder { get; set; }
        string FindFolder { get; set; }
        ObservableCollection<CopyFileInfo> Result {  set; }
        string TypeFile { get; set; }
        bool CheckAllFolder { get; set; }
        int CountCoincidence { get; set; }
        bool BlockButton { set; }
        bool Progress { set; }
    }
}
