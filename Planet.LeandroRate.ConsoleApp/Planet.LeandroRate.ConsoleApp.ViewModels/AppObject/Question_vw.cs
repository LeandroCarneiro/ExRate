using System.Collections.Generic;

namespace Planet.LeandroRate.ConsoleApp.ViewModels.AppObjects
{
    public class Question_vw : EntityBase_vw<long>
    {
        public string Title { get; set; }
        public string Help { get; set; }
        public IEnumerable<Answer_vw> Answers { get; set; }
    }
}