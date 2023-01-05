using DSA;
using DSA.Assignment_10;
using DSA.Assignment_11;
using DSA.Assignment_12;
using DSA.Assignment_13;
using DSA.Assignment_14;
using DSA.Assignment_15;
using DSA.Assignment_5;
using DSA.Assignment_6;
using DSA.Assignment_7;
using DSA.Assignment_8;
using DSA.Assignment_9;
using DSA.Assignment8;
using DSA.BST_Problem;
using DSA.DivideAndConquer_Algo;
using DSA.Dynamic_Programming;
using DSA.Graph_Data_Structure;
using DSA.Hashing_Data_Type;
using DSA.HeapSort;
using DSA.LinkedList_Datatype;
using DSA.MergeSort;
using DSA.QuickSort;
using DSA.Sorting_Algo;
using DSA.Stack_DataType;
using DSA.Testing;
using DSA.Tree_Data_Structure;
using QueueDataType.Queue;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 20, 40, 60, 80, 90, 120, 140 };
            int result = 210;
            int l = 0;
            int r = arr.Length - 1;

            Program obj = new Program();

            TwoSumQuestion twoPointerApproach = new TwoSumQuestion();
            //Console.WriteLine("Result:" +twoPointerApproach.RunTwoPointer());

            _2DArrayQuestion _2DArrayQuestion = new _2DArrayQuestion();
            //Console.WriteLine("Result:" + _2DArrayQuestion.Run());

            FindSqaureRoot findSqaureRoot = new FindSqaureRoot();
            //Console.WriteLine(findSqaureRoot.FindSqaureRootFirstApproach(12));


            ArrayProblemWithoutLength arrayProblem = new ArrayProblemWithoutLength();
            //Console.WriteLine(arrayProblem.Run());

            IsPrefectSqaure isPrefectSqaure = new IsPrefectSqaure();
            //Console.WriteLine("Is Prefect Sqaure: " + isPrefectSqaure.FindSqaureRootFirstApproach(12));

            TernarySearch ternarySearch = new TernarySearch();
            //Console.WriteLine(ternarySearch.Run());

            BubbleSort bubbleSort = new BubbleSort();
            //Console.WriteLine(bubbleSort.Run());

            SelectionSort selectionSort = new SelectionSort();
            //Console.WriteLine(selectionSort.Run());

            InsertionSort insertionSort = new InsertionSort();
            //Console.WriteLine(insertionSort.Run());

            //Console.WriteLine("******** Min Heap ***********");
            CreateMinHeap createMinHeap = new CreateMinHeap();
            //Console.WriteLine(createMinHeap.Run());

            //Console.WriteLine("First Min Integer: " + createMinHeap.Pop());
            //Console.WriteLine("Second Min Integer: " + createMinHeap.Pop());
            //Console.WriteLine("Third Min Integer: " + createMinHeap.Pop());
            //Console.WriteLine(createMinHeap.DisplayArray());
            //createMinHeap.Insert(-1);
            //Console.WriteLine(createMinHeap.DisplayArray());

            //Console.WriteLine("******** Max Heap ***********");
            CreateMaxHeap createMaxHeap = new CreateMaxHeap();
            //Console.WriteLine(createMaxHeap.Run());
            //Console.WriteLine("First Max Integer: " + createMaxHeap.Pop());
            //Console.WriteLine("Second Max Integer: " + createMaxHeap.Pop());
            //Console.WriteLine("Third Max Integer: " + createMaxHeap.Pop());
            //Console.WriteLine(createMaxHeap.DisplayArray());
            //createMaxHeap.Insert(123);
            //Console.WriteLine(createMaxHeap.DisplayArray());

            KMostFrequentWord kMostFrequentWord = new KMostFrequentWord();
            //Console.WriteLine(kMostFrequentWord.Run());


            FindMinAndMax findMinAndMax = new FindMinAndMax();
            //Console.WriteLine(findMinAndMax.Run());


            KClosestPointToOrigin kClosestPointToOrigin = new KClosestPointToOrigin();
            //Console.WriteLine("K Closest Point to Origin");
            //Console.WriteLine(kClosestPointToOrigin.Run());

            KMostFrequentWord mostFrequentWord = new KMostFrequentWord();
            //Console.WriteLine("K Most Frequent Word");
            //Console.WriteLine(mostFrequentWord.Run());


            SumOfClosestToTarget sumOfClosestToTarget = new SumOfClosestToTarget();
            //sumOfClosestToTarget.Run();

            AreThreePointCollinear areThreePointCollinear = new AreThreePointCollinear();
            //areThreePointCollinear.Run();


            TrackPurchasesQuestion3 priorityQueue = new TrackPurchasesQuestion3();
            //Console.WriteLine(priorityQueue.Run());


            BuildMinHeap buildMinHeap = new BuildMinHeap();
            //Console.WriteLine(buildMinHeap.Run());

            MergeSortArray mergeSortArray = new MergeSortArray();
            //mergeSortArray.Run();

            QuickSortAlgo quickSortAlgo = new QuickSortAlgo();
            //quickSortAlgo.Run();

            RandomizQuickSortAlgo randomizQuick = new RandomizQuickSortAlgo();
            //randomizQuick.Run();

            SelectionProcedureQuickSort selectionProcedure = new SelectionProcedureQuickSort();
            //selectionProcedure.Run();

            KSmallestElement kSmallestElement = new KSmallestElement();
            //kSmallestElement.Run();

            KLargestElement kLargestElement = new KLargestElement();
            //kLargestElement.Run();

            SortColor sortColor = new SortColor();
            //sortColor.Run();


            SortColorApproach_2 sortColorApproach_2 = new SortColorApproach_2();
            //sortColorApproach_2.Run();

            FindMajorityElement majorityElement = new FindMajorityElement();
            //majorityElement.Run();

            FindPeekElement peekElement = new FindPeekElement();
            //Console.WriteLine($"Peek Element: {peekElement.Run()}");


            CountNumberOfInversion inversion = new CountNumberOfInversion();
            //inversion.Run();

            DivideTwoInterger twoInterger = new DivideTwoInterger();
            //twoInterger.Run();

            FindMedianOfSortedTwoArray sortedTwoArray = new FindMedianOfSortedTwoArray();
            //sortedTwoArray.Run();
            //sortedTwoArray.Approach_2();

            FindPowerOfElement findPowerOfElement = new FindPowerOfElement();
            //findPowerOfElement.Run();

            StrassensMatrixMultiplication strassensMatrix = new StrassensMatrixMultiplication();
            //strassensMatrix.Run();

            SingleLinkedList singleLinkedList = new SingleLinkedList();
            //singleLinkedList.Run();

            MergeTwoSortedLinkedList mergeTwoSortedLinkedList = new MergeTwoSortedLinkedList();
            //mergeTwoSortedLinkedList.Run();


            ReversalLinkedList reversalLinkedList = new ReversalLinkedList();
            //reversalLinkedList.Run();

            LinkedListCycle linkedListCycle = new LinkedListCycle();
            //linkedListCycle.Run();

            PalindromeLinkedList palindromeLinkedList = new PalindromeLinkedList();
            //palindromeLinkedList.Run();

            SortLinkedList sortLinkedList = new SortLinkedList();
            //sortLinkedList.Run();

            RemoveNthNodeFromLinkedList removeNthNode = new RemoveNthNodeFromLinkedList();
            //removeNthNode.Run();

            ConvertSinglyToCircularLinkedList convertSingly = new ConvertSinglyToCircularLinkedList();
            //convertSingly.Run();

            FindStringIsvalid isvalid = new FindStringIsvalid();
            //isvalid.Run();

            QueuePractice queuePractice = new QueuePractice();
            //queuePractice.Run();

            ImplementStackUsingQueue queue = new ImplementStackUsingQueue();
            //queue.Run();

            ImplementStackUsingQueueApproach_2 queueApproach_2 = new ImplementStackUsingQueueApproach_2();
            //queueApproach_2.Run();

            ImplementQueueUsingStack queueUsingStack = new ImplementQueueUsingStack();
            //queueUsingStack.Run();

            ImplementQueueUsingStackApproach_2 stackApproach_2 = new ImplementQueueUsingStackApproach_2();
            //stackApproach_2.Run();

            HashTable hashTable = new HashTable();
            //hashTable.Run();

            HashTableUsingMidSqaure midSqaure = new HashTableUsingMidSqaure();
            //midSqaure.Run();

            HashTableWithChainingCollision chainingCollision = new HashTableWithChainingCollision();
            //chainingCollision.Run();

            HashTableLinearProbingCollision linearProbingCollision = new HashTableLinearProbingCollision();
            //linearProbingCollision.Run();

            HashTableQuadraticProbingCollision quadraticProbingCollision = new HashTableQuadraticProbingCollision();
            //quadraticProbingCollision.Run();

            HashTableDoubleHashingCollision doubleHashingCollision = new HashTableDoubleHashingCollision();
            //doubleHashingCollision.Run();

            TreeTraversalAlgorithm treeTraversal = new TreeTraversalAlgorithm();
            //treeTraversal.Run();

            TreeTraversalAlgorithmWithoutRecursion algorithmWithoutRecursion = new TreeTraversalAlgorithmWithoutRecursion();
            //algorithmWithoutRecursion.Run();

            RecoverBinarySearchTree recoverBinary = new RecoverBinarySearchTree();
            //recoverBinary.Run();

            LCAOfBinarySearchTree lcaBST = new LCAOfBinarySearchTree();
            //lcaBST.Run();

            FindPathExistInGraph existInGraph = new FindPathExistInGraph();
            //existInGraph.Run();

            DepthFirstTraversal depthFirstTraversal = new DepthFirstTraversal();
            //depthFirstTraversal.Run();

            InvertBinaryTree invertBinaryTree = new InvertBinaryTree();
            //invertBinaryTree.Run();


            ValidBST validBST = new ValidBST();
            //validBST.Run();

            FibonacciSeriesUsingDP usingDP = new FibonacciSeriesUsingDP();
            //usingDP.Run();

            LongestCommonSubSequence subSequence = new LongestCommonSubSequence();
            //subSequence.Run();

            _01Knapsack _01Knapsack = new _01Knapsack();
            //_01Knapsack.Run();

            CatalanNumber catalanNumber = new CatalanNumber();
            catalanNumber.Run();

            Console.WriteLine();

        }
    }
}