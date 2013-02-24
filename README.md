GameOfLife
==========

Game of Life
The Game of Life is a cellular automaton devised by the British mathematician John Horton Conway in 1970. The "game" is a zero-player game, meaning that its evolution is determined by its initial state, requiring no further input. One interacts with the Game of Life by creating an initial configuration and observing how it evolves.

Rule

The universe of the Game of Life is an infinite two-dimensional orthogonal grid of square cells, each of which is in one of two possible states, live or dead. Every cell interacts with its eight neighbors, which are the cells that are horizontally, vertically, or diagonally adjacent. At each step in time, the following transitions occur:

Any live cell with fewer than two live neighbors dies, as if caused by under-population.
Any live cell with two or three live neighbors’ lives on to the next generation.
Any live cell with more than three live neighbors dies, as if by overcrowding.
Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
The initial pattern constitutes the seed of the system. The first generation is created by applying the above rules simultaneously to every cell in the seed—births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick (in other words, each generation is a pure function of the preceding one). The rules continue to be applied repeatedly to create further generations.

Approach
========

1. The program first loads all the set of dependencies, i.e. an instance of NeighbourCellFinder that finds the dead/alive neighbours depending upon the instance of CellRule instance that again could be a LiveCellRule to be applied on live cells and a DeadRuleEngine that could be applied on dead neighbours;
2. The program then accepts from the user and input in the format (0,1)|(0,2) that provides the current generation and also the number of generations the program needs to be run for.
3. Based on the user's input the program validates and executes the initialized rules and displays a copy of the current grid but with the affected cells.
4. There are unit test cases covering in depth both the core of the game logic and the UI.

