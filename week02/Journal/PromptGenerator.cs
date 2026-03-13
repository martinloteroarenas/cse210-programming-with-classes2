using System;
using System.Collections.Generic;
/*in the class PromptGenerator when we take a random prompt is usual to repeat prompt
because 5 is not enough so i added 5 propts more*/
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you eat for breakfast?",
        "What was something productive you did today?",
        "Was there a special event today like a birthday? if not, How are you going to prepare for the next event?",
        "did you enjoy a hobbie today?",
        "How did you work today to achieve your goals?"
    };
    public string GetRandomPrompt()
    {
        Random rng = new Random();
        int index = rng.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
}