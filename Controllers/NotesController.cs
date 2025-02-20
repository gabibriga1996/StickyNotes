using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StickyNotesAPIG.Models;

namespace StickyNotesAPIG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]  // הוספת האישור לכל הפעולות ב-Controller הזה
    public class NotesController : ControllerBase
    {
        // דוגמת פעולה לצפייה בפתקים
        [HttpGet]
        public ActionResult<List<Note>> GetNotes()
        {
            // חזור עם הפתקים של המשתמש (דוגמה)
            var notes = new List<Note>{new(){Id=1,Content="2",CreatedAt=DateTime.Now,Title="some title",UserId="user_1"},new(){Id=2,Content="3",CreatedAt=DateTime.Now,Title="some title 1",UserId="user_2"}};
            return Ok(notes);
        }
        // דוגמת פעולה ליצירת פתק חדש
        [HttpPost]
        public IActionResult CreateNote([FromBody] string note)
        {
            // כאן הוספת לוגיקה לשמירת הפתק
            return Ok($"Note '{note}' created successfully.");
        }

        // // דוגמת פעולה למחיקת פתק
         [HttpDelete("{id}")]
         public IActionResult DeleteNote(int id)
         {
             // כאן הוספת לוגיקה למחיקת פתק
            
             return Ok($"Note with ID {id} deleted.");
         }


        [HttpPut("{id}")]
 public  IActionResult UpdateNote(int id, [FromBody] Note updatedNote)
{
    //var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

    // if (note == null)
    // {
    //     return NotFound(new { message = "Note not found" });
    // }

    // // בדיקה שהמשתמש יכול לעדכן רק את הפתקים שלו
    // var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    // if (note.UserId != userId)
    // {
    //     return Forbid(); // מחזיר שגיאה 403 אם המשתמש לא הבעלים
    // }

    // // עדכון הנתונים
    // note.Title = updatedNote.Title;
    // note.Content = updatedNote.Content;
    // note.CreatedAt = DateTime.UtcNow; // אפשר לשמור גם את תאריך העדכון

    // await _context.SaveChangesAsync();

    return Ok(new { message = $"Note with ID {id} updated successfully"});
}



        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteNote(int id)
        // {
        //     var note = await _context.Notes.FindAsync(id);

        //     if (note == null)
        //     {
        //         return NotFound(new { message = "Note not found" });
        //     }

        //     // בדיקה שהמשתמש יכול למחוק רק את הפתקים שלו
        //     var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        //     if (note.UserId != userId)
        //     {
        //         return Forbid(); // מחזיר שגיאה 403 אם המשתמש לא הבעלים
        //     }

        //     _context.Notes.Remove(note);
        //     await _context.SaveChangesAsync();

        //     return Ok(new { message = $"Note with ID {id} deleted successfully" });
        // }


    }
}