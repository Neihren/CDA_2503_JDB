using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_EditeurTexte
{
    // Invoker Editeur de texte
    public class EditeurTexte
    {
        private readonly Stack<ICommand> undoStack;
        private readonly Stack<ICommand> redoStack;

        public EditeurTexte()
        {
            undoStack = new();
            redoStack = new();
        }

        public void Executer(ICommand command)
        {
            command.Execute();
            undoStack.Push(command);
            redoStack.Clear();
        }

        public void Annuler()
        {
            if (undoStack.Count > 0)
            {
                ICommand command = undoStack.Pop();
                command.Undo();
                redoStack.Push(command);
            }
        }

        public void Refaire()
        {
            if (redoStack.Count > 0)
            {
                ICommand command = redoStack.Pop();
                command.Execute();
                undoStack.Push(command);
            }
        }
    }
}
