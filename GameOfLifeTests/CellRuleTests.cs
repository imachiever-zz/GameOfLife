using System;
using NUnit.Framework;
using SampleCode.GameOfLifeCore;
using SampleCode.GameOfLifeCore.Base;

namespace SampleCode.GameOfLifeCoreTests
{
    public class FakeCellRule : CellRule<ICell, IGrid<ICell>>
    {
        public override void Execute(ICell cell)
        {
            throw new System.NotImplementedException();
        }

        public void Validate(ICell cell)
        {
            base.ValidateCell(cell);
        }
    }

    [TestFixture]
    public class CellRuleTests
    {
        private INeighbourCellsFinder<ICell, IGrid<ICell>> _neighbourCellsFinder;
        private FakeCellRule _cellRule;

        [SetUp]
        public void SetUp()
        {
            _neighbourCellsFinder = new NeighbourCellsFinder { Grid = TestObjects.ThreexThreeGrid };
            _cellRule = new FakeCellRule();
        }

        [TearDown]
        public void TearDown()
        {
            _neighbourCellsFinder = null;
            _cellRule = null;
        }

        [Test]
        public void Test_ValidateCell_NullCellIsPassedAsParam_ThrowsArgumentNullException()
        {
            _cellRule.Grid = TestObjects.TwoxTwoGrid;
            _cellRule.NeighbourCellsFinder = _neighbourCellsFinder;
            Assert.Throws<ArgumentNullException>(() => _cellRule.Validate(null));
        }

        [Test]
        public void Test_ValidateCell_GridIsNotSet_ThrowsException()
        {
            _cellRule.Grid = null;
            _cellRule.NeighbourCellsFinder = _neighbourCellsFinder;

            Assert.Throws<Exception>(() => _cellRule.Validate(TestObjects.TwoxTwoGrid.GetCellByIndex(0, 0)));
        }
        
        [Test]
        public void Test_ValidateCell_NeighbourCalculatorIsNotSet_ThrowsException()
        {
            _cellRule.Grid = TestObjects.ThreexThreeGrid;
            _cellRule.NeighbourCellsFinder = null;

            Assert.Throws<Exception>(() => _cellRule.Validate(TestObjects.TwoxTwoGrid.GetCellByIndex(0, 0)));
        }

    }
}