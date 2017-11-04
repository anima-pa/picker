using PickerItems.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PickerItems.ViewModel
{
    public class MainPageViewModel
    {     
        public List<States> states { get; set; } = new List<States>();
        public ObservableCollection<States> state { get; set; } = new ObservableCollection<States>();
        public List<string> countries = new List<string>
    {
        "Afghanistan",
        "Albania",
        "Algeria",
        "Andorra",
        "Angola",
        "India",
        "Pakistan",
    };
        public MainPageViewModel()
        {
           
            //Database
            states.Add(new States { State = "Kerala", Country = "India"});
            states.Add(new States { State = "Tamilnadu", Country = "India" });
            states.Add(new States { State = "jammu", Country = "India" });
            states.Add(new States { State = "pak", Country = "Pakistan" });
            states.Add(new States { State = "lahore", Country = "Pakistan" });
            states.Add(new States { State = "pak2", Country = "Pakistan" });
            states.Add(new States { State = "Tamil", Country = "Afghanistan" });
            states.Add(new States { State = "jam", Country = "Albania" });
            states.Add(new States { State = "p", Country = "Algeria" });
            states.Add(new States { State = "lre", Country = "Angola" });
            states.Add(new States { State = "karanchi", Country = "Pakistan" });
        }

       
        public void addStates(string selectedItem)
        {     
            state.Clear();
            Debug.WriteLine("VM:  "+selectedItem);
            for (var i = 0; i < states.Count; i++)
            {
                if (states[i].Country == selectedItem)
                {
                    state.Add(new States { State = states[i].State, Country = states[i].Country });
                    
                }
            }
            
        }
    }
}
