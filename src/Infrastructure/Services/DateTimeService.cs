using gis_photo_sharing_app.Application.Common.Interfaces;
using System;

namespace gis_photo_sharing_app.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
