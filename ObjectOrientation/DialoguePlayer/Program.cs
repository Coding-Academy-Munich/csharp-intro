using Dialogue;

// Joe (sad): Oh, that is so terrible!
// Jill: What's the matter?
// Joe: I lost my MacGuffin!
// Jill: You never take care of things!
// Joe: You're one to talk!
// Jill: Luckily for you, I've found your MacGuffin!
// Joe: Oh, Jill, you are the best!

Line[] lines = [
    new Line("Joe", "Oh, that is so terrible!", Emotion.Sad),
    new Line("Jill", "What's the matter?"),
    new Line("Joe", "I lost my MacGuffin!", Emotion.Sad),
    new Line("Jill", "You never take care of things!", Emotion.Angry),
    new Line("Joe", "You're one to talk!", Emotion.Angry),
    new Line("Jill", "Luckily for you, I've found your MacGuffin!"),
    new Line("Joe", "Oh, Jill, you are the best!", Emotion.Happy),
 ];

DialoguePlayer dialoguePlayer = new();
dialoguePlayer.AddRange(lines);
dialoguePlayer.Present();


List<ILine> colorLines = [
    new ColorLine("Joe", "Oh, that is so terrible!", Emotion.Sad),
    new ColorLine("Jill", "What's the matter?", note: "Holding something behind her back."),
    new ColorLine("Joe", "I lost my MacGuffin!", Emotion.Sad),
    new ColorLine("Jill", "You never take care of things!", Emotion.Angry),
    new ColorLine("Joe", "You're one to talk!", Emotion.Angry),
    new ColorLine("Jill", "Luckily for you, I've found your MacGuffin!", note: "Revealing the MacGuffin"),
    new ColorLine("Joe", "Oh, Jill, you are the best!", Emotion.Happy),
 ];

DialoguePlayer colorDialoguePlayer = new();
colorDialoguePlayer.AddRange(colorLines);
colorDialoguePlayer.Present("\nColor Dialogue Player:");


List<ILine> practiceLines = [
    new ColorLine("Joe", "Oh, that is so terrible!", Emotion.Sad),
    new Line("Jill", "What's the matter?", pauseBeforeStart: true),
    new ColorLine("Joe", "I lost my MacGuffin!", Emotion.Sad),
    new Line("Jill", "You never take care of things!", Emotion.Angry, true),
    new ColorLine("Joe", "You're one to talk!", Emotion.Angry),
    new Line("Jill", "Luckily for you, I've found your MacGuffin!", pauseBeforeStart: true),
    new ColorLine("Joe", "Oh, Jill, you are the best!", Emotion.Happy),
 ];

DialoguePlayer practiceDialoguePlayer = new();
practiceDialoguePlayer.AddRange(practiceLines);
practiceDialoguePlayer.Present("\nPractice Dialogue Player");
