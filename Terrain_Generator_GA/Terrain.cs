using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrain_Generator_GA
{
    class Terrain
    {
        public float fitness = 0;
        public float[] tileAmounts = new float[Program.NumberOfTerrainTypes];
        TerrainType[,] tiles;

        public Terrain(int width, int height, bool generate, bool tile_selection = false )
        {
            tiles = new TerrainType[width, height];

            if( generate ) {
                GenerateRandom( tile_selection );
            }
        }

        void GenerateRandom( bool tile_selection )
        {
            if( tile_selection ) {
                int choiceAmount = Program.random.Next( Program.NumberOfTerrainTypes * 2 );
                TerrainType[] typeChoices = new TerrainType[choiceAmount+1];
                for( int i = 0; i < choiceAmount; i++ ) {
                    typeChoices[i] = (TerrainType)Program.random.Next(Program.NumberOfTerrainTypes);
                }

                for( int x = 0; x < tiles.GetLength(0); x++ ) {
                    for( int y = 0; y < tiles.GetLength(1); y++ ) {
                        tiles[x, y] = typeChoices[Program.random.Next( choiceAmount )];
                    }
                }
            } else {
                for (int x = 0; x < tiles.GetLength(0); x++) {
                    for (int y = 0; y < tiles.GetLength(1); y++) {
                        tiles[x, y] = (TerrainType)Program.random.Next(Program.NumberOfTerrainTypes);
                    }
                }
            }
        }

        public float CalcFitness()
        {
            GASettings settings = Program.tg_ga.settings;
            fitness = 0;

            tileAmounts = new float[Program.NumberOfTerrainTypes];

            for( int x = 0; x < tiles.GetLength( 0 ); x++ ) {
                for( int y = 0; y < tiles.GetLength( 1 ); y++ ) {
                    TerrainType thisTile = tiles[x, y];
                    tileAmounts[ (int)thisTile ] += 1;

                    if( settings.clumping_weight != 0 ) {
                        for( int x2 = -1; x2 < 2; x2++ ) {
                            for( int y2 = -1; y2 < 2; y2++ ) {
                                if( ( x2 == x && y2 == y )
                                    || x + x2 < 0
                                    || y + y2 < 0
                                    || x + x2 >= tiles.GetLength(0) 
                                    || y + y2 >= tiles.GetLength(1) )
                                { continue; }
                                
                                TerrainType otherTile = tiles[x + x2, y + y2];

                                if( !settings.refined_clumping ) {
                                    if( thisTile == otherTile ) {
                                        fitness += settings.clumping_weight;
                                    }
                                } else {
                                    switch( thisTile ) {
                                    case TerrainType.Grass:
                                        if( otherTile == TerrainType.Mountain
                                            || otherTile == TerrainType.Forest )
                                        {
                                            fitness += settings.clumping_weight;
                                        }
                                        break;
                                    case TerrainType.Water:
                                        if( otherTile == TerrainType.Water ) {
                                            fitness += settings.clumping_weight;
                                        }
                                        break;
                                    case TerrainType.Sand:
                                        if( otherTile == TerrainType.Sand
                                            || otherTile == TerrainType.Water ) {
                                            fitness += settings.clumping_weight;
                                        }
                                        break;
                                    case TerrainType.Forest:
                                        if( otherTile == TerrainType.Mountain
                                        || otherTile == TerrainType.Grass )
                                        {
                                            fitness += settings.clumping_weight;
                                        }
                                        break;
                                    case TerrainType.Mountain:
                                        if( otherTile == TerrainType.Grass
                                        || otherTile == TerrainType.Forest )
                                        {
                                            fitness += settings.clumping_weight;
                                        }
                                        break;
                                    case TerrainType.Ice:
                                        if( otherTile == TerrainType.Ice
                                        || otherTile == TerrainType.Mountain )
                                        {
                                            fitness += settings.clumping_weight;
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for( int i = 0; i < Program.NumberOfTerrainTypes; i++ ) {
                tileAmounts[i] = tileAmounts[i] / tiles.Length;
                fitness += ( 1 / ( Math.Abs( tileAmounts[i] - settings.tilePercentages[i] ) * 100 + 1 ) ) * settings.ratio_weight;
            }

            return fitness;
        }

        public void Mutate()
        {
            int startX = 0;
            int startY = 0;

            if( !Program.tg_ga.settings.expanded_mutation ) {
                startX = Program.random.Next( tiles.GetLength(0) - 1 );
                startY = Program.random.Next( tiles.GetLength(1) - 1 );
            }

            for( int x = startX; x < tiles.GetLength( 0 ); x++ ) {
                for( int y = startY; y < tiles.GetLength( 1 ); y++ ) {
                    double mutateRoll = Program.random.NextDouble();
                    if( mutateRoll < Program.tg_ga.settings.individualMutationRate ) {
                        tiles[x, y] = (TerrainType)Program.random.Next( Program.NumberOfTerrainTypes );
                    } else if( !Program.tg_ga.settings.expanded_mutation ) {
                        return;
                    }
                }
            }
        }

        public TerrainType GetAt( int x, int y )
        {
            return tiles[x, y];
        }
        public void SetAt( TerrainType type, int x, int y )
        {
            tiles[x, y] = type;
        }
    }
}