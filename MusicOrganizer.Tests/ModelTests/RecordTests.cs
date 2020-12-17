using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.TestTools
{
  [TestClass]
  public class RecordTest
  {
    [TestMethod]
    public void RecordConstructor_CreateInstanceOfRecord_Record()
    {
      Record newRecord = new Record("test record");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }

    [TestMethod]
    public void GetArtistName_ReturnArtistName_String()
    {
      string artistName = "Test Record";
      Record newRecord = new Record(artistName);

      string result = newRecord.ArtistName;

      Assert.AreEqual("name", result);
    }

    // [TestMethod]
    // public void GetId_ReturnIdOfRecord_Int()
    // {
    //   string artistName = "Test Record";
    //   Record newRecord = new Record(artistName);

    //   string result = newRecord.Id;

    //   Assert.AreEqual(1, result);
    // }
  }
}
