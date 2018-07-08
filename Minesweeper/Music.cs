using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace Minesweeper
{
    public class Music
    {
        SoundPlayer slipSound;//按鍵聲音
        SoundPlayer bombSound;//炸彈聲音
        public static bool slipSoundBool;
        public static bool bombSoundBool;
        public Music()
        {
            slipSound = new SoundPlayer(Properties.Resources.slip);
            bombSound = new SoundPlayer(Properties.Resources.bombmine);
        }
        public void playAudioSlipSound()
        {
            if (!slipSoundBool) return;
            slipSound.Play();
        }
        public void playAudiobombSound()
        {
            if (!bombSoundBool) return;
            bombSound.Play();
        }
    }
}
