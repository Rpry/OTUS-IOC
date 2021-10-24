using System;
using BusinessLogic.Abstractions;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Сервис работы со студентами
    /// </summary>
    public class StudentService : IStudentService
    {
        private Guid instanceId;
        
        public StudentService()
        {
            instanceId = Guid.NewGuid();
        }
    }
}