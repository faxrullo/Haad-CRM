using Haad_CRM.Models.Lesson;

namespace Haad_CRM.Interfaces;

public interface ILessonService
{
    Task<LessonViewModel> CreateAsync(LessonCreation lesson);
    Task<LessonViewModel> UpdateAsync(LessonUpdate lesson);
    Task<bool> DeleteAsync(long id);
    Task<LessonViewModel> GetByIdAsync(long id);
    Task<List<LessonViewModel>> GetAllAsync();
}
