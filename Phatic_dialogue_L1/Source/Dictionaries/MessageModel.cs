namespace Phatic_dialogue_L1.Source.Dictionaries;

public class MessageModel
{
    public readonly string Text;
    public readonly MessageType MessageType;

    public MessageModel(string text, MessageType messageType)
    {
        Text = text;
        MessageType = messageType;
    }
}
