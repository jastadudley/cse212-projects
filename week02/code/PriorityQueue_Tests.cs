using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Needing to add three different elements with different priorities
    // Expected Result: The item with the highest priority should come out from the stack first, the priority 10.
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low",1);
        priorityQueue.Enqueue("medium",5);
        priorityQueue.Enqueue("high",10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("high",result);
    }

    [TestMethod]
    // Scenario: Needing to add three items but this time all with the same priority
    // Expected Result: They should come out of the stack in the order they were added.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 3);
        priorityQueue.Enqueue("second", 3);
        priorityQueue.Enqueue("third", 3);

        Assert.AreEqual("first", priorityQueue.Dequeue());
        Assert.AreEqual("second", priorityQueue.Dequeue());
        Assert.AreEqual("third", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}