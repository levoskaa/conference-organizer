using Domain.Entitites.Abstractions;
using System;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class TimeFrame : ValueObject
    {
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public TimeFrame()
        {
        }

        public TimeFrame(DateTime beginDate, DateTime endDate)
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Using a yield return statement to return each element one at a time
            yield return BeginDate;
            yield return EndDate;
        }
    }
}