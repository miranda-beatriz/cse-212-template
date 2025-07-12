using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // This test case checks if the priority queue correctly returns the item with the highest priority.
    // Expected Result: 
    // The expected result is that the item with the highest priority is returned first.
    // Defect(s) Found:
    // Before fix, returned "Medium" instead of "High" because loop did not check all elements.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Enqueue 2 items with the same priority.
    // Expected Result: Dequeue returns the first enqueued item ("First") following FIFO
    // Defect(s) Found: Before fix, returned "Second" because loop used >= instead of >.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
    }


}