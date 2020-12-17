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
    
  }
}