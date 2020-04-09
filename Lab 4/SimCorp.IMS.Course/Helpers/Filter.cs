using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Filter
    {
        public enum FilteringOptions
        {
            BySender,
            ByContainingText,
            ByDate
        }

        public static IEnumerable<Message> FilterBySender(List<Message> messagesToFilter, string sender)
        {
            IEnumerable<Message> queryToFilterBySender = Enumerable.Empty<Message>();
            queryToFilterBySender = messagesToFilter.Where(m => m.PhoneNumber.Equals(sender));

            return queryToFilterBySender;
        }

        public static IEnumerable<Message> FilterByContainingText(List<Message> messagesToFilter, string textToLookFor)
        {
            IEnumerable<Message> queryToFilterByContainingText = Enumerable.Empty<Message>();
            queryToFilterByContainingText = messagesToFilter.Where(m => m.Text.Contains(textToLookFor));

            return queryToFilterByContainingText;
        }

        public static IEnumerable<Message> FilterByRecievingTime(List<Message> messagesToFilter, DateTime fromDate, DateTime toDate)
        {
            IEnumerable<Message> queryToFilterByRecievingTime = messagesToFilter.Select(m => m);

            bool fromDateIsSpecified = (fromDate != new DateTime(2020, 3, 1));
            bool toDateIsSpecified = (toDate != new DateTime(2020, 3, 1));

            if (fromDateIsSpecified)
            {
                queryToFilterByRecievingTime = messagesToFilter.Where(m => m.RecievingTime > fromDate);
            }

            if (toDateIsSpecified)
            {
                queryToFilterByRecievingTime = queryToFilterByRecievingTime.Intersect(messagesToFilter.Where(m => m.RecievingTime < toDate));
            }

            return queryToFilterByRecievingTime;
        }

        public static IEnumerable<Message> ApplyAndOrLogic(List<Message> messages,
                                                    Dictionary<FilteringOptions, bool> selectedFilteringOptions, 
                                                    Dictionary<FilteringOptions, IEnumerable<Message>> filteredEnumerables,
                                                    bool andLogicIsSelected,
                                                    bool orLogicIsSelected)
        {
            IEnumerable<Message> queryWithLogicApplied = messages.Select(m => m);

            if (orLogicIsSelected)
            {
                queryWithLogicApplied = Enumerable.Empty<Message>();

                if (selectedFilteringOptions[FilteringOptions.BySender])
                {
                    queryWithLogicApplied = queryWithLogicApplied.Union(filteredEnumerables[FilteringOptions.BySender]);
                }

                if (selectedFilteringOptions[FilteringOptions.ByContainingText])
                {
                    queryWithLogicApplied = queryWithLogicApplied.Union(filteredEnumerables[FilteringOptions.ByContainingText]);
                }

                if (selectedFilteringOptions[FilteringOptions.ByDate])
                {
                    queryWithLogicApplied = queryWithLogicApplied.Union(filteredEnumerables[FilteringOptions.ByDate]);
                }
            }

            if (andLogicIsSelected)
            {
                if (selectedFilteringOptions[FilteringOptions.BySender])
                {
                    queryWithLogicApplied = queryWithLogicApplied.Intersect(filteredEnumerables[FilteringOptions.BySender]);
                }

                if (selectedFilteringOptions[FilteringOptions.ByContainingText])
                {
                    queryWithLogicApplied = queryWithLogicApplied.Intersect(filteredEnumerables[FilteringOptions.ByContainingText]);
                }

                if (selectedFilteringOptions[FilteringOptions.ByDate])
                {
                    queryWithLogicApplied = queryWithLogicApplied.Intersect(filteredEnumerables[FilteringOptions.ByDate]);
                }
            }

            return queryWithLogicApplied;
        }
    }
}
