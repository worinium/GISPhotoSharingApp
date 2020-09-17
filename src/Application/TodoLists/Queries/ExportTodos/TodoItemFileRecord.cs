using gis_photo_sharing_app.Application.Common.Mappings;
using gis_photo_sharing_app.Domain.Entities;

namespace gis_photo_sharing_app.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
