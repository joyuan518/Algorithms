using System;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms.Others
{
    /// <summary>
    /// The intention here is to try to find the 3 earliest common timeslots that exist in all of the give timeslot lists
    /// </summary>
    public static class GetCommonTimeslots
    {
        /// <summary>
        /// This method will return the ordered available time slots for an given user.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static List<string> GetTimeSlots(string userName)
        {
            throw new NotImplementedException();
        }

        public static List<string> GetThreeEarliestTimeSlots(List<string> userNames)
        {
            var timeSlotList = new List<List<string>>();
            userNames.ForEach(u => timeSlotList.Add(GetTimeSlots(u)));

            var counterTable = new Dictionary<string, int>();

            foreach (var timeSlots in timeSlotList)
            {
                foreach (var timeSlot in timeSlots)
                {
                    if (!counterTable.ContainsKey(timeSlot))
                    {
                        counterTable.Add(timeSlot, 1);
                    }

                    counterTable[timeSlot]++;
                }
            }

            return counterTable.Where(c => c.Value == userNames.Count).OrderBy(t => t.Key).Take(3).Select(r => r.Key).ToList();
        }
    }
}
