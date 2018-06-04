using System; 
using System.Windows.Input;

namespace WpfApplication3.Command
{
    /// <summary>
    /// Helper calss for deleting a task
    /// </summary>
   public class DeleteTaskCommand : ICommand { 
      Action<object> _TargetExecuteMethod; 
      Func<bool> _TargetCanExecuteMethod;

      public DeleteTaskCommand(Action<object> executeMethod)
      {
         _TargetExecuteMethod = executeMethod; 
      }

      public DeleteTaskCommand(Action<object> executeMethod, Func<bool> canExecuteMethod)
      { 
         _TargetExecuteMethod = executeMethod;
         _TargetCanExecuteMethod = canExecuteMethod; 
      }
		
      public void RaiseCanExecuteChanged() { 
         CanExecuteChanged(this, EventArgs.Empty); 
      }
		
      bool ICommand.CanExecute(object parameter) { 
		
         if (_TargetCanExecuteMethod != null) { 
            return _TargetCanExecuteMethod(); 
         } 
			
         if (_TargetExecuteMethod != null) { 
            return true; 
         } 
			
         return false; 
      }
			
      // Prism commands solve this in their implementation 
      public event EventHandler CanExecuteChanged = delegate { };
		
      void ICommand.Execute(object parameter) { 
         if (_TargetExecuteMethod != null) {
            _TargetExecuteMethod(parameter); 
         } 
      } 
   } 
}