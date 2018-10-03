using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobile {
    public class CallsBook
    {
        private List<Call> callList;
        private List<Call> saveHistory;

        public CallsBook()
        {
            callList = new List<Call>();
            saveHistory = new List<Call>();
        }

        public void AddCall(Call newCall)
        {
            if (callList.Count > 0 && callList.Last().EqualsLast(newCall))
            {
                Call lastItem = callList.Last();
                saveHistory.Add((Call)lastItem.Clone());
                
                lastItem.CallTimeHistory = newCall.CallTimeHistory;
                lastItem.Duration = newCall.Duration;
                lastItem.Num++;
            }
            else
            {
                callList.Add(newCall);
            }
        }

        public List<Call> GetListCalls()
        {
            return callList;
        }

        public List<Call> GetListHistory(Contact contact, string contactPhone, CallDirections direction, DateTime dt)
        {
            Call tempCall = new Call(contact, contactPhone, direction, dt);
            List<Call> history = new List<Call>();
            foreach (var item in saveHistory)
            {
                if (item.Equals(tempCall)) history.Add(item);
            }
            for (var i = callList.Count-1; i>=0; i--) {
                if (callList[i].Equals(tempCall))
                {
                    history.Add(callList[i]);
                    break;
                }
            }
            return history;
        }
    }
}
