using KidsDressShop.Application.TodoLists.Queries.ExportTodos;

namespace KidsDressShop.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
