using clean.Application.Common.Interfaces;
using System;

namespace clean.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
