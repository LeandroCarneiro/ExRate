using LeandroExRate.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeandroExRate.Domain.Entities
{
    [Table("tbl_answers")]
    public class Answer : EntityBase<long>
    {
        public string Text { get; set; }
        public EAnswerType Type { get; set; }
    }
}