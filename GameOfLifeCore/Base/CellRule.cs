using System;

namespace SampleCode.GameOfLifeCore.Base
{
    
    /// <summary>
    /// abstract class that should be implemented by 
    /// a class representing rule to act on 
    /// <see cref="ICell"/> objects.
    /// </summary>
    /// <typeparam name="TC"></typeparam>
    /// <typeparam name="TG"></typeparam>
    public abstract class CellRule<TC, TG> : ICellRule<TC, TG>
                                                where TC : ICell
                                                where TG : IGrid<TC>
    {
        /// <summary>
        /// Acts on the <paramref name="cell"/>
        /// to execute the rule using <see cref="ICellRule{TC,TG}.NeighbourCellsFinder"/>
        /// and <see cref="ICellRule{TC,TG}.Grid"/>
        /// </summary>
        /// <param name="cell"></param>
        public abstract void Execute(TC cell);

        /// <summary>
        /// gets/sets instance of class implementing
        /// <see cref="INeighbourCellsFinder{TC,TG}"/>.
        /// Used by the <see cref="ICellRule{TC,TG}.Execute"/> method to
        /// implement the rule.
        /// </summary>
        public INeighbourCellsFinder<TC, TG> NeighbourCellsFinder { get; set; }

        /// <summary>
        /// gets/sets instance of class implementing
        /// <see cref="IGrid{TC}"/>. Used by the 
        /// <see cref="ICellRule{TC,TG}.Execute"/> method to implement the 
        /// rule
        /// </summary>
        public TG Grid { get; set; }

        /// <summary>
        /// Validates if the <paramref name="cell"/>
        /// is null or <see cref="NeighbourCellsFinder"/> 
        /// is null or <see cref="Grid"/> is null.
        /// </summary>
        /// <param name="cell"></param>
        protected virtual void ValidateCell(TC cell)
        {
            if (Grid == null)
            {
                throw new Exception("Grid needs to be set before calling this method");
            }

            if (NeighbourCellsFinder == null)
            {
                throw new Exception("NeighbourCellsFinder needs to be set before calling this method");
            }

            if (cell == null)
            {
                throw new ArgumentNullException("cell", "Cannot be null");
            }
        }
    }
}