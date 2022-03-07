using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using Transmission.API.RPC.Arguments;
using Transmission.API.RPC.Entity;

namespace Transmission.API.RPC.Test
{
    [TestClass]
    public class MethodsTest
    {
        private const string FILE_PATH = "./Data/ubuntu-10.04.4-server-amd64.iso.torrent";
        private const string HOST = "http://localhost:9091/transmission/rpc";
        private const string SESSION_ID = "";
        private readonly Client client = new(HOST, SESSION_ID);

        #region Torrent Test

        [TestMethod]
        public void AddTorrent_Test()
        {
            if (!File.Exists(FILE_PATH))
            {
                throw new Exception("Torrent file not found");
            }

            var fstream = File.OpenRead(FILE_PATH);
            byte[] filebytes = new byte[fstream.Length];
            fstream.Read(filebytes, 0, Convert.ToInt32(fstream.Length));

            string encodedData = Convert.ToBase64String(filebytes);

            //The path relative to the server (priority than the metadata)
            //string filename = "/DataVolume/shares/Public/Transmission/torrents/ubuntu-10.04.4-server-amd64.iso.torrent";

            var torrent = new NewTorrent
            {
                //Filename = filename,
                Metainfo = encodedData,
                Paused = true
            };

            var newTorrentInfo = client.TorrentAdd(torrent);

            Assert.IsNotNull(newTorrentInfo);
            Assert.IsTrue(newTorrentInfo.ID != 0);
        }

        [TestMethod]
        public void AddTorrent_Magnet_Test()
        {
            var torrent = new NewTorrent
            {
                Filename = "magnet:?xt=urn:btih:5bcb7e72aec774997622af7de5471d71e17f1db8&dn=ubuntu-12.04.5-desktop-amd64.iso&tr=http%3A%2F%2Ftorrent.ubuntu.com%3A6969%2Fannounce&tr=http%3A%2F%2Fipv6.torrent.ubuntu.com%3A6969%2Fannounce",
                Paused = false
            };

            var newTorrentInfo = client.TorrentAdd(torrent);

            Assert.IsNotNull(newTorrentInfo);
            Assert.IsTrue(newTorrentInfo.ID != 0);
        }

        [TestMethod]
        public void GetTorrentInfo_Test()
        {
            var torrentsInfo = client.TorrentGet(TorrentFields.ALL_FIELDS);

            Assert.IsNotNull(torrentsInfo);
            Assert.IsNotNull(torrentsInfo.Torrents);
            Assert.IsTrue(torrentsInfo.Torrents.Any());
        }

        [TestMethod]
        public void SetTorrentSettings_Test()
        {
            var torrentsInfo = client.TorrentGet(TorrentFields.ALL_FIELDS);
            var torrentInfo = torrentsInfo.Torrents.FirstOrDefault();
            Assert.IsNotNull(torrentInfo, "Torrent not found");

            var trackerInfo = torrentInfo.Trackers.FirstOrDefault();
            Assert.IsNotNull(trackerInfo, "Tracker not found");
            var trackerCount = torrentInfo.Trackers.Length;
            TorrentSettings settings = new()
            {
                IDs = new object[] { torrentInfo.HashString },
                TrackerRemove = new int[] { trackerInfo.ID }
            };

            client.TorrentSet(settings);

            torrentsInfo = client.TorrentGet(TorrentFields.ALL_FIELDS, torrentInfo.ID);
            torrentInfo = torrentsInfo.Torrents.FirstOrDefault();

            Assert.IsFalse(trackerCount == torrentInfo.Trackers.Length);
        }

        [TestMethod]
        public void RenamePathTorrent_Test()
        {
            var torrentsInfo = client.TorrentGet(TorrentFields.ALL_FIELDS);
            var torrentInfo = torrentsInfo.Torrents.FirstOrDefault();
            Assert.IsNotNull(torrentInfo, "Torrent not found");

            var result = client.TorrentRenamePath(torrentInfo.ID, torrentInfo.Files[0].Name, "test_" + torrentInfo.Files[0].Name);

            Assert.IsNotNull(result, "Torrent not found");
            Assert.IsTrue(result.ID != 0);
        }

        [TestMethod]
        public void RemoveTorrent_Test()
        {
            var torrentsInfo = client.TorrentGet(TorrentFields.ALL_FIELDS);
            var torrentInfo = torrentsInfo.Torrents.FirstOrDefault();
            Assert.IsNotNull(torrentInfo, "Torrent not found");

            client.TorrentRemove(new int[] { torrentInfo.ID });

            torrentsInfo = client.TorrentGet(TorrentFields.ALL_FIELDS);

            Assert.IsFalse(torrentsInfo.Torrents.Any(t => t.ID == torrentInfo.ID));
        }

        #endregion

        #region Session Test

        [TestMethod]
        public void SessionGetTest()
        {
            var info = client.GetSessionInformation();
            Assert.IsNotNull(info);
            Assert.IsNotNull(info.Version);
        }

        [TestMethod]
        public void ChangeSessionTest()
        {
            //Get current session information
            var sessionInformation = client.GetSessionInformation();

            //Save old speed limit up
            var oldSpeedLimit = sessionInformation.SpeedLimitUp;

            //Set new session settings
            client.SetSessionSettings(new SessionSettings() { SpeedLimitUp = 100 });

            //Get new session information
            var newSessionInformation = client.GetSessionInformation();

            //Check new speed limit
            Assert.AreEqual(newSessionInformation.SpeedLimitUp, 100);

            //Restore speed limit
            newSessionInformation.SpeedLimitUp = oldSpeedLimit;

            //Set new session settinhs
            client.SetSessionSettings(new SessionSettings() { SpeedLimitUp = oldSpeedLimit });
        }

        #endregion
    }
}
