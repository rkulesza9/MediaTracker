using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData
{
    public class CConstants
    {
        public const string FILE_DIALOG_FILTER = "json files (*.json)|*.json|All Files (*.*)|*.*";
        public const string FILE_DIALOG_TITLE_NEW = "Create New File...";
        public const string FILE_DIALOG_TITLE_OPEN = "Open File...";
        public const string FILE_DIALOG_TITLE_SAVEAS = "Save File As...";
        public const string FILE_DIALOG_MSGBOX_NEW = "New File Created.";
        public const string FILE_DIALOG_MSGBOX_OPEN = "File Opened";
        public const string FILE_DIALOG_MSGBOX_SAVEAS = "File Saved";
        public const string FILE_DIALOG_MSGBOX_SAVE = "File Saved.";

        public const string OBJECT_SERIES_TYPE_NEW = "<New Series Type>";
        public const string OBJECT_SERIES_NEW = "<New Series>";
        public const string OBJECT_ISSUE_NEW = "<New Issue>";

        public const string STATUS_BAR_TEXT = "Select A File.";

        public const int CLASS_SERIES_TYPE = 0;
        public const int CLASS_SERIES = 1;
        public const int CLASS_ISSUE = 2;

        public const int LISTVIEW_SERIES_TYPE = 0;
        public const int LISTVIEW_SERIES = 1;
        public const int LISTVIEW_ISSUE = 2;
    }
}
