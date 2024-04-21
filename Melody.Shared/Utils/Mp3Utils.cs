using NAudio.Wave;
using System.IO;

namespace Melody.Shared.Utils
{
    public static class Mp3Utils
    {
        public static double GetAudioDuration(Stream stream)
        {
            try
            {
                using (StreamMediaFoundationReader audioFile = new StreamMediaFoundationReader(stream))
                {
                    return audioFile.TotalTime.TotalSeconds;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
