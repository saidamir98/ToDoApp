﻿using System; 
using System.Windows.Input;

namespace WpfApplication3.Command
{
    /// <summary>
    /// Helper Class for adding new task
    /// </summary>
   public class AddNewTaskCommand : ICommand { 
      Action _TargetExecuteMethod; 
      Func<bool> _TargetCanExecuteMethod;
		
      public AddNewTaskCommand(Action executeMethod) {
         _TargetExecuteMethod = executeMethod; 
      }
		
      public AddNewTaskCommand(Action executeMethod, Func<bool> canExecuteMethod){ 
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

      public event EventHandler CanExecuteChanged = delegate { };
		
      void ICommand.Execute(object parameter) { 
         if (_TargetExecuteMethod != null) {
            _TargetExecuteMethod(); 
         } 
      } 
   } 
}