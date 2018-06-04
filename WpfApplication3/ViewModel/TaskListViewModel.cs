using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using WpfApplication3.Command;
using WpfApplication3.Model;

namespace WpfApplication3.ViewModel
{
    public class TaskListViewModel
    {
        /// <summary>
        /// constructor
        /// </summary>
        public TaskListViewModel()
        {
            //initializee with zero current Items number in the list
            itemsNum = 0;

            //loads list
            LoadTasks();

            //initialize command for adding new task
            _AddNewTaskCommand = new AddNewTaskCommand(OnAdd, CanAdd);
            NewTask = new TaskListObj ();
            //initialize command for deleting all task
            _DeleteAllTaskCommand = new DeleteAllTaskCommand(OnDeleteAll, CanDeleteAll);
            //initialize command for deleting a task
            _DeleteTaskCommand = new DeleteTaskCommand(OnDelete, CanDelete);
            //initialize command for editing a task
            _EditTaskCommand = new EditTaskCommand(OnEdit, CanEdit);

        }

        //new task object
        private TaskListObj _newTask { get; set; }

        /// <summary>
        /// Task List Items
        /// </summary>
        public ObservableCollection<TaskListObj> Tasks { get; set; }
        //Number of Items in current list
        private static int itemsNum;
        
        /// <summary>
        /// Loads Items
        /// </summary>
        public void LoadTasks()
        {
            ObservableCollection<TaskListObj> tasks = new ObservableCollection<TaskListObj>();
            tasks.Add(new TaskListObj { Id = itemsNum++, Content = "Hello, World!)", IsComplete = true, IsEditing = "Hidden", EditBtnText = "Edit" });
            tasks.Add(new TaskListObj { Id = itemsNum++, Content = "Task 1", IsComplete = true, IsEditing = "Hidden", EditBtnText = "Edit" });
            tasks.Add(new TaskListObj { Id = itemsNum++, Content = "Task 2", IsComplete = false, IsEditing = "Visible", EditBtnText = "Done" });
            tasks.Add(new TaskListObj { Id = itemsNum++, Content = "Task 3", IsComplete = true, IsEditing = "Hidden", EditBtnText = "Edit" });
            Tasks = tasks;
        }


        /// <summary>
        /// Add New Task Command
        /// </summary>
        #region Add New Task Command Region
        public AddNewTaskCommand _AddNewTaskCommand { get; set; }

        private void OnAdd()
        {
            if (!string.IsNullOrWhiteSpace(NewTask.Content)) { 
            Tasks.Add(new TaskListObj { Id = itemsNum++, Content = NewTask.Content, IsComplete = NewTask.IsComplete, IsEditing = NewTask.IsEditing, EditBtnText = NewTask.EditBtnText });
            NewTask.Content = "";
            }
        }

        private bool CanAdd()
        {
            if (NewTask == null)
                return false;
            return true;
        }

        public TaskListObj NewTask
        {
            get { return _newTask; }
            set
            {
                if (_newTask != value) { _newTask = value; _AddNewTaskCommand.RaiseCanExecuteChanged(); }
            }
        }
        #endregion

        /// <summary>
        /// Delete All Task Command
        /// </summary>
        #region Delete All Task Command Region
        public DeleteAllTaskCommand _DeleteAllTaskCommand { get; set; }
        private void OnDeleteAll()
        {
            Tasks.Clear();
            itemsNum = 0;
        }

        private bool CanDeleteAll()
        {
            if (Tasks.Count == 0)
                return false;
            return true;
        }
        #endregion

        #region Delete Task Command Region
        public DeleteTaskCommand _DeleteTaskCommand { get; set; }
        private void OnDelete(object index)
        {
            int val = (int)index;
            Tasks.RemoveAt(val);
            itemsNum--;
            for (int i = 0; i < itemsNum; i++)
            {
                Tasks[i].Id = i;
            }
        }

        private bool CanDelete()
        {
            if (Tasks.Count == 0)
                return false;
            return true;
        }
        #endregion


        /// <summary>
        /// Edit Task Command
        /// </summary>
        #region Edit Task Command Region
        public EditTaskCommand _EditTaskCommand { get; set; }
        private void OnEdit(object index)
        {
            int val = (int)index;
            if (Tasks[val].IsEditing == "Hidden")
            {
                Tasks[val].IsEditing = "Visible";
                Tasks[val].EditBtnText = "Done";
            }
            else
            {
                Tasks[val].IsEditing = "Hidden";
                Tasks[val].EditBtnText = "Edit";
            }

        }

        private bool CanEdit()
        {
            if (Tasks.Count == 0)
                return false;
            return true;
        }
        #endregion

    }
}
