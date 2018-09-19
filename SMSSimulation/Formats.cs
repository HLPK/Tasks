using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSimulation {
    public class Formats {

        public string FormatWithTime(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }

        public string FormatNone(string message) {
            return message;
        }

        public string FormatWithTimeEnd(string message) {
            return $"{message} [{DateTime.Now}]";
        }

        public string FormatCustom(string message) {
            return $"[My format] {message}";
        }

        public string FormatLowerCase(string message) {
            return message.ToLower();
        }

        public string FormatUpperCase(string message) {
            return message.ToUpper();
        }
    }
}
