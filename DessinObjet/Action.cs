using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessinObjet
{
    internal class Action
    {
        public Type_Action TypeAction {get; set;}
        public ISupprimable Objet { get; set;}
        public void Undo()
        {
            switch (TypeAction)
            {
                case Type_Action.Detruire:
                    Objet.Supprimé = false;
                    break;
                case Type_Action.Creer:
                    Objet.Supprimé = true;
                    break;
            }
        }

        public void Redo()
        {
            switch (TypeAction)
            {
                case Type_Action.Detruire:
                    Objet.Supprimé = true;
                    break;
                case Type_Action.Creer:
                    Objet.Supprimé = false;
                    break;
            }
        }
    }

    
}
