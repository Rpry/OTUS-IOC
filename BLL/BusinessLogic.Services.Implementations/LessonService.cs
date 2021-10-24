using System;
using BusinessLogic.Abstractions;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Сервис работы с уроками
    /// </summary>
    public class LessonService : ILessonService
    {
        private Guid instanceId;
        
        public LessonService()
        {
            instanceId = Guid.NewGuid();
        }
    }
}