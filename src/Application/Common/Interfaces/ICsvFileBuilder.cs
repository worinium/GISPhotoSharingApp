using gis_photo_sharing_app.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace gis_photo_sharing_app.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
