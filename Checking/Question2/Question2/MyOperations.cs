using System;

namespace MyOperations
{
    public delegate void OperationHandler();

    public class Operations
    {
        public void PerformDivision(int a, int b)
        {
            OperationHandler handler = () =>
            {
                try
                {
                    int result = a / b;
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    throw new MyCustomException(1001, "Attempted to divide by zero.");
                }
            };
            ExecuteOperation(handler);
        }

        public void AccessArrayElement(int[] arr, int index)
        {
            OperationHandler handler = () =>
            {
                try
                {
                    Console.WriteLine($"Element at index {index}: {arr[index]}");
                }
                catch (IndexOutOfRangeException)
                {
                    throw new MyCustomException(1002, "Index out of range.");
                }
            };
            ExecuteOperation(handler);
        }

        private void ExecuteOperation(OperationHandler operation)
        {
            try
            {
                operation.Invoke();
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Error Code: {ex.ErrorCode}, Message: {ex.Message}");
            }
        }
    }
}