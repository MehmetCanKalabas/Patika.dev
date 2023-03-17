using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_
{
    public interface IPhoneBook
    {
        void AddNewContact();

        void DeleteContact();

        void UpdateContact();

        void ListAllContacts();

        void SearchContact();

        void PreferencesOrExitMenu();

        void ExitPhoneBook();

    }
}
