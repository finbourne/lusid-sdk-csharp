using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Lusid.Sdk.Tests
{
    [TestFixture]
    public class PropertyBasedConverterTests
    {

        [DataContract]
        class SimpleObject : Dictionary<string, object>
        {
            private SimpleObject()
            {
            }
            
            [DataMember(Name="stringValue")]
            public string StringValue { get; set; }
            
            [DataMember(Name="optionalValue")]
            public string OptionalValue { get; set; }
        }

        [Test]
        public void Deserialized_Dictionary_Does_Not_Contain_Json_Values()
        {
            var json = @"
                {
                    ""stringValue"": ""foo"",
                    ""optionalValue"": ""bar""
                }
                ";
            
            var obj = JsonConvert.DeserializeObject<SimpleObject>(json, new JsonConverter[]
            {
                new PropertyBasedConverter(),
            });
            
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.Keys, Is.Empty);
        }
        
        [Test]
        public void Deserialize_Json_With_All_Fields()
        {
            var json = @"
                {
                    ""stringValue"": ""foo"",
                    ""optionalValue"": ""bar""
                }
                ";
            
            var obj = JsonConvert.DeserializeObject<SimpleObject>(json, new JsonConverter[]
            {
                new PropertyBasedConverter(),
            });
            
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.StringValue, Is.EqualTo("foo"));
            Assert.That(obj.OptionalValue, Is.EqualTo("bar"));
        }
        
        [Test]
        public void Deserialize_Json_With_Partial_Fields()
        {
            var json = @"
                {
                    ""stringValue"": ""foo""
                }
                ";
            
            var obj = JsonConvert.DeserializeObject<SimpleObject>(json, new JsonConverter[]
            {
                new PropertyBasedConverter(),
            });
            
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.StringValue, Is.EqualTo("foo"));
            Assert.That(obj.OptionalValue, Is.Null);
        }

        class ComplexFieldsObject : Dictionary<string, object>
        {
            private ComplexFieldsObject()
            {
            }
            
            [DataMember(Name="stringValue")]
            public string StringValue { get; set; }
            
            [DataMember(Name="nestedField")]
            public Dictionary<string, List<string>> NestedField { get; set; }
        }
        
        [Test]
        public void Deserialize_Json_With_Complex_Fields()
        {
            var json = @"
                {
                    ""stringValue"": ""foo"",
                    ""nestedField"": {
                        ""key"": [
                            ""value1"", 
                            ""value2""
                        ]
                    }
                }
                ";
            
            var obj = JsonConvert.DeserializeObject<ComplexFieldsObject>(json, new JsonConverter[]
            {
                new PropertyBasedConverter(),
            });
            
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.StringValue, Is.EqualTo("foo"));
            Assert.That(obj.NestedField, Is.Not.Null);
            Assert.That(obj.NestedField, Contains.Key("key"));
            Assert.That(obj.NestedField["key"], Has.Exactly(1).EqualTo("value1").And.Exactly(1).EqualTo("value2"));
        }

        class PartialObject : Dictionary<string, object>
        {
            private PartialObject()
            {
                NonSerialisedValue = "not set";
            }
            
            [DataMember(Name="stringValue")]
            public string StringValue { get; set; }
            
            public string NonSerialisedValue { get; set; }
        }

        [Test]
        public void Deserialize_Json_To_Object_With_NonSerializable_Fields()
        {
            var json = @"
                {
                    ""stringValue"": ""foo""
                }
                ";
            
            var obj = JsonConvert.DeserializeObject<PartialObject>(json, new JsonConverter[]
            {
                new PropertyBasedConverter(),
            });
            
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.StringValue, Is.EqualTo("foo"));
            Assert.That(obj.NonSerialisedValue, Is.EqualTo("not set"));
            
        }
    }
}