using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;

namespace ToDoAzure.Speech
{
    public class SpeechService
    {
        public static async Task<string> RecognizeSpeechAsync()
        {
            var config = SpeechConfig.FromSubscription("844213cc6234423295a082b7745243e0", "westeurope");

            using (var recognizer = new SpeechRecognizer(config, "pl-PL"))
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
