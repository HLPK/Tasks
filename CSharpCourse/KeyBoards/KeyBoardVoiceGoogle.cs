using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.KeyBoards {
    public class KeyBoardVoiceGoogle : KeyBoardVirtual {
        public Layouts Language { get; set; }
        public KeyBoardsVoiceMatch VoiceMatch { get; set; }
        public bool UseBluetooth { get; set; }

        public KeyBoardVoiceGoogle(Layouts language, KeyBoardsVoiceMatch voiceMatch, bool useBlueTooth) {
            Language = language;
            VoiceMatch = voiceMatch;
            UseBluetooth = useBlueTooth;
        }

        public override string ToString() {
            return $"Virual keyboard Voice Google /language {Language}, Voice matches {VoiceMatch}, Use Bluetooth {UseBluetooth}/.";
        }
    }
}
