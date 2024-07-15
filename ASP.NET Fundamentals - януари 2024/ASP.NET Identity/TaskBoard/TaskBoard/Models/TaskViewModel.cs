using System.ComponentModel.DataAnnotations;
using TaskBoard.Data;

namespace TaskBoard.Models
{
	public class TaskViewModel
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(DataConstants.Task.TitleMaxLength)]
		[MinLength(DataConstants.Task.TitleMinLength)]
		public string Title { get; set; } = string.Empty;

		[Required]
		[MaxLength(DataConstants.Task.DesctiptionMaxLength)]
		[MinLength(DataConstants.Task.DesctiptionMinLength)]
		public string Description { get; set; } = string.Empty;

		[Required]
		public string Owner { get; set; } = string.Empty;
	}
}
