using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebASPMVC_BS.Models;

namespace WebASPMVC_BS.Tests.Controllers
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void TrackTest()
        {
            TRACK track = new TRACK();
            track.name = "one";
            track.id = 1;

            TrackChecker trackChecker= new TrackChecker(track);
        }

       


    }
}
