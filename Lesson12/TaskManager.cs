
namespace Lesson12
{
    internal class TaskManager
    {
        public List<Task> Tasks { get; set; } = new();
        public List<Event> Events { get; set; } = new();
        public void AddTask(Task task)=>Tasks.Add(task);
        public void RemoveTaskEvent(string name)
        {
            foreach (var task in Tasks)
            {
                if (task.Name == name)
                {
                    Tasks.Remove(task);
                    break;
                }
            }
            foreach (var @event in Events)
            {
                if (@event.Name == name)
                {
                    Events.Remove(@event);
                    break;
                }
            }
        }
        public void AddEvent(Event @event)=>Events.Add(@event);


        public void Print()
        {
            foreach (var task in Tasks)
            {
                task.Display();
            }
            foreach (var @event in Events)
            {
                @event.Display();
            }
        }
    }
}
