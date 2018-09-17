using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.KeyBoards {
    public abstract class KeyBoardPhysical : KeyBoardBase {
        public bool IsVirtualKeyboardAnable { get; set; }
        private Dictionary<string, FunctionalKeys> SetOfFunctionalKeys { get; set; }

        public KeyBoardPhysical() {
            IsVirtualKeyboardAnable = true;
            InitialiseDictionary();
        }
        public KeyBoardPhysical(bool isVirtualKeyboardAnable) {
            IsVirtualKeyboardAnable = isVirtualKeyboardAnable;
            InitialiseDictionary();
        }

        private void InitialiseDictionary()
        {
            SetOfFunctionalKeys = new Dictionary<string, FunctionalKeys>();
            SetOfFunctionalKeys.Add("MainScreen",FunctionalKeys.Enter);
            SetOfFunctionalKeys.Add("Back",FunctionalKeys.BackSpace);
            SetOfFunctionalKeys.Add("Recent", FunctionalKeys.AtlTab);
            SetOfFunctionalKeys.Add("Notice", FunctionalKeys.N);
            SetOfFunctionalKeys.Add("HotKeys", FunctionalKeys.Slash);
            SetOfFunctionalKeys.Add("SwitchLayout", FunctionalKeys.Space);
        }

        public override string ToString() {
            return $"Physical keyboard Swift Key /is Virtual keyboard anable {IsVirtualKeyboardAnable}/.";
        }

    }
}
