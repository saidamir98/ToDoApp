using System.ComponentModel;

namespace WpfApplication3.Model
{
    public class TaskListModel { }

    public class TaskListObj : INotifyPropertyChanged
    {
        /// <summary>
        /// constructor
        /// </summary>
        public TaskListObj()
        {
            content = "";
            isComplete = false;
            isComplete = false;
            isEditing = "Hidden";
            editBtnText = "Edit";
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="obj"></param>
        public TaskListObj(TaskListObj obj)
        {
            this.Content = obj.Content;
            this.EditBtnText = obj.EditBtnText;
            this.Id = obj.Id;
            this.IsComplete = obj.IsComplete;
            this.IsEditing = obj.IsEditing;
        }

        #region class private inctance
        private int id;
        private string content;
        private bool isComplete;
        private string isEditing;
        private string editBtnText;
        #endregion

        #region class public inctance

        public string EditBtnText
        {
            get { return editBtnText; }
            set
            {
                if (editBtnText != value)
                {
                    editBtnText = value;
                    RaisePropertyChanged("EditBtnText");
                }
            }
        }

        public string IsEditing
        {
            get { return isEditing; }
            set
            {
                if (isEditing != value)
                {
                    isEditing = value;
                    RaisePropertyChanged("IsEditing");
                }
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        public string Content
        {
            get { return content; }
            set
            {
                if (content != value)
                {
                    content = value;
                    RaisePropertyChanged("Content");
                }
            }
        }

        public bool IsComplete
        {
            get { return isComplete; }
            set
            {
                if (isComplete != value)
                {
                    isComplete = value;
                    RaisePropertyChanged("IsComplete");
                }
            }
        }
        #endregion

        /// <summary>
        /// Event Handler class implementation
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
