using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_BinaryTree_Search
{
    class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _head;

        private int _count;

        public void Add (T value)
        {
            // Первый случай: дерево пустое     

            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }

            // Второй случай: дерево не пустое, поэтому применяем рекурсивный алгоритм 
            //                для поиска места добавления узла        

            else
            {
                AddTo(_head, value);
            }
            _count++;
        }

        // Рекурсивный алгоритм 

        private void AddTo (BinaryTreeNode<T> node, T value)
        {
            // Первый случай: значение добавляемого узла меньше чем значение текущего. 

            if (value.CompareTo(node.Value) < 0)
            {
                // если левый потомок отсутствует - добавляем его          

                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация               
                    AddTo(node.Left, value);
                }
            }
            // Второй случай: значение добавляемого узла равно или больше текущего значения      
            else
            {
                // Если правый потомок отсутствует - добавлем его.          

                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация

                    AddTo(node.Right, value);
                }
            }
        }

        public int Count { get { return _count; } }

        public bool Contains (T value)
        {

            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        // Метод FindWithParent возвращает первый найденный узел.
        // Если значение не найдено, метод возвращает null.
        // Так же возвращает родительский узел для найденного значения.

        private BinaryTreeNode<T> FindWithParent (T value, out BinaryTreeNode<T> parent)
        {
            // Поиск значения в дереве.     

            BinaryTreeNode<T> current = _head;
            parent = null;

            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    // Если искомое значение меньше значение текущего узла - переходим к левому потомку.             

                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // Если искомое значение больше значение текущего узла - переходим к правому потомку.

                    parent = current;
                    current = current.Right;
                }
                else
                {
                    // Искомый элемент найден             
                    break;
                }
            }
            return current;
        }

        #region Нумератор

        public IEnumerator<T> GetEnumerator ()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
