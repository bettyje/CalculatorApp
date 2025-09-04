
---

### File 2: `PROMPT_JOURNAL.md` (Create this new file in your project root)

```markdown
# AI Prompt Journal

A log of the Generative AI prompts used to learn C# and build the Console Calculator toolkit.

---

### **Prompt 1: Foundation & Setup**
**Prompt:** 
"Explain C# to a total beginner. What is the smallest console app I can build in 30 minutes? Show steps and commands for Windows."

**AI Response Summary:**
The AI introduced C# and the .NET platform, explaining its use cases and core concepts like the `Main()` method. It provided the exact CLI commands (`dotnet new console`, `dotnet run`) to scaffold and run a "Hello World" application on Windows.

**Outcome:** Successfully created and ran the initial console project.
**Helpfulness:** 5/5
**Reflection:** This was a perfect starting point. It cut through the theoretical overview and gave me immediate, actionable commands to see a result, which is crucial for beginner motivation.

---

### **Prompt 2: Core Functionality**
**Prompt:** 
"Generate a menu-driven console calculator in C# with add, subtract, multiply, divide, power, and square root. Use methods for each operation."

**AI Response Summary:**
The AI provided a complete code skeleton using a `while` loop to keep the app running, a `switch` statement to handle menu options, and separate static methods (`PerformOperation`, `PerformSquareRoot`) to encapsulate the logic for each calculation. It included error handling for division by zero.

**Outcome:** The core calculator logic worked almost immediately after copying the code. Only minor adjustments were needed.
**Helpfulness:** 5/5
**Reflection:** This prompt was highly effective. It demonstrated key C# concepts in practice: methods, switch-case, conditional logic, and using the `Math` library. It gave me a functional project to dissect and learn from.

---

### **Prompt 3: Code Quality & Modern Standards**
**Prompt:** 
"My C# code has a warning: `CS8600: Converting null literal or possible null value to non-nullable type.` How do I fix this for `Console.ReadLine()`?"

**AI Response Summary:**
The AI explained that this is a warning from .NET's "nullable reference types" feature, which helps prevent null reference exceptions. It suggested changing the variable type from `string` to `string?` to explicitly indicate that `Console.ReadLine()` can return `null` (if Ctrl+Z is pressed).

**Outcome:** The warning was resolved by using `string? choice = Console.ReadLine();`.
**Helpfulness:** 4/5
**Reflection:** This was invaluable for learning modern C# best practices. It wasn't just a fix; it was a lesson in writing safer, more intentional code.

---

### **Prompt 4: Documentation**
**Prompt:** 
"Draft a beginner-friendly README for a C# console calculator project. Include sections for Objective, Setup, How to Run, and a code example."

**AI Response Summary:**
The AI generated a well-structured Markdown template with clear headings, code blocks, and placeholders for information. It provided the correct syntax for .NET CLI commands and emphasized the importance of step-by-step instructions.

**Outcome:** Used the structure and content as a foundation for the final `README.md` file.
**Helpfulness:** 5/5
**Reflection:** This prompt accelerated the documentation process significantly. It ensured the guide would be useful and accessible to other beginners, which is the core goal of a toolkit.