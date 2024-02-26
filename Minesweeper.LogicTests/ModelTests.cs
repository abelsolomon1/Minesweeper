using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Logic.Tests
{
    [TestClass()]
    public class ModelTests
    {
        [TestMethod()]
        public void DoTurnTest()
        {
            //ARRANGE 
            var model = new Model(16, 16);
            //ACT
            model.DoTurn("87");
            //ASSERT
            //spielzustand prüfen

        }
    }
}