//using System;
//using System.Collections.Generic;
//using System.Text;

////true - стена
////false - пусто
//namespace ConsoleLab
//{
//    //class Animal, class Human, class CellPhone, class Balance

//    class Animal 
//    {
//        Labyrinth l;
//        protected int age;
//        Animal()
//        {
//        }
//    }

//    class Human : Animal
//    {
//        private Balance balance;
//        protected CellPhone phone;
//        public Human(CellPhone p)
//        {
//            age = 0;
//            balance = new Balance();
//            phone = p;
//        }

//        public void SetAge(int a)
//        {
//            if (a < 0) return;
//            else age = a;
//        }
//    }

//    class CellPhone
//    {
       
//    }
//    class Balance
//    {

//    }



//    class Labyrinth
//    {
//        private Cell[,] field;
//        public int Width { get; private set; }
//        public int Height { get; private set; }

//        private Labyrinth(int Width, int Height)
//        {
//            this.Width = Width % 2 == 0 ? Width + 1 : Width;
//            this.Height = Height % 2 == 0 ? Height + 1 : Height;
//            field = new Cell[this.Width, this.Height];
            
//            bool isCell = false;
//            for (int i = 0; i<this.Width; i++)
//            {
//                for (int j = 0; j < this.Height; j++)
//                {
//                    isCell = (i % 2 != 0 && j % 2 != 0) && (i < this.Width - 1 && j < this.Height - 1);
//                    field[i, j] = new Cell(isCell ? CellStruct.EMPTY : CellStruct.WALL);
//                }
//            }
//        }

//        public Cell this[int x, int y]
//        {
//            get => field[x, y];

//            set => field[x, y] = value;
//        }

//        public static Labyrinth GenerateLabyrinth(int Width, int Height)
//        {
//            Labyrinth lab = new Labyrinth(Width, Height);
//            Coordinates current = new Coordinates(1, 1);
//            Coordinates chosen = new Coordinates(1, 1);
//            Stack<Coordinates> path = new Stack<Coordinates>();

//            lab[1, 1].Visited = true;
//            while(lab.IsUnvisitedCells())
//            {
//                if (lab.IsUnvisitedNeighbours(current))
//                {
//                    path.Push(current);
//                    chosen = lab.GetRandomNeighbour(current);
//                    if (current.x == chosen.x)
//                    {
//                        if (current.y - chosen.y < 0)
//                        {
//                            lab[current.x, current.y + 1].cstr = CellStruct.EMPTY;
//                            lab[current.x, current.y + 1].Visited = true;
//                        }
//                        else
//                        {
//                            lab[current.x, current.y - 1].cstr = CellStruct.EMPTY;
//                            lab[current.x, current.y - 1].Visited = true;
//                        }
//                    }
//                    else
//                    {
//                        if (current.x - chosen.x < 0)
//                        {
//                            lab[current.x + 1, current.y].cstr = CellStruct.EMPTY;
//                            lab[current.x + 1, current.y].Visited = true;
//                        }
//                        else
//                        {
//                            lab[current.x - 1, current.y].cstr = CellStruct.EMPTY;
//                            lab[current.x - 1, current.y].Visited = true;
//                        }
//                    }
//                    current = chosen;
//                    lab[current.x, current.y].Visited = true;
//                }
                
//                else if(path.Count != 0)
//                {
//                    current = path.Pop();
//                    lab[current.x, current.y].Visited = true;
//                }
//                else
//                {
//                    current = lab.GetRandomCell();
//                    lab[current.x, current.y].Visited = true;
//                }
//            }

//            for (int i = 0; i < Width; i++)
//                for (int j = 0; j < Height; j++)
//                    lab[i, j].Visited = false;

//            return lab;
//        }

//        private Coordinates GetRandomCell()
//        {
//            for(int i = 0; i<Width; i++)
//            {
//                for(int j = 0; j<Height; j++)
//                {
//                    if (field[i, j].cstr == CellStruct.EMPTY && !field[i, j].Visited)
//                        return new Coordinates(i, j);
//                }
//            }
//            return new Coordinates(0, 0);
//        }
//        private bool IsUnvisitedCells()
//        {
//            for (int i = 0; i < Width; i++)
//                for (int j = 0; j < Height; j++)
//                    if (field[i, j].cstr == CellStruct.EMPTY && !field[i, j].Visited)
//                        return true;
//            return false;
//        }

//        private bool IsUnvisitedNeighbours(Coordinates c)
//        {
//            /*
//             ███████
//             █ █ █ █
//             ███████
//             █ █ █ █
//             ███████
//             █ █ █ █
//             ███████
//             */

//            if (c.x - 2 >= 0)
//                if (field[c.x - 2, c.y].cstr == CellStruct.EMPTY && !field[c.x - 2, c.y].Visited) return true;

//            if (c.y - 2 >= 0)
//                if (field[c.x, c.y - 2].cstr == CellStruct.EMPTY && !field[c.x, c.y - 2].Visited) return true;

//            if (c.y + 2 < Height)
//                if (field[c.x, c.y + 2].cstr == CellStruct.EMPTY && !field[c.x, c.y + 2].Visited) return true;

//            if (c.x + 2 < Width)
//                if (field[c.x + 2, c.y].cstr == CellStruct.EMPTY && !field[c.x + 2, c.y].Visited) return true;

//            return false;
//        }

//        private bool HasUnvisitedNeighbours(Coordinates c)
//        {
//            /*
//             ███████
//             █     █
//             █████ █
//             █     █
//             █ ███ █
//             █ █   █
//             ███████
//             */

//            if (c.x - 1 >= 0)
//                if (field[c.x - 1, c.y].cstr == CellStruct.EMPTY && !field[c.x - 1, c.y].Visited) return true;

//            if (c.y - 1 >= 0)
//                if (field[c.x, c.y - 1].cstr == CellStruct.EMPTY && !field[c.x, c.y - 1].Visited) return true;

//            if (c.y + 1 < Height)
//                if (field[c.x, c.y + 1].cstr == CellStruct.EMPTY && !field[c.x, c.y + 1].Visited) return true;

//            if (c.x + 1 < Width)
//                if (field[c.x + 1, c.y].cstr == CellStruct.EMPTY && !field[c.x + 1, c.y].Visited) return true;

//            return false;
//        }

//        private Coordinates GetRandomNeighbour(Coordinates c)
//        {
//            List<Coordinates> coords = new List<Coordinates>();
            
//            if (c.x - 2 >= 0)
//                if (!field[c.x - 2, c.y].Visited) coords.Add(new Coordinates(c.x - 2, c.y));

//            if (c.y - 2 >= 0)
//                if (!field[c.x, c.y - 2].Visited) coords.Add(new Coordinates(c.x, c.y - 2));

//            if (c.y + 2 < Height)
//                if (!field[c.x, c.y + 2].Visited) coords.Add(new Coordinates(c.x, c.y + 2));

//            if (c.x + 2 < Width)
//                if (!field[c.x + 2, c.y].Visited) coords.Add(new Coordinates(c.x + 2, c.y));

//            Random r = new Random();
//            return coords[r.Next(0, coords.Count)];
//        }

//        private Coordinates GetRandomNeighbour(Coordinates c, bool b)
//        {
//            List<Coordinates> coords = new List<Coordinates>();

//            if (c.x - 1 >= 0)
//                if (!field[c.x - 1, c.y].Visited) coords.Add(new Coordinates(c.x - 1, c.y));

//            if (c.y - 1 >= 0)
//                if (!field[c.x, c.y - 1].Visited) coords.Add(new Coordinates(c.x, c.y - 1));

//            if (c.y + 1 < Height)
//                if (!field[c.x, c.y + 1].Visited) coords.Add(new Coordinates(c.x, c.y + 1));

//            if (c.x + 1 < Width)
//                if (!field[c.x + 1, c.y].Visited) coords.Add(new Coordinates(c.x + 1, c.y));

//            Random r = new Random();
//            return coords[r.Next(0, coords.Count)];
//        }

//        public void FindPath()
//        {
//            Stack<Coordinates> path = new Stack<Coordinates>();
//            Coordinates current = new Coordinates(1, 1);
//            Coordinates chosen = new Coordinates(1, 1);
//            Coordinates exit = new Coordinates(Width - 2, Height - 2);

//            field[current.x, current.y].Visited = true;
//            while(current.x != exit.x && current.y != exit.y)
//            {
//                if(HasUnvisitedNeighbours(current))
//                {
//                    path.Push(current);
//                    chosen = GetRandomNeighbour(current, true);
//                    current = chosen;
//                    field[current.x, current.y].Visited = true;
//                }
//                else if(path.Count != 0)
//                {
//                    current = path.Pop();
//                }
//            }

//            for(int i = 0; i<Width; i++)
//            {
//                for(int j = 0; j<Height; j++)
//                {
//                    field[i, j].Visited = false;
//                }
//            }

//            Coordinates c;
//            while(path.Count != 0)
//            {
//                c = path.Pop();
//                Console.SetCursorPosition(c.y, c.x);
//                Console.Write("*");
//            }
//            Console.SetCursorPosition(20, 20);
//        }
//        /*
//         * 1. Сделайте начальную клетку текущей и отметьте ее как посещенную.
//2. Пока не найден выход
//  1. Если текущая клетка имеет непосещенных «соседей»
//    1. Протолкните текущую клетку в стек
//    2. Выберите случайную клетку из соседних
//    3. Сделайте выбранную клетку текущей и отметьте ее как посещенную.
//  2. Иначе если стек не пуст
//    1. Выдерните клетку из стека
//    2. Сделайте ее текущей
//  3. Иначе выхода нет
//         */
//        public bool GetWall(int x, int y) => field[x,y].cstr == CellStruct.WALL;
//    }

//    class Cell
//    {
//        public CellStruct cstr { get; set; }
//        public bool Visited { get; set; }

//        public Cell(CellStruct cstr)
//        {
//            this.cstr = cstr;
//            Visited = false;
//        }

//    }

//    enum CellStruct { WALL, EMPTY };

//    struct Coordinates
//    {
//        public int x;
//        public int y;

//        public Coordinates(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }
//}
