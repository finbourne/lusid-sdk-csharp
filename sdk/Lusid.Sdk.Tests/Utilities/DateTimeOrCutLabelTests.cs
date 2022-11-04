using System;
using Newtonsoft.Json;
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

        [Test]
        public void Compare_DateOrCutLabels()
        {
            // GIVEN some example DateTimeOrCutLabels which share values
            var testDate = new DateTimeOffset(2018, 3, 28, 0, 0, 0, 0, TimeSpan.Zero);
            var testDateWithTime = new DateTimeOffset(2018, 3, 28, 12, 1, 2, 3, TimeSpan.Zero);
            var testCutLabel = "TEST_CUTLABEL";

            DateTimeOrCutLabel a = new DateTimeOrCutLabel(testDate, testCutLabel);
            DateTimeOrCutLabel b = new DateTimeOrCutLabel(testDate, testCutLabel);
            DateTimeOrCutLabel c = new DateTimeOrCutLabel(testDateWithTime);
            DateTimeOrCutLabel d = new DateTimeOrCutLabel(testDateWithTime);

            // WHEN they are compared
            // THEN the expected results are returned
            Assert.That(a, Is.Not.SameAs(b));
            Assert.That(a, Is.EqualTo(b));

            Assert.That(a, Is.Not.EqualTo(c));

            Assert.That(c, Is.Not.SameAs(d));
            Assert.That(c, Is.EqualTo(d));
        }
        
        class JsonCutLabel
        {
            public JsonCutLabel()
            {
            }
            
            public DateTimeOrCutLabel dt { get; set; }
        }

        [TestCase("{'dt': '2021-10-29T00:00:00.0000000+00:00'}")]
        [TestCase("{'dt': '2021-10-29T01:00:00.0000000+01:00'}")]
        [TestCase("{'dt': '2021-10-29T00:00:00.0000000Z'}")]
        public void Deserialize_CutLabelJsonConverter(string json)
        {
            var jcl = JsonConvert.DeserializeObject<JsonCutLabel>(json, converters: new JsonConverter[] {new CutLabelJsonConverter() });
            
            Assert.That(jcl.dt.Parameter, Is.EqualTo("2021-10-29T00:00:00.0000000+00:00"));
        }
    }
}
