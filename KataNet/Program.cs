using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Security.Cryptography;

Console.WriteLine("Initializing benchmark...");

BenchmarkRunner.Run<Kata>();

public class Kata
{
	//Declare variables to do stuff
	private const int N = 10000;
	private readonly byte[] _data;
	private readonly SHA256 _hasher = SHA256.Create();

	public Kata()
	{
		//Initialize stuff
		_data = new byte[N];
		new Random(42).NextBytes(_data);
	}

	[Benchmark]
	public void Execute()
	{
		//Execute code to benchmark
		_hasher.ComputeHash(_data);
	}
}