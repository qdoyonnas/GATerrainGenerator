using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Terrain_Generator_GA
{
    public enum TerrainType
    {
        Grass,
        Water,
        Sand,
        Forest,
        Mountain,
        Ice
    }

    public struct GASettings
    {
        public int populationSize;
        public float mutationRate;
        public float crossoverRate;
        public float individualMutationRate;

        public int mapWidth;
        public int mapHeight;

        public bool tile_selection;
        public bool expanded_mutation;
        public bool blend_crossover;
        public bool refined_clumping;

        public float ratio_weight;
        public float[] tilePercentages;
        public float clumping_weight;
    }

    static class Program
    {
        public const int NumberOfTerrainTypes = 6;

        public static Terrain_generator_form tg_form;
        public static TerrainGeneratorGA tg_ga;
        public static Random random;

        public static bool isRunningGA = false;

        static Thread GAThread;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            random = new Random();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            tg_form = new Terrain_generator_form();
            Application.Run( tg_form );
        }

        public static void StartGA(GASettings settings)
        {
            tg_ga = new TerrainGeneratorGA( settings );
            tg_ga.EvaluateFitness();
            tg_ga.Draw();

            isRunningGA = true;

            GAThread = new Thread( new ThreadStart( Run ) );
            GAThread.Start();
        }
        public static void StopGA()
        {
            isRunningGA = false;
        }

        public static void Run()
        {
            while( isRunningGA ) {
                tg_ga.RunGeneration();

                Thread.Sleep( 0 );
            }
        }
    }
}
