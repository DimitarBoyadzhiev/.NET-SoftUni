using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskBoard.Data
{
	[Comment("Board Tasks")]
	public class Task
	{
		[Key]
		[Comment("Task Identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(DataConstants.Task.TitleMaxLength)]
		[Comment("Task Title")]
		public string Title { get; set; } = string.Empty;

		[Required]
		[MaxLength(DataConstants.Task.DesctiptionMaxLength)]
		[Comment("Task Description")]
		public string Description { get; set; } = string.Empty;

		[Comment("Task Created On Date")]
		public DateTime? CreatedOn { get; set; }

		[Comment("Board Identifier")]
		public int? BoardId { get; set; }

		[Required]
		[Comment("Application user Identifier")]
		public string OwnerId { get; set; } = string.Empty;

		[ForeignKey(nameof(BoardId))]
        public Board? Board { get; set; }

		[ForeignKey(nameof(OwnerId))]
		public IdentityUser Owner { get; set; } = null!;
    }
}
