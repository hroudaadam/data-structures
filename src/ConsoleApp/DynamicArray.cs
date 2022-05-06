namespace ConsoleApp
{
    public class DynamicArray<T>
    {
        public int Count => _lastIndex + 1;

        private int _lastIndex = -1;
        private T[] _array = new T[1];

        public T this[int i]
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

        public void Add(T value)
        {
            TryExpandArray();

            _array[_lastIndex + 1] = value;
            _lastIndex++;
        }

        public void RemoveAt(int index)
        {
            CheckOutOfRange(index);

            for (int i = index; i <= _lastIndex; i++)
            {
                if (i < _lastIndex)
                {
                    _array[i] = _array[i + 1];
                }
                else
                {
                    _array[i] = default;
                }
            }

            TryShrinkArray();
            _lastIndex--;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < _lastIndex; i++)
            {
                if (_array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            _lastIndex = -1;
            _array = new T[1];
        }

        public override string ToString()
        {
            return string.Join(", ", _array[..(_lastIndex + 1)]);
        }

        private void CheckOutOfRange(int index)
        {
            if (_lastIndex == -1 || index > _lastIndex || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void TryShrinkArray()
        {
            if (_lastIndex >= _array.Length / 2) return;

            T[] tmp = new T[_array.Length / 2];
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = _array[i];
            }
            _array = tmp;
        }

        private void TryExpandArray()
        {
            if (_lastIndex < (_array.Length - 1)) return;

            T[] tmp = _array;
            _array = new T[_array.Length * 2];
            tmp.CopyTo(_array, 0);
        }
    }
}
