using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TaskBoard.Data
{
	public class Board
	{
		[Key]
		[Comment("Board Identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(DataConstants.Board.NameMaxLength)]
		[Comment("Board Name")]
		public string Name { get; set; } = string.Empty;

		public IEnumerable<Task> Tasks { get; set; } = new List<Task>();
    }
}