using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Engines;

namespace FractalSets
{
    /// <summary>
    /// Класс тестирования
    /// </summary>
    [Config(typeof(TestConfig))]
    [SimpleJob(RunStrategy.Monitoring, launchCount: 1, warmupCount: 0, targetCount: 15)]
    public class Tests
    {
        /// <summary>
        /// Конфигурация тестов
        /// </summary>
        private class TestConfig : ManualConfig
        {
            public TestConfig()
            {
                Add(TargetMethodColumn.Method, StatisticColumn.Min, StatisticColumn.Max, StatisticColumn.Median);
                Add(new ParamsColumnWidth("Width"),new ParamsColumnHeight("Height"));
                Add(ConsoleLogger.Default);
                Add(CsvExporter.Default);   
                UnionRule = ConfigUnionRule.AlwaysUseLocal;
            }

        }
        /// <summary>
        /// Вычисления фрактала Жулиа
        /// </summary>
        public IFractalDrawer[] fractalPaintingJul = new IFractalDrawer[]{new FractalDrawerJuliaSimple(), new FractalDrawerJuliaFastBitmap(), new FractalDrawerJuliaAsync(),
new FractalDrawerJuliaAsyncFast()};
        /// <summary>
        /// Вычисления фрактала Мандельброта
        /// </summary>
        public IFractalDrawer[] fractalPaintingMand = new IFractalDrawer[]{new FractalDrawMandelbrotSimple(), new FractalDrawMandelbrotFast(), new FractalDrawMandelbrotSimpleAsync(),
new FractalDrawerMandelbrotFastAsync()};

        JuliaFractal julia;

        MandelbrotFractal mandelbrot;

        [Benchmark(Description = "Simple Julia")]
        [Arguments(600, 800)]
        [Arguments(1920, 1080)]
        public void TestpaintJulSimple(int width, int height)
        {
            julia = new JuliaFractal(width, height, 300, -0.254362425435387, -0.764323274433643325, fractalPaintingJul[0]);
            julia.Draw();
        }

        [Benchmark(Description = "Julia FastBitmap with")]
        [Arguments(600, 800)]
        [Arguments(1920, 1080)]
        public void TestpaintJulFast(int width, int height)
        {
            julia = new JuliaFractal(width, height, 300, -0.254362425435387, -0.764323274433643325, fractalPaintingJul[1]);
            julia.Draw();
        }

        [Benchmark(Description = "Parallel Julia")]
        [Arguments(600, 800)]
        [Arguments(1920, 1080)]
        public void TestpaintJulAsync(int width, int height)
        {
            julia = new JuliaFractal(width, height, 300, -0.254362425435387, -0.764323274433643325, fractalPaintingJul[2]);
            julia.Draw();
        }

        [Benchmark(Description = "Julia Parallel and FB with")]
        [Arguments(600, 800)]
        [Arguments(1920, 1080)]
        public void TestpaintJulFastAsync(int width, int height)
        {
            julia = new JuliaFractal(width, height, 300, -0.254362425435387, -0.764323274433643325, fractalPaintingJul[3]);
            julia.Draw();
        }

        [Benchmark(Description = "Simple Mandelbrot")]
        [Arguments(600, 800)]
        [Arguments(1920, 1080)]
        public void TestpaintMandelbrotSimple(int width, int height)
        {
            mandelbrot = new MandelbrotFractal(300, -2.1, 1, -1.3, 1.3, width, height, fractalPaintingMand[0]);
            mandelbrot.Draw();
        }

        [Benchmark(Description = "Mandelbrot FastBitmap with")]
        [Arguments(600, 800)]
        [Arguments(1920, 1080)]
        public void TestpaintMandelbrotFast(int width, int height)
        {
            mandelbrot = new MandelbrotFractal(300, -2.1, 1, -1.3, 1.3, width, height, fractalPaintingMand[1]);
            mandelbrot.Draw();
        }

        [Benchmark(Description = "Parallel Mandelbrot")]
        [Arguments(600, 800)]
        [Arguments(1920, 1080)]
        public void TestpaintMandelbrotAsync(int width, int height)
        {
            mandelbrot = new MandelbrotFractal(300, -2.1, 1, -1.3, 1.3, width, height, fractalPaintingMand[2]);
            mandelbrot.Draw();
        }

        [Benchmark(Description = "Mandelbrot Parallel and FB with")]
        [Arguments(600, 800)]
        [Arguments(1920, 1080)]
        public void TestpaintMandelbrotAsyncFast(int width, int height)
        {
            mandelbrot = new MandelbrotFractal(300, -2.1, 1, -1.3, 1.3, width, height, fractalPaintingMand[3]);
            mandelbrot.Draw();
        }
    }
}
