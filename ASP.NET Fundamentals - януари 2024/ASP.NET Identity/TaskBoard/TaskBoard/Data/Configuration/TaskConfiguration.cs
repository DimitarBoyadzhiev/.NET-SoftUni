using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskBoard.Data.Configuration
{
	public class TaskConfiguration : IEntityTypeConfiguration<Task>
	{
		

		public void Configure(EntityTypeBuilder<Task> builder)
		{
			builder
				.HasOne(t => t.Board)
				.WithMany(b => b.Tasks)
				.HasForeignKey(t => t.BoardId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(SeedTasks());
		}

		private IEnumerable<Task> SeedTasks()
		{
			return new Task[]
			{
				new Task()
				{
					Id = 1,
					Title = "Improve CSS Styles",
					Description = "Implement better CSS styles for pages",
					CreatedOn = DateTime.Now.AddDays(-200),
					OwnerId = ConfigurationHelper.TestUser.Id,
					BoardId = ConfigurationHelper.OpenBoard.Id
				},
				new Task()
				{
					Id = 2,
					Title = "Androit Client App",
					Description = "Create Android App",
					CreatedOn = DateTime.Now.AddMonths(-5),
					OwnerId = ConfigurationHelper.TestUser.Id,
					BoardId = ConfigurationHelper.OpenBoard.Id
				},
				new Task()
				{
					Id = 3,
					Title = "Desktop App",
					Description = "Create Desktop App for the TaskBoard RESTful API",
					CreatedOn = DateTime.Now.AddDays(-1),
					OwnerId = ConfigurationHelper.TestUser.Id,
					BoardId = ConfigurationHelper.InProgressBoard.Id
				},
				new Task()
				{
					Id = 4,
					Title = "Create Tasks",
					Description = "Implement [Create Task] page for adding tasks",
					CreatedOn = DateTime.Now.AddYears(-1),
					OwnerId = ConfigurationHelper.TestUser.Id,
					BoardId = ConfigurationHelper.DoneBoard.Id
				},
			};
		}
	}
}
