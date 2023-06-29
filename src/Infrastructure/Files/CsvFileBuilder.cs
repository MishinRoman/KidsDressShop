using System.Globalization;
using KidsDressShop.Application.Common.Interfaces;
using KidsDressShop.Application.TodoLists.Queries.ExportTodos;
using KidsDressShop.Infrastructure.Files.Maps;
using CsvHelper;

namespace KidsDressShop.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
