//using System.Transactions;

//namespace Lab6test
//{
//    [TestClass]
//    public sealed class GreenTest
//    {
//        Lab6.Green _main = new Lab6.Green();
//        const double E = 0.0001;
//        Data _data = new Data();

//        [TestMethod]
//        public void Test01()
//        {
//            // Arrange
//            var inputA = new int[][] {
//                new int[] { -2, -1, -3, -4 },
//                new int[] { 2, 1, 3, 4 },
//                new int[] { 0, 2, 4, 6, 8 },
//                new int[] { 2, 1, 3, 3, 5, 6, 3, 4 },
//                new int[] { 5, 2, -8, 1, 9, 3, 7, 4, 6 },
//                new int[] { 12, 1, 3, 3, 5, 6, 3, 4 },
//                new int[] { -2, -1, -3, -4 },
//                new int[] { 0, 2, 4, 6, 8 },
//                new int[] { 2, 1, 3, 3, 5, 6, 3, 4 },
//                new int[] { 5, 2, 8, 1, 9, 0, 7, 4, 6 }
//            };
//            var inputB = new int[][] {
//                new int[] { 0, 0, 0, 0, 0 },
//                new int[] { 5 },
//                new int[] { 0, 2, 4, 6, 8 },
//                new int[] { 5, 2, -8, 1, 9, 3, 7, 4, 6 },
//                new int[] { 5, 2, 8, 1, 4, 3, 7, 4, 6, 0 },
//                new int[] { 0, 0, 0, 0, 0 },
//                new int[] { 5 },
//                new int[] { 0, 2, 4, 6, 8 },
//                new int[] { 5, 2, -8, 1, 9, 3, 7, 4, 6 },
//                new int[] { 5, 2, 8, 1, 4, 3, 7, 4, 6, 0 }
//            };
//            var answerA = new int[][] {
//                new int[] { -2, -3, -4, 0, 0, 0, 0 },
//                new int[] { 2, 1, 3 },
//                new int[] { 0, 2, 4, 6, 0, 2, 4, 6 },
//                new int[] { 2, 1, 3, 3, 5, 3, 4, 5, 2, -8, 1, 3, 7, 4, 6 },
//                new int[] { 5, 2, -8, 1, 3, 7, 4, 6, 5, 2, 1, 4, 3, 7, 4, 6, 0 },
//                new int[] { 1, 3, 3, 5, 6, 3, 4, 0, 0, 0, 0 },
//                new int[] { -2, -3, -4 },
//                new int[] { 0, 2, 4, 6, 0, 2, 4, 6 },
//                new int[] { 2, 1, 3, 3, 5, 3, 4, 5, 2, -8, 1, 3, 7, 4, 6 },
//                new int[] { 5, 2, 8, 1, 0, 7, 4, 6, 5, 2, 1, 4, 3, 7, 4, 6, 0 }
//            };
//            var answerB = new int[][] {
//                new int[] { 0, 0, 0, 0 },
//                new int[] { },
//                new int[] { 0, 2, 4, 6 },
//                new int[] { 5, 2, -8, 1, 3, 7, 4, 6 },
//                new int[] { 5, 2, 1, 4, 3, 7, 4, 6, 0 },
//                new int[] { 0, 0, 0, 0 },
//                new int[] { },
//                new int[] { 0, 2, 4, 6 },
//                new int[] { 5, 2, -8, 1, 3, 7, 4, 6 },
//                new int[] { 5, 2, 1, 4, 3, 7, 4, 6, 0 }
//            };
//            // Act
//            for (int i = 0; i < answerA.Length; i++)
//            {
//                _main.Task1(ref inputA[i], ref inputB[i]);
//            }
//            // Assert
//            for (int i = 0; i < answerA.Length; i++)
//            {
//                Assert.AreEqual(answerA[i].Length, inputA[i].Length);
//                for (int j = 0; j < answerA[i].Length; j++)
//                {
//                    Assert.AreEqual(answerA[i][j], inputA[i][j], E);
//                }
//                Assert.AreEqual(answerB[i].Length, inputB[i].Length);
//                for (int j = 0; j < answerB[i].Length; j++)
//                {
//                    Assert.AreEqual(answerB[i][j], inputB[i][j], E);
//                }
//            }
//        }
//        [TestMethod]
//        public void Test02()
//        {
//            // Arrange
//            var inputA = _data.GetMatrixes();
//            var inputB = new int[][] {
//                new int[] { -2, -1, -3, -4 },
//                new int[] { 2, 1, 3, 4 },
//                new int[] { 0, 2, 4, 6, 8, -2 },
//                new int[] { 3, 3, 3, 3 },
//                new int[] { 5, 2, -8, 1, 9, 4, 6 },
//                new int[] { 12, 1, 3, 3, 5, 6, 3, 4 },
//                new int[] { -2, -1, -3 },
//                new int[] { 0, 2, 4, 6, 8, 11, 25 },
//                new int[] { 2, 1, 3, 3, 5, 6, 3 },
//                new int[] { 50, 20, 8, 1, 9 }
//            };
//            var answerA = new int[][,] {
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, 9, 10, 11},
//                    {9, 10, 11, 12, 13, 14, 15},
//                    {13, 14, 15, 16, 17, 18, 19},
//                    {0, 1, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {2},
//                    {5},
//                    {9},
//                    {13},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6},
//                    {5, 6, 7, 8, 9, 11},
//                    {0, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 4, 6},
//                    {5, -6, 7, 11},
//                    {-1, 4, -5, 6},
//                    {1, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, -9, 10, 11},
//                    {9, 10, -11, -12, -13, -14, -15},
//                    {-13, -14, 15, 16, 17, 18, -19},
//                },
//                new int[,] {
//                    {1, 2, 3},
//                    {5, 11, -17},
//                    {0, -2, -3},
//                },
//                new int[,] {
//                    {-9, -10, -11, -14, -15, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5, -6, -7},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, -15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5, -6, -7},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, 15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                    {5, 11, -17, 11, -10, 6, -5},
//                    {1, 1, -2, 3, -4, 0, 0},
//                    {0, -2, -3, -4, -5, 0, 5},
//                },
//                new int[,] {
//                    {1, 2, 3, 50, -5},
//                    {5, 20, -17, 11, 7},
//                    {8, -10, -11, -14, -15},
//                    {-9, -10, -11, -14, 1},
//                    {9, -2, -3, -4, -5},
//                }
//            };
//            var answerB = new int[][] {
//                new int[] { -2, -1, -3, -4 },
//                new int[] { 2, 1, 3, 4 },
//                new int[] { 0, 2, 4, 6, 8, -2 },
//                new int[] { 3, 3, 3, 3 },
//                new int[] { 5, 2, -8, 1, 9, 4, 6 },
//                new int[] { 12, 1, 3, 3, 5, 6, 3, 4 },
//                new int[] { -2, -1, -3 },
//                new int[] { 0, 2, 4, 6, 8, 11, 25 },
//                new int[] { 2, 1, 3, 3, 5, 6, 3 },
//                new int[] { 50, 20, 8, 1, 9 }
//            };
//            // Act
//            for (int i = 0; i < inputA.Length; i++)
//            {
//                _main.Task2(inputA[i], inputB[i]);
//            }
//            // Assert
//            for (int i = 0; i < inputA.Length; i++)
//            {
//                Assert.AreEqual(answerA[i].GetLength(0), inputA[i].GetLength(0));
//                for (int j = 0; j < inputA[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answerA[i].GetLength(1), inputA[i].GetLength(1));
//                    for (int k = 0; k < inputA[i].GetLength(1); k++)
//                    {
//                        Assert.AreEqual(answerA[i][j, k], inputA[i][j, k]);
//                    }
//                }
//                Assert.AreEqual(answerB[i].Length, inputB[i].Length);
//                for (int j = 0; j < answerB[i].Length; j++)
//                {
//                    Assert.AreEqual(answerB[i][j], inputB[i][j], E);
//                }
//            }
//        }
//        [TestMethod]
//        public void Test03()
//        {
//            // Arrange
//            var input = _data.GetMatrixes();
//            var answer = new int[][,] {
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, 9, 10, 11},
//                    {9, 10, 11, 12, 13, 14, 15},
//                    {13, 14, 15, 16, 17, 18, 19},
//                    {0, 1, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {1},
//                    {5},
//                    {9},
//                    {13},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6},
//                    {5, 6, 7, 8, 9, 11},
//                    {0, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {6, 2, 4, 1},
//                    {5, 11, 7, -6},
//                    {-1, 4, 6, -5},
//                    {1, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, -9, 10, 11},
//                    {9, 10, -11, -12, -13, -14, -15},
//                    {-13, -14, 15, 16, 17, 18, -19},
//                },
//                new int[,] {
//                    {2, 1, 3},
//                    {5, 11, -17},
//                    {0, -3, -2},
//                },
//                new int[,] {
//                    {-9, -10, -11, -14, -15, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5, -6, -7},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, -15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5, -6, -7},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, 15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                    {5, 11, -17, 11, -10, 6, -5},
//                    {1, 1, -2, 3, -4, 0, 0},
//                    {0, -2, -3, -4, -5, 0, 5},
//                },
//                new int[,] {
//                    {2, 1, 3, 4, -5},
//                    {5, 11, -17, 11, 7},
//                    {-9, -11, -10, -14, -15},
//                    {-9, -14, -11, -10, -6},
//                    {0, -5, -3, -4, -2},
//                }
//            };
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                _main.Task3(input[i]);
//            }
//            // Assert
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
//                for (int j = 0; j < answer[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
//                    for (int k = 0; k < answer[i].GetLength(1); k++)
//                    {
//                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
//                    }
//                }
//            }
//        }
//        [TestMethod]
//        public void Test04()
//        {
//            // Arrange
//            var input = _data.GetMatrixes();
//            var answer = new int[][,] {
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, 9, 10, 11},
//                    {9, 10, 11, 12, 13, 14, 15},
//                    {13, 14, 15, 16, 17, 18, 19},
//                },
//                new int[,] {
//                    {1},
//                    {5},
//                    {9},
//                    {13},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6},
//                    {5, 6, 7, 8, 9, 11},
//                },
//                new int[,] {
//                    {1, 2, 4, 6},
//                    {5, -6, 7, 11},
//                    {-1, 4, -5, 6},
//                    {1, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, -9, 10, 11},
//                    {9, 10, -11, -12, -13, -14, -15},
//                    {-13, -14, 15, 16, 17, 18, -19},
//                },
//                new int[,] {
//                    {1, 2, 3},
//                    {5, 11, -17},
//                },
//                new int[,] {
//                    {-9, -10, -11, -14, -15, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5, -6, -7},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, -15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5, -6, -7},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, 15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                    {5, 11, -17, 11, -10, 6, -5},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5},
//                    {5, 11, -17, 11, 7},
//                    {-9, -10, -11, -14, -15},
//                    {-9, -10, -11, -14, -6},
//                }
//            };
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                _main.Task4(ref input[i]);
//            }
//            // Assert
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
//                for (int j = 0; j < answer[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
//                    for (int k = 0; k < answer[i].GetLength(1); k++)
//                    {
//                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
//                    }
//                }
//            }
//        }
//        [TestMethod]
//        public void Test05()
//        {
//            // Arrange
//            var input = _data.GetMatrixes();
//            var answer = new int[][] {
//                null,
//                null,
//                null,
//                new int[] { 1, -6, -5, 6 },
//                null,
//                new int[] { 1, -17, -3 },
//                null,
//                null,
//                null,
//                new int[] { -5, -17, -15, -14, -5 }
//            };
//            var test = new int[answer.Length][];
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                test[i] = _main.Task5(input[i]);
//            }
//            // Assert
//            for (int i = 0; i < answer.Length; i++)
//            {
//                if (answer[i] == null)
//                {
//                    Assert.IsNull(test[i]);
//                    continue;
//                }
//                Assert.AreEqual(answer[i].Length, test[i].Length);
//                for (int j = 0; j < answer[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answer[i][j], test[i][j]);
//                }
//            }
//        }
//        [TestMethod]
//        public void Test06()
//        {
//            // Arrange
//            var inputA = _data.GetMatrixes();
//            var inputB = _data.GetMatrixes();
//            Array.Reverse(inputB);
//            var answer = new int[][] {
//                new int[] { 28, 33, 38, 43, 48, 53, 58, 6, 13, 3, 15, 7 },
//                new int[] { 28, 12, 25, 3, 29, 15, 18, 15 },
//                new int[] { 6, 10, 13, 16, 19, 23, 6, 13, 3, 15, 0, 12, 10 },
//                new int[] { 7, 10, 16, 29, 0, 0, 0, 0, 0, 6 },
//                new int[] { 15, 18, 25, 28, 22, 34, 18, 6, 13, 3 },
//                new int[] { 6, 13, 3, 15, 18, 25, 28, 22, 34, 18 },
//                new int[] { 0, 0, 0, 0, 0, 6, 7, 10, 16, 29 },
//                new int[] { 6, 13, 3, 15, 0, 12, 10, 6, 10, 13, 16, 19, 23 },
//                new int[] { 12, 25, 3, 29, 15, 18, 15, 28 },
//                new int[] { 6, 13, 3, 15, 7, 28, 33, 38, 43, 48, 53, 58 }
//            };
//            var test = new int[answer.Length][];
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                test[i] = _main.Task6(inputA[i], inputB[i]);
//            }
//            // Assert
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i].Length, test[i].Length);
//                for (int j = 0; j < answer[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answer[i][j], test[i][j]);
//                }
//            }
//        }
//        [TestMethod]
//        public void Test07A()
//        {
//            // Arrange
//            var input = _data.GetMatrixes();
//            var answer = new int[][,] {
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, 9, 10, 11},
//                    {9, 10, 11, 12, 13, 14, 15},
//                    {13, 14, 15, 16, 17, 18, 19},
//                    {0, 1, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {1},
//                    {5},
//                    {9},
//                    {13},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6},
//                    {5, 6, 7, 8, 9, 11},
//                    {0, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 4, 6},
//                    {5, -6, 7, 11},
//                    {-1, 4, -5, 6},
//                    {1, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, -9, 10, 11},
//                    {9, 10, -15, -14, -13, -12, -11},
//                    {-13, -14, 15, 16, 17, 18, -19},
//                },
//                new int[,] {
//                    {1, 2, 3},
//                    {5, 11, -17},
//                    {0, -3, -2},
//                },
//                new int[,] {
//                    {-9, -10, -11, -14, -15, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -7, -6, -5},
//                    {5, 11, -17, -10, 5, 6, 11},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, -15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -7, -6, -5},
//                    {5, 11, -17, -10, 5, 6, 11},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, 15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                    {5, 11, -17, -10, -5, 6, 11},
//                    {1, 1, -2, 3, -4, 0, 0},
//                    {0, -2, -3, -4, -5, 0, 5},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5},
//                    {5, 11, -17, 7, 11},
//                    {-9, -15, -14, -11, -10},
//                    {-9, -10, -11, -14, -6},
//                    {0, -5, -4, -3, -2},
//                }
//            };
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                _main.Task7(input[i], _main.SortEndAscending);
//            }
//            // Assert
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
//                for (int j = 0; j < answer[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
//                    for (int k = 0; k < answer[i].GetLength(1); k++)
//                    {
//                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
//                    }
//                }
//            }
//        }
//        [TestMethod]
//        public void Test07B()
//        {
//            // Arrange
//            var input = _data.GetMatrixes();
//            var answer = new int[][,] {
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, 9, 10, 11},
//                    {9, 10, 11, 12, 13, 14, 15},
//                    {13, 14, 15, 16, 17, 18, 19},
//                    {0, 1, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {1},
//                    {5},
//                    {9},
//                    {13},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6},
//                    {5, 6, 7, 8, 9, 11},
//                    {0, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 4, 6},
//                    {5, -6, 7, 11},
//                    {-1, 4, -5, 6},
//                    {1, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, -9, 10, 11},
//                    {9, 10, -11, -12, -13, -14, -15},
//                    {-13, -14, 15, 16, 17, 18, -19},
//                },
//                new int[,] {
//                    {1, 2, 3},
//                    {5, 11, -17},
//                    {0, -2, -3},
//                },
//                new int[,] {
//                    {-9, -10, -11, -14, -15, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5, -6, -7},
//                    {5, 11, 11, 6, 5, -10, -17},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, -15, -6, -2},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5, -6, -7},
//                    {5, 11, 11, 6, 5, -10, -17},
//                    {-9, -10, -11, -14, -15, -16, 1},
//                    {-9, -10, -11, -14, 15, -2, -6},
//                    {-9, -10, -11, -14, -15, 6, 4},
//                    {5, 11, 11, 6, -5, -10, -17},
//                    {1, 1, -2, 3, 0, 0, -4},
//                    {0, -2, -3, -4, -5, 0, 5},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, -5},
//                    {5, 11, 11, 7, -17},
//                    {-9, -10, -11, -14, -15},
//                    {-9, -10, -11, -14, -6},
//                    {0, -2, -3, -4, -5},
//                }
//            };
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                _main.Task7(input[i], _main.SortEndDescending);
//            }
//            // Assert
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
//                for (int j = 0; j < answer[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
//                    for (int k = 0; k < answer[i].GetLength(1); k++)
//                    {
//                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
//                    }
//                }
//            }
//        }
//        [TestMethod]
//        public void Test08()
//        {
//            // Arrange
//            var inputA = new double[][] {
//                new double[] { 2, 1.5, 3 },
//                new double[] { 1.9, 3, 4 },
//                new double[] { 4, 6, 8 },
//                new double[] { 2, 3, 3 },
//                new double[] { 5, 6, 8 },
//                new double[] { 12, 13, 35 },
//                new double[] { 13, 14, 15 },
//                new double[] { 12, 12, 12 },
//                new double[] { 15, 15, 15 },
//                new double[] { 5, 10, 8 }
//            };
//            var inputB = new double[][] {
//                new double[] { 5, 6, 8 },
//                new double[] { 1.7, 3, 4 },
//                new double[] { 2, 1.5, 3 },
//                new double[] { 12, 13, 35 },
//                new double[] { 13, 14, 15 },
//                new double[] { 15, 15, 15 },
//                new double[] { 4, 6, 8 },
//                new double[] { 12, 12, 12 },
//                new double[] { 2, 3, 3 },
//                new double[] { 5, 10, 8 }
//            };
//            var answer = new int[10] { 2, 1, 1, 1, 2, 2, 1, 2, 1, 2};
//            var test = new int[answer.Length];
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                test[i] = _main.Task8(inputA[i], inputB[i]);
//            }
//            // Assert
//            Assert.AreEqual(answer.Length, test.Length);
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i], test[i], E);
//            }
//        }
//        [TestMethod]
//        public void Test09B()
//        {
//            // Arrange
//            var input = _data.GetMatrixes();
//            var answer = new int[][,] {
//                new int[,] {
//                    {7, 6, 5, 4, 3, 2, 1},
//                    {5, 6, 7, 8, 9, 10, 11},
//                    {15, 14, 13, 12, 11, 10, 9},
//                    {13, 14, 15, 16, 17, 18, 19},
//                    {6, 5, 4, 3, 2, 1, 0},
//                },
//                new int[,] {
//                    {1},
//                    {5},
//                    {9},
//                    {13},
//                },
//                new int[,] {
//                    {6, 5, 4, 3, 2, 1},
//                    {5, 6, 7, 8, 9, 11},
//                    {6, 5, 4, 3, 2, 0},
//                },
//                new int[,] {
//                    {6, 4, 2, 1},
//                    {5, -6, 7, 11},
//                    {6, 4, -1, -5},
//                    {1, 4, 5, 6},
//                },
//                new int[,] {
//                    {7, 6, 5, 4, 3, 2, 1},
//                    {5, 6, 7, 8, -9, 10, 11},
//                    {10, 9, -11, -12, -13, -14, -15},
//                    {-13, -14, 15, 16, 17, 18, -19},
//                },
//                new int[,] {
//                    {3, 2, 1},
//                    {5, 11, -17},
//                    {0, -2, -3},
//                },
//                new int[,] {
//                    {6, -9, -10, -11, -14, -15},
//                },
//                new int[,] {
//                    {4, 3, 2, 1, -5, -6, -7},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {1, -9, -10, -11, -14, -15, -16},
//                    {-9, -10, -11, -14, -15, -6, -2},
//                    {6, 4, -9, -10, -11, -14, -15},
//                },
//                new int[,] {
//                    {4, 3, 2, 1, -5, -6, -7},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {1, -9, -10, -11, -14, -15, -16},
//                    {-9, -10, -11, -14, 15, -6, -2},
//                    {6, 4, -9, -10, -11, -14, -15},
//                    {5, 11, -17, 11, -10, 6, -5},
//                    {3, 1, 1, 0, 0, -2, -4},
//                    {0, -2, -3, -4, -5, 0, 5},
//                },
//                new int[,] {
//                    {4, 3, 2, 1, -5},
//                    {5, 11, -17, 11, 7},
//                    {-9, -10, -11, -14, -15},
//                    {-9, -10, -11, -14, -6},
//                    {0, -2, -3, -4, -5},
//                },
//            };
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                _main.Task9(input[i], _main.SortDescending);
//            }
//            // Assert
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
//                for (int j = 0; j < answer[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
//                    for (int k = 0; k < answer[i].GetLength(1); k++)
//                    {
//                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
//                    }
//                }
//            }
//        }
//        [TestMethod]
//        public void Test09A()
//        {
//            // Arrange
//            var input = _data.GetMatrixes();
//            var answer = new int[][,] {
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, 9, 10, 11},
//                    {9, 10, 11, 12, 13, 14, 15},
//                    {13, 14, 15, 16, 17, 18, 19},
//                    {0, 1, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {1},
//                    {5},
//                    {9},
//                    {13},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6},
//                    {5, 6, 7, 8, 9, 11},
//                    {0, 2, 3, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 4, 6},
//                    {5, -6, 7, 11},
//                    {-5, -1, 4, 6},
//                    {1, 4, 5, 6},
//                },
//                new int[,] {
//                    {1, 2, 3, 4, 5, 6, 7},
//                    {5, 6, 7, 8, -9, 10, 11},
//                    {-15, -14, -13, -12, -11, 9, 10},
//                    {-13, -14, 15, 16, 17, 18, -19},
//                },
//                new int[,] {
//                    {1, 2, 3},
//                    {5, 11, -17},
//                    {-3, -2, 0},
//                },
//                new int[,] {
//                    {-15, -14, -11, -10, -9, 6},
//                },
//                new int[,] {
//                    {-7, -6, -5, 1, 2, 3, 4},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {-16, -15, -14, -11, -10, -9, 1},
//                    {-9, -10, -11, -14, -15, -6, -2},
//                    {-15, -14, -11, -10, -9, 4, 6},
//                },
//                new int[,] {
//                    {-7, -6, -5, 1, 2, 3, 4},
//                    {5, 11, -17, 11, -10, 6, 5},
//                    {-16, -15, -14, -11, -10, -9, 1},
//                    {-9, -10, -11, -14, 15, -6, -2},
//                    {-15, -14, -11, -10, -9, 4, 6},
//                    {5, 11, -17, 11, -10, 6, -5},
//                    {-4, -2, 0, 0, 1, 1, 3},
//                    {0, -2, -3, -4, -5, 0, 5},
//                },
//                new int[,] {
//                    {-5, 1, 2, 3, 4},
//                    {5, 11, -17, 11, 7},
//                    {-15, -14, -11, -10, -9},
//                    {-9, -10, -11, -14, -6},
//                    {-5, -4, -3, -2, 0},
//                }
//            };
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                _main.Task9(input[i], _main.SortAscending);
//            }
//            // Assert
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
//                for (int j = 0; j < answer[i].GetLength(0); j++)
//                {
//                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
//                    for (int k = 0; k < answer[i].GetLength(1); k++)
//                    {
//                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
//                    }
//                }
//            }
//        }
//        [TestMethod]
//        public void Test10A()
//        {
//            // Arrange
//            var input = _data.GetArrayArrays();
//            var answer = new double[5] { 1, 1, 0, 1, 0 };
//            var test = new double[answer.Length];
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                test[i] = _main.Task10(input[i], _main.CountZeroSum);
//            }
//            // Assert
//            Assert.AreEqual(answer.Length, test.Length);
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i], test[i], E);
//            }
//        }
//        [TestMethod]
//        public void Test10B()
//        {
//            // Arrange
//            var input = _data.GetArrayArrays();
//            var answer = new double[5] { 3, 2, 3, 1, 3 };
//            var test = new double[answer.Length];
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                test[i] = _main.Task10(input[i], _main.FindMedian);
//            }
//            // Assert
//            Assert.AreEqual(answer.Length, test.Length);
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i], test[i], E);
//            }
//        }
//        [TestMethod]
//        public void Test10C()
//        {
//            // Arrange
//            var input = _data.GetArrayArrays();
//            var answer = new double[5] { 32, 20, 5, 0, 26 };
//            var test = new double[answer.Length];
//            // Act
//            for (int i = 0; i < answer.Length; i++)
//            {
//                test[i] = _main.Task10(input[i], _main.CountLargeElements);
//            }
//            // Assert
//            Assert.AreEqual(answer.Length, test.Length);
//            for (int i = 0; i < answer.Length; i++)
//            {
//                Assert.AreEqual(answer[i], test[i], E);
//            }
//        }
//        [TestMethod]
//        public void Test_DeleteMaxElement()
//        {
//            int[] array = { 1, 5, 3, 9, 2 };
//            int[] expected = { 1, 5, 3, 2 };
//            _main.DeleteMaxElement(ref array);
//            CollectionAssert.AreEqual(expected, array);
//        }

//        [TestMethod]
//        public void Test_CombineArrays()
//        {
//            int[] A = { 1, 2 };
//            int[] B = { 3, 4 };
//            int[] expected = { 1, 2, 3, 4 };
//            int[] actual = _main.CombineArrays(A, B);
//            CollectionAssert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        public void Test_FindMaxInRow()
//        {
//            int[,] matrix = {
//            { 1, 2, -33 },
//            { 4, 0, 6 },
//            { 17, 8, 9 }
//        };
//            int expected = 6;
//            int actual = _main.FindMaxInRow(matrix, 1, out int col);
//            Assert.AreEqual(expected, actual);
//            Assert.AreEqual(col, 2);
//        }

//        [TestMethod]
//        public void Test_FindMax_Matrix()
//        {
//            int[,] matrix = {
//            { 1, 2 },
//            { 3, 4 }
//        };
//            _main.FindMax(matrix, out int row, out int col);
//            Assert.AreEqual(1, row);
//            Assert.AreEqual(1, col);
//        }

//        [TestMethod]
//        public void Test_SwapColWithDiagonal()
//        {
//            int[,] matrix = {
//            { 1, 2, 7 },
//            { 3, 4, 3 },
//            { 0, 8, 2 }
//        };
//            _main.SwapColWithDiagonal(matrix, 1);
//            int[,] expected = {
//            { 2, 1, 7 },
//            { 3, 4, 3 },
//            { 0, 2, 8 }
//        }; // здесь пример, где результат совпадает с исходным (для 2x2)
//            CollectionAssert.AreEqual(expected.Cast<int>().ToArray(), matrix.Cast<int>().ToArray());
//        }

//        [TestMethod]
//        public void Test_RemoveRow()
//        {
//            int[,] matrix = {
//            { 1, 0 },
//            { 2, 3 }
//        };
//            _main.RemoveRow(ref matrix, 0);
//            int[,] expected = { { 2, 3 } };
//            CollectionAssert.AreEqual(expected.Cast<int>().ToArray(), matrix.Cast<int>().ToArray());
//        }

//        [TestMethod]
//        public void Test_GetRowsMinElements()
//        {
//            int[,] matrix = {
//            { 1, 2, 3 },
//            { 4, 0, 6 },
//            { 7, 8, 9 }
//        };
//            int[] expected = { 1, 0, 9 };
//            int[] actual = _main.GetRowsMinElements(matrix);
//            CollectionAssert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        public void Test_SumPositiveElementsInColumns()
//        {
//            int[,] matrix = {
//            { 1, -2 },
//            { 3, 4 }
//        };
//            int[] expected = { 4, 4 };
//            int[] actual = _main.SumPositiveElementsInColumns(matrix);
//            CollectionAssert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        public void Test_GeronArea()
//        {
//            double area = _main.GeronArea(3, 4, 5);
//            Assert.AreEqual(6, area, 0.0001);
//        }
//        [TestMethod]
//        public void Test_CountZeroSum()
//        {
//            int[][] array = {
//            new[] { 1, -1, 0 },
//            new[] { 2, 2, 2 }
//        };
//            Assert.AreEqual(1, _main.CountZeroSum(array), E);
//        }
//        [TestMethod]
//        public void Test_FindMedian()
//        {
//            int[][] array = {
//            new[] { 1, -1, 0 },
//            new[] { 2, 2, 2 }
//        };
//            Assert.AreEqual(1.5, _main.FindMedian(array), E); // median: -1,0,1,2,2,2 => 1.5
//        }
//        [TestMethod]
//        public void Test_CountLargeElements()
//        {
//            int[][] array = {
//            new[] { 1, -1, 0 },
//            new[] { 2, 2, 2 }
//        };
//            Assert.AreEqual(1, _main.CountLargeElements(array), E);
//        }
//    }
//}
