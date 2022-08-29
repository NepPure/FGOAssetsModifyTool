using Microsoft.VisualStudio.TestTools.UnitTesting;
using FGOAssetsModifyTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGOAssetsModifyTool.Tests
{
    [TestClass()]
    public class CatAndMouseGameTests
    {
        [TestMethod()]
        public void CatGame3Test()
        {
            CatAndMouseGame decryptor = new(CatAndMouseGame.FileType.CN);
            var test = "abcd";

            var enc = decryptor.CatGame3(test);
            var dec = decryptor.MouseGame3(enc);

            Assert.AreEqual(test, dec);
        }
    }
}