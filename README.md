# StickyNotes
StickyNotes-project
StickyNotesAPIG
 StickyNotesAPIG הוא פרויקט לניהול פתקים דיגיטליים באמצעות API מבוסס .NET Core עם   Angular בפרונט-אנד.
תכונות עיקריות
•	יצירה, עריכה, מחיקה ושליפה של פתקים באמצעות POSTMAN
•	אימות משתמשים באמצעות JWT 
•	שימוש ב-OpenAI לשכתוב טקסט
•	שמירת נתונים ב-SQL Server
•	תמיכה ב-CORS
טכנולוגיות
•	Backend: .NET Core (C#) עם  RESTful API
•	Frontend: Angular
•	Database: SQL Server
•	Authentication: JSON Web Tokens (JWT)
•	AI Services: OpenAI
התקנה והרצה
1.	Clone the repository: 
2.	git clone https://github.com/gabibriga1996/StickyNotes.git
3.	נווט לתיקייה: 
4.	cd StickyNotesAPIG
5.	התקנת תלויות Backend: 
6.	dotnet restore
7.	הרצת ה-Backend: 
8.	dotnet run
API Routes
•	 POST /api/auth/login - כניסה למערכת וקבלת טוקן JWT
•	 GET /api/notes - קבלת כל הפתקים של המשתמש
•	 POST /api/notes - יצירת פתק חדש
•	 PUT /api/notes/{id} - עדכון פתק קיים
•	 DELETE /api/notes/{id} - מחיקת פתק

