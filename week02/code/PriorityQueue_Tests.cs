using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with three items that needs to be ordered: facturation(2), building(3), sales(1)
    // Expected Result: building, facturation, sales
    // Defect(s) Found: Here it is receiving a different value than the expected one
    public void TestPriorityQueue_1()
    {
        var facturation = new PriorityItem("facturation", 2);
        var building = new PriorityItem("building", 3);
        var sales = new PriorityItem("sales", 1);

        PriorityItem[] expedtedResult = [building, facturation, sales];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(facturation.Value, facturation.Priority);
        priorityQueue.Enqueue(building.Value, building.Priority);
        priorityQueue.Enqueue(sales.Value, sales.Priority);

        for (int i = 0; i < 3; i++)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expedtedResult[i].Value, item);
        }

    }

    [TestMethod]
    // Scenario: Create a queue with four values-priority where two has the same level of priority: facturation(2), building(3), sales(1), details(2)
    // Expected Result: building, facturation, details, sales
    // Defect(s) Found: Here it is receiving a different value than the expected one
    public void TestPriorityQueue_2()
    {
        var facturation = new PriorityItem("facturation", 2);
        var building = new PriorityItem("building", 3);
        var sales = new PriorityItem("sales", 1);
        var details = new PriorityItem("details", 2);

        PriorityItem[] expedtedResult = [building, facturation, details, sales];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(facturation.Value, facturation.Priority);
        priorityQueue.Enqueue(building.Value, building.Priority);
        priorityQueue.Enqueue(sales.Value, sales.Priority);
        priorityQueue.Enqueue(details.Value, details.Priority);

        for (int i = 0; i < 4; i++)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expedtedResult[i].Value, item);
        }
    }



    [TestMethod]
    // Scenario: Try to get the next item from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: It doesn't have any defect
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
    [TestMethod]
    // Scenario: Create a queue with three items that needs to be ordered: facturation(2), building(3), sales(1), and also it is going to verify that the queue is empty
    // Expected Result: No error message is throwed
    // Defect(s) Found: The values are not being dequeued.
    public void TestPriorityQueue_3()
    {
        var facturation = new PriorityItem("facturation", 2);
        var building = new PriorityItem("building", 3);
        var sales = new PriorityItem("sales", 1);

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(facturation.Value, facturation.Priority);
        priorityQueue.Enqueue(building.Value, building.Priority);
        priorityQueue.Enqueue(sales.Value, sales.Priority);
        
        for (int i = 0; i < 3; i++)
        {
            var item = priorityQueue.Dequeue();
        }
        Assert.IsTrue(priorityQueue.IsEmpty, "The queue is not empty");
    }
}