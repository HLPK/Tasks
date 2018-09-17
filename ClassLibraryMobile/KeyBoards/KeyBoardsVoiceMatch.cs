using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.KeyBoards {
    public class KeyBoardsVoiceMatch {
        public bool IsGetAccess { get; set; }
        public bool IsUnlock { get; set; }
        public bool IsMapToGoogleMaps { get; set; }

        public KeyBoardsVoiceMatch(){
            IsGetAccess = false;
            IsUnlock = false;
            IsMapToGoogleMaps = false;
        }

        public KeyBoardsVoiceMatch(bool isGetAccess, bool isUnlock, bool isMapToGoogleMaps) {
            IsGetAccess = isGetAccess;
            IsUnlock = isUnlock;
            IsMapToGoogleMaps = isMapToGoogleMaps;
        }
    }
}
