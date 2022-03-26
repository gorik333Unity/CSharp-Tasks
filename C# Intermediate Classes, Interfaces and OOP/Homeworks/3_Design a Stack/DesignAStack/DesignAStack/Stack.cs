using System;

namespace DesignAStack
{
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();
        /// <summary>
        /// Adds a object to the stack
        /// </summary>
        /// <param name="obj">object</param>
        /// <exception cref="ArgumentNullException">object cannot be null</exception>
        public void Push(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("Null pushed");

            _stack.Add(obj);
        }
        /// <summary>
        /// Gets and remove that object from the stack
        /// </summary>
        /// <returns>Object in a LIFO fashion</returns>
        /// <exception cref="InvalidOperationException">Stack cannot be empty</exception>
        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("Stack is empty!");

            var itemIndex = _stack.Count - 1;
            object objectToReturn = _stack[itemIndex];

            _stack.RemoveAt(itemIndex);

            return objectToReturn;
        }
        /// <summary>
        /// Clears stack
        /// </summary>
        public void Clear()
        {
            _stack.Clear();
        }
    }
}
