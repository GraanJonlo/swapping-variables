using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using SwappingVariablesC;

namespace SwappingVariables.Benchmarks
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        private readonly Random _random;

        public Benchmarks()
        {
            _random = new Random(42);
        }

        [Benchmark(Baseline = true)]
        public (int, int) SwapWithVariable()
        {
            var a1 = _random.Next();
            var b1 = _random.Next();

            var result = Swapper.Vanilla(a1, b1);

            return result;
        }

        [Benchmark]
        public (int, int) SwapWithAdditionAndSubtraction()
        {
            var a1 = _random.Next();
            var b1 = _random.Next();

            var result = Swapper.AdditionAndSubtraction(a1, b1);

            return result;
        }

        [Benchmark]
        public (int, int) SwapWithXor()
        {
            var a1 = _random.Next();
            var b1 = _random.Next();

            var result = Swapper.Xor(a1, b1);

            return result;
        }

        [Benchmark]
        public (int, int) SwapWithTupleDeconstruction()
        {
            var a1 = _random.Next();
            var b1 = _random.Next();

            var result = Swapper.TupleDeconstruction(a1, b1);

            return result;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();
        }
    }
}
