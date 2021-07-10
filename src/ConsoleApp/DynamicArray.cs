using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class DynamicArray
    {
        public int Count { get; set; } = 0;

        private int _lastIndex = -1;
        private int[] _array = new int[1];

        public int this[int i]
        {
            get
            {
                CheckOutOfRange(i);
                return _array[i];
            }
            set
            {
                CheckOutOfRange(i);
                _array[i] = value;
            }
        }

        public void Add(int value)
        {
            // next index is out of range -> resize array
            if (_lastIndex >= (_array.Length - 1))
            {
                ExpandArray(_array.Length * 2);
            }

            _array[_lastIndex + 1] = value;
            _lastIndex++;
            Count++;
        }

        public void RemoveAt(int index)
        {
            CheckOutOfRange(index);

            for (int i = index; i <= _lastIndex; i++)
            {
                if (i < _array.Length - 1)
                {
                    _array[i] = _array[i + 1];
                }
                else
                {

                    _array[i] = 0;
                }
            }

            if (_lastIndex < _array.Length/2)
            {
                ShrinkArray(_array.Length / 2);
            }

            Count--;
            _lastIndex--;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < _lastIndex; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            _lastIndex = -1;
            _array = new int[1];
        }

        public override string ToString()
        {
            int[] values = new int[_lastIndex + 1];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = _array[i];
            }

            return string.Join(", ", values);
        }

        private void CheckOutOfRange(int index)
        {
            if (_lastIndex == -1 || index > _lastIndex || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void ShrinkArray(int length)
        {
            int[] tmp = new int[length];
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = _array[i];
            }

            _array = tmp;
        }

        private void ExpandArray(int length)
        {
            int[] tmp = _array;
            _array = new int[length];
            tmp.CopyTo(_array, 0);
        }
    }
}
