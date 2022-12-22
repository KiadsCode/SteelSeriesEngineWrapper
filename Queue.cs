﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SteelSeries.GameSense.Generic
{
    [DebuggerDisplay("Count = {Count}")]
    [TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    [Serializable]
    public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
    {
        public Queue()
        {
            this._array = Array.Empty<T>();
        }

        public Queue(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("capacity", capacity, SR.ArgumentOutOfRange_NeedNonNegNum);
            }
            this._array = new T[capacity];
        }

        public Queue(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection");
            }
            this._array = EnumerableHelpers.ToArray<T>(collection, out this._size);
            if (this._size != this._array.Length)
            {
                this._tail = this._size;
            }
        }

        public int Count
        {
            get
            {
                return this._size;
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                return false;
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                return this;
            }
        }

        public void Clear()
        {
            if (this._size != 0)
            {
                if (this._head < this._tail)
                {
                    Array.Clear(this._array, this._head, this._size);
                }
                else
                {
                    Array.Clear(this._array, this._head, this._array.Length - this._head);
                    Array.Clear(this._array, 0, this._tail);
                }
                this._size = 0;
            }
            this._head = 0;
            this._tail = 0;
            this._version++;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (arrayIndex < 0 || arrayIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException("arrayIndex", arrayIndex, SR.ArgumentOutOfRange_Index);
            }
            int num = array.Length;
            if (num - arrayIndex < this._size)
            {
                throw new ArgumentException(SR.Argument_InvalidOffLen);
            }
            int num2 = this._size;
            if (num2 == 0)
            {
                return;
            }
            int num3 = Math.Min(this._array.Length - this._head, num2);
            Array.Copy(this._array, this._head, array, arrayIndex, num3);
            num2 -= num3;
            if (num2 > 0)
            {
                Array.Copy(this._array, 0, array, arrayIndex + this._array.Length - this._head, num2);
            }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (array.Rank != 1)
            {
                throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
            }
            if (array.GetLowerBound(0) != 0)
            {
                throw new ArgumentException(SR.Arg_NonZeroLowerBound, "array");
            }
            int length = array.Length;
            if (index < 0 || index > length)
            {
                throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_Index);
            }
            if (length - index < this._size)
            {
                throw new ArgumentException(SR.Argument_InvalidOffLen);
            }
            int num = this._size;
            if (num == 0)
            {
                return;
            }
            try
            {
                int num2 = (this._array.Length - this._head < num) ? (this._array.Length - this._head) : num;
                Array.Copy(this._array, this._head, array, index, num2);
                num -= num2;
                if (num > 0)
                {
                    Array.Copy(this._array, 0, array, index + this._array.Length - this._head, num);
                }
            }
            catch (ArrayTypeMismatchException)
            {
                throw new ArgumentException(SR.Argument_InvalidArrayType, "array");
            }
        }

        public void Enqueue(T item)
        {
            if (this._size == this._array.Length)
            {
                int num = (int)((long)this._array.Length * 200L / 100L);
                if (num < this._array.Length + 4)
                {
                    num = this._array.Length + 4;
                }
                this.SetCapacity(num);
            }
            this._array[this._tail] = item;
            this.MoveNext(ref this._tail);
            this._size++;
            this._version++;
        }

        public Queue<T>.Enumerator GetEnumerator()
        {
            return new Queue<T>.Enumerator(this);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()

        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Queue<T>.Enumerator(this);
        }

        public T Dequeue()
        {
            int head = this._head;
            T[] array = this._array;
            if (this._size == 0)
            {
                this.ThrowForEmptyQueue();
            }
            T result = array[head];
            this.MoveNext(ref this._head);
            this._size--;
            this._version++;
            return result;
        }

        public bool TryDequeue(out T result)
        {
            int head = this._head;
            T[] array = this._array;
            if (this._size == 0)
            {
                result = default(T);
                return false;
            }
            result = array[head];
            this.MoveNext(ref this._head);
            this._size--;
            this._version++;
            return true;
        }

        public T Peek()
        {
            if (this._size == 0)
            {
                this.ThrowForEmptyQueue();
            }
            return this._array[this._head];
        }

        public bool TryPeek(out T result)
        {
            if (this._size == 0)
            {
                result = default(T);
                return false;
            }
            result = this._array[this._head];
            return true;
        }

        public bool Contains(T item)
        {
            if (this._size == 0)
            {
                return false;
            }
            if (this._head < this._tail)
            {
                return Array.IndexOf<T>(this._array, item, this._head, this._size) >= 0;
            }
            return Array.IndexOf<T>(this._array, item, this._head, this._array.Length - this._head) >= 0 || Array.IndexOf<T>(this._array, item, 0, this._tail) >= 0;
        }

        public T[] ToArray()
        {
            if (this._size == 0)
            {
                return Array.Empty<T>();
            }
            T[] array = new T[this._size];
            if (this._head < this._tail)
            {
                Array.Copy(this._array, this._head, array, 0, this._size);
            }
            else
            {
                Array.Copy(this._array, this._head, array, 0, this._array.Length - this._head);
                Array.Copy(this._array, 0, array, this._array.Length - this._head, this._tail);
            }
            return array;
        }

        private void SetCapacity(int capacity)
        {
            T[] array = new T[capacity];
            if (this._size > 0)
            {
                if (this._head < this._tail)
                {
                    Array.Copy(this._array, this._head, array, 0, this._size);
                }
                else
                {
                    Array.Copy(this._array, this._head, array, 0, this._array.Length - this._head);
                    Array.Copy(this._array, 0, array, this._array.Length - this._head, this._tail);
                }
            }
            this._array = array;
            this._head = 0;
            this._tail = ((this._size == capacity) ? 0 : this._size);
            this._version++;
        }

        private void MoveNext(ref int index)
        {
            int num = index + 1;
            if (num == this._array.Length)
            {
                num = 0;
            }
            index = num;
        }

        private void ThrowForEmptyQueue()
        {
            throw new InvalidOperationException(SR.InvalidOperation_EmptyQueue);
        }

        public void TrimExcess()
        {
            int num = (int)((double)this._array.Length * 0.9);
            if (this._size < num)
            {
                this.SetCapacity(this._size);
            }
        }

        private T[] _array;

        private int _head;

        private int _tail;

        private int _size;

        private int _version;

        public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
        {
            internal Enumerator(Queue<T> q)
            {
                this._q = q;
                this._version = q._version;
                this._index = -1;
                this._currentElement = default(T);
            }

            public void Dispose()
            {
                this._index = -2;
                this._currentElement = default(T);
            }

            public bool MoveNext()
            {
                if (this._version != this._q._version)
                {
                    throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
                }
                if (this._index == -2)
                {
                    return false;
                }
                this._index++;
                if (this._index == this._q._size)
                {
                    this._index = -2;
                    this._currentElement = default(T);
                    return false;
                }
                T[] array = this._q._array;
                int num = array.Length;
                int num2 = this._q._head + this._index;
                if (num2 >= num)
                {
                    num2 -= num;
                }
                this._currentElement = array[num2];
                return true;
            }

            public T Current
            {
                get
                {
                    if (this._index < 0)
                    {
                        this.ThrowEnumerationNotStartedOrEnded();
                    }
                    return this._currentElement;
                }
            }

            private void ThrowEnumerationNotStartedOrEnded()
            {
                throw new InvalidOperationException((this._index == -1) ? SR.InvalidOperation_EnumNotStarted : SR.InvalidOperation_EnumEnded);
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            void IEnumerator.Reset()
            {
                if (this._version != this._q._version)
                {
                    throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
                }
                this._index = -1;
                this._currentElement = default(T);
            }

            private readonly Queue<T> _q;

            private readonly int _version;

            private int _index;

            private T _currentElement;
        }
    }
}