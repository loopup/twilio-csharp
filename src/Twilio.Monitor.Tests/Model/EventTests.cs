﻿using System;
using System.IO;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;

namespace Twilio.Monitor.Tests.Model
{
    [TestFixture]
    public class EventTests
    {
        [Test]
        public void testDeserializeResponse()
        {
            var doc = File.ReadAllText(Path.Combine("Resources", "event.json"));
            var json = new JsonDeserializer();
            var output = json.Deserialize<Event>(new RestResponse { Content = doc });

            Assert.NotNull(output);
        }
    }
}

