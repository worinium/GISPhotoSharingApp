using gis_photo_sharing_app.Application.Common.Mappings;
using gis_photo_sharing_app.Domain.Entities;
using System.Collections.Generic;

namespace gis_photo_sharing_app.Application.TodoLists.Queries.GetTodos
{
    public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = new List<TodoItemDto>();
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public IList<TodoItemDto> Items { get; set; }
}
}
