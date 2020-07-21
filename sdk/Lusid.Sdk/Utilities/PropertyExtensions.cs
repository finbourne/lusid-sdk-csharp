using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Utilities for working with Properties.
    /// </summary>
    internal static class PropertyExtensions
    {
        /// <summary>
        /// Creates a PropertyValue containing a string label.
        /// </summary>
        public static PropertyValue CreateLabel(string value)
        {
            return new PropertyValue(labelValue: value);
        }

        /// <summary>
        /// Creates a PropertyValue containing a metric value with unit.
        /// </summary>
        public static PropertyValue CreateMetric(decimal value, string unit)
        {
            return new PropertyValue(metricValue: new MetricValue(value, unit));
        }
        
        /// <summary>
        /// Creates a PropertyValue containing a set of distinct string labels.
        /// </summary>
        public static PropertyValue CreateLabelSet(params string[] values)
        {
            if (values.Distinct().Count() != values.Length)
            {
                throw new ArgumentException("Labels must be distinct.", nameof(values));
            }
            
            return new PropertyValue(labelValueSet: new LabelValueSet(values.ToList()));
        }
        
        public static PropertyValueComparer PropertyValueEquality => new PropertyValueComparer();
        public static LabelValueSetComparer LabelValueSetEquality => new LabelValueSetComparer();

        /// <summary>
        /// Compares LabelSetValues without ordering, unlike the default SDK behaviour.
        /// </summary>
        public class PropertyValueComparer : IComparer<PropertyValue>
        {
            public int Compare(PropertyValue pv1, PropertyValue pv2)
            {
                return AreEqual(pv1, pv2, CompareNonNull) ? 0 : 1;
            }
            
            private static bool CompareNonNull(PropertyValue pv1, PropertyValue pv2)
            {
                return Equals(pv1.LabelValue, pv2.LabelValue) &&
                       Equals(pv1.MetricValue, pv2.MetricValue) &&
                       AreEqual(pv1.LabelValueSet, pv2.LabelValueSet, LabelValueSetComparer.CompareNonNull);
            }
        }

        public class LabelValueSetComparer : IComparer<LabelValueSet>
        {
            public int Compare(LabelValueSet l1, LabelValueSet l2)
            {
                return AreEqual(l1, l2, CompareNonNull) ? 0 : 1;
            }

            internal static bool CompareNonNull(LabelValueSet l1, LabelValueSet l2)
            {
                return l1.Values.OrderBy(e => e)
                    .SequenceEqual(l2.Values.OrderBy(e => e));
            }
        }
        
        private static bool AreEqual<T>(T a, T b, Func<T,T,bool> nonNullEquals)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
                
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return nonNullEquals(a, b);
        }
    }
}