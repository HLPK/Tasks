using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.KeyBoards {
    public class KeyBoardSwiftKey : KeyBoardVirtual
    {
        public Layouts Layout { get; set; }
        public Themes Theme { get; set; }

        public KeyBoardSwiftKey(Layouts layout, Themes theme) {
            Layout = layout;
            Theme = theme;
        }

        public override string ToString()
        {
            return $"Virual keyboard Swift Key /layuot {Layout} theme {Theme}/.";
        }
    }
}
