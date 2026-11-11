
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Three people are added with different priorities.
    // Expected Result: The person with the highest priority (Tim) is removed first.
    // Defect(s) Found: No defect found. The original code correctly selected the person
    // with the highest priority.
    // Final Test Result: Passed. Tim was returned as expected.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Tim", result);
    }

    [TestMethod]
    // Scenario: Two people have the same highest priority.
    // Expected Result: Bob is removed first because he joined before Tim.
    // Defect(s) Found: The original code used >= when comparing priorities.
    // This caused the later person (Tim) to be selected instead of Bob when
    // both had the same priority. The queue did not maintain arrival order.
    // Final Test Result: Passed after changing the comparison from >= to >.
    // Bob is now returned first when priorities are equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Bob", result);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue is called on an empty priority queue.
    // Expected Result: An InvalidOperationException should be thrown with
    // the message "The queue is empty."
    // Defect(s) Found: No defect found. The original code already checked
    // whether the queue was empty and threw the correct exception.
    // Final Test Result: Passed. The expected exception and error message were received.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
        () => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }

}
