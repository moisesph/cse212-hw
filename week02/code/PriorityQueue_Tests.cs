using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Linq;


// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add an item to the QUEUE
    // Expected Result: Add an item at the back
    // Defect(s) Found: No Errors Found
    public void TestPriorityAddQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Rodolfo", 3);
        Assert.AreEqual(1, priorityQueue.Count());
    }

    [TestMethod]
    // Scenario: Take off a person from the queue and return them to the back
    // Expected Result: if the list is "Rodolfo, Pepe, Rosa" then it must be " Rosa, miguel, rodolfo"
    // Defect(s) Found: It was not reacting the the Priority Number because the it was not saving the index of the priority element
    public void TestMostPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Rodolfo", 2);
        priorityQueue.Enqueue("Pepe", 1);
        priorityQueue.Enqueue("Rosa", 3);
        priorityQueue.Dequeue();
        string testOriginal = priorityQueue.ToString();
        string testString = Regex.Replace(testOriginal, @"[^a-zA-Z ]", "");
        string[] TestList = testString.Split(' ');
        Assert.AreEqual("Rodolfo", TestList[0]);
    }

    [TestMethod]
    // Scenario: If 2 elements have the same Priority, it should take the first one
    // Expected Result: Take the closes element ("pepe")
    // Defect(s) Found: No Defects founded
    public void TestClosestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Rodolfo", 2);
        priorityQueue.Enqueue("Pepe", 1);
        priorityQueue.Enqueue("Rosa", 1);
        priorityQueue.Dequeue();
        string testOriginal = priorityQueue.ToString();
        string testString = Regex.Replace(testOriginal, @"[^a-zA-Z ]", "");
        string[] TestList = testString.Split(' ');
        Assert.AreNotEqual("Pepe", TestList[0]);
    }

    [TestMethod]
    // Scenario: The list is empty
    // Expected Result: Gives an error message: "The queue is empty."
    // Defect(s) Found: No Errors found
    public void TestEmptyPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        var error = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", error.Message);
    }
}