﻿using NUnit.Framework;
using System.Threading.Tasks;

namespace gis_photo_sharing_app.Application.IntegrationTests
{
    using static Testing;

    public class TestBase
    {
        [SetUp]
        public async Task TestSetUp()
        {
            await ResetState();
        }
    }
}
