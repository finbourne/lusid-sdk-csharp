using System;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Utilities
{
    public class DateTimeOrCutLabelTests
    {
        [Test]
        public void Create_DateOrCutLabel_From_Date_Succeeds()
        {
            var testDateTime = new DateTimeOffset(2018, 3, 28, 12, 1, 2, 3, TimeSpan.Zero);

            var parameterUsingConstructor = new DateTimeOrCutLabel(testDateTime);
            var parameterUsingConversion = (DateTimeOrCutLabel) testDateTime;

            Assert.That(parameterUsingConstructor.Parameter, Is.EqualTo("2018-03-28T12:01:02.0030000+00:00"));
            Assert.That(parameterUsingConversion.Parameter, Is.EqualTo("2018-03-28T12:01:02.0030000+00:00"));
        }

        [Test]
        public void Create_DateOrCutLabel_From_Cut_Label_Definition_Succeeds()
        {
            var testDate = new DateTimeOffset(2018, 3, 28, 0, 0, 0, 0, TimeSpan.Zero);

            var parameter = new DateTimeOrCutLabel(testDate, "ExampleCutLabel");

            Assert.That(parameter.Parameter, Is.EqualTo("2018-03-28NExampleCutLabel"));
        }


        [Test]
        public void Create_DateOrCutLabel_From_Cut_Label_Definition_With_Invalid_Date_Fails()
        {
            var dateWithTime1 = new DateTimeOffset(2018, 3, 28, 12, 1, 2, 3, TimeSpan.Zero);
            var dateWithTime2 = new DateTimeOffset(2018, 3, 28, 12, 1, 2, TimeSpan.Zero);
            var dateWithOffset = new DateTimeOffset(2018, 3, 28, 0, 0, 0, 0, TimeSpan.FromHours(1));

            Assert.That(() => new DateTimeOrCutLabel(dateWithTime1, "ExampleCutLabel"), Throws.ArgumentException);
            Assert.That(() => new DateTimeOrCutLabel(dateWithTime2, "ExampleCutLabel"), Throws.ArgumentException);
            Assert.That(() => new DateTimeOrCutLabel(dateWithOffset, "ExampleCutLabel"), Throws.ArgumentException);
        }

        [Test]
        public void Create_DateOrCutLabel_From_String()
        {
            var testValue = "2018-03-28T12:01:02.3";

            var parameterUsingConversion = (DateTimeOrCutLabel) testValue;

            Assert.That(parameterUsingConversion.Parameter, Is.EqualTo(testValue));
        }
    }
}
