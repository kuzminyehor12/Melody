using NAudio.Wave;

namespace Melody.Shared.Utils
{
    public static class WavUtils
    {
        public static double GetAudioDuration(Stream stream)
        {
            try
            {
                using (WaveFileReader audioFile = new WaveFileReader(stream))
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
