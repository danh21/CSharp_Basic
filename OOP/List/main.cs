using System;

public class List<T>
{
	// Constant
	const int defaultCapacity = 4;

	// Fields
	T[] items;
	int count;

	// Constructor
	public List(int capacity = defaultCapacity)
	{
		items = new T[capacity];
	}

	// Properties
	public int Count => count;
	public int Capacity
	{
		get { return items.Length; }
		set
		{
			if (value < count) value = count;
			if (value != items.Length)
			{
				T[] newItems = new T[value];
				Array.Copy(items, 0, newItems, 0, count); //Copy the contents of the original array (items) into the new array, up to count elements
				items = newItems;
			}
		}
	}

	// Indexer
	public T this[int index]
	{
		get
		{
			return items[index];
		}
		set
		{
			items[index] = value;
			OnChanged();
		}
	}

	// Methods
	public void Add(T item)
	{
		if (count == Capacity) Capacity = count * 2;
		items[count] = item;
		count++;
		OnChanged();
	}

	protected virtual void OnChanged() => Changed?.Invoke(this, EventArgs.Empty);
    
    // override of the Equals method
	public override bool Equals(object other) => Equals(this, other as List<T>);    
	static bool Equals(List<T> a, List<T> b)
	{
	    // both a and b are null
		if (Object.ReferenceEquals(a, null)) 
		    return Object.ReferenceEquals(b, null);
		    
		if (Object.ReferenceEquals(b, null) || a.count != b.count)
			return false;
			
		for (int i = 0; i < a.count; i++)
		{
			if (!object.Equals(a.items[i], b.items[i]))
			{
				return false;
			}
		}
		
		return true;
	}

	// fix warning related to override GetHashCode
	public override int GetHashCode()
	{
		int hash = 17;
		for (int i = 0; i < count; i++)
		{
			hash = hash * 31 + (items[i]?.GetHashCode() ?? 0);
		}
		return hash;
	}

	// Event
	public event EventHandler Changed;

	// Operators
	public static bool operator ==(List<T> a, List<T> b) => Equals(a, b);
	public static bool operator !=(List<T> a, List<T> b) => !Equals(a, b);
}



class HelloWorld {
	static int changeCount;
	static void ListChanged(object sender, EventArgs e)
	{
		changeCount++;
	}

	static void Main() {
		List<string> names = new List<string>();
		names.Capacity = 100;   // Invokes set accessor
		names.Changed += new EventHandler(ListChanged);

		names.Add("Liz");
		names.Add("Martha");
		names.Add("Beth");
		Console.WriteLine($"Count = {names.Count} ; Capacity = {names.Capacity}");

		Console.WriteLine(changeCount); // Outputs "3"

		for (int i = 0; i < names.Count; i++)
		{
			string s = names[i];
			names[i] = s.ToUpper();
			Console.WriteLine(names[i]);
		}

		List<int> a = new List<int>();
		a.Add(1);
		a.Add(2);
		List<int> b = new List<int>();
		b.Add(1);
		b.Add(2);
		Console.WriteLine(a == b); // Outputs "True"
		b.Add(3);
		Console.WriteLine(a == b); // Outputs "False"
	}
}