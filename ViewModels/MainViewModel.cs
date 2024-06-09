using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikklient.ViewModels
{
    public class MainViewModel
    {
        public ICollection<string> HttpVerbs { get; set; }
        public string InitialEditorText { get; set; }

        public MainViewModel()
        {
            HttpVerbs = new List<string>() { "GET", "POST", "PUT", "PATCH", "DELETE" };
            InitialEditorText = @"/ $$$$$$                                           / $$             / $$     / $$                       / $$   / $$ / $$$$$$$  / $$               / $$$
| _  $$_ /                                          | $$            | $$    | $$                      | $$  | $$| $$__  $$| $$              | _  $$
  | $$   / $$$$$$$   / $$$$$$$  / $$$$$$   / $$$$$$  / $$$$$$         / $$$$$$  | $$$$$$$   / $$$$$$       | $$  | $$| $$  \ $$| $$             / $$\  $$
  | $$  | $$__  $$ / $$_____ / / $$__  $$ / $$__  $$| _  $$_ /        | _  $$_ /  | $$__  $$ / $$__  $$      | $$  | $$| $$$$$$$/| $$            | __ / | $$
  | $$  | $$  \ $$| $$$$$$ | $$$$$$$$| $$  \__ /  | $$            | $$    | $$  \ $$| $$$$$$$$      | $$  | $$| $$__  $$| $$                 | $$
  | $$  | $$  | $$ \____  $$| $$_____ /| $$        | $$ / $$        | $$ / $$| $$  | $$| $$_____ /      | $$  | $$| $$  \ $$| $$             / $$ / $$/
 / $$$$$$| $$  | $$ / $$$$$$$/| $$$$$$$| $$        | $$$$/        | $$$$/| $$  | $$| $$$$$$$      | $$$$$$/| $$  | $$| $$$$$$$$      | $/ $$$/
| ______ /| __ /  | __ /| _______ /  \_______ /| __ /         \___ /           \___ /  | __ /  | __ / \_______ /       \______ / | __ /  | __ /| ________ /      | _ / ___ /";
        }
    }

}
