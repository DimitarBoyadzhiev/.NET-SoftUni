using System.ComponentModel.DataAnnotations;
using TaskBoard.Data;

namespace TaskBoard.Models
{
    public class TaskFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequireError)]
        [StringLength(DataConstants.Task.TitleMaxLength,
            MinimumLength = DataConstants.Task.TitleMinLength,
            ErrorMessage = ErrorMessages.StringLengtError)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.RequireError)]
        [StringLength(DataConstants.Task.DesctiptionMaxLength, 
            MinimumLength = DataConstants.Task.DesctiptionMinLength,
            ErrorMessage = ErrorMessages.StringLengtError)]
        public string Description { get; set; } = string.Empty;

        public int? BoardId { get; set; }

        public IEnumerable<TaskBoardModel> Boards { get; set; } = new List<TaskBoardModel>();
    }
}
