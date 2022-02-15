namespace Phatic_dialogue_L1.Source.Dictionaries;

public static class Specification
{
    public static MessageModel GetRandomCue(CueSpec spec) => Cues[spec][new Random().Next(0, Cues[spec].Count)];

    public static Dictionary<CueSpec, List<MessageModel>> Cues = new()
    {
        [CueSpec.Consent] = new()
        {
            new MessageModel("без сумніву", MessageType.narration),
            new MessageModel("маєте рацію", MessageType.narration),
            new MessageModel("правильно", MessageType.narration),
            new MessageModel("звісно", MessageType.narration),
            new MessageModel("100%", MessageType.narration),
            new MessageModel("так", MessageType.command),
        },
        [CueSpec.Disagreement] = new()
        {
            new MessageModel("не погоджуюсь", MessageType.command),
            new MessageModel("не згоден", MessageType.command),
            new MessageModel("жартуєш", MessageType.question),
            new MessageModel("ні", MessageType.command),
        },
        [CueSpec.Greetings] = new()
        {
            new MessageModel("здоровенькі були", MessageType.narration),
            new MessageModel("доброго здоров’я", MessageType.narration),
            new MessageModel("радий вітати Вас", MessageType.command),
            new MessageModel("добрий день", MessageType.narration),
            new MessageModel("привіт", MessageType.narration),
            new MessageModel("здоров", MessageType.narration),
            new MessageModel("вітаю", MessageType.narration),
            new MessageModel("хай", MessageType.narration),
            new MessageModel("ку", MessageType.narration),
            new MessageModel("qq", MessageType.narration),
        },
        [CueSpec.Idk] = new()
        {
            new MessageModel("не знаю, що відповісти", MessageType.narration),
            new MessageModel("мені потрібно подумати", MessageType.narration),
            new MessageModel("спробуйте ще", MessageType.command),
            new MessageModel("спробуйте знову", MessageType.command),
            new MessageModel("це ви мені", MessageType.question),
            new MessageModel("це ви до мене звертаєтесь", MessageType.question),
            new MessageModel("побережіть мій примітивний алгоритм", MessageType.question),
            new MessageModel("перепрошую", MessageType.question),
        },
        [CueSpec.Common] = new()
        {
            new MessageModel("чому так довго не виходили на зв'язок", MessageType.question),
            new MessageModel("не вірю своєму коду, які люди", MessageType.command),
            new MessageModel("хочете дізнатися секрет", MessageType.question),
            new MessageModel("як ся маєте", MessageType.question),
        }
    };
}

