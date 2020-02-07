using System;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;

namespace ToDoSpeech
{
    public class SpeechService
    {
        public async Task<string> RecognizeSpeechAsync(string selectedLanguage)
        {
            var config = SpeechConfig.FromSubscription("5bf83dc627494dd28fdaddf2d6d60ff2", "westeurope");

            using (var recognizer = new SpeechRecognizer(config, selectedLanguage))
            {
                var result = await recognizer.RecognizeOnceAsync();

                if (result.Reason == ResultReason.Canceled)
                {
                    var cancellation = CancellationDetails.FromResult(result);
                    throw new Exception($"CANCELED: Reason={cancellation.Reason}");
                }

                if (result.Reason == ResultReason.NoMatch)
                {
                    throw new Exception($"NOMATCH: Speech could not be recognized.");
                }

                return result.Text;
            }
        }
    }
}



