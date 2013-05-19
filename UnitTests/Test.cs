using System;
using System.IO;
using NUnit.Framework;

using XR.Mono.Cover;

namespace UnitTests
{
    [TestFixture()]
    public class Test
    {
        [SetUp]
        public void Init ()
        {
            if (File.Exists ("self.covcfg.covdb"))
                File.Delete ("self.covcfg.covdb");
        }

        [Test()]
        public void SelfCover ()
        {
            Environment.SetEnvironmentVariable("BABOON_CFG", "testsubject.exe.covcfg" );
            var h = CoverHostFactory.CreateHost ("self.exe.covdb", "covem.exe", "testsubject.exe");

            h.Cover ("^XR.Mono.Cover");

        }
    }
}

