using System;
using System.Collections.Generic;
using System.Text;

namespace lab10yauri
{
    public class MonkeysPageViewModel_yauri : ViewModelBase_yauri
    {
        public IList<Monkey_yauri> Monkeys { get { return MonkeyData_yauri.Monkeys; } }

        Monkey_yauri selectedMonkey;
        public Monkey_yauri SelectedMonkey
        {
            get { return selectedMonkey; }
            set
            {
                if (selectedMonkey != value)
                {
                    selectedMonkey = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}





