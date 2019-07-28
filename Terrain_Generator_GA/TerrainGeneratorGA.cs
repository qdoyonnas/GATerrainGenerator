using System;
using System.Collections.Generic;
using System.Drawing;

namespace Terrain_Generator_GA
{
    class TerrainGeneratorGA
    {
        public GASettings settings;
        List<Terrain> population;

        int generation;
        float totalFitness;
        float highestFitness;

        public TerrainGeneratorGA( GASettings settings)
        {
            this.settings = settings;
            totalFitness = 0;
            highestFitness = 0;

            population = new List<Terrain>(settings.populationSize);
            for( int i = 0; i < settings.populationSize; i++ ) {
                population.Add( new Terrain( settings.mapWidth, settings.mapHeight, true, settings.tile_selection ) );
            }
        }

        public void Settings( GASettings settings )
        {
            this.settings = settings;
        }

        #region Genetic Algorithm

        public void RunGeneration()
        {
            generation++;
            Program.tg_form.IncrementGeneration( generation );

            List<Terrain> new_population = new List<Terrain>(settings.populationSize);

            for( int i = 0; i < settings.populationSize; i += 2 ) {
                int parent1Index = RouletteSelect();
                int parent2Index = RouletteSelect();

                Terrain baby1; Terrain baby2;
                BoxCrossover( population[parent1Index], population[parent2Index], out baby1, out baby2 );
                new_population.Add( baby1 );
                new_population.Add( baby2 );
            }
            population = new_population;

            Mutate();

            EvaluateFitness();
            Draw();
        }

        public void EvaluateFitness()
        {
            totalFitness = 0;
            highestFitness = 0;

            foreach( Terrain terrain in population ) {
                float fitness = terrain.CalcFitness();
                totalFitness += fitness;

                highestFitness = ( fitness > highestFitness ? fitness : highestFitness );
            }

            Program.tg_form.UpdateFitness( highestFitness );

            // Sort
            population.Sort( ( t1, t2 ) => t2.fitness.CompareTo( t1.fitness ) );
        }

        int RouletteSelect()
        {
            float fitnessMark = (float)Program.random.NextDouble() * totalFitness;

            int index = -1;
            float atFitness = 0;
            while( atFitness <= fitnessMark && index < population.Count-1 ) {
                index++;
                atFitness += population[index].fitness;
            }

            return index;
        }

        void BoxCrossover( Terrain parent1, Terrain parent2, out Terrain baby1, out Terrain baby2 )
        {
            double crossRoll = Program.random.NextDouble();
            if( crossRoll < settings.crossoverRate ) {
                baby1 = parent1;
                baby2 = parent2;
                return;
            }

            baby1 = new Terrain( settings.mapWidth, settings.mapHeight, false );
            baby2 = new Terrain( settings.mapWidth, settings.mapHeight, false );

            int crossPointXMin = Program.random.Next( 0, settings.mapWidth - 2 );
            int crossPointXMax = Program.random.Next( crossPointXMin + 1, settings.mapWidth - 1 );
            int crossPointYMin = Program.random.Next( 0, settings.mapHeight - 2 );
            int crossPointYMax = Program.random.Next( crossPointYMin + 1, settings.mapHeight - 1 );

            for( int x = 0; x < settings.mapWidth; x++ ) {
                for( int y = 0; y < settings.mapHeight; y++ ) {
                    if( CheckInBox(x, y, crossPointXMin, crossPointXMax, crossPointYMin, crossPointYMax)
                        && ( !settings.blend_crossover || Program.random.NextDouble() < settings.crossoverRate ) )
                    {
                        baby1.SetAt( parent2.GetAt( x, y ), x, y );
                        baby2.SetAt( parent1.GetAt( x, y ), x, y );
                    } else {
                        baby1.SetAt( parent1.GetAt( x, y ), x, y );
                        baby2.SetAt( parent2.GetAt( x, y ), x, y );
                    }
                }
            }
        }

        bool CheckInBox(int x, int y, int crossPointXMin, int crossPointXMax, int crossPointYMin, int crossPointYMax)
        {
            if( x >= crossPointXMin
                && x <= crossPointXMax
                && y >= crossPointYMin
                && y <= crossPointYMax  )
            {
                return true;
            }

            return false;
        }

        void Mutate()
        {
            foreach( Terrain terrain in population ) {
                double mutateRoll = Program.random.NextDouble();

                if( mutateRoll < settings.mutationRate ) {
                    terrain.Mutate();
                } else {
                    return;
                }
            }
        }

        #endregion

        #region Draw

        public void Draw()
        {
            Size pictureSize = Program.tg_form.GetPictureSize();
            Size pixelSize = new Size( ( pictureSize.Width / settings.mapWidth ), ( pictureSize.Height / settings.mapHeight ) );

            for( int i = 0; i < 1; i++ ) {
                DrawMap( i, pictureSize, pixelSize );
            }
        }

        void DrawMap( int index, Size pictureSize, Size pixelSize )
        {
            Bitmap image = new Bitmap( pictureSize.Width, pictureSize.Height );
            Graphics graphics = Graphics.FromImage( image );

            for( int x = 0; x < settings.mapWidth; x++ ) {
                for( int y = 0; y < settings.mapHeight; y++ ) {
                    graphics.FillRectangle( SelectBrush( index, x, y ), x * pixelSize.Width, y * pixelSize.Height, pixelSize.Width, pixelSize.Height );
                }
            }

            PictureData data = new PictureData();
            data.image = image;
            data.fit = population[index].fitness;
            data.index = index;
            data.terrains = new int[Program.NumberOfTerrainTypes];
            data.terrains[(int)TerrainType.Grass] = (int)Math.Floor(population[index].tileAmounts[(int)TerrainType.Grass] * 100);
            data.terrains[(int)TerrainType.Water] = (int)Math.Floor(population[index].tileAmounts[(int)TerrainType.Water] * 100);
            data.terrains[(int)TerrainType.Forest] = (int)Math.Floor(population[index].tileAmounts[(int)TerrainType.Forest] * 100);
            data.terrains[(int)TerrainType.Mountain] = (int)Math.Floor(population[index].tileAmounts[(int)TerrainType.Mountain] * 100);
            data.terrains[(int)TerrainType.Sand] = (int)Math.Floor(population[index].tileAmounts[(int)TerrainType.Sand] * 100);
            data.terrains[(int)TerrainType.Ice] = (int)Math.Floor(population[index].tileAmounts[(int)TerrainType.Ice] * 100);

            Program.tg_form.SetMapPicture( data );
            graphics.Dispose();
        }
        Brush SelectBrush(int idx, int x, int y)
        {
            Brush brush = Brushes.Black;
            switch( population[idx].GetAt( x, y ) ) {
                case TerrainType.Grass:
                    brush = Brushes.Green;
                    break;
                case TerrainType.Water:
                    brush = Brushes.Blue;
                    break;
                case TerrainType.Sand:
                    brush = Brushes.Yellow;
                    break;
                case TerrainType.Forest:
                    brush = Brushes.DarkGreen;
                    break;
                case TerrainType.Mountain:
                    brush = Brushes.Gray;
                    break;
                case TerrainType.Ice:
                    brush = Brushes.LightBlue;
                    break;
            }

            return brush;
        }

        #endregion
    }
}
