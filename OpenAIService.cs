// using OpenAI;
// using OpenAI.Chat;
// using System.Collections.Generic;

// public class OpenAIService
// {
//     private readonly OpenAIClient _client;

//     public OpenAIService(string apiKey)
//     {
//         var openAiSettings = new OpenAiSettings(apiKey);
//         _client = new OpenAIClient(openAiSettings);
//     }

//     public async Task<string> GetChatResponseAsync(string userMessage)
//     {
//         // יצירת הודעות שיחה
//         var messages = new List<ChatMessage>
//         {
//             new ChatMessage
//             {
//                 Role = Role.System,
//                 Content = "אתה עוזר למשתמש."
//             },
//             new ChatMessage
//             {
//                 Role = Role.User,
//                 Content = userMessage
//             }
//         };

//         // // יצירת בקשה לשיחה
//         var request = new ChatCompletionRequest
//         {
//             Messages = messages,
//             Model = "gpt-3.5-turbo" // מודל מבית OpenAI
//         };

//         // שליחה ל-API לקבלת תשובה
//         var response = await _client.Chat.Completions.CreateCompletionAsync(request);

//         // החזרת התשובה
//         return response.Choices[0].Message.Content;
//     }
// }