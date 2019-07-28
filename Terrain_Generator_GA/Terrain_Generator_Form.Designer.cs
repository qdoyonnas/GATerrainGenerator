using System;
using System.Drawing;

namespace Terrain_Generator_GA
{
    partial class Terrain_generator_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.map1_picturebox = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            this.ratios_label = new System.Windows.Forms.Label();
            this.grass_label = new System.Windows.Forms.Label();
            this.grass_track = new System.Windows.Forms.TrackBar();
            this.water_track = new System.Windows.Forms.TrackBar();
            this.water_label = new System.Windows.Forms.Label();
            this.mountain_track = new System.Windows.Forms.TrackBar();
            this.mountain_label = new System.Windows.Forms.Label();
            this.sand_track = new System.Windows.Forms.TrackBar();
            this.sand_label = new System.Windows.Forms.Label();
            this.forest_track = new System.Windows.Forms.TrackBar();
            this.forest_label = new System.Windows.Forms.Label();
            this.ice_track = new System.Windows.Forms.TrackBar();
            this.ice_label = new System.Windows.Forms.Label();
            this.ga_label = new System.Windows.Forms.Label();
            this.population_label = new System.Windows.Forms.Label();
            this.population_number = new System.Windows.Forms.NumericUpDown();
            this.mapwidth_number = new System.Windows.Forms.NumericUpDown();
            this.mapwidth_label = new System.Windows.Forms.Label();
            this.mapheight_number = new System.Windows.Forms.NumericUpDown();
            this.mapheight_label = new System.Windows.Forms.Label();
            this.map_tabcontrol = new System.Windows.Forms.TabControl();
            this.map1_tab = new System.Windows.Forms.TabPage();
            this.map1_ice_text = new System.Windows.Forms.Label();
            this.map1_ice_label = new System.Windows.Forms.Label();
            this.map1_sand_text = new System.Windows.Forms.Label();
            this.map1_sand_label = new System.Windows.Forms.Label();
            this.map1_mountain_text = new System.Windows.Forms.Label();
            this.map1_mountain_label = new System.Windows.Forms.Label();
            this.map1_forest_text = new System.Windows.Forms.Label();
            this.map1_forest_label = new System.Windows.Forms.Label();
            this.map1_land_text = new System.Windows.Forms.Label();
            this.map1_land_label = new System.Windows.Forms.Label();
            this.map1_water_text = new System.Windows.Forms.Label();
            this.map1_water_label = new System.Windows.Forms.Label();
            this.map1_fitness_text = new System.Windows.Forms.Label();
            this.map1_fitness_label = new System.Windows.Forms.Label();
            this.map2_tab = new System.Windows.Forms.TabPage();
            this.map2_ice_text = new System.Windows.Forms.Label();
            this.map2_ice_label = new System.Windows.Forms.Label();
            this.map2_sand_text = new System.Windows.Forms.Label();
            this.map2_sand_label = new System.Windows.Forms.Label();
            this.map2_mountain_text = new System.Windows.Forms.Label();
            this.map2_mountain_label = new System.Windows.Forms.Label();
            this.map2_forest_text = new System.Windows.Forms.Label();
            this.map2_forest_label = new System.Windows.Forms.Label();
            this.map2_land_text = new System.Windows.Forms.Label();
            this.map2_land_label = new System.Windows.Forms.Label();
            this.map2_water_text = new System.Windows.Forms.Label();
            this.map2_water_label = new System.Windows.Forms.Label();
            this.map2_fitness_text = new System.Windows.Forms.Label();
            this.map2_fitness_label = new System.Windows.Forms.Label();
            this.map2_picturebox = new System.Windows.Forms.PictureBox();
            this.map3_tab = new System.Windows.Forms.TabPage();
            this.map3_ice_text = new System.Windows.Forms.Label();
            this.map3_ice_label = new System.Windows.Forms.Label();
            this.map3_sand_text = new System.Windows.Forms.Label();
            this.map3_sand_label = new System.Windows.Forms.Label();
            this.map3_mountain_text = new System.Windows.Forms.Label();
            this.map3_mountain_label = new System.Windows.Forms.Label();
            this.map3_forest_text = new System.Windows.Forms.Label();
            this.map3_forest_label = new System.Windows.Forms.Label();
            this.map3_land_text = new System.Windows.Forms.Label();
            this.map3_land_label = new System.Windows.Forms.Label();
            this.map3_water_text = new System.Windows.Forms.Label();
            this.map3_water_label = new System.Windows.Forms.Label();
            this.map3_fitness_text = new System.Windows.Forms.Label();
            this.map3_fitness_label = new System.Windows.Forms.Label();
            this.map3_picturebox = new System.Windows.Forms.PictureBox();
            this.map4_tab = new System.Windows.Forms.TabPage();
            this.map4_picturebox = new System.Windows.Forms.PictureBox();
            this.map5_tab = new System.Windows.Forms.TabPage();
            this.map5_picturebox = new System.Windows.Forms.PictureBox();
            this.grass_number = new System.Windows.Forms.NumericUpDown();
            this.water_number = new System.Windows.Forms.NumericUpDown();
            this.forest_number = new System.Windows.Forms.NumericUpDown();
            this.mountain_number = new System.Windows.Forms.NumericUpDown();
            this.sand_number = new System.Windows.Forms.NumericUpDown();
            this.ice_number = new System.Windows.Forms.NumericUpDown();
            this.fitness_label = new System.Windows.Forms.Label();
            this.generation_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.time_text = new System.Windows.Forms.Label();
            this.generation_text = new System.Windows.Forms.Label();
            this.fitness_text = new System.Windows.Forms.Label();
            this.mutation_number = new System.Windows.Forms.NumericUpDown();
            this.mutation_label = new System.Windows.Forms.Label();
            this.crossover_number = new System.Windows.Forms.NumericUpDown();
            this.crossover_label = new System.Windows.Forms.Label();
            this.settings_tabcontrol = new System.Windows.Forms.TabControl();
            this.algorithm_tab = new System.Windows.Forms.TabPage();
            this.refined_clumping_check = new System.Windows.Forms.CheckBox();
            this.individual_mutation_number = new System.Windows.Forms.NumericUpDown();
            this.individual_mutation_label = new System.Windows.Forms.Label();
            this.blend_check = new System.Windows.Forms.CheckBox();
            this.expanded_mutation = new System.Windows.Forms.CheckBox();
            this.tile_selection = new System.Windows.Forms.CheckBox();
            this.gen_rules_label = new System.Windows.Forms.Label();
            this.ratio_tab = new System.Windows.Forms.TabPage();
            this.ratio_number = new System.Windows.Forms.NumericUpDown();
            this.ratioweight_label = new System.Windows.Forms.Label();
            this.clumping_number = new System.Windows.Forms.NumericUpDown();
            this.formation_label = new System.Windows.Forms.Label();
            this.clumping_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.map1_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountain_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sand_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forest_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ice_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.population_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapwidth_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapheight_number)).BeginInit();
            this.map_tabcontrol.SuspendLayout();
            this.map1_tab.SuspendLayout();
            this.map2_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map2_picturebox)).BeginInit();
            this.map3_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map3_picturebox)).BeginInit();
            this.map4_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map4_picturebox)).BeginInit();
            this.map5_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map5_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forest_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountain_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sand_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ice_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutation_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossover_number)).BeginInit();
            this.settings_tabcontrol.SuspendLayout();
            this.algorithm_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individual_mutation_number)).BeginInit();
            this.ratio_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratio_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clumping_number)).BeginInit();
            this.SuspendLayout();
            // 
            // map1_picturebox
            // 
            this.map1_picturebox.Location = new System.Drawing.Point(0, 0);
            this.map1_picturebox.Name = "map1_picturebox";
            this.map1_picturebox.Size = new System.Drawing.Size(600, 600);
            this.map1_picturebox.TabIndex = 0;
            this.map1_picturebox.TabStop = false;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(628, 577);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(152, 57);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // ratios_label
            // 
            this.ratios_label.AutoSize = true;
            this.ratios_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratios_label.Location = new System.Drawing.Point(6, 3);
            this.ratios_label.Name = "ratios_label";
            this.ratios_label.Size = new System.Drawing.Size(61, 24);
            this.ratios_label.TabIndex = 2;
            this.ratios_label.Text = "Ratios";
            // 
            // grass_label
            // 
            this.grass_label.AutoSize = true;
            this.grass_label.Location = new System.Drawing.Point(7, 56);
            this.grass_label.Name = "grass_label";
            this.grass_label.Size = new System.Drawing.Size(34, 13);
            this.grass_label.TabIndex = 4;
            this.grass_label.Text = "Grass";
            // 
            // grass_track
            // 
            this.grass_track.AutoSize = false;
            this.grass_track.LargeChange = 10;
            this.grass_track.Location = new System.Drawing.Point(58, 56);
            this.grass_track.Maximum = 100;
            this.grass_track.Name = "grass_track";
            this.grass_track.Size = new System.Drawing.Size(242, 20);
            this.grass_track.TabIndex = 5;
            this.grass_track.TickFrequency = 10;
            this.grass_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.grass_track.Value = 20;
            this.grass_track.Scroll += new System.EventHandler(this.grass_track_Scroll);
            // 
            // water_track
            // 
            this.water_track.AutoSize = false;
            this.water_track.LargeChange = 10;
            this.water_track.Location = new System.Drawing.Point(58, 82);
            this.water_track.Maximum = 100;
            this.water_track.Name = "water_track";
            this.water_track.Size = new System.Drawing.Size(242, 20);
            this.water_track.TabIndex = 8;
            this.water_track.TickFrequency = 10;
            this.water_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.water_track.Value = 60;
            this.water_track.Scroll += new System.EventHandler(this.water_track_Scroll);
            // 
            // water_label
            // 
            this.water_label.AutoSize = true;
            this.water_label.Location = new System.Drawing.Point(7, 82);
            this.water_label.Name = "water_label";
            this.water_label.Size = new System.Drawing.Size(36, 13);
            this.water_label.TabIndex = 7;
            this.water_label.Text = "Water";
            // 
            // mountain_track
            // 
            this.mountain_track.AutoSize = false;
            this.mountain_track.LargeChange = 10;
            this.mountain_track.Location = new System.Drawing.Point(58, 131);
            this.mountain_track.Maximum = 100;
            this.mountain_track.Name = "mountain_track";
            this.mountain_track.Size = new System.Drawing.Size(242, 20);
            this.mountain_track.TabIndex = 11;
            this.mountain_track.TickFrequency = 10;
            this.mountain_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mountain_track.Value = 10;
            this.mountain_track.Scroll += new System.EventHandler(this.mountain_track_Scroll);
            // 
            // mountain_label
            // 
            this.mountain_label.AutoSize = true;
            this.mountain_label.Location = new System.Drawing.Point(7, 131);
            this.mountain_label.Name = "mountain_label";
            this.mountain_label.Size = new System.Drawing.Size(51, 13);
            this.mountain_label.TabIndex = 10;
            this.mountain_label.Text = "Mountain";
            // 
            // sand_track
            // 
            this.sand_track.AutoSize = false;
            this.sand_track.LargeChange = 10;
            this.sand_track.Location = new System.Drawing.Point(58, 157);
            this.sand_track.Maximum = 100;
            this.sand_track.Name = "sand_track";
            this.sand_track.Size = new System.Drawing.Size(242, 20);
            this.sand_track.TabIndex = 14;
            this.sand_track.TickFrequency = 10;
            this.sand_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sand_track.Value = 1;
            this.sand_track.Scroll += new System.EventHandler(this.sand_track_Scroll);
            // 
            // sand_label
            // 
            this.sand_label.AutoSize = true;
            this.sand_label.Location = new System.Drawing.Point(7, 157);
            this.sand_label.Name = "sand_label";
            this.sand_label.Size = new System.Drawing.Size(32, 13);
            this.sand_label.TabIndex = 13;
            this.sand_label.Text = "Sand";
            // 
            // forest_track
            // 
            this.forest_track.AutoSize = false;
            this.forest_track.LargeChange = 10;
            this.forest_track.Location = new System.Drawing.Point(58, 108);
            this.forest_track.Maximum = 100;
            this.forest_track.Name = "forest_track";
            this.forest_track.Size = new System.Drawing.Size(242, 20);
            this.forest_track.TabIndex = 17;
            this.forest_track.TickFrequency = 10;
            this.forest_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.forest_track.Value = 10;
            this.forest_track.Scroll += new System.EventHandler(this.forest_track_Scroll);
            // 
            // forest_label
            // 
            this.forest_label.AutoSize = true;
            this.forest_label.Location = new System.Drawing.Point(7, 108);
            this.forest_label.Name = "forest_label";
            this.forest_label.Size = new System.Drawing.Size(36, 13);
            this.forest_label.TabIndex = 16;
            this.forest_label.Text = "Forest";
            // 
            // ice_track
            // 
            this.ice_track.AutoSize = false;
            this.ice_track.LargeChange = 10;
            this.ice_track.Location = new System.Drawing.Point(58, 183);
            this.ice_track.Maximum = 100;
            this.ice_track.Name = "ice_track";
            this.ice_track.Size = new System.Drawing.Size(242, 20);
            this.ice_track.TabIndex = 20;
            this.ice_track.TickFrequency = 10;
            this.ice_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ice_track.Value = 1;
            this.ice_track.Scroll += new System.EventHandler(this.ice_track_Scroll);
            // 
            // ice_label
            // 
            this.ice_label.AutoSize = true;
            this.ice_label.Location = new System.Drawing.Point(7, 183);
            this.ice_label.Name = "ice_label";
            this.ice_label.Size = new System.Drawing.Size(22, 13);
            this.ice_label.TabIndex = 19;
            this.ice_label.Text = "Ice";
            // 
            // ga_label
            // 
            this.ga_label.AutoSize = true;
            this.ga_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ga_label.Location = new System.Drawing.Point(6, 3);
            this.ga_label.Name = "ga_label";
            this.ga_label.Size = new System.Drawing.Size(160, 24);
            this.ga_label.TabIndex = 22;
            this.ga_label.Text = "Genetic Algorithm";
            // 
            // population_label
            // 
            this.population_label.AutoSize = true;
            this.population_label.Location = new System.Drawing.Point(7, 34);
            this.population_label.Name = "population_label";
            this.population_label.Size = new System.Drawing.Size(57, 13);
            this.population_label.TabIndex = 23;
            this.population_label.Text = "Population";
            // 
            // population_number
            // 
            this.population_number.Location = new System.Drawing.Point(93, 32);
            this.population_number.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.population_number.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.population_number.Name = "population_number";
            this.population_number.Size = new System.Drawing.Size(70, 20);
            this.population_number.TabIndex = 24;
            this.population_number.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // mapwidth_number
            // 
            this.mapwidth_number.Location = new System.Drawing.Point(247, 32);
            this.mapwidth_number.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.mapwidth_number.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.mapwidth_number.Name = "mapwidth_number";
            this.mapwidth_number.Size = new System.Drawing.Size(67, 20);
            this.mapwidth_number.TabIndex = 26;
            this.mapwidth_number.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // mapwidth_label
            // 
            this.mapwidth_label.AutoSize = true;
            this.mapwidth_label.Location = new System.Drawing.Point(183, 32);
            this.mapwidth_label.Name = "mapwidth_label";
            this.mapwidth_label.Size = new System.Drawing.Size(59, 13);
            this.mapwidth_label.TabIndex = 25;
            this.mapwidth_label.Text = "Map Width";
            // 
            // mapheight_number
            // 
            this.mapheight_number.Location = new System.Drawing.Point(247, 58);
            this.mapheight_number.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.mapheight_number.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.mapheight_number.Name = "mapheight_number";
            this.mapheight_number.Size = new System.Drawing.Size(67, 20);
            this.mapheight_number.TabIndex = 28;
            this.mapheight_number.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // mapheight_label
            // 
            this.mapheight_label.AutoSize = true;
            this.mapheight_label.Location = new System.Drawing.Point(183, 58);
            this.mapheight_label.Name = "mapheight_label";
            this.mapheight_label.Size = new System.Drawing.Size(62, 13);
            this.mapheight_label.TabIndex = 27;
            this.mapheight_label.Text = "Map Height";
            // 
            // map_tabcontrol
            // 
            this.map_tabcontrol.Controls.Add(this.map1_tab);
            this.map_tabcontrol.Controls.Add(this.map2_tab);
            this.map_tabcontrol.Controls.Add(this.map3_tab);
            this.map_tabcontrol.Controls.Add(this.map4_tab);
            this.map_tabcontrol.Controls.Add(this.map5_tab);
            this.map_tabcontrol.Location = new System.Drawing.Point(10, 12);
            this.map_tabcontrol.Name = "map_tabcontrol";
            this.map_tabcontrol.SelectedIndex = 0;
            this.map_tabcontrol.Size = new System.Drawing.Size(608, 627);
            this.map_tabcontrol.TabIndex = 29;
            // 
            // map1_tab
            // 
            this.map1_tab.Controls.Add(this.map1_ice_text);
            this.map1_tab.Controls.Add(this.map1_ice_label);
            this.map1_tab.Controls.Add(this.map1_sand_text);
            this.map1_tab.Controls.Add(this.map1_sand_label);
            this.map1_tab.Controls.Add(this.map1_mountain_text);
            this.map1_tab.Controls.Add(this.map1_mountain_label);
            this.map1_tab.Controls.Add(this.map1_forest_text);
            this.map1_tab.Controls.Add(this.map1_forest_label);
            this.map1_tab.Controls.Add(this.map1_land_text);
            this.map1_tab.Controls.Add(this.map1_land_label);
            this.map1_tab.Controls.Add(this.map1_water_text);
            this.map1_tab.Controls.Add(this.map1_water_label);
            this.map1_tab.Controls.Add(this.map1_fitness_text);
            this.map1_tab.Controls.Add(this.map1_fitness_label);
            this.map1_tab.Controls.Add(this.map1_picturebox);
            this.map1_tab.Location = new System.Drawing.Point(4, 22);
            this.map1_tab.Name = "map1_tab";
            this.map1_tab.Padding = new System.Windows.Forms.Padding(3);
            this.map1_tab.Size = new System.Drawing.Size(600, 601);
            this.map1_tab.TabIndex = 0;
            this.map1_tab.Text = "Map 1";
            this.map1_tab.UseVisualStyleBackColor = true;
            // 
            // map1_ice_text
            // 
            this.map1_ice_text.AutoSize = true;
            this.map1_ice_text.Location = new System.Drawing.Point(352, 585);
            this.map1_ice_text.Name = "map1_ice_text";
            this.map1_ice_text.Size = new System.Drawing.Size(13, 13);
            this.map1_ice_text.TabIndex = 14;
            this.map1_ice_text.Text = "0";
            // 
            // map1_ice_label
            // 
            this.map1_ice_label.AutoSize = true;
            this.map1_ice_label.Location = new System.Drawing.Point(323, 585);
            this.map1_ice_label.Name = "map1_ice_label";
            this.map1_ice_label.Size = new System.Drawing.Size(33, 13);
            this.map1_ice_label.TabIndex = 13;
            this.map1_ice_label.Text = "Ice %";
            // 
            // map1_sand_text
            // 
            this.map1_sand_text.AutoSize = true;
            this.map1_sand_text.Location = new System.Drawing.Point(306, 585);
            this.map1_sand_text.Name = "map1_sand_text";
            this.map1_sand_text.Size = new System.Drawing.Size(13, 13);
            this.map1_sand_text.TabIndex = 12;
            this.map1_sand_text.Text = "0";
            // 
            // map1_sand_label
            // 
            this.map1_sand_label.AutoSize = true;
            this.map1_sand_label.Location = new System.Drawing.Point(267, 585);
            this.map1_sand_label.Name = "map1_sand_label";
            this.map1_sand_label.Size = new System.Drawing.Size(43, 13);
            this.map1_sand_label.TabIndex = 11;
            this.map1_sand_label.Text = "Sand %";
            // 
            // map1_mountain_text
            // 
            this.map1_mountain_text.AutoSize = true;
            this.map1_mountain_text.Location = new System.Drawing.Point(248, 585);
            this.map1_mountain_text.Name = "map1_mountain_text";
            this.map1_mountain_text.Size = new System.Drawing.Size(13, 13);
            this.map1_mountain_text.TabIndex = 10;
            this.map1_mountain_text.Text = "0";
            // 
            // map1_mountain_label
            // 
            this.map1_mountain_label.AutoSize = true;
            this.map1_mountain_label.Location = new System.Drawing.Point(190, 585);
            this.map1_mountain_label.Name = "map1_mountain_label";
            this.map1_mountain_label.Size = new System.Drawing.Size(62, 13);
            this.map1_mountain_label.TabIndex = 9;
            this.map1_mountain_label.Text = "Mountain %";
            // 
            // map1_forest_text
            // 
            this.map1_forest_text.AutoSize = true;
            this.map1_forest_text.Location = new System.Drawing.Point(168, 585);
            this.map1_forest_text.Name = "map1_forest_text";
            this.map1_forest_text.Size = new System.Drawing.Size(13, 13);
            this.map1_forest_text.TabIndex = 8;
            this.map1_forest_text.Text = "0";
            // 
            // map1_forest_label
            // 
            this.map1_forest_label.AutoSize = true;
            this.map1_forest_label.Location = new System.Drawing.Point(125, 585);
            this.map1_forest_label.Name = "map1_forest_label";
            this.map1_forest_label.Size = new System.Drawing.Size(47, 13);
            this.map1_forest_label.TabIndex = 7;
            this.map1_forest_label.Text = "Forest %";
            // 
            // map1_land_text
            // 
            this.map1_land_text.AutoSize = true;
            this.map1_land_text.Location = new System.Drawing.Point(110, 585);
            this.map1_land_text.Name = "map1_land_text";
            this.map1_land_text.Size = new System.Drawing.Size(13, 13);
            this.map1_land_text.TabIndex = 6;
            this.map1_land_text.Text = "0";
            // 
            // map1_land_label
            // 
            this.map1_land_label.AutoSize = true;
            this.map1_land_label.Location = new System.Drawing.Point(69, 585);
            this.map1_land_label.Name = "map1_land_label";
            this.map1_land_label.Size = new System.Drawing.Size(45, 13);
            this.map1_land_label.TabIndex = 5;
            this.map1_land_label.Text = "Grass %";
            // 
            // map1_water_text
            // 
            this.map1_water_text.AutoSize = true;
            this.map1_water_text.Location = new System.Drawing.Point(50, 585);
            this.map1_water_text.Name = "map1_water_text";
            this.map1_water_text.Size = new System.Drawing.Size(13, 13);
            this.map1_water_text.TabIndex = 4;
            this.map1_water_text.Text = "0";
            // 
            // map1_water_label
            // 
            this.map1_water_label.AutoSize = true;
            this.map1_water_label.Location = new System.Drawing.Point(7, 585);
            this.map1_water_label.Name = "map1_water_label";
            this.map1_water_label.Size = new System.Drawing.Size(47, 13);
            this.map1_water_label.TabIndex = 3;
            this.map1_water_label.Text = "Water %";
            // 
            // map1_fitness_text
            // 
            this.map1_fitness_text.AutoSize = true;
            this.map1_fitness_text.Location = new System.Drawing.Point(45, 565);
            this.map1_fitness_text.Name = "map1_fitness_text";
            this.map1_fitness_text.Size = new System.Drawing.Size(13, 13);
            this.map1_fitness_text.TabIndex = 2;
            this.map1_fitness_text.Text = "0";
            // 
            // map1_fitness_label
            // 
            this.map1_fitness_label.AutoSize = true;
            this.map1_fitness_label.Location = new System.Drawing.Point(7, 565);
            this.map1_fitness_label.Name = "map1_fitness_label";
            this.map1_fitness_label.Size = new System.Drawing.Size(43, 13);
            this.map1_fitness_label.TabIndex = 1;
            this.map1_fitness_label.Text = "Fitness:";
            // 
            // map2_tab
            // 
            this.map2_tab.Controls.Add(this.map2_ice_text);
            this.map2_tab.Controls.Add(this.map2_ice_label);
            this.map2_tab.Controls.Add(this.map2_sand_text);
            this.map2_tab.Controls.Add(this.map2_sand_label);
            this.map2_tab.Controls.Add(this.map2_mountain_text);
            this.map2_tab.Controls.Add(this.map2_mountain_label);
            this.map2_tab.Controls.Add(this.map2_forest_text);
            this.map2_tab.Controls.Add(this.map2_forest_label);
            this.map2_tab.Controls.Add(this.map2_land_text);
            this.map2_tab.Controls.Add(this.map2_land_label);
            this.map2_tab.Controls.Add(this.map2_water_text);
            this.map2_tab.Controls.Add(this.map2_water_label);
            this.map2_tab.Controls.Add(this.map2_fitness_text);
            this.map2_tab.Controls.Add(this.map2_fitness_label);
            this.map2_tab.Controls.Add(this.map2_picturebox);
            this.map2_tab.Location = new System.Drawing.Point(4, 22);
            this.map2_tab.Name = "map2_tab";
            this.map2_tab.Padding = new System.Windows.Forms.Padding(3);
            this.map2_tab.Size = new System.Drawing.Size(600, 601);
            this.map2_tab.TabIndex = 1;
            this.map2_tab.Text = "Map 2";
            this.map2_tab.UseVisualStyleBackColor = true;
            // 
            // map2_ice_text
            // 
            this.map2_ice_text.AutoSize = true;
            this.map2_ice_text.Location = new System.Drawing.Point(352, 585);
            this.map2_ice_text.Name = "map2_ice_text";
            this.map2_ice_text.Size = new System.Drawing.Size(13, 13);
            this.map2_ice_text.TabIndex = 28;
            this.map2_ice_text.Text = "0";
            // 
            // map2_ice_label
            // 
            this.map2_ice_label.AutoSize = true;
            this.map2_ice_label.Location = new System.Drawing.Point(323, 585);
            this.map2_ice_label.Name = "map2_ice_label";
            this.map2_ice_label.Size = new System.Drawing.Size(33, 13);
            this.map2_ice_label.TabIndex = 27;
            this.map2_ice_label.Text = "Ice %";
            // 
            // map2_sand_text
            // 
            this.map2_sand_text.AutoSize = true;
            this.map2_sand_text.Location = new System.Drawing.Point(306, 585);
            this.map2_sand_text.Name = "map2_sand_text";
            this.map2_sand_text.Size = new System.Drawing.Size(13, 13);
            this.map2_sand_text.TabIndex = 26;
            this.map2_sand_text.Text = "0";
            // 
            // map2_sand_label
            // 
            this.map2_sand_label.AutoSize = true;
            this.map2_sand_label.Location = new System.Drawing.Point(267, 585);
            this.map2_sand_label.Name = "map2_sand_label";
            this.map2_sand_label.Size = new System.Drawing.Size(43, 13);
            this.map2_sand_label.TabIndex = 25;
            this.map2_sand_label.Text = "Sand %";
            // 
            // map2_mountain_text
            // 
            this.map2_mountain_text.AutoSize = true;
            this.map2_mountain_text.Location = new System.Drawing.Point(248, 585);
            this.map2_mountain_text.Name = "map2_mountain_text";
            this.map2_mountain_text.Size = new System.Drawing.Size(13, 13);
            this.map2_mountain_text.TabIndex = 24;
            this.map2_mountain_text.Text = "0";
            // 
            // map2_mountain_label
            // 
            this.map2_mountain_label.AutoSize = true;
            this.map2_mountain_label.Location = new System.Drawing.Point(190, 585);
            this.map2_mountain_label.Name = "map2_mountain_label";
            this.map2_mountain_label.Size = new System.Drawing.Size(62, 13);
            this.map2_mountain_label.TabIndex = 23;
            this.map2_mountain_label.Text = "Mountain %";
            // 
            // map2_forest_text
            // 
            this.map2_forest_text.AutoSize = true;
            this.map2_forest_text.Location = new System.Drawing.Point(168, 585);
            this.map2_forest_text.Name = "map2_forest_text";
            this.map2_forest_text.Size = new System.Drawing.Size(13, 13);
            this.map2_forest_text.TabIndex = 22;
            this.map2_forest_text.Text = "0";
            // 
            // map2_forest_label
            // 
            this.map2_forest_label.AutoSize = true;
            this.map2_forest_label.Location = new System.Drawing.Point(125, 585);
            this.map2_forest_label.Name = "map2_forest_label";
            this.map2_forest_label.Size = new System.Drawing.Size(47, 13);
            this.map2_forest_label.TabIndex = 21;
            this.map2_forest_label.Text = "Forest %";
            // 
            // map2_land_text
            // 
            this.map2_land_text.AutoSize = true;
            this.map2_land_text.Location = new System.Drawing.Point(110, 585);
            this.map2_land_text.Name = "map2_land_text";
            this.map2_land_text.Size = new System.Drawing.Size(13, 13);
            this.map2_land_text.TabIndex = 20;
            this.map2_land_text.Text = "0";
            // 
            // map2_land_label
            // 
            this.map2_land_label.AutoSize = true;
            this.map2_land_label.Location = new System.Drawing.Point(69, 585);
            this.map2_land_label.Name = "map2_land_label";
            this.map2_land_label.Size = new System.Drawing.Size(45, 13);
            this.map2_land_label.TabIndex = 19;
            this.map2_land_label.Text = "Grass %";
            // 
            // map2_water_text
            // 
            this.map2_water_text.AutoSize = true;
            this.map2_water_text.Location = new System.Drawing.Point(50, 585);
            this.map2_water_text.Name = "map2_water_text";
            this.map2_water_text.Size = new System.Drawing.Size(13, 13);
            this.map2_water_text.TabIndex = 18;
            this.map2_water_text.Text = "0";
            // 
            // map2_water_label
            // 
            this.map2_water_label.AutoSize = true;
            this.map2_water_label.Location = new System.Drawing.Point(7, 585);
            this.map2_water_label.Name = "map2_water_label";
            this.map2_water_label.Size = new System.Drawing.Size(47, 13);
            this.map2_water_label.TabIndex = 17;
            this.map2_water_label.Text = "Water %";
            // 
            // map2_fitness_text
            // 
            this.map2_fitness_text.AutoSize = true;
            this.map2_fitness_text.Location = new System.Drawing.Point(44, 565);
            this.map2_fitness_text.Name = "map2_fitness_text";
            this.map2_fitness_text.Size = new System.Drawing.Size(13, 13);
            this.map2_fitness_text.TabIndex = 16;
            this.map2_fitness_text.Text = "0";
            // 
            // map2_fitness_label
            // 
            this.map2_fitness_label.AutoSize = true;
            this.map2_fitness_label.Location = new System.Drawing.Point(6, 565);
            this.map2_fitness_label.Name = "map2_fitness_label";
            this.map2_fitness_label.Size = new System.Drawing.Size(43, 13);
            this.map2_fitness_label.TabIndex = 15;
            this.map2_fitness_label.Text = "Fitness:";
            // 
            // map2_picturebox
            // 
            this.map2_picturebox.Location = new System.Drawing.Point(0, 0);
            this.map2_picturebox.Name = "map2_picturebox";
            this.map2_picturebox.Size = new System.Drawing.Size(600, 600);
            this.map2_picturebox.TabIndex = 1;
            this.map2_picturebox.TabStop = false;
            // 
            // map3_tab
            // 
            this.map3_tab.Controls.Add(this.map3_ice_text);
            this.map3_tab.Controls.Add(this.map3_ice_label);
            this.map3_tab.Controls.Add(this.map3_sand_text);
            this.map3_tab.Controls.Add(this.map3_sand_label);
            this.map3_tab.Controls.Add(this.map3_mountain_text);
            this.map3_tab.Controls.Add(this.map3_mountain_label);
            this.map3_tab.Controls.Add(this.map3_forest_text);
            this.map3_tab.Controls.Add(this.map3_forest_label);
            this.map3_tab.Controls.Add(this.map3_land_text);
            this.map3_tab.Controls.Add(this.map3_land_label);
            this.map3_tab.Controls.Add(this.map3_water_text);
            this.map3_tab.Controls.Add(this.map3_water_label);
            this.map3_tab.Controls.Add(this.map3_fitness_text);
            this.map3_tab.Controls.Add(this.map3_fitness_label);
            this.map3_tab.Controls.Add(this.map3_picturebox);
            this.map3_tab.Location = new System.Drawing.Point(4, 22);
            this.map3_tab.Name = "map3_tab";
            this.map3_tab.Padding = new System.Windows.Forms.Padding(3);
            this.map3_tab.Size = new System.Drawing.Size(600, 601);
            this.map3_tab.TabIndex = 2;
            this.map3_tab.Text = "Map 3";
            this.map3_tab.UseVisualStyleBackColor = true;
            // 
            // map3_ice_text
            // 
            this.map3_ice_text.AutoSize = true;
            this.map3_ice_text.Location = new System.Drawing.Point(351, 585);
            this.map3_ice_text.Name = "map3_ice_text";
            this.map3_ice_text.Size = new System.Drawing.Size(13, 13);
            this.map3_ice_text.TabIndex = 42;
            this.map3_ice_text.Text = "0";
            // 
            // map3_ice_label
            // 
            this.map3_ice_label.AutoSize = true;
            this.map3_ice_label.Location = new System.Drawing.Point(322, 585);
            this.map3_ice_label.Name = "map3_ice_label";
            this.map3_ice_label.Size = new System.Drawing.Size(33, 13);
            this.map3_ice_label.TabIndex = 41;
            this.map3_ice_label.Text = "Ice %";
            // 
            // map3_sand_text
            // 
            this.map3_sand_text.AutoSize = true;
            this.map3_sand_text.Location = new System.Drawing.Point(305, 585);
            this.map3_sand_text.Name = "map3_sand_text";
            this.map3_sand_text.Size = new System.Drawing.Size(13, 13);
            this.map3_sand_text.TabIndex = 40;
            this.map3_sand_text.Text = "0";
            // 
            // map3_sand_label
            // 
            this.map3_sand_label.AutoSize = true;
            this.map3_sand_label.Location = new System.Drawing.Point(266, 585);
            this.map3_sand_label.Name = "map3_sand_label";
            this.map3_sand_label.Size = new System.Drawing.Size(43, 13);
            this.map3_sand_label.TabIndex = 39;
            this.map3_sand_label.Text = "Sand %";
            // 
            // map3_mountain_text
            // 
            this.map3_mountain_text.AutoSize = true;
            this.map3_mountain_text.Location = new System.Drawing.Point(247, 585);
            this.map3_mountain_text.Name = "map3_mountain_text";
            this.map3_mountain_text.Size = new System.Drawing.Size(13, 13);
            this.map3_mountain_text.TabIndex = 38;
            this.map3_mountain_text.Text = "0";
            // 
            // map3_mountain_label
            // 
            this.map3_mountain_label.AutoSize = true;
            this.map3_mountain_label.Location = new System.Drawing.Point(189, 585);
            this.map3_mountain_label.Name = "map3_mountain_label";
            this.map3_mountain_label.Size = new System.Drawing.Size(62, 13);
            this.map3_mountain_label.TabIndex = 37;
            this.map3_mountain_label.Text = "Mountain %";
            // 
            // map3_forest_text
            // 
            this.map3_forest_text.AutoSize = true;
            this.map3_forest_text.Location = new System.Drawing.Point(167, 585);
            this.map3_forest_text.Name = "map3_forest_text";
            this.map3_forest_text.Size = new System.Drawing.Size(13, 13);
            this.map3_forest_text.TabIndex = 36;
            this.map3_forest_text.Text = "0";
            // 
            // map3_forest_label
            // 
            this.map3_forest_label.AutoSize = true;
            this.map3_forest_label.Location = new System.Drawing.Point(124, 585);
            this.map3_forest_label.Name = "map3_forest_label";
            this.map3_forest_label.Size = new System.Drawing.Size(47, 13);
            this.map3_forest_label.TabIndex = 35;
            this.map3_forest_label.Text = "Forest %";
            // 
            // map3_land_text
            // 
            this.map3_land_text.AutoSize = true;
            this.map3_land_text.Location = new System.Drawing.Point(109, 585);
            this.map3_land_text.Name = "map3_land_text";
            this.map3_land_text.Size = new System.Drawing.Size(13, 13);
            this.map3_land_text.TabIndex = 34;
            this.map3_land_text.Text = "0";
            // 
            // map3_land_label
            // 
            this.map3_land_label.AutoSize = true;
            this.map3_land_label.Location = new System.Drawing.Point(68, 585);
            this.map3_land_label.Name = "map3_land_label";
            this.map3_land_label.Size = new System.Drawing.Size(45, 13);
            this.map3_land_label.TabIndex = 33;
            this.map3_land_label.Text = "Grass %";
            // 
            // map3_water_text
            // 
            this.map3_water_text.AutoSize = true;
            this.map3_water_text.Location = new System.Drawing.Point(49, 585);
            this.map3_water_text.Name = "map3_water_text";
            this.map3_water_text.Size = new System.Drawing.Size(13, 13);
            this.map3_water_text.TabIndex = 32;
            this.map3_water_text.Text = "0";
            // 
            // map3_water_label
            // 
            this.map3_water_label.AutoSize = true;
            this.map3_water_label.Location = new System.Drawing.Point(6, 585);
            this.map3_water_label.Name = "map3_water_label";
            this.map3_water_label.Size = new System.Drawing.Size(47, 13);
            this.map3_water_label.TabIndex = 31;
            this.map3_water_label.Text = "Water %";
            // 
            // map3_fitness_text
            // 
            this.map3_fitness_text.AutoSize = true;
            this.map3_fitness_text.Location = new System.Drawing.Point(44, 565);
            this.map3_fitness_text.Name = "map3_fitness_text";
            this.map3_fitness_text.Size = new System.Drawing.Size(13, 13);
            this.map3_fitness_text.TabIndex = 30;
            this.map3_fitness_text.Text = "0";
            // 
            // map3_fitness_label
            // 
            this.map3_fitness_label.AutoSize = true;
            this.map3_fitness_label.Location = new System.Drawing.Point(6, 565);
            this.map3_fitness_label.Name = "map3_fitness_label";
            this.map3_fitness_label.Size = new System.Drawing.Size(43, 13);
            this.map3_fitness_label.TabIndex = 29;
            this.map3_fitness_label.Text = "Fitness:";
            // 
            // map3_picturebox
            // 
            this.map3_picturebox.Location = new System.Drawing.Point(0, 0);
            this.map3_picturebox.Name = "map3_picturebox";
            this.map3_picturebox.Size = new System.Drawing.Size(600, 600);
            this.map3_picturebox.TabIndex = 1;
            this.map3_picturebox.TabStop = false;
            // 
            // map4_tab
            // 
            this.map4_tab.Controls.Add(this.map4_picturebox);
            this.map4_tab.Location = new System.Drawing.Point(4, 22);
            this.map4_tab.Name = "map4_tab";
            this.map4_tab.Padding = new System.Windows.Forms.Padding(3);
            this.map4_tab.Size = new System.Drawing.Size(600, 601);
            this.map4_tab.TabIndex = 3;
            this.map4_tab.Text = "Map 4";
            this.map4_tab.UseVisualStyleBackColor = true;
            // 
            // map4_picturebox
            // 
            this.map4_picturebox.Location = new System.Drawing.Point(0, 0);
            this.map4_picturebox.Name = "map4_picturebox";
            this.map4_picturebox.Size = new System.Drawing.Size(600, 600);
            this.map4_picturebox.TabIndex = 1;
            this.map4_picturebox.TabStop = false;
            // 
            // map5_tab
            // 
            this.map5_tab.Controls.Add(this.map5_picturebox);
            this.map5_tab.Location = new System.Drawing.Point(4, 22);
            this.map5_tab.Name = "map5_tab";
            this.map5_tab.Padding = new System.Windows.Forms.Padding(3);
            this.map5_tab.Size = new System.Drawing.Size(600, 601);
            this.map5_tab.TabIndex = 4;
            this.map5_tab.Text = "Map 5";
            this.map5_tab.UseVisualStyleBackColor = true;
            // 
            // map5_picturebox
            // 
            this.map5_picturebox.Location = new System.Drawing.Point(0, 0);
            this.map5_picturebox.Name = "map5_picturebox";
            this.map5_picturebox.Size = new System.Drawing.Size(600, 600);
            this.map5_picturebox.TabIndex = 1;
            this.map5_picturebox.TabStop = false;
            // 
            // grass_number
            // 
            this.grass_number.Location = new System.Drawing.Point(307, 56);
            this.grass_number.Name = "grass_number";
            this.grass_number.Size = new System.Drawing.Size(42, 20);
            this.grass_number.TabIndex = 30;
            this.grass_number.ValueChanged += new System.EventHandler(this.grass_number_ValueChanged);
            // 
            // water_number
            // 
            this.water_number.Location = new System.Drawing.Point(307, 82);
            this.water_number.Name = "water_number";
            this.water_number.Size = new System.Drawing.Size(42, 20);
            this.water_number.TabIndex = 31;
            this.water_number.ValueChanged += new System.EventHandler(this.water_number_ValueChanged);
            // 
            // forest_number
            // 
            this.forest_number.Location = new System.Drawing.Point(306, 108);
            this.forest_number.Name = "forest_number";
            this.forest_number.Size = new System.Drawing.Size(42, 20);
            this.forest_number.TabIndex = 32;
            this.forest_number.ValueChanged += new System.EventHandler(this.forest_number_ValueChanged);
            // 
            // mountain_number
            // 
            this.mountain_number.Location = new System.Drawing.Point(306, 131);
            this.mountain_number.Name = "mountain_number";
            this.mountain_number.Size = new System.Drawing.Size(42, 20);
            this.mountain_number.TabIndex = 33;
            this.mountain_number.ValueChanged += new System.EventHandler(this.mountain_number_ValueChanged);
            // 
            // sand_number
            // 
            this.sand_number.Location = new System.Drawing.Point(306, 157);
            this.sand_number.Name = "sand_number";
            this.sand_number.Size = new System.Drawing.Size(42, 20);
            this.sand_number.TabIndex = 34;
            this.sand_number.ValueChanged += new System.EventHandler(this.sand_number_ValueChanged);
            // 
            // ice_number
            // 
            this.ice_number.Location = new System.Drawing.Point(306, 183);
            this.ice_number.Name = "ice_number";
            this.ice_number.Size = new System.Drawing.Size(42, 20);
            this.ice_number.TabIndex = 35;
            this.ice_number.ValueChanged += new System.EventHandler(this.ice_number_ValueChanged);
            // 
            // fitness_label
            // 
            this.fitness_label.AutoSize = true;
            this.fitness_label.Location = new System.Drawing.Point(787, 577);
            this.fitness_label.Name = "fitness_label";
            this.fitness_label.Size = new System.Drawing.Size(82, 13);
            this.fitness_label.TabIndex = 36;
            this.fitness_label.Text = "Highest Fitness:";
            // 
            // generation_label
            // 
            this.generation_label.AutoSize = true;
            this.generation_label.Location = new System.Drawing.Point(787, 599);
            this.generation_label.Name = "generation_label";
            this.generation_label.Size = new System.Drawing.Size(62, 13);
            this.generation_label.TabIndex = 37;
            this.generation_label.Text = "Generation:";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(787, 621);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(33, 13);
            this.time_label.TabIndex = 38;
            this.time_label.Text = "Time:";
            // 
            // time_text
            // 
            this.time_text.AutoSize = true;
            this.time_text.Location = new System.Drawing.Point(871, 621);
            this.time_text.Name = "time_text";
            this.time_text.Size = new System.Drawing.Size(13, 13);
            this.time_text.TabIndex = 41;
            this.time_text.Text = "0";
            // 
            // generation_text
            // 
            this.generation_text.AutoSize = true;
            this.generation_text.Location = new System.Drawing.Point(871, 599);
            this.generation_text.Name = "generation_text";
            this.generation_text.Size = new System.Drawing.Size(13, 13);
            this.generation_text.TabIndex = 40;
            this.generation_text.Text = "0";
            // 
            // fitness_text
            // 
            this.fitness_text.AutoSize = true;
            this.fitness_text.Location = new System.Drawing.Point(871, 577);
            this.fitness_text.Name = "fitness_text";
            this.fitness_text.Size = new System.Drawing.Size(13, 13);
            this.fitness_text.TabIndex = 39;
            this.fitness_text.Text = "0";
            // 
            // mutation_number
            // 
            this.mutation_number.DecimalPlaces = 4;
            this.mutation_number.Location = new System.Drawing.Point(93, 58);
            this.mutation_number.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutation_number.Name = "mutation_number";
            this.mutation_number.Size = new System.Drawing.Size(70, 20);
            this.mutation_number.TabIndex = 43;
            this.mutation_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // mutation_label
            // 
            this.mutation_label.AutoSize = true;
            this.mutation_label.Location = new System.Drawing.Point(7, 60);
            this.mutation_label.Name = "mutation_label";
            this.mutation_label.Size = new System.Drawing.Size(66, 13);
            this.mutation_label.TabIndex = 42;
            this.mutation_label.Text = "Mutate Rate";
            // 
            // crossover_number
            // 
            this.crossover_number.DecimalPlaces = 4;
            this.crossover_number.Location = new System.Drawing.Point(271, 84);
            this.crossover_number.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crossover_number.Name = "crossover_number";
            this.crossover_number.Size = new System.Drawing.Size(70, 20);
            this.crossover_number.TabIndex = 45;
            this.crossover_number.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // crossover_label
            // 
            this.crossover_label.AutoSize = true;
            this.crossover_label.Location = new System.Drawing.Point(183, 86);
            this.crossover_label.Name = "crossover_label";
            this.crossover_label.Size = new System.Drawing.Size(80, 13);
            this.crossover_label.TabIndex = 44;
            this.crossover_label.Text = "Crossover Rate";
            // 
            // settings_tabcontrol
            // 
            this.settings_tabcontrol.Controls.Add(this.algorithm_tab);
            this.settings_tabcontrol.Controls.Add(this.ratio_tab);
            this.settings_tabcontrol.Location = new System.Drawing.Point(624, 12);
            this.settings_tabcontrol.Name = "settings_tabcontrol";
            this.settings_tabcontrol.SelectedIndex = 0;
            this.settings_tabcontrol.Size = new System.Drawing.Size(375, 560);
            this.settings_tabcontrol.TabIndex = 1;
            // 
            // algorithm_tab
            // 
            this.algorithm_tab.Controls.Add(this.refined_clumping_check);
            this.algorithm_tab.Controls.Add(this.individual_mutation_number);
            this.algorithm_tab.Controls.Add(this.individual_mutation_label);
            this.algorithm_tab.Controls.Add(this.blend_check);
            this.algorithm_tab.Controls.Add(this.expanded_mutation);
            this.algorithm_tab.Controls.Add(this.tile_selection);
            this.algorithm_tab.Controls.Add(this.gen_rules_label);
            this.algorithm_tab.Controls.Add(this.ga_label);
            this.algorithm_tab.Controls.Add(this.crossover_number);
            this.algorithm_tab.Controls.Add(this.population_label);
            this.algorithm_tab.Controls.Add(this.crossover_label);
            this.algorithm_tab.Controls.Add(this.population_number);
            this.algorithm_tab.Controls.Add(this.mutation_number);
            this.algorithm_tab.Controls.Add(this.mapwidth_label);
            this.algorithm_tab.Controls.Add(this.mutation_label);
            this.algorithm_tab.Controls.Add(this.mapwidth_number);
            this.algorithm_tab.Controls.Add(this.mapheight_label);
            this.algorithm_tab.Controls.Add(this.mapheight_number);
            this.algorithm_tab.Location = new System.Drawing.Point(4, 22);
            this.algorithm_tab.Name = "algorithm_tab";
            this.algorithm_tab.Padding = new System.Windows.Forms.Padding(3);
            this.algorithm_tab.Size = new System.Drawing.Size(367, 534);
            this.algorithm_tab.TabIndex = 0;
            this.algorithm_tab.Text = "Algorithm";
            this.algorithm_tab.UseVisualStyleBackColor = true;
            // 
            // refined_clumping_check
            // 
            this.refined_clumping_check.AutoSize = true;
            this.refined_clumping_check.Checked = true;
            this.refined_clumping_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refined_clumping_check.Location = new System.Drawing.Point(162, 173);
            this.refined_clumping_check.Name = "refined_clumping_check";
            this.refined_clumping_check.Size = new System.Drawing.Size(109, 17);
            this.refined_clumping_check.TabIndex = 53;
            this.refined_clumping_check.Text = "Refined Clumping";
            this.refined_clumping_check.UseVisualStyleBackColor = true;
            // 
            // individual_mutation_number
            // 
            this.individual_mutation_number.DecimalPlaces = 4;
            this.individual_mutation_number.Location = new System.Drawing.Point(106, 84);
            this.individual_mutation_number.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.individual_mutation_number.Name = "individual_mutation_number";
            this.individual_mutation_number.Size = new System.Drawing.Size(70, 20);
            this.individual_mutation_number.TabIndex = 52;
            this.individual_mutation_number.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // individual_mutation_label
            // 
            this.individual_mutation_label.AutoSize = true;
            this.individual_mutation_label.Location = new System.Drawing.Point(7, 86);
            this.individual_mutation_label.Name = "individual_mutation_label";
            this.individual_mutation_label.Size = new System.Drawing.Size(96, 13);
            this.individual_mutation_label.TabIndex = 51;
            this.individual_mutation_label.Text = "Individual Mutation";
            // 
            // blend_check
            // 
            this.blend_check.AutoSize = true;
            this.blend_check.Checked = true;
            this.blend_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blend_check.Location = new System.Drawing.Point(10, 173);
            this.blend_check.Name = "blend_check";
            this.blend_check.Size = new System.Drawing.Size(103, 17);
            this.blend_check.TabIndex = 50;
            this.blend_check.Text = "Blend Crossover";
            this.blend_check.UseVisualStyleBackColor = true;
            // 
            // expanded_mutation
            // 
            this.expanded_mutation.AutoSize = true;
            this.expanded_mutation.Checked = true;
            this.expanded_mutation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expanded_mutation.Location = new System.Drawing.Point(162, 150);
            this.expanded_mutation.Name = "expanded_mutation";
            this.expanded_mutation.Size = new System.Drawing.Size(118, 17);
            this.expanded_mutation.TabIndex = 49;
            this.expanded_mutation.Text = "Expanded Mutation";
            this.expanded_mutation.UseVisualStyleBackColor = true;
            // 
            // tile_selection
            // 
            this.tile_selection.AutoSize = true;
            this.tile_selection.Checked = true;
            this.tile_selection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tile_selection.Location = new System.Drawing.Point(10, 150);
            this.tile_selection.Name = "tile_selection";
            this.tile_selection.Size = new System.Drawing.Size(130, 17);
            this.tile_selection.TabIndex = 48;
            this.tile_selection.Text = "Refined Tile Selection";
            this.tile_selection.UseVisualStyleBackColor = true;
            // 
            // gen_rules_label
            // 
            this.gen_rules_label.AutoSize = true;
            this.gen_rules_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_rules_label.Location = new System.Drawing.Point(6, 123);
            this.gen_rules_label.Name = "gen_rules_label";
            this.gen_rules_label.Size = new System.Drawing.Size(156, 24);
            this.gen_rules_label.TabIndex = 46;
            this.gen_rules_label.Text = "Generation Rules";
            // 
            // ratio_tab
            // 
            this.ratio_tab.Controls.Add(this.ratio_number);
            this.ratio_tab.Controls.Add(this.ratioweight_label);
            this.ratio_tab.Controls.Add(this.clumping_number);
            this.ratio_tab.Controls.Add(this.formation_label);
            this.ratio_tab.Controls.Add(this.clumping_label);
            this.ratio_tab.Controls.Add(this.ratios_label);
            this.ratio_tab.Controls.Add(this.grass_label);
            this.ratio_tab.Controls.Add(this.grass_track);
            this.ratio_tab.Controls.Add(this.water_label);
            this.ratio_tab.Controls.Add(this.water_track);
            this.ratio_tab.Controls.Add(this.mountain_label);
            this.ratio_tab.Controls.Add(this.mountain_track);
            this.ratio_tab.Controls.Add(this.ice_number);
            this.ratio_tab.Controls.Add(this.sand_label);
            this.ratio_tab.Controls.Add(this.sand_number);
            this.ratio_tab.Controls.Add(this.sand_track);
            this.ratio_tab.Controls.Add(this.mountain_number);
            this.ratio_tab.Controls.Add(this.forest_label);
            this.ratio_tab.Controls.Add(this.forest_number);
            this.ratio_tab.Controls.Add(this.forest_track);
            this.ratio_tab.Controls.Add(this.water_number);
            this.ratio_tab.Controls.Add(this.ice_label);
            this.ratio_tab.Controls.Add(this.grass_number);
            this.ratio_tab.Controls.Add(this.ice_track);
            this.ratio_tab.Location = new System.Drawing.Point(4, 22);
            this.ratio_tab.Name = "ratio_tab";
            this.ratio_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ratio_tab.Size = new System.Drawing.Size(367, 534);
            this.ratio_tab.TabIndex = 1;
            this.ratio_tab.Text = "Rules";
            this.ratio_tab.UseVisualStyleBackColor = true;
            // 
            // ratio_number
            // 
            this.ratio_number.DecimalPlaces = 4;
            this.ratio_number.Location = new System.Drawing.Point(58, 28);
            this.ratio_number.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ratio_number.Name = "ratio_number";
            this.ratio_number.Size = new System.Drawing.Size(72, 20);
            this.ratio_number.TabIndex = 40;
            this.ratio_number.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ratioweight_label
            // 
            this.ratioweight_label.AutoSize = true;
            this.ratioweight_label.Location = new System.Drawing.Point(8, 30);
            this.ratioweight_label.Name = "ratioweight_label";
            this.ratioweight_label.Size = new System.Drawing.Size(41, 13);
            this.ratioweight_label.TabIndex = 39;
            this.ratioweight_label.Text = "Weight";
            // 
            // clumping_number
            // 
            this.clumping_number.DecimalPlaces = 4;
            this.clumping_number.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.clumping_number.Location = new System.Drawing.Point(58, 251);
            this.clumping_number.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.clumping_number.Name = "clumping_number";
            this.clumping_number.Size = new System.Drawing.Size(72, 20);
            this.clumping_number.TabIndex = 38;
            this.clumping_number.Value = new decimal(new int[] {
            15,
            0,
            0,
            262144});
            // 
            // formation_label
            // 
            this.formation_label.AutoSize = true;
            this.formation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formation_label.Location = new System.Drawing.Point(1, 219);
            this.formation_label.Name = "formation_label";
            this.formation_label.Size = new System.Drawing.Size(95, 24);
            this.formation_label.TabIndex = 37;
            this.formation_label.Text = "Formation";
            // 
            // clumping_label
            // 
            this.clumping_label.AutoSize = true;
            this.clumping_label.Location = new System.Drawing.Point(8, 253);
            this.clumping_label.Name = "clumping_label";
            this.clumping_label.Size = new System.Drawing.Size(50, 13);
            this.clumping_label.TabIndex = 36;
            this.clumping_label.Text = "Clumping";
            // 
            // Terrain_generator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 655);
            this.Controls.Add(this.settings_tabcontrol);
            this.Controls.Add(this.time_text);
            this.Controls.Add(this.generation_text);
            this.Controls.Add(this.fitness_text);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.generation_label);
            this.Controls.Add(this.fitness_label);
            this.Controls.Add(this.map_tabcontrol);
            this.Controls.Add(this.start_button);
            this.Name = "Terrain_generator_form";
            this.Text = "Terrain Generator";
            ((System.ComponentModel.ISupportInitialize)(this.map1_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountain_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sand_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forest_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ice_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.population_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapwidth_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapheight_number)).EndInit();
            this.map_tabcontrol.ResumeLayout(false);
            this.map1_tab.ResumeLayout(false);
            this.map1_tab.PerformLayout();
            this.map2_tab.ResumeLayout(false);
            this.map2_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map2_picturebox)).EndInit();
            this.map3_tab.ResumeLayout(false);
            this.map3_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map3_picturebox)).EndInit();
            this.map4_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map4_picturebox)).EndInit();
            this.map5_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map5_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forest_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountain_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sand_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ice_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutation_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossover_number)).EndInit();
            this.settings_tabcontrol.ResumeLayout(false);
            this.algorithm_tab.ResumeLayout(false);
            this.algorithm_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individual_mutation_number)).EndInit();
            this.ratio_tab.ResumeLayout(false);
            this.ratio_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratio_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clumping_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox map1_picturebox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label ratios_label;
        private System.Windows.Forms.Label grass_label;
        private System.Windows.Forms.TrackBar grass_track;
        private System.Windows.Forms.TrackBar water_track;
        private System.Windows.Forms.Label water_label;
        private System.Windows.Forms.TrackBar mountain_track;
        private System.Windows.Forms.Label mountain_label;
        private System.Windows.Forms.TrackBar sand_track;
        private System.Windows.Forms.Label sand_label;
        private System.Windows.Forms.TrackBar forest_track;
        private System.Windows.Forms.Label forest_label;
        private System.Windows.Forms.TrackBar ice_track;
        private System.Windows.Forms.Label ice_label;
        private System.Windows.Forms.Label ga_label;
        private System.Windows.Forms.Label population_label;
        private System.Windows.Forms.NumericUpDown population_number;
        private System.Windows.Forms.NumericUpDown mapwidth_number;
        private System.Windows.Forms.Label mapwidth_label;
        private System.Windows.Forms.NumericUpDown mapheight_number;
        private System.Windows.Forms.Label mapheight_label;
        private System.Windows.Forms.TabControl map_tabcontrol;
        private System.Windows.Forms.TabPage map1_tab;
        private System.Windows.Forms.TabPage map2_tab;
        private System.Windows.Forms.PictureBox map2_picturebox;
        private System.Windows.Forms.TabPage map3_tab;
        private System.Windows.Forms.PictureBox map3_picturebox;
        private System.Windows.Forms.TabPage map4_tab;
        private System.Windows.Forms.PictureBox map4_picturebox;
        private System.Windows.Forms.TabPage map5_tab;
        private System.Windows.Forms.PictureBox map5_picturebox;
        private System.Windows.Forms.NumericUpDown grass_number;
        private System.Windows.Forms.NumericUpDown water_number;
        private System.Windows.Forms.NumericUpDown forest_number;
        private System.Windows.Forms.NumericUpDown mountain_number;
        private System.Windows.Forms.NumericUpDown sand_number;
        private System.Windows.Forms.NumericUpDown ice_number;
        private System.Windows.Forms.Label fitness_label;
        private System.Windows.Forms.Label generation_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label time_text;
        private System.Windows.Forms.Label generation_text;
        private System.Windows.Forms.Label fitness_text;
        private System.Windows.Forms.NumericUpDown mutation_number;
        private System.Windows.Forms.Label mutation_label;
        private System.Windows.Forms.NumericUpDown crossover_number;
        private System.Windows.Forms.Label crossover_label;
        private System.Windows.Forms.TabControl settings_tabcontrol;
        private System.Windows.Forms.TabPage algorithm_tab;
        private System.Windows.Forms.TabPage ratio_tab;
        private System.Windows.Forms.NumericUpDown clumping_number;
        private System.Windows.Forms.Label formation_label;
        private System.Windows.Forms.Label clumping_label;
        private System.Windows.Forms.NumericUpDown ratio_number;
        private System.Windows.Forms.Label ratioweight_label;
        private System.Windows.Forms.CheckBox tile_selection;
        private System.Windows.Forms.Label gen_rules_label;
        private System.Windows.Forms.CheckBox expanded_mutation;
        private System.Windows.Forms.CheckBox blend_check;
        private System.Windows.Forms.Label map1_ice_text;
        private System.Windows.Forms.Label map1_ice_label;
        private System.Windows.Forms.Label map1_sand_text;
        private System.Windows.Forms.Label map1_sand_label;
        private System.Windows.Forms.Label map1_mountain_text;
        private System.Windows.Forms.Label map1_mountain_label;
        private System.Windows.Forms.Label map1_forest_text;
        private System.Windows.Forms.Label map1_forest_label;
        private System.Windows.Forms.Label map1_land_text;
        private System.Windows.Forms.Label map1_land_label;
        private System.Windows.Forms.Label map1_water_text;
        private System.Windows.Forms.Label map1_water_label;
        private System.Windows.Forms.Label map1_fitness_text;
        private System.Windows.Forms.Label map1_fitness_label;
        private System.Windows.Forms.Label map2_ice_text;
        private System.Windows.Forms.Label map2_ice_label;
        private System.Windows.Forms.Label map2_sand_text;
        private System.Windows.Forms.Label map2_sand_label;
        private System.Windows.Forms.Label map2_mountain_text;
        private System.Windows.Forms.Label map2_mountain_label;
        private System.Windows.Forms.Label map2_forest_text;
        private System.Windows.Forms.Label map2_forest_label;
        private System.Windows.Forms.Label map2_land_text;
        private System.Windows.Forms.Label map2_land_label;
        private System.Windows.Forms.Label map2_water_text;
        private System.Windows.Forms.Label map2_water_label;
        private System.Windows.Forms.Label map2_fitness_text;
        private System.Windows.Forms.Label map2_fitness_label;
        private System.Windows.Forms.Label map3_ice_text;
        private System.Windows.Forms.Label map3_ice_label;
        private System.Windows.Forms.Label map3_sand_text;
        private System.Windows.Forms.Label map3_sand_label;
        private System.Windows.Forms.Label map3_mountain_text;
        private System.Windows.Forms.Label map3_mountain_label;
        private System.Windows.Forms.Label map3_forest_text;
        private System.Windows.Forms.Label map3_forest_label;
        private System.Windows.Forms.Label map3_land_text;
        private System.Windows.Forms.Label map3_land_label;
        private System.Windows.Forms.Label map3_water_text;
        private System.Windows.Forms.Label map3_water_label;
        private System.Windows.Forms.Label map3_fitness_text;
        private System.Windows.Forms.Label map3_fitness_label;
        private System.Windows.Forms.NumericUpDown individual_mutation_number;
        private System.Windows.Forms.Label individual_mutation_label;
        private System.Windows.Forms.CheckBox refined_clumping_check;
    }
}

