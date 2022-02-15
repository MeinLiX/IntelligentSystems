using Phatic_dialogue_L1.Source.Dictionaries;
using System.Text;

namespace Phatic_dialogue_L1.Source
{
    public static class Brain
    {
        public static string GetPredict(string input)
        {
            BMessage msg = new(input);

            return msg.GenerateAnswer();
        }

        private static string GenerateAnswer(this BMessage bMessage)
        {
            string answer = GenerateIdk();
            Specification.Cues[CueSpec.Greetings].ForEach(w =>
            {
                if (bMessage.SplittedText.Contains(w.Text))
                {
                    answer = GenerateGreeting();
                }

            });

            return answer;
        }

        private static string GenerateIdk()
        {
            StringBuilder sb = new();
            sb.AppendWithSplitter(Specification.GetRandomCue(CueSpec.Idk));

            sb.TryAppendDotEndSplitter();
            return sb.ToString();
        }

        private static string GenerateGreeting()
        {
            StringBuilder sb = new();
            sb.Append(Specification.GetRandomCue(CueSpec.Greetings).Text);

            if (new Random().Next(0, 4) == 1)
            {
                sb.AppendWithSplitter(Specification.GetRandomCue(CueSpec.Common), ", ");
            }


            sb.TryAppendDotEndSplitter();
            return sb.ToString();
        }

        private static void AppendWithSplitter(this StringBuilder sb, MessageModel mm, string behinderSplitter = "")
            => sb.Append($"{behinderSplitter}{mm.Text}{GetSplitter(mm)}");

        private static void TryAppendDotEndSplitter(this StringBuilder sb)
        {
            sb[0] = char.ToUpper(sb[0]);

            for (int i = 0; i < sb.Length; i++)
                if (sb[i] == '!' &&
                    sb[i] == '?' &&
                    sb[i] == '.' &&
                    i < sb.Length - 2)
                {
                    sb[i + 2] = char.ToUpper(sb[i + 2]);
                }
            

            if (sb[^1] != '!' &&
               sb[^1] != '?' &&
               sb[^1] != '.')
            {
                sb.Append(". ");
            }
        }

        private static string GetSplitter(MessageModel mm) => mm.MessageType switch
        {
            MessageType.command => "!",
            MessageType.question => "?",
            _ => ""
        };

    }
}
