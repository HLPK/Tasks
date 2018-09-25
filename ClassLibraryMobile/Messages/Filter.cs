using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobile.Messages {
    public class Filter {
        public Filter(string subscriber, string messagePattern, DateTime dateFrom, DateTime dateTo, bool isSubscriber, bool isMessagePattern, bool isPeriod, bool isOr) {
            Subscriber = subscriber;
            MessagePattern = messagePattern;
            DateFrom = dateFrom;
            DateTo = dateTo;
            IsSubscriber = isSubscriber;
            IsMessagePattern = isMessagePattern;
            IsPeriod = isPeriod;
            IsOr = isOr;
        }

        public string Subscriber { get; set; }
        public string MessagePattern { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public bool IsSubscriber { get; set; }
        public bool IsMessagePattern { get; set; }
        public bool IsPeriod { get; set; }

        public bool IsOr { get; set; }  // false = OR, true = AND


       
        
        public List<Message> GetFilteredList(List<Message> inputList)
        {

            if (IsSubscriber == true && IsMessagePattern == false && IsPeriod == false) return GetFilteredBySubscriber(inputList);
            if (IsSubscriber == false && IsMessagePattern == true && IsPeriod == false) return GetFilteredByMessagePattern(inputList);
            if (IsSubscriber == false && IsMessagePattern == false && IsPeriod == true) return GetFilteredByPeriod(inputList);
            if (IsSubscriber == true && IsMessagePattern == true && IsPeriod == false) return GetJoin(GetFilteredBySubscriber(inputList), GetFilteredByMessagePattern(inputList));
            if (IsSubscriber == false && IsMessagePattern == true && IsPeriod == true) return GetJoin(GetFilteredByMessagePattern(inputList), GetFilteredByPeriod(inputList));
            if (IsSubscriber == true && IsMessagePattern == false && IsPeriod == true) return GetJoin(GetFilteredBySubscriber(inputList), GetFilteredByPeriod(inputList));
            if (IsSubscriber == true && IsMessagePattern == true && IsPeriod == true) return GetJoin(GetFilteredBySubscriber(inputList), GetFilteredByMessagePattern(inputList), GetFilteredByPeriod(inputList));

            else return new List<Message>();

        }

        private List<Message> GetJoin(List<Message> list, List<Message> list2, List<Message> list3)
        {
            if (IsOr) return list.Union(list2).Union(list3).ToList();
            else return list.Intersect(list2).Intersect(list3).ToList();
        }

        private List<Message> GetJoin(List<Message> list, List<Message> list2) {
            if (IsOr) return list.Union(list2).ToList();
            else return list.Intersect(list2).ToList();
        }

        private List<Message> GetFilteredByMessagePattern(List<Message> list) {
            return list.Where(m => m.Text.Contains(MessagePattern)).ToList();
        }

        private List<Message> GetFilteredBySubscriber(List<Message> list)
        {
            return list.Where(m => m.User == Subscriber).ToList();
        }

        private List<Message> GetFilteredByPeriod(List<Message> list) {
            return list.Where( m => m.ReceivingTime >= DateFrom && m.ReceivingTime <= DateTo).ToList();
        }
    }
}
