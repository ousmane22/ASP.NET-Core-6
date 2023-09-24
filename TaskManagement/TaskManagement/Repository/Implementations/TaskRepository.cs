using TaskManagement.Data;
using TaskManagement.Repository.Interfaces;

namespace TaskManagement.Repository.Implementations
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagementDbContext _taskManagementDbContext;

        public TaskRepository(TaskManagementDbContext taskManagementDbContext)
        {
            _taskManagementDbContext = taskManagementDbContext;
        }

        public Task AddTask(Task task)
        {

         
        }

        public Task DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task GetTask(int id)
        {
            throw new NotImplementedException();
        }
    }
}
