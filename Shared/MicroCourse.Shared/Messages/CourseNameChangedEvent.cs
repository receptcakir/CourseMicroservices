using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCourse.Shared.Messages
{
    public class CourseNameChangedEvent
    {
        public string CourseId { get; set; }
        public string UpdatedName { get; set; }
    }
}