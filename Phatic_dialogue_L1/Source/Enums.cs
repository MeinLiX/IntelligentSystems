namespace Phatic_dialogue_L1.Source;

public enum MessageType
{
    unset = -1,

    //type
    command = 0,
    question,
    narration,
    notification
}

public enum CueSpec
{
    Consent,
    Disagreement,
    Greetings,
    Idk,
    Common
}