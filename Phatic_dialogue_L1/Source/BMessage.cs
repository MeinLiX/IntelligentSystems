namespace Phatic_dialogue_L1.Source;

public class BMessage
{
    private string _text = string.Empty;
    public string Text
    {
        get => _text;
        set => _text = PreProcessText(value);
    }
    public MessageType MessageType { get; set; } = MessageType.unset;

    public List<string> KeyWords { get; private set; } = new();
    public List<string> SplittedText { get; private set; } = new();

    public BMessage(string textForProcessing)
    {
        Text = textForProcessing;
        PullOutKeyWords();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="key">Itterator</param>
    /// <param name="keyword">Return keywords when TRUE also all message words</param>
    public string this[int key, bool keyword = false]
    {
        get => keyword ? KeyWords[key] : SplittedText[key];
    }

    public System.Collections.IEnumerator GetEnumerator(bool keyword = false) => keyword ? KeyWords.GetEnumerator() : SplittedText.GetEnumerator();

    private string PreProcessText(string input)
    {
        input = input.ToLower().Trim();
        

        SplittedText = input.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

        if (input.StartsWith("/"))
        {
            MessageType = MessageType.command;
        }
        else if (input.EndsWith("?"))
        {
            MessageType = MessageType.question;
        }
        else
        {
            MessageType = MessageType.narration;
        }


        return string.Join(" ", SplittedText);
    }

    private List<string> PullOutKeyWords()
    {
        KeyWords = new List<string>();
        SplittedText.ForEach(word => KeyWords.Add(word));
        return KeyWords;
    }


}


