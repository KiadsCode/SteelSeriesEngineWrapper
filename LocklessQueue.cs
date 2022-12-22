using System;
using System.Threading;

namespace SteelSeries.GameSense
{
	public class LocklessQueue<T>
	{
		public LocklessQueue(uint size)
		{
			this._bfr = new T[size];
			this._length = (int)size;
			this._readIdx = 0;
			this._maxReadIdx = 0;
			this._writeIdx = 0;
		}

		private int index(int i)
		{
			return i % this._length;
		}

		public bool PEnqueue(T obj)
		{
			int writeIdx;
			for (;;)
			{
				writeIdx = this._writeIdx;
				int readIdx = this._readIdx;
				if (this.index(writeIdx + 1) == this.index(readIdx))
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this._writeIdx, this.index(writeIdx + 1), writeIdx) == writeIdx)
				{
					goto Block_1;
				}
			}
			return false;
			Block_1:
			this._bfr[this.index(writeIdx)] = obj;
			while (Interlocked.CompareExchange(ref this._maxReadIdx, this.index(writeIdx + 1), writeIdx) != writeIdx)
			{
			}
			return true;
		}

		public T CDequeue()
		{
			T result = default(T);
			for (;;)
			{
				int readIdx = this._readIdx;
				int maxReadIdx = this._maxReadIdx;
				if (this.index(readIdx) == this.index(maxReadIdx))
				{
					break;
				}
				result = this._bfr[this.index(readIdx)];
				if (Interlocked.CompareExchange(ref this._readIdx, readIdx + 1, readIdx) != this._readIdx)
				{
					return result;
				}
			}
			return default(T);
		}

		private T[] _bfr;

		private int _length;

		private int _readIdx;

		private int _maxReadIdx;

		private int _writeIdx;
	}
}
