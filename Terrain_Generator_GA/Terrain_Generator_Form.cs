using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Terrain_Generator_GA
{
    public struct PictureData
    {
        public int index;
        public Image image;
        public float fit;
        public int[] terrains;
    }

    delegate void SetMapPictureDelegate( PictureData data );
    delegate void UpdateFitnessDelegate( float fitness );
    delegate void IncrementFitnessDelegate( int generation );

    public partial class Terrain_generator_form : Form
    {
        public Terrain_generator_form()
        {
            InitializeComponent();

            SetRatioTexts();
        }

        void SetRatioTexts()
        {
            grass_number.Value = grass_track.Value;
            water_number.Value = water_track.Value;
            forest_number.Value = forest_track.Value;
            mountain_number.Value = mountain_track.Value;
            sand_number.Value = sand_track.Value;
            ice_number.Value = ice_track.Value;
        }

        public void IncrementGeneration( int generation )
        {
            if( generation_text.InvokeRequired ) {
                IncrementFitnessDelegate del = new IncrementFitnessDelegate( IncrementGeneration );
                this.Invoke( del, new object[] { generation } );
            } else {
                generation_text.Text = generation.ToString();
            }
        }
        public void UpdateFitness( float fitness )
        {
            if( fitness_text.InvokeRequired ) {
                UpdateFitnessDelegate del = new UpdateFitnessDelegate( UpdateFitness );
                this.Invoke( del, new object[] { fitness } );
            } else {
                fitness_text.Text = fitness.ToString();
            }
        }

        public Size GetPictureSize()
        {
            return map1_picturebox.Size;
        }
        public void SetMapPicture( PictureData data )
        {
            if( this.map1_picturebox.InvokeRequired ) {
                SetMapPictureDelegate del = new SetMapPictureDelegate( SetMapPicture );
                this.Invoke( del, new object[] { data } );
            } else {
                string map_name = "map" + (data.index + 1).ToString();
                PictureBox picture = this.Controls.Find(map_name + "_picturebox", true).FirstOrDefault() as PictureBox;
                Label fit_text = this.Controls.Find(map_name + "_fitness_text", true).FirstOrDefault() as Label;
                Label water_text = this.Controls.Find(map_name + "_water_text", true).FirstOrDefault() as Label;
                Label land_text = this.Controls.Find(map_name + "_land_text", true).FirstOrDefault() as Label;
                Label forest_text = this.Controls.Find(map_name + "_forest_text", true).FirstOrDefault() as Label;
                Label mountain_text = this.Controls.Find(map_name + "_mountain_text", true).FirstOrDefault() as Label;
                Label sand_text = this.Controls.Find(map_name + "_sand_text", true).FirstOrDefault() as Label;
                Label ice_text = this.Controls.Find(map_name + "_ice_text", true).FirstOrDefault() as Label;

                if( picture != null ) {
                    picture.Image = data.image;
                    picture.Refresh();
                }

                if( fit_text != null ) { fit_text.Text = data.fit.ToString(); }
                if( water_text != null ) { water_text.Text = data.terrains[(int)TerrainType.Water].ToString(); }
                if( land_text != null ) { land_text.Text = data.terrains[(int)TerrainType.Grass].ToString(); }
                if( forest_text != null ) { forest_text.Text = data.terrains[(int)TerrainType.Forest].ToString(); }
                if( mountain_text != null ) { mountain_text.Text = data.terrains[(int)TerrainType.Mountain].ToString(); }
                if( sand_text != null ) { sand_text.Text = data.terrains[(int)TerrainType.Sand].ToString(); }
                if( ice_text != null ) { ice_text.Text = data.terrains[(int)TerrainType.Ice].ToString(); }
            }
        }

        private void Start_button_Click( object sender, EventArgs e )
        {
            if( !Program.isRunningGA ) {
                GASettings settings = new GASettings();
                settings.populationSize = (int)population_number.Value;
                settings.mutationRate = (float)mutation_number.Value;
                settings.individualMutationRate = (float)individual_mutation_number.Value;
                settings.crossoverRate = (float)crossover_number.Value;

                settings.mapWidth = (int)mapwidth_number.Value;
                settings.mapHeight = (int)mapheight_number.Value;

                settings.tile_selection = tile_selection.Checked;
                settings.expanded_mutation = expanded_mutation.Checked;
                settings.blend_crossover = blend_check.Checked;
                settings.refined_clumping = refined_clumping_check.Checked;

                settings.ratio_weight = (float)ratio_number.Value;
                settings.tilePercentages = new float[Program.NumberOfTerrainTypes];
                settings.tilePercentages[(int)TerrainType.Grass] = (float)grass_track.Value / 100f;
                settings.tilePercentages[(int)TerrainType.Water] = (float)water_track.Value / 100f;
                settings.tilePercentages[(int)TerrainType.Forest] = (float)forest_track.Value / 100f;
                settings.tilePercentages[(int)TerrainType.Mountain] = (float)mountain_track.Value / 100f;
                settings.tilePercentages[(int)TerrainType.Sand] = (float)sand_track.Value / 100f;
                settings.tilePercentages[(int)TerrainType.Ice] = (float)ice_track.Value / 100f;

                settings.clumping_weight = (float)clumping_number.Value;

                start_button.Text = "STOP";

                Program.StartGA( settings );
            } else {
                start_button.Text = "START";

                Program.StopGA();
            }
        }

        private void grass_track_Scroll( object sender, EventArgs e )
        {
            SetRatioTexts();
        }
        private void water_track_Scroll( object sender, EventArgs e )
        {
            SetRatioTexts();
        }
        private void ice_track_Scroll( object sender, EventArgs e )
        {
            SetRatioTexts();
        }
        private void forest_track_Scroll( object sender, EventArgs e )
        {
            SetRatioTexts();
        }
        private void mountain_track_Scroll( object sender, EventArgs e )
        {
            SetRatioTexts();
        }
        private void sand_track_Scroll( object sender, EventArgs e )
        {
            SetRatioTexts();
        }

        private void sand_number_ValueChanged( object sender, EventArgs e )
        {
            sand_track.Value = (int)sand_number.Value;
        }
        private void grass_number_ValueChanged( object sender, EventArgs e )
        {
            grass_track.Value = (int)grass_number.Value;
        }
        private void ice_number_ValueChanged( object sender, EventArgs e )
        {
            ice_track.Value = (int)ice_number.Value;
        }
        private void mountain_number_ValueChanged( object sender, EventArgs e )
        {
            mountain_track.Value = (int)mountain_number.Value;
        }
        private void forest_number_ValueChanged( object sender, EventArgs e )
        {
            forest_track.Value = (int)forest_number.Value;
        }
        private void water_number_ValueChanged( object sender, EventArgs e )
        {
            water_track.Value = (int)water_number.Value;
        }
    }
}
