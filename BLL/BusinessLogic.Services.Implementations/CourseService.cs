using System;
using BusinessLogic.Abstractions;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Cервис работы с курсами
    /// </summary>
    public class CourseService : ICourseService
    {
        private Guid instanceId;
        
        public CourseService()
        {
            instanceId = Guid.NewGuid();
        }
    }
}