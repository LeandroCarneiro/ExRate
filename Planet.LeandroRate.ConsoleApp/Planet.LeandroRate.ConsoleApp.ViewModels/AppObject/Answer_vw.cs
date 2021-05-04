using Planet.LeandroRate.ConsoleApp.Common.Enums;

namespace Planet.LeandroRate.ConsoleApp.ViewModels.AppObjects
{
    public class Answer_vw : EntityBase_vw<long>
    {
        public string Text { get; set; }
        public EAnswerType Type { get; set; }
    }
}