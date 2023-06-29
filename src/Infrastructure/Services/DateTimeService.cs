using KidsDressShop.Application.Common.Interfaces;

namespace KidsDressShop.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
